﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlbumWordAddin;
using System.Linq;
using MoreLinq;

namespace PositionerTests
{
    public static class RectangleExtensions
    {
        public static IEnumerable<Rectangle> Range(this Rectangle first, int count, float offsetX, float offsetY)
        {
            return Enumerable.Range(0, count).Select(i => first.Move(i * offsetX, i * offsetY));
        }

        public static IEnumerable<Rectangle> Range(this Rectangle first, int count)
            => first.Range(count, 0, 0);
    }

    [TestClass]
    public class PositionerTests
    {
        static readonly Rectangle R1X1 = new Rectangle(0, 0, 1, 1);
        static readonly Rectangle R4X1 = new Rectangle(0, 0, 4, 1);
        static readonly Rectangle R1X4 = new Rectangle(0, 0, 1, 4);
        static readonly Rectangle R4X4 = new Rectangle(0, 0, 4, 4);
        static readonly Rectangle R4X2 = new Rectangle(0, 0, 4, 2);
        static readonly Rectangle R2X4 = new Rectangle(0, 0, 2, 4);
        static readonly Positioner HFlatPos     = new Positioner { Cols = 4, Rows = 1, HShape = HShape.Flat, VShape = VShape.Flat, Margin = 0, Padding = 0    };
        static readonly Positioner HFlatPosPad  = new Positioner { Cols = 4, Rows = 1, HShape = HShape.Flat, VShape = VShape.Flat, Margin = 0, Padding = 0.1f };
        static readonly Positioner HFlatLeftPos = new Positioner { Cols = 4, Rows = 1, HShape = HShape.Left, VShape = VShape.Flat, Margin = 0, Padding = 0    };
        static readonly Positioner HFlatTopPos  = new Positioner { Cols = 4, Rows = 1, HShape = HShape.Flat, VShape = VShape.Top , Margin = 0, Padding = 0};
        static readonly Positioner VFlatPos     = new Positioner { Cols = 1, Rows = 4, HShape = HShape.Flat, VShape = VShape.Flat, Margin = 0, Padding = 0    };
        static readonly Positioner VFlatPosPad  = new Positioner { Cols = 1, Rows = 4, HShape = HShape.Flat, VShape = VShape.Flat, Margin = 0, Padding = 0.1f };
        static readonly Positioner VFlatLeftPos = new Positioner { Cols = 1, Rows = 4, HShape = HShape.Left, VShape = VShape.Flat, Margin = 0, Padding = 0    };
        static readonly Positioner VFlatTopPos  = new Positioner { Cols = 1, Rows = 4, HShape = HShape.Flat, VShape = VShape.Top , Margin = 0, Padding = 0};

        [TestMethod]
        public void TestPositioner_1x1()
        {
            var pos = new Positioner { Cols = 1, Rows = 1, HShape = HShape.Flat, VShape = VShape.Flat, Margin = 0, Padding = 0 };
            var rc = pos.DoPosition(R1X1, new[] { R1X1 }).ToArray();
            Assert.AreEqual(1, rc.Length);
            Assert.AreEqual(R1X1, rc.First());
        }
        [TestMethod]
        public void TestPositioner_2x1()
        {
            var pos = new Positioner { Cols = 1, Rows = 2, HShape = HShape.Flat, VShape = VShape.Flat, Margin = 0, Padding = 0 };
            var rc = pos.DoPosition(R1X1, new[] { R1X1, R1X1 }).ToArray();
            Assert.AreEqual(2, rc.Length);
            Assert.AreEqual(new Rectangle(.25f, 0, .5f, .5f), rc.First());
            Assert.AreEqual(new Rectangle(.25f, .5f, .5f, .5f), rc.Skip(1).First());
        }
        [TestMethod]
        public void TestPositioner_1x2()
        {
            new[] { .5f, 1f, 1.5f, 2f }.ForEach(TestPositioner_1x2);
        }
        public void TestPositioner_1x2(float factor)
        {
            var pos = new Positioner { Cols = 2, Rows = 1, HShape = HShape.Flat, VShape = VShape.Flat, Margin = 0, Padding = 0 };
            var rc = pos.DoPosition(R1X1.Grow(factor), new[] { R1X1, R1X1 }).ToArray();
            Assert.AreEqual(2, rc.Length);
            var expected = new Rectangle(0, .25f, .5f, .5f).Scale(factor, factor);
            Assert.AreEqual(expected, rc.First());
            expected = expected.Move(.5f * factor, 0);
            Assert.AreEqual(expected, rc.Skip(1).First());
        }
        [TestMethod]
        public void TestPositioner_1x3()
        {
            new[] { .5f, 1f, 1.5f, 2f }.ForEach(TestPositioner_1x3);
        }
        void TestPositioner_1x3(float factor)
        {
            var pos = new Positioner { Cols = 3, Rows = 1, HShape = HShape.Flat, VShape = VShape.Flat, Margin = 0, Padding = 0 };
            var rc = pos.DoPosition(R1X1.Grow(factor), new[] { R1X1, R1X1, R1X1 }).ToArray();
            Assert.AreEqual(3, rc.Length);
            var expected = new Rectangle(0, 1 / 3f, 1 / 3f, 1 / 3f).Scale(factor, factor);
            Assert.AreEqual(expected, rc.First());
            expected = expected.Move(1 / 3f * factor, 0);
            Assert.AreEqual(expected, rc.Skip(1).First());
            expected = expected.Move(1 / 3f * factor, 0);
            Assert.AreEqual(expected, rc.Skip(2).First());
        }

