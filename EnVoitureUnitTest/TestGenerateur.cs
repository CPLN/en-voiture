using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EnVoiture;
using EnVoiture.Modele;

namespace EnVoitureUnitTest
{
    [TestClass]
    public class TestGenerateur
    {
        /*
         * 
         * Tests avec l'orientation nord 
         *
         */

        /// <summary>
        /// Test si l'état du nord a changé de rien à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteNordRienRoute()
        {
            Orientation orientation = Orientation.NORD;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état du nord a changé de route simple à route avec trottoir
        /// </summary>
        [TestMethod]
        public void TestEditionRouteNordRouteTrottoir()
        {
            Orientation orientation = Orientation.NORD;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.ROUTETROTTOIR);
        }

        /// <summary>
        /// Test si l'état du nord a changé de route avec trottoir à rien
        /// </summary>
        [TestMethod]
        public void TestEditionRouteNordTrottoirRien()
        {
            Orientation orientation = Orientation.NORD;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.RIEN);
        }

        /*
         * 
         * Tests avec l'orientation de l'est
         *
         */

        /// <summary>
        /// Test si l'état de l'est a changé de rien à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteEstRienRoute()
        {
            Orientation orientation = Orientation.EST;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état de l'est a changé de route simple à route avec trottoir
        /// </summary>
        [TestMethod]
        public void TestEditionRouteEstRouteTrottoir()
        {
            Orientation orientation = Orientation.EST;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.ROUTETROTTOIR);
        }

        /// <summary>
        /// Test si l'état de l'est a changé de route avec trottoir à rien
        /// </summary>
        [TestMethod]
        public void TestEditionRouteEstTrottoirRien()
        {
            Orientation orientation = Orientation.EST;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.RIEN);
        }

        /*
         * 
         * Tests avec l'orientation sud
         *
         */

        /// <summary>
        /// Test si l'état de l'est a changé de rien à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteSudRienRoute()
        {
            Orientation orientation = Orientation.SUD;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état de l'est a changé de route simple à route avec trottoir
        /// </summary>
        [TestMethod]
        public void TestEditionRouteSudRouteTrottoir()
        {
            Orientation orientation = Orientation.SUD;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.ROUTETROTTOIR);
        }

        /// <summary>
        /// Test si l'état de l'est a changé de route avec trottoir à rien
        /// </summary>
        [TestMethod]
        public void TestEditionRouteSudTrottoirRien()
        {
            Orientation orientation = Orientation.SUD;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.RIEN);
        }

        /*
         * 
         * Tests avec l'orientation ouest
         *
         */

        /// <summary>
        /// Test si l'état de l'est a changé de rien à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteOuestRienRoute()
        {
            Orientation orientation = Orientation.OUEST;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état de l'est a changé de route simple à route avec trottoir
        /// </summary>
        [TestMethod]
        public void TestEditionRouteOuestRouteTrottoir()
        {
            Orientation orientation = Orientation.OUEST;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.ROUTETROTTOIR);
        }

        /// <summary>
        /// Test si l'état de l'est a changé de route avec trottoir à rien
        /// </summary>
        [TestMethod]
        public void TestEditionRouteOuestTrottoirRien()
        {
            Orientation orientation = Orientation.OUEST;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.RIEN);
        }
    }
}
