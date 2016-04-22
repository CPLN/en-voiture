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


        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();
            List<WayWidget> ww = new List<WayWidget>();
            ww.Add(new WayWidget(new Way(0, 0, 0, 0, new List<Orientation>() { Orientation.NORTH } )));
            _toolBox = new ToolsBox(ww);

        }
        /// <summary>
        /// 
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
    }
}
