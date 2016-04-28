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
                Pen BlackPen = new Pen(Color.Black, 20);
                Point point2 = new Point(way.Location.X + way.Size.Width / 2, way.Location.Y + way.Size.Height/2);
                Point point1;
                way.Paint(g);
                if (way.GetDictionaire.ContainsKey(Orientation.NORTH) && way.GetDictionaire[Orientation.NORTH])
                {
                    point1 = new Point(way.Location.X + way.Size.Width / 2, way.Location.X);
                    g.DrawLine(BlackPen, point1, point2);

                }
                if (way.GetDictionaire.ContainsKey(Orientation.SOUTH) && way.GetDictionaire[Orientation.SOUTH])
                {
                    point1 = new Point(way.Location.X + way.Size.Width / 2, way.Location.Y + way.Size.Height);
                    g.DrawLine(BlackPen, point1, point2);
                }
                if (way.GetDictionaire.ContainsKey(Orientation.EAST) && way.GetDictionaire[Orientation.EAST])
                {
                    point1 = new Point(way.Location.X, way.Location.Y + way.Size.Height / 2);
                    g.DrawLine(BlackPen, point1, point2);
                }
                if (way.GetDictionaire.ContainsKey(Orientation.WEST) && way.GetDictionaire[Orientation.WEST])
                {
                    point1 = new Point(way.Location.X + way.Size.Width, way.Location.Y + way.Size.Height / 2);
                    g.DrawLine(BlackPen, point1, point2);
                }
            }
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
