using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EnVoiture;
using System.Drawing;
using EnVoiture.Modele;

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
            Assert.AreEqual(Orientation.NORD.Oppose(), Orientation.SUD);
        }

        [TestMethod]
        public void TestOppositeOrientationWE()
        {
            Assert.AreEqual(Orientation.OUEST.Oppose(), Orientation.EST);
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
