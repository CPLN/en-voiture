using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using EnVoiture.Modele;

namespace EnVoitureUnitTest
{
    [TestClass]
    public class TestRoadUser
    {
        [TestMethod]
        public void TestBounds()
        {
            Usager car1 = new Voiture(10, 20, 30, 40, 80);

            Rectangle rect = new Rectangle(10, 20, 30, 40);
            Usager car2 = new Voiture(rect, 80);

            Assert.AreEqual(car1.Bornes, car2.Bornes);
            Assert.AreNotEqual(car1, car2);
        }

        [TestMethod]
        public void TestGeometry()
        {
            Usager car = new Voiture(16, 42, 120, 910, 80);
            Assert.AreEqual(new Point(16, 42), car.Position);
            Assert.AreEqual(new Size(120, 910), car.Taille);
            Assert.AreEqual(120, car.Largeur);
            Assert.AreEqual(910, car.Hauteur);
            Assert.AreEqual(16, car.Gauche);
            Assert.AreEqual(136, car.Droite);
            Assert.AreEqual(42, car.Haut);
            Assert.AreEqual(952, car.Bas);
        }

        [TestMethod]
        public void TestAngle()
        {
            Usager car = new Voiture(0, 0, 10, 10, 80);
            car.Angle = 42;
            Assert.AreEqual(42, car.Angle);
        }

        [TestMethod]
        public void TestCollide()
        {
            Usager car1;
            Usager car2;

            // Contact
            car1 = new Voiture(0, 0, 10, 10, 80);
            car2 = new Voiture(5, 5, 10, 10, 80);
            Assert.IsTrue(car1.Heurte(car2));
            Assert.IsTrue(car2.Heurte(car1));

            // Pas de contact
            car1 = new Voiture(0, 0, 10, 10, 80);
            car2 = new Voiture(15, 15, 10, 10, 80);
            Assert.IsFalse(car1.Heurte(car2));
            Assert.IsFalse(car2.Heurte(car1));

            // Léger contact par le côté horizontal
            car1 = new Voiture(0, 0, 10, 10, 80);
            car2 = new Voiture(9, 0, 10, 10, 80);
            Assert.IsTrue(car1.Heurte(car2));
            Assert.IsTrue(car2.Heurte(car1));

            // Presque en contact par le côté horizontal
            car1 = new Voiture(0, 0, 10, 10, 80);
            car2 = new Voiture(10, 0, 10, 10, 80);
            Assert.IsFalse(car1.Heurte(car2));
            Assert.IsFalse(car2.Heurte(car1));

            // Léger contact par le côté vertical
            car1 = new Voiture(0, 0, 10, 10, 80);
            car2 = new Voiture(0, 9, 10, 10, 80);
            Assert.IsTrue(car1.Heurte(car2));
            Assert.IsTrue(car2.Heurte(car1));

            // Presque en contact par le côté vertical
            car1 = new Voiture(0, 0, 10, 10, 80);
            car2 = new Voiture(0, 10, 10, 10, 80);
            Assert.IsFalse(car1.Heurte(car2));
            Assert.IsFalse(car2.Heurte(car1));

            // Léger contact par l'angle
            car1 = new Voiture(0, 0, 10, 10, 80);
            car2 = new Voiture(9, 9, 10, 10, 80);
            Assert.IsTrue(car1.Heurte(car2));
            Assert.IsTrue(car2.Heurte(car1));

            // Presque en contact par l'angle
            car1 = new Voiture(0, 0, 10, 10, 80);
            car2 = new Voiture(10, 10, 10, 10, 80);
            Assert.IsFalse(car1.Heurte(car2));
            Assert.IsFalse(car2.Heurte(car1));

            // Léger contact par l'autre angle
            car1 = new Voiture(10, 10, 10, 10, 80);
            car2 = new Voiture(19, 1, 10, 10, 80);
            Assert.IsTrue(car1.Heurte(car2));
            Assert.IsTrue(car2.Heurte(car1));

            // Presque en contact par l'autre angle
            car1 = new Voiture(10, 10, 10, 10, 80);
            car2 = new Voiture(20, 0, 10, 10, 80);
            Assert.IsFalse(car1.Heurte(car2));
            Assert.IsFalse(car2.Heurte(car1));
        }
        [TestMethod]
        public void TestAvance()
        {
            Usager car = new Voiture(0, 0, 10, 10, 80);
            car.Avancer();
            Assert.AreEqual(-1, car.Position.Y); //teste si la position sur l'axe y a bien été incrémenté
            Assert.AreEqual(0, car.Position.X);//teste si la position su l'axe x est restée la même
        }
        [TestMethod]
        public void TestGauche()
        {
            Usager car = new Voiture(0, 0, 10, 10, 80);
            car.TournerGauche();
            Assert.AreEqual(0, car.Position.Y); //teste si la position sur l'axe y a bien été décrémentée
            Assert.AreEqual(-1, car.Position.X);//teste si la position su l'axe x est restée la même
        }
        [TestMethod]
        public void TestDroite()
        {
            Usager car = new Voiture(0, 0, 10, 10, 80);
            car.TournerDroite();
            Assert.AreEqual(0, car.Position.Y); //teste si la position sur l'axe y a bien été incrémentée
            Assert.AreEqual(1, car.Position.X);//teste si la position su l'axe x est restée la même
        }
        [TestMethod]
        public void TestReculer()
        {
            Usager car = new Voiture(0, 0, 10, 10, 80);
            car.Reculer();
            Assert.AreEqual(1, car.Position.Y); //teste si la position sur l'axe y a bien été décrémentée
            Assert.AreEqual(0, car.Position.X);//teste si la position su l'axe x est restée la même
        }
        [TestMethod]
        public void TestStopDeplacement()
        {
            Usager car = new Voiture(0, 0, 10, 10, 80);
            car.FreinageUrgence();
            Assert.AreEqual(0, car.Position.Y); //teste si la position su l'axe y est restée la même
            Assert.AreEqual(0, car.Position.X);//teste si la position su l'axe x est restée la même
        }
        [TestMethod]
        public void TestIsClicked()
        {
            Point pnt = new Point(50, 50);
            Usager car = new Voiture(50,50,10,10,80);
            Assert.IsTrue(car.estClique(pnt));

        }
    }
}
