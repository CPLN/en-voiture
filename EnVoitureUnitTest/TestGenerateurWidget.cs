using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnVoiture;
using EnVoiture.Vue;
using System.Drawing;

namespace EnVoitureUnitTest
{
    [TestClass]
    public class TestGenerateurWidget
    {
        /*
         * 
         * Tests est
         * 
         */

        /// <summary>
        /// Test si on clique en x78 et y30 que cela retourne est
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationEstX78Y30()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(78, 30));
            Assert.AreEqual(o, Orientation.EST);
        }

        /// <summary>
        /// Test si on clique en x100 et y0 que cela retourne est
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationEstX100Y0()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(100, 0));
            Assert.AreEqual(o, Orientation.EST);
        }

        /// <summary>
        /// Test si on clique en x100 et y100 que cela retourne est
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationEstX100Y100()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(100, 100));
            Assert.AreEqual(o, Orientation.EST);
        }

        /// <summary>
        /// Test si on clique en x51 et y50 que cela retourne est
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationEstX50Y51()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(51, 50));
            Assert.AreEqual(o, Orientation.EST);
        }


        /*
         * 
         * Tests sud
         * 
         */

        /// <summary>
        /// Test si on clique en x50 et y51 que cela retourne sud
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationSudX50Y51()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(50, 51));
            Assert.AreEqual(o, Orientation.SUD);
        }

        /// <summary>
        /// Test si on clique en x2 et y99 que cela retourne sud
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationSudX2Y99()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(2, 99));
            Assert.AreEqual(o, Orientation.SUD);
        }

        /// <summary>
        /// Test si on clique en x1 et y100 que cela retourne sud
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationSudX1Y100()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(1, 100));
            Assert.AreEqual(o, Orientation.SUD);
        }

        /// <summary>
        /// Test si on clique en x99 et y100 que cela retourne sud
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationSudX99Y100()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(99, 100));
            Assert.AreEqual(o, Orientation.SUD);
        }

        /*
         * 
         * Tests ouest
         * 
         */

        /// <summary>
        /// Test si on clique en x13 et y24 que cela retourne ouest
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationOuestX13Y24()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(13, 24));
            Assert.AreEqual(o, Orientation.OUEST);
        }

        /// <summary>
        /// Test si on clique en x0 et y0 que cela retourne ouest
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationOuestX0Y0()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(0, 0));
            Assert.AreEqual(o, Orientation.OUEST);
        }

        /// <summary>
        /// Test si on clique en x0 et y1 que cela retourne ouest
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationOuestX0Y1()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(0, 1));
            Assert.AreEqual(o, Orientation.OUEST);
        }

        /// <summary>
        /// Test si on clique en x1 et y1 que cela retourne ouest
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationOuestX1Y1()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(1, 1));
            Assert.AreEqual(o, Orientation.OUEST);
        }

        /// <summary>
        /// Test si on clique en x50 et y50 que cela retourne ouest
        /// </summary>
        [TestMethod]
        public void TestDetectionOrientationOuestX50Y50()
        {
            GenerateurWidget generateurw = new GenerateurWidget();

            Orientation o = generateurw.DetectionOrientation(new Point(50, 50));
            Assert.AreEqual(o, Orientation.OUEST);
        }
    }
}
