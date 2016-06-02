using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using EnVoiture.Modele;

namespace EnVoitureUnitTest
{
    [TestClass]
    public class testAcceleration
    {
        [TestMethod]
        public void TestAcceleration1()
        {
            Voiture car = new Voiture(new Rectangle(0, 0, 0, 0), 5);

            Assert.AreEqual(0, car.Vitesse);
            car.Avancer();

            Assert.AreEqual(1, car.Vitesse);
            car.Avancer();

            Assert.AreEqual(2, car.Vitesse);
            car.Avancer();

            Assert.AreEqual(3, car.Vitesse);
            car.Avancer();

            Assert.AreEqual(4, car.Vitesse);
            car.Avancer();

            Assert.AreEqual(5, car.Vitesse);

            car.Avancer();
            Assert.AreEqual(5, car.Vitesse);

        }

        [TestMethod]
        public void Testralentir()
        {
            Voiture car = new Voiture(new Rectangle(0, 0, 0, 0), 5);

            car.Vitesse = 5;

            car.Ralentir();
            Assert.AreEqual(4, car.Vitesse);

            car.Ralentir();
            Assert.AreEqual(3, car.Vitesse);

            car.Ralentir();
            Assert.AreEqual(2, car.Vitesse);

            car.Ralentir();
            Assert.AreEqual(1, car.Vitesse);

            car.Ralentir();
            Assert.AreEqual(0, car.Vitesse);
        }

        [TestMethod]
        public void TestAcceleration2()
        {
            Voiture car = new Voiture(new Rectangle(0, 0, 0, 0), 5);

            car.Vitesse = 5;

            car.Freiner();
            Assert.AreEqual(2, car.Vitesse);

            car.Freiner();
            Assert.AreEqual(0, car.Vitesse);

            car.Freiner();
            Assert.AreEqual(0, car.Vitesse);
        }
    }
}
