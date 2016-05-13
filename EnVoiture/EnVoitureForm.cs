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

        Voiture voiture;
        bool bAvancer = false, bReculer = false, bDroite = false, bGauche = false;

        // Liste des routes
        private List<Route> Ways = new List<Route>();

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();
            VoitureWidget v = new VoitureWidget(0, 0, 10, 20, 80);
            this._roadUsers.Add(v);
            this.voiture = v.Voiture;
            enVoiturePanel.ToolsBox = toolsBox;
        }

        /// <summary>
        /// On crée une route en fonction des cordonnées reçu en paramètre
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Route CreateWay(int x, int y)
        {
            Route RouteBase = new Route(x, y, 100, 100, new List<Orientation>() { Orientation.NORTH });
            return RouteBase;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnVoitureForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && e.Control)
                toolsBox.Visible = !toolsBox.Visible;
            enVoiturePanel.OnKeyDown(sender, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnVoitureForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            enVoiturePanel.OnKeyUp(sender, e);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    if (!(user is VoitureWidget))
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, System.EventArgs e)
        {
            enVoiturePanel.Tick(sender, e);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnVoitureForm_MouseDown(object sender, MouseEventArgs e)
        {
            enVoiturePanel.OnMouseDown(sender, e);
        }
    }
}
