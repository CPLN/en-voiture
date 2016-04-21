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
        bool TouchPressed;

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
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

        private void EnVoitureForm_KeyDown(object sender, KeyEventArgs e)
        {
            TouchPressed = true;
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                Avancer(TouchPressed);
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                Gauche(TouchPressed);
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                Reculer(TouchPressed);
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                Droite(TouchPressed);
            }
        }

        private void EnVoitureForm_KeyUp(object sender, KeyEventArgs e)
        {
            TouchPressed = false;
            StopDeplacement(TouchPressed);
        }
    }
}
