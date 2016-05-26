using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using EnVoiture;
using System.Collections.Generic;

namespace EnVoitureUnitTest
{
    //Localisation = new PointF((float)(Localisation.X + dblVitesse * Math.Sin(Angle)),
    //(float)(Localisation.Y - dblVitesse * Math.Cos(Angle)));
    [TestClass]
    public class TestVirages
    {

//===========================================================================
// Tests Gauche
//===========================================================================

        /*
         * 
         * Acceleration
         * 
         */

        [TestMethod]//Test vitesse et angle de la voiture arretee qui accelere à gauche
        public void TestAccelerationGaucheDepartArrete()
        {
            Usager voiture = new Voiture(0, 0, 10, 20, 80);
            voiture.Accelerer();
            voiture.TournerGauche();
            
            Assert.AreEqual(voiture.Angle, -0.1, 0.000001);
            Assert.AreEqual(voiture.Vitesse, 10.0);
        }

        [TestMethod]//Test vitesse et angle de voiture en mouvement qui accelere à gauche
        public void TestAccelerationGaucheDepartMouvement()
        {
            //Usager voiture = new Voiture(0, 0, 10, 20, 80);
            //voiture.Accelerer();
            //voiture.Accelerer();
            //voiture.TournerGauche();
            //Assert.AreEqual(voiture.Angle, -0.2, 0.000001);
            //Assert.AreEqual(voiture.Vitesse, 20.0);
        }

        [TestMethod]//Test vitesse et angle de voiture en mouvement negatif qui accelere à gauche
        public void TestAccelerationGaucheDepartVitesseNegative()
        {

        }

        [TestMethod]
        public void TestAccelerationGaucheDepartVitessesDifferentes()
        {

        }

        /*
         * 
         * Freinages
         * 
         */

        [TestMethod]//Test vitesse et angle de la voiture arretee qui freine à gauche
        public void TestFreinageGaucheDepartArrete()
        {

        }

        [TestMethod]
        public void TestFreinageGaucheDepartMouvement()
        {

        }

        [TestMethod]
        public void TestFreinageGaucheDepartVitesseNegative()
        {

        }

        [TestMethod]
        public void TestFreinageGaucheDepartVitessesDifferentes()
        {

        }

        /*
         * 
         * Frottement
         * 
         */

        [TestMethod]//Test vitesse et angle de la voiture arretee qui decelere à gauche
        public void TestFrottementGaucheDepartArrete()
        {

        }

        [TestMethod]
        public void TestFrottementGaucheDepartMouvement()
        {

        }

        [TestMethod]
        public void TestFrottementGaucheDepartVitesseNegative()
        {

        }

        [TestMethod]
        public void TestFrottementGaucheDepartVitessesDifferentes()
        {

        }
//===========================================================================
// Tests Droite
//===========================================================================

        /*
         * 
         * Acceleration
         * 
         */

        [TestMethod]//Test vitesse et angle de la voiture arretee qui accelere à droite
        public void TestAccelerationDroiteDepartArrete()
        {

        }

        [TestMethod]
        public void TestAccelerationDroiteDepartMouvement()
        {

        }

        [TestMethod]
        public void TestAccelerationDroiteDepartVitesseNegative()
        {

        }

        [TestMethod]
        public void TestAccelerationDroiteDepartVitessesDifferentes()
        {

        }

        /*
         * 
         * Freinages
         * 
         */

        [TestMethod]//Test vitesse et angle de la voiture arretee qui freine à droite
        public void TestFreinageDroiteDepartArrete()
        {

        }

        [TestMethod]
        public void TestFreinageDroiteDepartMouvement()
        {

        }

        [TestMethod]
        public void TestFreinageDroiteDepartVitesseNegative()
        {

        }

        [TestMethod]
        public void TestFreinageDroiteDepartVitessesDifferentes()
        {

        }

        /*
         * 
         * Frottement
         * 
         */

        [TestMethod]//Test vitesse et angle de la voiture arretee qui decelere à droite
        public void TestFrottementDroiteDepartArrete()
        {

        }

        [TestMethod]
        public void TestFrottementDroiteDepartMouvement()
        {

        }

        [TestMethod]
        public void TestFrottementDroiteDepartVitesseNegative()
        {

        }

        [TestMethod]
        public void TestFrottementDroiteDepartVitessesDifferentes()
        {

        }
//===========================================================================
// Tests tout droit
//===========================================================================

        /*
         * 
         * Acceleration
         * 
         */

        [TestMethod]//Test vitesse et angle de la voiture arretee qui accelere tout droit
        public void TestAccelerationToutDroitDepartArrete()
        {

        }

        [TestMethod]
        public void TestAccelerationToutDroitDepartMouvement()
        {

        }

        [TestMethod]
        public void TestAccelerationToutDroitDepartVitesseNegative()
        {

        }

        [TestMethod]
        public void TestAccelerationToutDroitDepartVitessesDifferentes()
        {

        }

        /*
         * 
         * Freinages
         * 
         */

        [TestMethod]//Test vitesse et angle de la voiture arretee qui freine tout droit
        public void TestFreinageToutDroitDepartArrete()
        {

        }

        [TestMethod]
        public void TestFreinageToutDroitDepartMouvement()
        {

        }

        [TestMethod]
        public void TestFreinageToutDroitDepartVitesseNegative()
        {

        }

        [TestMethod]
        public void TestFreinageToutDroitDepartVitessesDifferentes()
        {

        }

        /*
         * 
         * Frottement
         * 
         */

        [TestMethod]//Test vitesse et angle de la voiture arretee qui decelere tout droit
        public void TestFrottementToutDroitDepartArrete()
        {

        }

        [TestMethod]
        public void TestFrottementToutDroitDepartMouvement()
        {

        }

        [TestMethod]
        public void TestFrottementToutDroitDepartVitesseNegative()
        {

        }

        [TestMethod]
        public void TestFrottementToutDroitDepartVitessesDifferentes()
        {

        }
    }
}
