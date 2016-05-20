using EnVoiture.Modele;
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


            g.FillRectangle(Brushes.Gray, Route.Position.X * TAILLE, Route.Position.Y * TAILLE, Route.Taille.Width * TAILLE, Route.Taille.Height * TAILLE);
            Point point2 = new Point(Route.Position.X * TAILLE + Route.Taille.Height * TAILLE / 2, Route.Position.Y * TAILLE + Route.Taille.Height * TAILLE / 2);
            

            g.FillEllipse(Brushes.Black, point2.X - 10, point2.Y - 10, 20, 20);

            if (Route.DictionaireObstacles.ContainsKey(Orientation.NORD))
            {
                DessinerSegment(g, Orientation.NORD, Route.DictionaireObstacles[Orientation.NORD]);
            }
            if (Route.DictionaireObstacles.ContainsKey(Orientation.SUD))
            {
                DessinerSegment(g, Orientation.SUD, Route.DictionaireObstacles[Orientation.SUD]);

            }
            if (Route.DictionaireObstacles.ContainsKey(Orientation.EST))
            {
                DessinerSegment(g, Orientation.EST, Route.DictionaireObstacles[Orientation.EST]);

            }
            if (Route.DictionaireObstacles.ContainsKey(Orientation.OUEST))
            {
                DessinerSegment(g, Orientation.OUEST, Route.DictionaireObstacles[Orientation.OUEST]);

            }
        }

        public void DessinerSurOrigine(Graphics g)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 100, 100));
        }

        public void DessinerSegment(Graphics g, Orientation orientation, Obstacle obstacle)
        {
            int Left = Route.Position.X * TAILLE;
            int Top = Route.Position.Y * TAILLE;
            int TailleX = Route.Taille.Width * TAILLE;
            int TailleY = Route.Taille.Height * TAILLE;
            Point point2 = new Point(Left + TailleY / 2, Top + TailleY / 2);
            Pen pen;
            switch (obstacle)
            {
                case Obstacle.RIEN:
                    pen = new Pen(Brushes.Transparent, 20);
                    break;
                case Obstacle.ROUTE:
                    pen = new Pen(Brushes.Black, 20);
                    break;
                case Obstacle.ROUTETROTTOIR:
                    pen = new Pen(Brushes.Blue, 20);
                    break;
                default:
                    pen = new Pen(Brushes.Gainsboro, 20);
                    break;
            }
            Point point1;

            switch (orientation)
            {
                case Orientation.NORD:
                    point1 = new Point(Left + TailleX / 2, Top);
                    g.DrawLine(pen, point1, point2);
                    break;
                case Orientation.EST:
                    point1 = new Point(Left + TailleX, Top + TailleY / 2);
                    g.DrawLine(pen, point1, point2);
                    break;
                case Orientation.SUD:
                    point1 = new Point(Left + TailleX / 2, Top + TailleY);
                    g.DrawLine(pen, point1, point2);
                    break;
                case Orientation.OUEST:
                    point1 = new Point(Left, Top + TailleY / 2);
                    g.DrawLine(pen, point1, point2);
                    break;
                default:
                    break;
            }
        }
    }
}
