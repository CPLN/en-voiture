using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace en_voiture
{
    /// <summary>
    /// Classe principale du projet.
    /// </summary>
    public partial class EnVoiture : Form
    {
        private List<RoadUserWidget> roadUsers;

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoiture()
        {
            InitializeComponent();

            this.roadUsers = new List<RoadUserWidget>();
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
