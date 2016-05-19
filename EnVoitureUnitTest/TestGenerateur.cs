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
            Orientation orientation = Orientation.NORTH;
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
            Orientation orientation = Orientation.NORTH;
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
            Orientation orientation = Orientation.NORTH;
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
            Orientation orientation = Orientation.EAST;
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
            Orientation orientation = Orientation.EAST;
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
            Orientation orientation = Orientation.EAST;
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
        /// Test si l'état du sud n'a pas changé
        /// </summary>
        [TestMethod]
        public void TestEditionRouteSouth()
        {
            Orientation orientation = Orientation.SOUTH;
            Route route = new Route(0, 0, 1, 1, new List<Orientation>());
            Generateur generateur = new Generateur(route);
            generateur.EditionRoute(orientation);

            bool obstacle = false;
            if (route.GetDictionaire.ContainsKey(orientation))
                obstacle = route.GetDictionaire[orientation];
            Assert.AreEqual(obstacle, false);
        }

        /*
         * 
         * Tests avec l'orientation ouest
         *
         */

        /// <summary>
        /// Test si l'état de l'ouest n'a pas changé
        /// </summary>
        [TestMethod]
        public void TestEditionRouteWest()
        {
            Orientation orientation = Orientation.WEST;
            Route route = new Route(0, 0, 1, 1, new List<Orientation>());
            Generateur generateur = new Generateur(route);
            generateur.EditionRoute(orientation);

            bool obstacle = false;
            if (route.GetDictionaire.ContainsKey(orientation))
                obstacle = route.GetDictionaire[orientation];
            Assert.AreEqual(obstacle, false);
        }
    }
}
