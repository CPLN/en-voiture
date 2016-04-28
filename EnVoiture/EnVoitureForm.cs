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
        private List<RoadUserWidget> roadUsers;
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

            this.roadUsers = new List<RoadUserWidget>();
            
            this.Ways = new List<Way>();
            this.Ways = Way.WaysGenerator(15, 12);
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Way way in Ways)
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
