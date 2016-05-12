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
        // Liste des elements qui seront affichés
        private List<RoadUserWidget> _roadUsers = new List<RoadUserWidget>();

        Car voiture;
        bool bAvancer = false, bReculer = false, bDroite = false, bGauche = false;

        // ?
        private List<Way> Ways = new List<Way>();

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();
            CarWidget v = new CarWidget(0, 0, 10, 20, 80);
            this._roadUsers.Add(v);
            this.voiture = v.Car;
        }

        public Way CreateWay(int x, int y)
        {
            Way RouteBase = new Way(x, y, 100, 100, new List<Orientation>() { Orientation.NORTH });
            return RouteBase;
        }


        private void EnVoitureForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && e.Control)
                toolsBox.Visible = !toolsBox.Visible;
            enVoiturePanel.OnKeyDown(sender, e);
        }

        private void EnVoitureForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            enVoiturePanel.OnKeyUp(sender, e);
        }



        private void timerDirection_Tick(object sender, System.EventArgs e)
        {
            if (bAvancer)
                voiture.Avancer();
            if (bReculer)
                voiture.Reculer();
            if (bGauche)
                voiture.Gauche();
            if (bDroite)
                voiture.Droite();
            enVoiturePanel.Invalidate();
        }

        /// <summary>
        /// est appelé quand on fait: pEnVoiture.Invalidate();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pEnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (toolsBox.Visible)
            {
                // mode edition
                foreach (RoadUserWidget user in _roadUsers)
                {
                    if (!(user is CarWidget))
                        user.Paint(g);
                }
            }
            else
            {
                foreach (RoadUserWidget user in _roadUsers)
                {
                    user.Paint(g);
                }
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            enVoiturePanel.Tick(sender, e);
        }

        private void EnVoitureForm_MouseDown(object sender, MouseEventArgs e)
        {
            enVoiturePanel.OnMouseDown(sender, e);
        }
    }
}
