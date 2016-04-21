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
        /// Faire un foreach pour l'affichage
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
          Way w1 = new Way(10, 10, 10, 10, new List<Orientation>() { Orientation.NORTH, Orientation.SOUTH});
        }

        private void EnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // route

            g.FillRectangle(Brushes.Gray, 0, 0, 10, 10);

            

            foreach (RoadUserWidget user in roadUsers)
            {
                user.Paint(g);
            }
        }
    }
}
