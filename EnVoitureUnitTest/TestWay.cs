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
            Route w = new Route(0, 0, 20, 30, o);
            Assert.AreEqual(w.Position, new Point(0, 0));
        }

        [TestMethod]
        public void TestSize()
        {
            List<Orientation> o = new List<Orientation>();
            Route w = new Route(new Point(0, 0), new Size(20, 30), o);
            Assert.AreEqual(w.Taille, new Size(20, 30));
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
            Route w1 = new Route(2, 1, 20, 30, o);
            Assert.AreEqual(2, w1.Position.X);
            Assert.AreEqual(1, w1.Position.Y);
        }
    }
}
