using EnVoiture.Modele;
using EnVoiture.Vue;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnVoiture.Controller
{
    public class BoiteAOutils : UserControl
    {
        public GenerateurWidget GenerateurWidget { get; private set; }

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
            GenerateurWidget = new GenerateurWidget(new Generateur());
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
