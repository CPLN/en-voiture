using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using EnVoiture;
using System.Collections.Generic;

namespace EnVoitureUnitTest
{

    [TestClass]
    public class TestVirages
    {
        /// <summary>
        /// Teste que l'angle change quand l'on avance et que l'on tourne à gauche
        /// </summary>
        [TestMethod]
        public void TestAngleVirageGauche()
        {
            RoadUser voiture = new Voiture(10, 20, 30, 40, 80);
            voiture.Accelerer();
            voiture.Gauche();
            Assert.AreNotEqual(0.0F, voiture.Angle);
        }
        /// <summary>
        /// Teste que l'angle change quand l'on avance et que l'on tourne à droite
        /// </summary>
        [TestMethod]
        public void TestAngleVirageDroite()
        {
            RoadUser voiture = new Voiture(10, 20, 30, 40, 80);
            voiture.Accelerer();
            voiture.Droite();
            Assert.AreNotEqual(0.0F, voiture.Angle);
            Assert.AreEqual(12.1, 12.0999999, 1e-4);
        }
        /// <summary>
        /// Teste que l'angle calculé est correct
        /// </summary>
        [TestMethod]
        public void TestCalculAngle()
        {

        }
    }
}
