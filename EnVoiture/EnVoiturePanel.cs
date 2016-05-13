using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnVoiture
{
    public class EnVoiturePanel : UserControl
    {
        private Voiture voiture;
        private List<RoadUserWidget> roadUsers;
        private bool bAvancer = false;
        private bool bReculer = false;
        private bool bDroite = false;
        private bool bGauche = false;
        private RouteWidget _hoverWayWidget = new RouteWidget(new Route(0, 0, 1, 1, new List<Orientation> { }));

        //Variables de détection de la voiture
        private GraphicsPath _graphicsPath;
        private Region _region;

        private List<RouteWidget> Ways;

        public BoiteAOutils ToolsBox
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

            this.roadUsers = new List<RoadUserWidget>();
            roadUsers.Add(new VoitureWidget(0, 0, 10, 20, 80));
            roadUsers.Add(new VoitureWidget(150, 150, 10, 20, 80));
            roadUsers.Add(new VoitureWidget(240, 240, 10, 20, 80));
            voiture = (roadUsers[0] as VoitureWidget).Voiture;
            this.Ways = new List<RouteWidget>();

            this.Paint += new PaintEventHandler(EnVoiture_Paint);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (RouteWidget way in Ways)
            {
                way.Dessiner(g);
            }
            foreach (RoadUserWidget user in roadUsers)
            {
                user.Paint(g);
            }
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

        public void Tick(object sender, System.EventArgs e)
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


            if (ToolsBox.Visible && _hoverWayWidget != null)
            {
                Point p = PointToClient(Cursor.Position);
                _hoverWayWidget.Route.Position = new Point(p.X / 100, p.Y / 100);
            }

            Invalidate();
        }

        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            foreach (RoadUserWidget roaduser in roadUsers)
            {
                VoitureWidget voitureCourante = roaduser as VoitureWidget;
                if (voitureCourante.Voiture.IsClicked(e.Location))
                {
                    voiture = voitureCourante.Voiture;
                    return;
                }
            }

            // creation de la route si en mode edition
            if (ToolsBox.Visible)
            {
                Route w = Route.VersPositionCase(e.X, e.Y, ToolsBox.RouteSelectionnee);
                if (w != null)
                    Ways.Add(new RouteWidget(w));
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
