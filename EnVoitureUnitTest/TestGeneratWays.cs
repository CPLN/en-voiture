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
             List<Way> Ways= new List<Way>();
             Ways = Way.WaysGenerator(3, 6);
             Assert.AreEqual(18, Ways.Count);
         }
    }
}
