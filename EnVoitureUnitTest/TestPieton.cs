using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using EnVoiture;

namespace EnVoitureUnitTest
{
    [TestClass]
    public class TestPieton
    {
        /// <summary>
        /// Test de création de nouvel objet Pieton 
        /// (posX, posY, largeur, hauteur, vitesse base, vitesse max)
        /// Tests Assert : IsNotNull -> objet Pieton
        /// </summary>
        [TestMethod]
        public void TestCreatePieton()
        {
            Pieton pieton1 = new Pieton(30, 30, 10, 10, 0.0f, 150.0f);
            Assert.IsNotNull(pieton1);
        }
    }
}
