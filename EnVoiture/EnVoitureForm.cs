using System;
using System.Collections.Generic;
using System.Drawing;
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
        private ToolsBox _toolBox;

        Car voiture;
        private List<RoadUserWidget> roadUsers;
        bool bAvancer = false, bReculer = false, bDroite = false, bGauche = false;

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
            List<WayWidget> ww = new List<WayWidget>();
            ww.Add(new WayWidget(new Way(0, 0, 0, 0, new List<Orientation>() { Orientation.NORTH })));
            _toolBox = new ToolsBox(ww);
			this.roadUsers = new List<RoadUserWidget>();
            roadUsers.Add(new CarWidget(0, 0, 10, 20, 80));
            voiture = (roadUsers[0] as CarWidget).Car;

            this.Ways = new List<Way>();
        }

        public Way CreateWay(int x, int y)
        {
            Way RouteBase = new Way(x, y, 100, 100, new List<Orientation>() { Orientation.NORTH });
            return RouteBase;
        }
        /// <summary>
        /// Est apellé beaucoup de fois par seconde 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (RoadUserWidget user in _roadUsers)
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
    }
}
