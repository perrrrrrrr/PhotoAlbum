﻿namespace PicturesSorter
{
    using System.ComponentModel;
    using System.Windows.Forms;

    partial class PictureSorterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureSorterForm));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.previousFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.openInWindowsExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateLeftClock = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateLeftAnti = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateRightClock = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateRightAnti = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickDirectoryToolStripMenuItem,
            this.nextFolder,
            this.previousFolder,
            this.openInWindowsExplorerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "&Folder";
            // 
            // pickDirectoryToolStripMenuItem
            // 
            this.pickDirectoryToolStripMenuItem.Name = "pickDirectoryToolStripMenuItem";
            this.pickDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.pickDirectoryToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.pickDirectoryToolStripMenuItem.Text = "&Open";
            this.pickDirectoryToolStripMenuItem.Click += new System.EventHandler(this.pickDirectoryToolStripMenuItem_Click);
            // 
            // nextFolder
            // 
            this.nextFolder.Name = "nextFolder";
            this.nextFolder.ShortcutKeyDisplayString = "PgDn";
            this.nextFolder.Size = new System.Drawing.Size(253, 22);
            this.nextFolder.Text = "Next";
            this.nextFolder.Click += new System.EventHandler(this.nextFolder_Click);
            // 
            // previousFolder
            // 
            this.previousFolder.Name = "previousFolder";
            this.previousFolder.ShortcutKeyDisplayString = "PgUp";
            this.previousFolder.Size = new System.Drawing.Size(253, 22);
            this.previousFolder.Text = "Previous";
            this.previousFolder.Click += new System.EventHandler(this.previousFolder_Click);
            // 
            // openInWindowsExplorerToolStripMenuItem
            // 
            this.openInWindowsExplorerToolStripMenuItem.Name = "openInWindowsExplorerToolStripMenuItem";
            this.openInWindowsExplorerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.openInWindowsExplorerToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.openInWindowsExplorerToolStripMenuItem.Text = "Open in Windows Explorer";
            this.openInWindowsExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInWindowsExplorerToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.leftPreviousToolStripMenuItem,
            this.leftNextToolStripMenuItem,
            this.rightPreviousToolStripMenuItem,
            this.rightNextToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.ShortcutKeyDisplayString = "<- Left ";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.previousToolStripMenuItem.Text = "&Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeyDisplayString = "Right ->";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.nextToolStripMenuItem.Text = "&Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // leftPreviousToolStripMenuItem
            // 
            this.leftPreviousToolStripMenuItem.Name = "leftPreviousToolStripMenuItem";
            this.leftPreviousToolStripMenuItem.ShortcutKeyDisplayString = "<-Ctrl+Left ";
            this.leftPreviousToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.leftPreviousToolStripMenuItem.Text = "Left P&revious";
            this.leftPreviousToolStripMenuItem.Click += new System.EventHandler(this.leftPreviousToolStripMenuItem_Click);
            // 
            // leftNextToolStripMenuItem
            // 
            this.leftNextToolStripMenuItem.Name = "leftNextToolStripMenuItem";
            this.leftNextToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Right ->";
            this.leftNextToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.leftNextToolStripMenuItem.Text = "Left Next";
            this.leftNextToolStripMenuItem.Click += new System.EventHandler(this.leftNextToolStripMenuItem_Click);
            // 
            // rightPreviousToolStripMenuItem
            // 
            this.rightPreviousToolStripMenuItem.Name = "rightPreviousToolStripMenuItem";
            this.rightPreviousToolStripMenuItem.ShortcutKeyDisplayString = "<- Ctrl+Shift+Left";
            this.rightPreviousToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.rightPreviousToolStripMenuItem.Text = "Right Previous";
            this.rightPreviousToolStripMenuItem.Click += new System.EventHandler(this.rightPreviousToolStripMenuItem_Click);
            // 
            // rightNextToolStripMenuItem
            // 
            this.rightNextToolStripMenuItem.Name = "rightNextToolStripMenuItem";
            this.rightNextToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+Right->";
            this.rightNextToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.rightNextToolStripMenuItem.Text = "Right N&ext";
            this.rightNextToolStripMenuItem.Click += new System.EventHandler(this.rightNextToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem,
            this.rotateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.archiveToolStripMenuItem.Text = "Archive";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.ShortcutKeyDisplayString = "F1, 1";
            this.leftToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.archiveLeftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.ShortcutKeyDisplayString = "F2, 2";
            this.rightToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.archiveRightToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RotateLeftClock,
            this.RotateLeftAnti,
            this.RotateRightClock,
            this.RotateRightAnti});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // RotateLeftClock
            // 
            this.RotateLeftClock.Name = "RotateLeftClock";
            this.RotateLeftClock.ShortcutKeyDisplayString = "";
            this.RotateLeftClock.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.RotateLeftClock.Size = new System.Drawing.Size(198, 22);
            this.RotateLeftClock.Text = "Left clock";
            this.RotateLeftClock.Click += new System.EventHandler(this.RotateLeftClock_Click);
            // 
            // RotateLeftAnti
            // 
            this.RotateLeftAnti.Name = "RotateLeftAnti";
            this.RotateLeftAnti.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.RotateLeftAnti.Size = new System.Drawing.Size(198, 22);
            this.RotateLeftAnti.Text = "Left anti";
            this.RotateLeftAnti.Click += new System.EventHandler(this.RotateLeftAnti_Click);
            // 
            // RotateRightClock
            // 
            this.RotateRightClock.Name = "RotateRightClock";
            this.RotateRightClock.ShortcutKeyDisplayString = "";
            this.RotateRightClock.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RotateRightClock.Size = new System.Drawing.Size(198, 22);
            this.RotateRightClock.Text = "Right clock";
            this.RotateRightClock.Click += new System.EventHandler(this.RotateRightClock_Click);
            // 
            // RotateRightAnti
            // 
            this.RotateRightAnti.Name = "RotateRightAnti";
            this.RotateRightAnti.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.RotateRightAnti.Size = new System.Drawing.Size(198, 22);
            this.RotateRightAnti.Text = "Right anti";
            this.RotateRightAnti.Click += new System.EventHandler(this.RotateRightAnti_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(302, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 54);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 20);
            this.panel3.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(527, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(410, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 34);
            this.panel4.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Image = global::PicturesSorter.Properties.Resources.SmallShelve;
            this.button2.Location = new System.Drawing.Point(119, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 24;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::PicturesSorter.Properties.Resources.SmallLeft;
            this.button3.Location = new System.Drawing.Point(4, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 23;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::PicturesSorter.Properties.Resources.SmallRotateRight;
            this.button4.Location = new System.Drawing.Point(91, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 22;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = global::PicturesSorter.Properties.Resources.SmallRotateLeft;
            this.button9.Location = new System.Drawing.Point(63, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 32);
            this.button9.TabIndex = 21;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Image = global::PicturesSorter.Properties.Resources.SmallRight;
            this.button10.Location = new System.Drawing.Point(34, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 32);
            this.button10.TabIndex = 20;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 34);
            this.panel2.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Image = global::PicturesSorter.Properties.Resources.SmallShelve;
            this.button1.Location = new System.Drawing.Point(117, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 24;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = global::PicturesSorter.Properties.Resources.SmallLeft;
            this.button8.Location = new System.Drawing.Point(1, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 32);
            this.button8.TabIndex = 23;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::PicturesSorter.Properties.Resources.SmallRotateRight;
            this.button5.Location = new System.Drawing.Point(89, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 22;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::PicturesSorter.Properties.Resources.SmallRotateLeft;
            this.button6.Location = new System.Drawing.Point(60, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 32);
            this.button6.TabIndex = 21;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = global::PicturesSorter.Properties.Resources.SmallRight;
            this.button7.Location = new System.Drawing.Point(31, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 32);
            this.button7.TabIndex = 20;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.button12);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Location = new System.Drawing.Point(234, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(87, 34);
            this.panel5.TabIndex = 29;
            // 
            // button11
            // 
            this.button11.Image = global::PicturesSorter.Properties.Resources.SmallLeftSync;
            this.button11.Location = new System.Drawing.Point(13, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 32);
            this.button11.TabIndex = 25;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Image = global::PicturesSorter.Properties.Resources.SmallRightSync;
            this.button12.Location = new System.Drawing.Point(42, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 32);
            this.button12.TabIndex = 26;
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // PictureSorterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 321);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PictureSorterForm";
            this.Text = "PictureSorterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PictureSorterForm_FormClosing);
            this.Load += new System.EventHandler(this.PictureSorterForm_Load);
            this.Resize += new System.EventHandler(this.PictureSorterForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem pickDirectoryToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem previousToolStripMenuItem;
        private ToolStripMenuItem nextToolStripMenuItem;
        private ToolStripMenuItem leftPreviousToolStripMenuItem;
        private ToolStripMenuItem rightNextToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem nextFolder;
        private ToolStripMenuItem previousFolder;
        private ToolStripMenuItem leftNextToolStripMenuItem;
        private ToolStripMenuItem rightPreviousToolStripMenuItem;
        private ToolStripMenuItem archiveToolStripMenuItem;
        private ToolStripMenuItem leftToolStripMenuItem;
        private ToolStripMenuItem rightToolStripMenuItem;
        private ToolStripMenuItem rotateToolStripMenuItem;
        private ToolStripMenuItem RotateLeftClock;
        private ToolStripMenuItem RotateLeftAnti;
        private ToolStripMenuItem RotateRightClock;
        private ToolStripMenuItem RotateRightAnti;
        private ToolStripMenuItem openInWindowsExplorerToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel5;
        private Button button12;
        private Button button11;
        private Panel panel4;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button9;
        private Button button10;
        private Panel panel2;
        private Button button1;
        private Button button8;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel panel3;
        private Label label1;
        private Label label3;
    }
}

