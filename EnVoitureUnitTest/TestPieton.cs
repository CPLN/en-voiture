using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using EnVoiture;

namespace EnVoitureUnitTest
{
    [TestClass]
    public class TestPieton
    {
        [TestMethod]
        public void TestCreatePieton()
        {
            RoadUser pieton1 = new Pieton(30, 30, 10, 10);
            Assert.IsNull(pieton1);
        }
    }
}
