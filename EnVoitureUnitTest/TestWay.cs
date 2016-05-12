using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EnVoiture;
using System.Drawing;

namespace EnVoitureUnitTest
{
    [TestClass]
    public class TestWay
    {
        [TestMethod]
        public void TestLocation()
        {
            List<Orientation> o = new List<Orientation>();
            Way w = new Way(0, 0, 20, 30, o);
            Assert.AreEqual(w.Location, new Point(0, 0));
        }

        [TestMethod]
        public void TestSize()
        {
            List<Orientation> o = new List<Orientation>();
            Way w = new Way(new Point(0, 0), new Size(20, 30), o);
            Assert.AreEqual(w.Size, new Size(20, 30));
        }

        [TestMethod]
        public void TestOppositeOrientationNS()
        {
            Assert.AreEqual(Orientation.NORTH.getOpposite(), Orientation.SOUTH);
        }

        [TestMethod]
        public void TestOppositeOrientationWE()
        {
            Assert.AreEqual(Orientation.WEST.getOpposite(), Orientation.EAST);
        }

        [TestMethod]
        public void TestCreatWayPosition()
        {
            List<Orientation> o = new List<Orientation>();
            Way w1 = new Way(2, 1, 20, 30, o);
            Assert.AreEqual(2, w1.Location.X);
            Assert.AreEqual(1, w1.Location.Y);
        }
    }
}
