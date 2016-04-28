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
        /// 
        /// </summary>
        private List<Way> Ways;

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();
            DoubleBuffered = true;

            this.roadUsers = new List<RoadUserWidget>();
            roadUsers.Add(new CarWidget(0, 0, 10, 20, 80));
            voiture = (roadUsers[0] as CarWidget).Car;

            this.Ways = new List<Way>();
            this.Ways = Way.WaysGenerator(2, 12);
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
                way.Left = way.Location.X * 10;
                way.Top = way.Location.Y * 10;
                way.TailleX = 100;
                way.TailleY = 100;
                way.Paint(g);
            }
            foreach (RoadUserWidget user in roadUsers)
            {
                user.Paint(g);
            }
        }

        private void EnVoitureForm_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.W && bReculer == false || e.KeyCode == Keys.Up && bReculer == false)
            {
                bAvancer = true;
            }
            
            if (e.KeyCode == Keys.S && bAvancer == false || e.KeyCode == Keys.Down && bAvancer == false)
            {
                bReculer = true;
            }

            if (e.KeyCode == Keys.A && bDroite == false || e.KeyCode == Keys.Left && bDroite == false)
            {
                bGauche = true;
            }

            if (e.KeyCode == Keys.D && bGauche == false || e.KeyCode == Keys.Right && bGauche == false)
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
            
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
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
