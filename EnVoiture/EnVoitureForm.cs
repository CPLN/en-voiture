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
        private List<RoadUserWidget> roadUsers = new List<RoadUserWidget>();
        /// <summary>
        /// Liste des routes qui seront affichées
        /// </summary>
        private List<WayWidget> Ways = new List<WayWidget>();

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();
        }

       public Way creatWay(int x, int y) {

           Way RouteBase = new Way(x, y, 100, 100, new List<Orientation>() { Orientation.NORTH});

           return RouteBase;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (WayWidget way in Ways)
            {
                way.Paint(g);
            }

            foreach (RoadUserWidget user in roadUsers)
            {
                user.Paint(g);
            }
        }
    }
}
