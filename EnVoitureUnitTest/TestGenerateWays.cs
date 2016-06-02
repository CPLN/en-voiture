using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnVoiture;

namespace EnVoitureUnitTest
{
     [TestClass]
    public class TestGenerateWays
    {
         [TestMethod]
         public void TestCreationVille()
         {
             List<Route> Ways = new List<Route>();
             Ways = Route.Generer(3, 3);
             Assert.AreEqual(9, Ways.Count);
         }

         [TestMethod]
         public void TestCorrespondanceOrientations()
         {
             List<Route> Ways = new List<Route>();
             Ways = Route.Generer(3, 3);

             Assert.AreEqual(Ways[0].DictionaireObstacles[Orientation.EST], Ways[1].DictionaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(Ways[1].DictionaireObstacles[Orientation.EST], Ways[2].DictionaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(Ways[3].DictionaireObstacles[Orientation.EST], Ways[4].DictionaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(Ways[4].DictionaireObstacles[Orientation.EST], Ways[5].DictionaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(Ways[6].DictionaireObstacles[Orientation.EST], Ways[7].DictionaireObstacles[Orientation.OUEST]);
             Assert.AreEqual(Ways[7].DictionaireObstacles[Orientation.EST], Ways[8].DictionaireObstacles[Orientation.OUEST]);

             Assert.AreEqual(Ways[0].DictionaireObstacles[Orientation.SUD], Ways[3].DictionaireObstacles[Orientation.NORD]);
             Assert.AreEqual(Ways[1].DictionaireObstacles[Orientation.SUD], Ways[4].DictionaireObstacles[Orientation.NORD]);
             Assert.AreEqual(Ways[2].DictionaireObstacles[Orientation.SUD], Ways[5].DictionaireObstacles[Orientation.NORD]);
             Assert.AreEqual(Ways[3].DictionaireObstacles[Orientation.SUD], Ways[6].DictionaireObstacles[Orientation.NORD]);
             Assert.AreEqual(Ways[4].DictionaireObstacles[Orientation.SUD], Ways[7].DictionaireObstacles[Orientation.NORD]);
             Assert.AreEqual(Ways[5].DictionaireObstacles[Orientation.SUD], Ways[8].DictionaireObstacles[Orientation.NORD]);

         }
    }
}
