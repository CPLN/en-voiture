﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnVoiture.Modele;
using EnVoiture.Vue;
using Orientation = EnVoiture.Modele.Orientation;

namespace EnVoiture.Controller
{
    public class EnVoiturePanel : UserControl
    {
        private Voiture voiture;
        private List<UsagerWidget> _usagers;
        private bool bAvancer = false;
        private bool bReculer = false;
        private bool bDroite = false;
        private bool bGauche = false;
        private RouteWidget _prevRouteWidget = new RouteWidget(new Route(0, 0, 1, 1, new List<Orientation> { }));

        //Variables de détection de la voiture
        private GraphicsPath _graphicsPath;
        private Region _region;

        private List<RouteWidget> Routes;

        public BoiteAOutils BoiteAOutils
        {
            get;
            set;
        }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoiturePanel()
        {
            this.Enabled = true;

            DoubleBuffered = true;

            this._usagers = new List<UsagerWidget>();
            this._usagers.Add(new VoitureWidget(0, 0, 10, 20, 80));
            this._usagers.Add(new VoitureWidget(150, 150, 10, 20, 80));
            this._usagers.Add(new VoitureWidget(240, 240, 10, 20, 80));
            this.voiture = (_usagers[0] as VoitureWidget).Voiture;
            BoiteAOutils = new BoiteAOutils();
            this.Routes = new List<RouteWidget>();
            foreach (Route route in Route.Generer(6,5))
            {
                Routes.Add(new RouteWidget(route));
            }

            foreach (Route route in Route.Generer(6,6))
            {
                Routes.Add(new RouteWidget(route));
            }
            this.Paint += new PaintEventHandler(EnVoiture_Paint);
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (RouteWidget way in Routes)
            {
                way.Dessiner(g);
            }
            if (!BoiteAOutils.Visible)
            {
                foreach (UsagerWidget user in _usagers)
                {
                    user.Dessiner(g);
                }

            }
            else
                _prevRouteWidget.Dessiner(g, 50, Color.Black);
        }
        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && bReculer == false || e.KeyCode == Keys.Up && bReculer == false)
            {
                bAvancer = true;
            }
            
            if (e.KeyCode == Keys.S && bAvancer == false || e.KeyCode == Keys.Down && bAvancer == false)
            {
                bReculer = true;
            }

            if (e.KeyCode == Keys.A && bDroite == false || e.KeyCode == Keys.Left && bDroite == false)
            {
                bGauche = true;
            }

            if (e.KeyCode == Keys.D && bGauche == false || e.KeyCode == Keys.Right && bGauche == false)
            {
                bDroite = true;
            }
        }
        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                bAvancer = false;
            }
            
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Tick(object sender, System.EventArgs e)
        {
            if (bAvancer)
            {
                voiture.Accelerer();
            }
            else if (bReculer)
            {
                if(voiture.Vitesse <= 0)
                {
                    voiture.Reculer();
                }
                else
                {
                    voiture.Freiner();
                }
            }
            else if(!bReculer && !bAvancer)
            {
                voiture.Ralentir();
            }
            voiture.Avancer();
            
            if (bGauche)
            {
                voiture.TournerGauche();
            }

            if (bDroite)
            {
                voiture.TournerDroite();
            }

            if (BoiteAOutils.Visible && _prevRouteWidget != null)
            {
                Point p = PointToClient(Cursor.Position);
                Route r = BoiteAOutils.GenerateurWidget.Generateur.Route;
                
                _prevRouteWidget.Route = r;
                _prevRouteWidget.Route.Position = new Point(p.X / 100, p.Y / 100);
            }
            Invalidate();
        }

        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            foreach (UsagerWidget roaduser in _usagers)
            {
                VoitureWidget voitureCourante = roaduser as VoitureWidget;
                if (voitureCourante.Voiture.estClique(e.Location))
                    voiture = voitureCourante.Voiture;
            }

            // creation de la route si en mode edition
            if (BoiteAOutils.Visible)
            {
                Route w = Route.VersPositionCase(e.X, e.Y, BoiteAOutils.RouteSelectionnee);
                if (w != null)
                {
                    List<RouteWidget> routes = new List<RouteWidget>();
                    foreach (RouteWidget r in Routes)
                    {
                        if (r.Route.Position != w.Position)
                            routes.Add(r);
                    }
                    routes.Add(new RouteWidget(w));
                    Routes = routes;
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EnVoiturePanel
            // 
            this.Name = "EnVoiturePanel";
            this.ResumeLayout(false);
        }
    }    
}
