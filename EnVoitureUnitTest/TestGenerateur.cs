using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EnVoiture;
using EnVoiture.Modele;
using System.Drawing;

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
        /// Test si l'état du nord a changé de null à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteNordNullRoute()
        {
            Orientation orientation = Orientation.NORD;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état du nord a changé de rien à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteNordRienRoute()
        {
            Orientation orientation = Orientation.NORD;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.NORD, Obstacle.RIEN }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état du nord a changé de route simple à route avec trottoir
        /// </summary>
        [TestMethod]
        public void TestEditionRouteNordRouteTrottoir()
        {
            Orientation orientation = Orientation.NORD;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.NORD, Obstacle.ROUTE }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTETROTTOIR);
        }

        /// <summary>
        /// Test si l'état du nord a changé de route avec trottoir à rien
        /// </summary>
        [TestMethod]
        public void TestEditionRouteNordTrottoirRien()
        {
            Orientation orientation = Orientation.NORD;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.NORD, Obstacle.ROUTETROTTOIR }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.RIEN);
        }

        /*
         * 
         * Tests avec l'orientation de l'est
         *
         */

        /// <summary>
        /// Test si l'état de l'est a changé de null à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteEstNullRoute()
        {
            Orientation orientation = Orientation.EST;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état de l'est a changé de rien à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteEstRienRoute()
        {
            Orientation orientation = Orientation.EST;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.EST, Obstacle.RIEN }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état de l'est a changé de route simple à route avec trottoir
        /// </summary>
        [TestMethod]
        public void TestEditionRouteEstRouteTrottoir()
        {
            Orientation orientation = Orientation.EST;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.EST, Obstacle.ROUTE }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTETROTTOIR);
        }

        /// <summary>
        /// Test si l'état de l'est a changé de route avec trottoir à rien
        /// </summary>
        [TestMethod]
        public void TestEditionRouteEstTrottoirRien()
        {
            Orientation orientation = Orientation.EST;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.EST, Obstacle.ROUTETROTTOIR }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.RIEN);
        }

        /*
         * 
         * Tests avec l'orientation sud
         *
         */

        /// <summary>
        /// Test si l'état du sud a changé de null à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteSudNullRoute()
        {
            Orientation orientation = Orientation.SUD;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état du sud a changé de rien à route simple
        [TestMethod]
        public void TestEditionRouteSudRienRoute()
        {
            Orientation orientation = Orientation.SUD;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.SUD, Obstacle.RIEN }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état du sud a changé de route simple à route avec trottoir
        /// </summary>
        [TestMethod]
        public void TestEditionRouteSudRouteTrottoir()
        {
            Orientation orientation = Orientation.SUD;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.SUD, Obstacle.ROUTE }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTETROTTOIR);
        }

        /// <summary>
        /// Test si l'état du sud a changé de route avec trottoir à rien
        /// </summary>
        [TestMethod]
        public void TestEditionRouteSudTrottoirRien()
        {
            Orientation orientation = Orientation.SUD;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.SUD, Obstacle.ROUTETROTTOIR }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.RIEN);
        }

        /*
         * 
         * Tests avec l'orientation ouest
         *
         */

        /// <summary>
        /// Test si l'état de l'ouest a changé de null à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteOuestNullRoute()
        {
            Orientation orientation = Orientation.OUEST;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état de l'ouest a changé de rien à route simple
        /// </summary>
        [TestMethod]
        public void TestEditionRouteOuestRienRoute()
        {
            Orientation orientation = Orientation.OUEST;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.OUEST, Obstacle.RIEN }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état de l'ouest a changé de route simple à route avec trottoir
        /// </summary>
        [TestMethod]
        public void TestEditionRouteOuestRouteTrottoir()
        {
            Orientation orientation = Orientation.OUEST;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.OUEST, Obstacle.ROUTE }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.ROUTETROTTOIR);
        }

        /// <summary>
        /// Test si l'état de l'ouest a changé de route avec trottoir à rien
        /// </summary>
        [TestMethod]
        public void TestEditionRouteOuestTrottoirRien()
        {
            Orientation orientation = Orientation.OUEST;
            Generateur generateur = new Generateur(new Route(new Point(0, 0), new Size(1, 1), new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.OUEST, Obstacle.ROUTETROTTOIR }
                }));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.DictionnaireObstacles[orientation], Obstacle.RIEN);
        }
    }
}
