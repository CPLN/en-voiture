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
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();

            this.roadUsers = new List<RoadUserWidget>();
            roadUsers.Add(new PietonWidget(50, 50, 50, 50, 10, 100));
        }

        private void EnVoiture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (RoadUserWidget user in roadUsers)
            {
                user.Paint(g);
            }
        }
    }
}
