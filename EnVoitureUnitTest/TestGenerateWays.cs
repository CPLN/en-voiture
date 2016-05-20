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

             Assert.AreEqual(Ways[0].GetDictionaire[Orientation.EAST], Ways[1].GetDictionaire[Orientation.WEST]);
             Assert.AreEqual(Ways[1].GetDictionaire[Orientation.EAST], Ways[2].GetDictionaire[Orientation.WEST]);
             Assert.AreEqual(Ways[3].GetDictionaire[Orientation.EAST], Ways[4].GetDictionaire[Orientation.WEST]);
             Assert.AreEqual(Ways[4].GetDictionaire[Orientation.EAST], Ways[5].GetDictionaire[Orientation.WEST]);
             Assert.AreEqual(Ways[6].GetDictionaire[Orientation.EAST], Ways[7].GetDictionaire[Orientation.WEST]);
             Assert.AreEqual(Ways[7].GetDictionaire[Orientation.EAST], Ways[8].GetDictionaire[Orientation.WEST]);

             Assert.AreEqual(Ways[0].GetDictionaire[Orientation.SOUTH], Ways[3].GetDictionaire[Orientation.NORTH]);
             Assert.AreEqual(Ways[1].GetDictionaire[Orientation.SOUTH], Ways[4].GetDictionaire[Orientation.NORTH]);
             Assert.AreEqual(Ways[2].GetDictionaire[Orientation.SOUTH], Ways[5].GetDictionaire[Orientation.NORTH]);
             Assert.AreEqual(Ways[3].GetDictionaire[Orientation.SOUTH], Ways[6].GetDictionaire[Orientation.NORTH]);
             Assert.AreEqual(Ways[4].GetDictionaire[Orientation.SOUTH], Ways[7].GetDictionaire[Orientation.NORTH]);
             Assert.AreEqual(Ways[5].GetDictionaire[Orientation.SOUTH], Ways[8].GetDictionaire[Orientation.NORTH]);

         }
    }
}
