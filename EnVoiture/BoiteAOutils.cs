using EnVoiture.Modele;
using EnVoiture.Vue;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnVoiture
{
    public class BoiteAOutils : UserControl
    {
        

 
       // private int _tailleRoutes = 1;
        public Route _routeSelectionnee
        {
            get
            {
                return GenerateurWidget.RouteWidget.Route;
            }
        }

        /// <summary>
        /// propriété WayWidgets permetant d'ajouter des WayWidget dans la liste ww
        /// </summary>
        /// 
        //public List<RouteWidget> RouteWidgets
        //{
        //    get
        //    {
        //        List<RouteWidget> ww = new List<RouteWidget>();

        //        ww.Add(new RouteWidget(new Route(20, 100, _tailleRoutes, _tailleRoutes, new List<Orientation>() { Orientation.NORTH, Orientation.SOUTH })));
        //        ww.Add(new RouteWidget(new Route(20, 300, _tailleRoutes, _tailleRoutes, new List<Orientation>() { Orientation.EAST, Orientation.SOUTH })));
        //        ww.Add(new RouteWidget(new Route(20, 300, _tailleRoutes, _tailleRoutes, new List<Orientation>() { Orientation.EAST, Orientation.SOUTH })));

        //        ww.Add(new RouteWidget(new Route(0, 0, 100, 100, new List<Orientation>() { Orientation.NORTH })));
        //        return ww;
        //    }
        //}

        public GenerateurWidget GenerateurWidget
        {

            get;
            private set;
        }


        public Route RouteSelectionnee
        {
            get
            {
                return GenerateurWidget.RouteWidget.Route;
            }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public BoiteAOutils()
        {
            InitializeComponent();
            GenerateurWidget = new GenerateurWidget();
            Paint += new PaintEventHandler((source, e) => { GenerateurWidget.DessinerSurOrigine(e.Graphics); });
            MouseClick += new MouseEventHandler(this.RouteBouton_MouseClick);
            //panel.Location = new Point(this.Location.X + this.Size.Width / 2, 0);
        }

        private void RouteBouton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GenerateurWidget.Detectcontenu(e.Location))
                {
                    MessageBox.Show(GenerateurWidget.DetectionOrientation(e.Location).ToString());
                    GenerateurWidget.Generateur.EditionRoute(GenerateurWidget.DetectionOrientation(e.Location));
                }
                Invalidate();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BoiteAOutils
            // 
            this.AutoScroll = true;
            this.Name = "BoiteAOutils";
            this.Size = new System.Drawing.Size(311, 194);
            this.ResumeLayout(false);

        }
    }
}