        [TestMethod]
        public void TestPositioner_FourInaRowFlatNoPadding()
        {
            TestPositioner_global(R4X1, R1X1.Range(4), HFlatPos, R1X1.Range(4, 1, 0), nameof(R1X1));
            TestPositioner_global(R4X1, R4X2.Range(4), HFlatPos, R4X2.Move(0, .25f).Grow(.25f).Range(4, 1, 0), nameof(R4X2));
            TestPositioner_global(R4X1, R2X4.Range(4), HFlatPos, R2X4.Move(.25f, 0).Grow(.25f).Range(4, 1, 0), nameof(R2X4));
        }
        [TestMethod]
        public void TestPositioner_FourInaRowFlatPadding()
        {
            TestPositioner_global(R4X1, R1X1.Range(4), HFlatPosPad, R1X1.Move(HFlatPosPad.Padding, HFlatPosPad.Padding).Grow(1 - 2 * HFlatPosPad.Padding).Range(4, 1, 0), nameof(R1X1));
        }
        [TestMethod]
        public void TestPositioner_FourInaRowLeftNoPadding()
        {
            TestPositioner_global(R4X1, R1X1.Range(4), HFlatLeftPos, R1X1.Range(4, 1, 0), nameof(R1X1));
            TestPositioner_global(R4X1, R4X2.Range(4), HFlatLeftPos, R4X2.Move(0, .25f).Grow(.25f).Range(4, 1, 0), nameof(R4X2));
            TestPositioner_global(R4X1, R2X4.Range(4), HFlatLeftPos, R2X4.Grow(.25f).Range(4, 1, 0), nameof(R2X4));
        }
        [TestMethod]
        public void TestPositioner_FourInaRowTopNoPadding()
        {
            TestPositioner_global(R4X1, R1X1.Range(4), HFlatTopPos, R1X1.Range(4, 1, 0), nameof(R1X1));
            TestPositioner_global(R4X1, R4X2.Range(4), HFlatTopPos, R4X2.Grow(.25f).Range(4, 1, 0), nameof(R4X2));
            TestPositioner_global(R4X1, R2X4.Range(4), HFlatTopPos, R2X4.Move(.25f, 0).Grow(.25f).Range(4, 1, 0), nameof(R2X4));
        }
        [TestMethod]
        public void TestPositioner_FourInaColFlatNoPadding()
        {
            TestPositioner_global(R1X4, R1X1.Range(4), VFlatPos, R1X1.Range(4, 0, 1), nameof(R1X1));
            TestPositioner_global(R1X4, R4X2.Range(4), VFlatPos, R4X2.Move(0, .25f).Grow(.25f).Range(4, 0, 1), nameof(R4X2));
            TestPositioner_global(R1X4, R2X4.Range(4), VFlatPos, R2X4.Move(.25f, 0).Grow(.25f).Range(4, 0, 1), nameof(R2X4));
        }
        [TestMethod]
        public void TestPositioner_FourInaColFlatPadding()
        {
            TestPositioner_global(R1X4, R1X1.Range(4), VFlatPosPad, R1X1.Move(VFlatPosPad.Padding, VFlatPosPad.Padding).Grow(1 - 2 * VFlatPosPad.Padding).Range(4, 0, 1), nameof(R1X1));
        }
        [TestMethod]
        public void TestPositioner_FourInaColLeftNoPadding()
        {
            TestPositioner_global(R1X4, R1X1.Range(4), VFlatLeftPos, R1X1.Range(4, 0, 1), nameof(R1X1));
            TestPositioner_global(R1X4, R4X2.Range(4), VFlatLeftPos, R4X2.Move(0, .25f).Grow(.25f).Range(4, 0, 1), nameof(R4X2));
            TestPositioner_global(R1X4, R2X4.Range(4), VFlatLeftPos, R2X4.Grow(.25f).Range(4, 0, 1), nameof(R2X4));
        }
        [TestMethod]
        public void TestPositioner_FourInaColTopNoPadding()
        {
            TestPositioner_global(R1X4, R1X1.Range(4), VFlatTopPos, R1X1.Range(4, 0, 1), nameof(R1X1));
            TestPositioner_global(R1X4, R4X2.Range(4), VFlatTopPos, R4X2.Grow(.25f).Range(4, 0, 1), nameof(R4X2));
            TestPositioner_global(R1X4, R2X4.Range(4), VFlatTopPos, R2X4.Move(.25f, 0).Grow(.25f).Range(4, 0, 1), nameof(R2X4));
        }
        static void TestPositioner_global(Rectangle clientArea, IEnumerable<Rectangle> rectangles, Positioner pos, IEnumerable<Rectangle> expected, string label)
        {
            var rc = pos.DoPosition(clientArea, rectangles).ToArray();
            expected = expected.ToArray();
            Assert.AreEqual(expected.Count(), rc.Length, "Results length");
            foreach (var rr in expected.EquiZip(rc,(e,r)=> new {expected=e, results=r})
                                 .Select((r,i)=>new {i, r.expected, r.results}))
            {
                Assert.AreEqual(rr.expected, rr.results, $"{label} failed expected #{rr.i}");
            }
        }
    }
}
