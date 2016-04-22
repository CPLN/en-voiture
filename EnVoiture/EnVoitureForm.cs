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
            Ways.Add(new Way(10,10,100,100,new List<Orientation>()));
            Ways.Add(new Way(120, 120, 100, 100, new List<Orientation>()));
            
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
                Pen BlackPen = new Pen(Color.Black, 20);
                Point point1 = new Point(way.Location.X+way.Size.Width/2, way.Location.X);
                Point point2 = new Point(way.Location.Y+way.Size.Width/2,way.Location.Y+way.Size.Height);
                way.Paint(g);
                g.DrawLine(BlackPen, point1, point2);
            }
            foreach (RoadUserWidget user in roadUsers)
            {
                user.Paint(g);
            }
        }
    }
}
