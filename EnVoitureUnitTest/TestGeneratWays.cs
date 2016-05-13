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
    public class TestGeneratWays
    {
         [TestMethod]
         public void TestCreationVille()
         {
             List<Route> Ways= new List<Route>();
             Ways = Route.Generer(3, 6);
             Assert.AreEqual(18, Ways.Count);
         }
    }
}
