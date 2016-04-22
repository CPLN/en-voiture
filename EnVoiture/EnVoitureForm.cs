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
        Car voiture;
        private List<RoadUserWidget> roadUsers;
        bool bAvancer = false, bReculer = false, bDroite = false, bGauche = false;

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();

            this.roadUsers = new List<RoadUserWidget>();
            roadUsers.Add(new CarWidget(50, 50, 10, 20));
            voiture = (roadUsers[0] as CarWidget).Car;
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
            

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                bAvancer = true;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                bReculer = true;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                bGauche = true;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                bDroite = true;
            }
        }

        private void EnVoitureForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                bAvancer = false;
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                bReculer = false;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                bGauche = false;
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                bDroite = false;
            }
        }

        private void timerDirection_Tick(object sender, System.EventArgs e)
        {
            if (bAvancer)
            {
                voiture.Avancer();
            }

            if (bReculer)
            {
                voiture.Reculer();
            }

            if (bGauche)
            {
                voiture.Gauche();
            }

            if (bDroite)
            {
                voiture.Droite();
            }
            Invalidate();
        }
    }
}
