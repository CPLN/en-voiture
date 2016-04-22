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
            roadUsers.Add(new CarWidget(10, 10, 30, 20));

            this.Ways = new List<Way>();
          
            Way w1 = new Way(100, 100, 75, 150, new List<Orientation>() { Orientation.NORTH, Orientation.SOUTH});
            Ways.Add(w1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Way ways in Ways)
            {
                ways.Paint(g);
            }

            foreach (RoadUserWidget user in roadUsers)
            {
                user.Paint(g);
            }
        }
    }
}
