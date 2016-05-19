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

            g.FillRectangle(Brushes.Gray, Left, Top, TailleX, TailleY);
            Pen BlackPen = new Pen(Color.Black, 20);
            Point point2 = new Point(Left + TailleY / 2, Top + TailleY / 2);
            Point point1;

            g.FillEllipse(Brushes.Black, point2.X - 10, point2.Y - 10, 20, 20);

            if (Route.GetDictionaire.ContainsKey(Orientation.NORTH) && Route.GetDictionaire[Orientation.NORTH])
            {
                point1 = new Point(Left + TailleX / 2, Top);
                g.DrawLine(BlackPen, point1, point2);

            }
            if (Route.GetDictionaire.ContainsKey(Orientation.SOUTH) && Route.GetDictionaire[Orientation.SOUTH])
            {
                point1 = new Point(Left + TailleX / 2, Top + TailleY);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (Route.GetDictionaire.ContainsKey(Orientation.EAST) && Route.GetDictionaire[Orientation.EAST])
            {
                point1 = new Point(Left + TailleX, Top + TailleY / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (Route.GetDictionaire.ContainsKey(Orientation.WEST) && Route.GetDictionaire[Orientation.WEST])
            {
                point1 = new Point(Left, Top + TailleY / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
        }

        public void DessinerSurOrigine(Graphics g)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 100, 100));
        }
    }
}
