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
        [TestMethod]
        public void TestEditionRoute()
        {
            Route route = new Route(0, 0, 1, 1, new List<Orientation>());
            Generateur generateur = new Generateur(route);
            generateur.EditionRoute(Orientation.NORTH);

            Assert.AreEqual(route.GetDictionaire[Orientation.NORTH], false);
        }
    }
}
