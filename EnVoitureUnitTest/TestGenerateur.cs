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
        public void TestEditionRouteNord()
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
        public void TestEditionRouteNordNord()
        {
            Orientation orientation = Orientation.NORTH;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.ROUTE);
        }

        /// <summary>
        /// Test si l'état du nord a changé de route aec trottoir à rien
        /// </summary>
        [TestMethod]
        public void TestEditionRouteNordEst()
        {
            Orientation orientation = Orientation.NORTH;
            Generateur generateur = new Generateur(new Route(0, 0, 1, 1, null));
            generateur.EditionRoute(orientation);

            Assert.AreEqual(generateur.Route.GetDictionaire[orientation], Obstacle.PASROUTE);
        }

        /*
         * 
         * Tests avec l'orientation de l'est
         *
         */

        /// <summary>
        /// Test si l'état de l'est n'a pas changé
        /// </summary>
        [TestMethod]
        public void TestEditionRouteEast()
        {
            Orientation orientation = Orientation.EAST;
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
