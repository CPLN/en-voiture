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
            Way w = new Way(new Point(0,0), new Size(20, 30), o);
            Assert.AreEqual(w.Size, new Size(20, 30));
        }
    }
}
