﻿namespace AlbumWordAddin
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using MoreLinq;

    public class FolderWalker
    {
        readonly Func<string, string> _smallFileNameMaker;
        readonly IProgress _progressIndicator;
        readonly DirectoryInfo _diFolderFrom;
        readonly DirectoryInfo _diFolderTo;
        readonly Regex _filePattern;
        readonly Regex _excludePattern;
        readonly Regex _smallPattern;

        public FolderWalker(
            string folderFrom, 
            string folderTo, 
            string fileMaskList, 
            string excludeMaskList, 
            string smallPattern, 
            Func<string, string> smallFileNameMaker, 
            IProgress progressIndicator)
        {
            _smallFileNameMaker = smallFileNameMaker;
            _progressIndicator = progressIndicator;
            if (folderFrom == null) throw new ArgumentNullException(nameof(folderFrom));
            if (folderTo == null) throw new ArgumentNullException(nameof(folderTo));
            _diFolderFrom = new DirectoryInfo(folderFrom);
            _diFolderTo = new DirectoryInfo(folderTo);
            if (!_diFolderFrom.Exists) throw new DirectoryNotFoundException(folderFrom);
            if (!_diFolderTo.Exists  ) throw new DirectoryNotFoundException(folderTo  );
            if (string.Compare(folderFrom, folderTo, StringComparison.InvariantCultureIgnoreCase) > 0) throw new InvalidOperationException("Please pick an upper bound folder alphabetically after the lower bound folder");
            _filePattern = RegexFromPatternList(fileMaskList);
            _excludePattern = RegexFromPatternList(excludeMaskList);
            _smallPattern = new Regex(smallPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }

        Regex RegexFromPatternList(string maskList)
        {
            var pattern = "(" + maskList.Replace(".", "\\.")
                                  .Replace("?", ".")
                                  .Replace("*", ".*")
                                  .Split(';')
                                  .ToDelimitedString(")|(") 
                        + ")";
            return new Regex(
                pattern,
                RegexOptions.Compiled | RegexOptions.IgnoreCase
            );
        }

        public event EventHandler<FolderEventArgs> StartingFolder;
        public event EventHandler<FolderEventArgs> EndingFolder;
        public event EventHandler<FileEventArgs  > FoundAFile;

        public void Run()
        {
            _cancel = false;
            Run(_diFolderFrom);
        }

        void Run(DirectoryInfo folderFrom)
        {
            var matchingFiles1 = folderFrom
                .EnumerateFiles("*",SearchOption.TopDirectoryOnly)
//                .Where(fi => !_excludePattern.Match(fi.Name).Success)
                .Select(fi=>new
                {
                    fileInfo=fi,
                    fileMatch  = _filePattern.Match(fi.Name).Success,
                    smallMatch = _smallPattern.Match(fi.Name).Success,
                    smallName  = Path.Combine(folderFrom.FullName, _smallFileNameMaker(fi.Name))
                })
                .ToArray();
            var matchingFiles2=matchingFiles1
                .Select(fi=> new
                {
                    fi.fileInfo, fi.fileMatch, fi.smallMatch, fi.smallName, 
                    SmallFileExists = fi.smallMatch || new FileInfo(fi.smallName).Exists
                })
                .ToArray();
            var matchingFiles=matchingFiles2
                .Where(fi => fi.fileMatch && !fi.smallMatch && !fi.SmallFileExists // this is an new hi res file
                          || fi.smallMatch //  this is an already prepared low res file
                )
                .ToArray();
            if (matchingFiles.Length == 0) return;
            OnStartingFolder(folderFrom, matchingFiles.Length);
            if (_cancel) return;
            _progressIndicator?.InitProgress(matchingFiles.Length);
            foreach (var fi in matchingFiles)
            {
                if (fi.smallMatch)
                {
                    _progressIndicator?.Progress();
                    OnFoundAFile(fi.fileInfo);
                    if (_cancel) return;
                    continue;
                }
                if (!fi.fileMatch) continue;
                _progressIndicator?.Progress();
                OnFoundAFile(MakeSmallImage(fi.fileInfo, fi.smallName));
                if (_cancel) return;
            }
            OnEndingFolder(folderFrom);
            _progressIndicator?.CloseProgress();
            if (_cancel) return;
            folderFrom
                            .EnumerateDirectories()
                .TakeWhile(di=>string.Compare(di.FullName, _diFolderTo.FullName, StringComparison.InvariantCultureIgnoreCase) < 0)
                .ForEach(Run);
        }

        bool _cancel;
        public void Cancel() { _cancel = true; }

        void OnStartingFolder(DirectoryInfo di, int count) { StartingFolder?.Invoke(this, new FolderEventArgs { DirectoryInfo = di, MatchingFilesCount=count }); }
        void OnEndingFolder  (DirectoryInfo di) { EndingFolder  ?.Invoke(this, new FolderEventArgs { DirectoryInfo = di }); }
        void OnFoundAFile    (FileInfo      fi) { FoundAFile    ?.Invoke(this, new FileEventArgs   { FileInfo      = fi }); }

        static FileInfo MakeSmallImage(FileInfo sourceFileInfo, string newFileName)
        {
            using (var img = Image.FromFile(sourceFileInfo.FullName))
                using (var newImg = img.Scale(0.2))
            {
                newImg.Save(newFileName, ImageFormat.Jpeg);
                return new FileInfo(newFileName);
            }
        }
    }

    public class FileEventArgs:EventArgs
    {
        public FileInfo FileInfo { get; set; }
    }

    public class FolderEventArgs:EventArgs
    {
        public DirectoryInfo DirectoryInfo { get; set; }
        public int MatchingFilesCount { get; set; }
    }

    public static class ImageExtensions
    {
        public static Image Scale(this Image image, double factor)
        {
            var wi = (int)(image.Width * factor);
            var he = (int)(image.Height * factor);
            var newImage = new Bitmap(wi, he);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, wi, he);

            return newImage;

        }
    }
}
