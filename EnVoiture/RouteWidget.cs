using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class RouteWidget
    {
        public static int TAILLE = 100;
        public Route Route { get; set; }

        public RouteWidget(Route route)
        {
            Route = route;
        }
        public void Dessiner(Graphics g)
        {
            int Left = Route.Position.X * TAILLE;
            int Top = Route.Position.Y * TAILLE;
            int TailleX = Route.Taille.Width * TAILLE;
            int TailleY = Route.Taille.Height * TAILLE;

            Dessiner(g, Left, Top, TailleX, TailleY);
        }

        public void DessinerSurOrigine(Graphics g)
        {
            Dessiner(g, 0, 0, 100, 100);
        }

        private void Dessiner(Graphics g, int x, int y, int largeur, int hauteur)
        {
            g.FillRectangle(Brushes.Gray, x, y, largeur, hauteur);
            Pen BlackPen = new Pen(Color.Black, 20);
            Point point2 = new Point(x + hauteur / 2, y + hauteur / 2);
            Point point1;

            g.FillEllipse(Brushes.Black, point2.X - 10, point2.Y - 10, 20, 20);

            if (Route.GetDictionaire.ContainsKey(Orientation.NORD) && Route.GetDictionaire[Orientation.NORD])
            {
                point1 = new Point(x + largeur / 2, y);
                g.DrawLine(BlackPen, point1, point2);

            }
            if (Route.GetDictionaire.ContainsKey(Orientation.SUD) && Route.GetDictionaire[Orientation.SUD])
            {
                point1 = new Point(x + largeur / 2, y + hauteur);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (Route.GetDictionaire.ContainsKey(Orientation.EST) && Route.GetDictionaire[Orientation.EST])
            {
                point1 = new Point(x + largeur, y + hauteur / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (Route.GetDictionaire.ContainsKey(Orientation.OUEST) && Route.GetDictionaire[Orientation.OUEST])
            {
                point1 = new Point(x, y + hauteur / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
        }
    }
}
