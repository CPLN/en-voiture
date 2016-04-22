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
        Car voiture = new Car(0,0,20,9);
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
            //TouchPressed = true;
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                voiture.Avancer();
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                voiture.Gauche();
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                voiture.Reculer();
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                voiture.Droite();
            }
        }

        private void EnVoitureForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && e.KeyCode == Keys.S ||
                e.KeyCode == Keys.Up && e.KeyCode == Keys.Down)
            {

                voiture.StopDeplacement();
            }
        }
    }
}
