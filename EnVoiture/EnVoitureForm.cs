using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EnVoiture
{
    /// <summary>
    /// Classe principale du projet.
    /// </summary>
    public partial class EnVoitureForm : Form
    {
        Car voiture;
        private List<RoadUserWidget> roadUsers;
        bool bAvancer = false, bReculer = false, bDroite = false, bGauche = false;

        //Variables de détection de la voiture
        private GraphicsPath _graphicsPath;
        private Region _region;

        /// <summary>
        /// 
        /// </summary>
        private List<Way> Ways;

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();

            this.roadUsers = new List<RoadUserWidget>();
            roadUsers.Add(new CarWidget(0, 0, 10, 20, 80));
            roadUsers.Add(new CarWidget(150, 150, 10, 20, 80));
            roadUsers.Add(new CarWidget(240, 240, 10, 20, 80));
            voiture = (roadUsers[0] as CarWidget).Car;

            this.Ways = new List<Way>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Way way in Ways)
            {
                way.Paint(g);
            }

            foreach (RoadUserWidget user in roadUsers)
            {
                user.Paint(g);
            }
        }
        private void EnVoitureForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                bAvancer = true;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                bReculer = true;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                bGauche = true;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                bDroite = true;
            }
        }
        private void EnVoitureForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                bAvancer = false;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                bReculer = false;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                bGauche = false;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                bDroite = false;
            }
        }

        private void timerDirection_Tick(object sender, System.EventArgs e)
        {
            if (bAvancer)
            {
                voiture.Avancer();
            }

            if (bReculer)
            {
                voiture.Reculer();
            }

            if (bGauche)
            {
                voiture.Gauche();
            }

            if (bDroite)
            {
                voiture.Droite();
            }
            Invalidate();
        }

        private void EnVoitureForm_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (RoadUserWidget roaduser in roadUsers)
            {
                CarWidget voitureCourante = roaduser as CarWidget;
                if (voitureCourante.Car.IsClicked(e.Location))
                {
                    voiture = voitureCourante.Car;
                    return;
                }
            }
            
        }
    }
}
