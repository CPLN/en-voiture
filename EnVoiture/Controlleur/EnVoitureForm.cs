using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EnVoiture.Modele;
using EnVoiture.Vue;
using Orientation = EnVoiture.Modele.Orientation;

namespace EnVoiture.Controller
{
    /// <summary>
    /// Classe principale du projet.
    /// </summary>
    public partial class EnVoitureForm : Form
    {
        // Liste des elements qui seront affichés
        private List<UsagerWidget> _usagers = new List<UsagerWidget>();

        Voiture voiture;
        bool bAvancer = false, bReculer = false, bDroite = false, bGauche = false;

        // Liste des routes
        private List<Route> _routes = new List<Route>();

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();
            VoitureWidget v = new VoitureWidget(0,0,10,20,80);
            this._usagers.Add(v);
            this.voiture = v.Voiture;
            enVoiturePanel.BoiteAOutils = toolsBox;
        }

        /// <summary>
        /// On crée une route en fonction des cordonnées reçu en paramètre
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Route creationRoute(int x, int y)
        {
            Route RouteBase = new Route(x, y, 100, 100, new List<Orientation>() { Orientation.NORD });
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
                foreach (UsagerWidget usager in _usagers)
                {
                    if (!(usager is VoitureWidget))
                        usager.Dessiner(g);
                }
            }
            else
            {
                foreach (UsagerWidget user in _usagers)
                {
                    user.Dessiner(g);
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
