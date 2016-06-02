using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnVoiture.Modele;

namespace EnVoitureUnitTest
{
     [TestClass]
    public class TestGenerationRoutes
    {
         [TestMethod]
         public void TestCreationVille()
         {
             List<Route> routes = new List<Route>();
             routes = Route.Generer(3, 3);
             Assert.AreEqual(9, routes.Count);
         }

         [TestMethod]
         public void TestCorrespondanceOrientations()
         {
             List<Route> routes = new List<Route>();
             routes = Route.Generer(3, 3);

             Assert.AreEqual(routes[0].DictionnaireObstacles[Orientation.EST], routes[1].DictionnaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(routes[1].DictionnaireObstacles[Orientation.EST], routes[2].DictionnaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(routes[3].DictionnaireObstacles[Orientation.EST], routes[4].DictionnaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(routes[4].DictionnaireObstacles[Orientation.EST], routes[5].DictionnaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(routes[6].DictionnaireObstacles[Orientation.EST], routes[7].DictionnaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(routes[7].DictionnaireObstacles[Orientation.EST], routes[8].DictionnaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(routes[0].DictionnaireObstacles[Orientation.SUD], routes[3].DictionnaireObstacles[Orientation.NORD]);
             Assert.AreEqual(routes[1].DictionnaireObstacles[Orientation.SUD], routes[4].DictionnaireObstacles[Orientation.NORD]);
             Assert.AreEqual(routes[2].DictionnaireObstacles[Orientation.SUD], routes[5].DictionnaireObstacles[Orientation.NORD]);
             Assert.AreEqual(routes[3].DictionnaireObstacles[Orientation.SUD], routes[6].DictionnaireObstacles[Orientation.NORD]);
             Assert.AreEqual(routes[4].DictionnaireObstacles[Orientation.SUD], routes[7].DictionnaireObstacles[Orientation.NORD]);
             Assert.AreEqual(routes[5].DictionnaireObstacles[Orientation.SUD], routes[8].DictionnaireObstacles[Orientation.NORD]);
         }
    }
}
