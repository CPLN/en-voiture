using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using EnVoiture;

namespace EnVoitureUnitTest
{
    [TestClass]
    public class TestRoadUser
    {
        [TestMethod]
        public void TestBounds()
        {
            RoadUser car1 = new Car(10, 20, 30, 40, 80);

            Rectangle rect = new Rectangle(10, 20, 30, 40);
            RoadUser car2 = new Car(rect, 80);

            Assert.AreEqual(car1.Bounds, car2.Bounds);
            Assert.AreNotEqual(car1, car2);
        }

        [TestMethod]
        public void TestGeometry()
        {
            RoadUser car = new Car(16, 42, 120, 910, 80);
            Assert.AreEqual(new Point(16, 42), car.Location);
            Assert.AreEqual(new Size(120, 910), car.Size);
            Assert.AreEqual(120, car.Width);
            Assert.AreEqual(910, car.Height);
            Assert.AreEqual(16, car.Left);
            Assert.AreEqual(136, car.Right);
            Assert.AreEqual(42, car.Top);
            Assert.AreEqual(952, car.Bottom);
        }

        [TestMethod]
        public void TestAngle()
        {
            RoadUser car = new Car(0, 0, 10, 10, 80);
            car.Angle = 42;
            Assert.AreEqual(42, car.Angle);
        }

        [TestMethod]
        public void TestCollide()
        {
            RoadUser car1;
            RoadUser car2;

            // Contact
            car1 = new Car(0, 0, 10, 10, 80);
            car2 = new Car(5, 5, 10, 10, 80);
            Assert.IsTrue(car1.Collide(car2));
            Assert.IsTrue(car2.Collide(car1));

            // Pas de contact
            car1 = new Car(0, 0, 10, 10, 80);
            car2 = new Car(15, 15, 10, 10, 80);
            Assert.IsFalse(car1.Collide(car2));
            Assert.IsFalse(car2.Collide(car1));

            // Léger contact par le côté horizontal
            car1 = new Car(0, 0, 10, 10, 80);
            car2 = new Car(9, 0, 10, 10, 80);
            Assert.IsTrue(car1.Collide(car2));
            Assert.IsTrue(car2.Collide(car1));

            // Presque en contact par le côté horizontal
            car1 = new Car(0, 0, 10, 10, 80);
            car2 = new Car(10, 0, 10, 10, 80);
            Assert.IsFalse(car1.Collide(car2));
            Assert.IsFalse(car2.Collide(car1));

            // Léger contact par le côté vertical
            car1 = new Car(0, 0, 10, 10, 80);
            car2 = new Car(0, 9, 10, 10, 80);
            Assert.IsTrue(car1.Collide(car2));
            Assert.IsTrue(car2.Collide(car1));

            // Presque en contact par le côté vertical
            car1 = new Car(0, 0, 10, 10, 80);
            car2 = new Car(0, 10, 10, 10, 80);
            Assert.IsFalse(car1.Collide(car2));
            Assert.IsFalse(car2.Collide(car1));

            // Léger contact par l'angle
            car1 = new Car(0, 0, 10, 10, 80);
            car2 = new Car(9, 9, 10, 10, 80);
            Assert.IsTrue(car1.Collide(car2));
            Assert.IsTrue(car2.Collide(car1));

            // Presque en contact par l'angle
            car1 = new Car(0, 0, 10, 10, 80);
            car2 = new Car(10, 10, 10, 10, 80);
            Assert.IsFalse(car1.Collide(car2));
            Assert.IsFalse(car2.Collide(car1));

            // Léger contact par l'autre angle
            car1 = new Car(10, 10, 10, 10, 80);
            car2 = new Car(19, 1, 10, 10, 80);
            Assert.IsTrue(car1.Collide(car2));
            Assert.IsTrue(car2.Collide(car1));

            // Presque en contact par l'autre angle
            car1 = new Car(10, 10, 10, 10, 80);
            car2 = new Car(20, 0, 10, 10, 80);
            Assert.IsFalse(car1.Collide(car2));
            Assert.IsFalse(car2.Collide(car1));
        }
        [TestMethod]
        public void TestAvance()
        {
            RoadUser car = new Car(0, 0, 10, 10, 80);
            car.Avancer();
            Assert.AreEqual(-1, car.Location.Y); //teste si la position sur l'axe y a bien été incrémenté
            Assert.AreEqual(0, car.Location.X);//teste si la position su l'axe x est restée la même
        }
        [TestMethod]
        public void TestGauche()
        {
            RoadUser car = new Car(0, 0, 10, 10, 80);
            car.Gauche();
            Assert.AreEqual(0, car.Location.Y); //teste si la position sur l'axe y a bien été décrémentée
            Assert.AreEqual(-1, car.Location.X);//teste si la position su l'axe x est restée la même
        }
        [TestMethod]
        public void TestDroite()
        {
            RoadUser car = new Car(0, 0, 10, 10, 80);
            car.Droite();
            Assert.AreEqual(0, car.Location.Y); //teste si la position sur l'axe y a bien été incrémentée
            Assert.AreEqual(1, car.Location.X);//teste si la position su l'axe x est restée la même
        }
        [TestMethod]
        public void TestReculer()
        {
            RoadUser car = new Car(0, 0, 10, 10, 80);
            car.Reculer();
            Assert.AreEqual(1, car.Location.Y); //teste si la position sur l'axe y a bien été décrémentée
            Assert.AreEqual(0, car.Location.X);//teste si la position su l'axe x est restée la même
        }
        [TestMethod]
        public void TestStopDeplacement()
        {
            RoadUser car = new Car(0, 0, 10, 10, 80);
            car.StopDeplacement();
            Assert.AreEqual(0, car.Location.Y); //teste si la position su l'axe y est restée la même
            Assert.AreEqual(0, car.Location.X);//teste si la position su l'axe x est restée la même
        }
    }
}
