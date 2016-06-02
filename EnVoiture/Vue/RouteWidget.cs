using EnVoiture.Modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnVoiture.Modele;

namespace EnVoiture.Vue
{
    public class RouteWidget
    {
        public static int TAILLE = 100;
        public Route Route { get; set; }

        public RouteWidget(Route route)
        {
            Route = route;
        }

        public void Dessiner(Graphics g, int opacite, Color color)
        {
            int x = Route.Position.X * TAILLE;
            int y = Route.Position.Y * TAILLE;
            int largeur = Route.Taille.Width * TAILLE;
            int hauteur = Route.Taille.Height * TAILLE;
            Brush b = new SolidBrush(Color.FromArgb(opacite, color));
            g.FillRectangle(b, x, y, largeur, hauteur);
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
            //Pen BlackPen = new Pen(Color.Black, 20);
            Point point2 = new Point(x + hauteur / 2, y + hauteur / 2);
            //Point point1;


            //g.FillRectangle(Brushes.Gray, Route.Position.X * TAILLE, Route.Position.Y * TAILLE, Route.Taille.Width * TAILLE, Route.Taille.Height * TAILLE);
            //Point point2 = new Point(Route.Position.X * TAILLE + Route.Taille.Height * TAILLE / 2, Route.Position.Y * TAILLE + Route.Taille.Height * TAILLE / 2);
            


            g.FillEllipse(Brushes.Black, point2.X - 10, point2.Y - 10, 20, 20);

            if (Route.DictionnaireObstacles.ContainsKey(Orientation.NORD))
            {

                /*point1 = new Point(x + largeur / 2, y);
                g.DrawLine(BlackPen, point1, point2);*/


                DessinerSegment(g, Orientation.NORD, Route.DictionnaireObstacles[Orientation.NORD], x, y, largeur, hauteur);

            }
            if (Route.DictionnaireObstacles.ContainsKey(Orientation.SUD))
            {

                /*point1 = new Point(x + largeur / 2, y + hauteur);
                g.DrawLine(BlackPen, point1, point2);*/

                DessinerSegment(g, Orientation.SUD, Route.DictionnaireObstacles[Orientation.SUD], x, y, largeur, hauteur);


            }
            if (Route.DictionnaireObstacles.ContainsKey(Orientation.EST))
            {

               /* point1 = new Point(x + largeur, y + hauteur / 2);
                g.DrawLine(BlackPen, point1, point2);*/

                DessinerSegment(g, Orientation.EST, Route.DictionnaireObstacles[Orientation.EST], x, y, largeur, hauteur);


            }
            if (Route.DictionnaireObstacles.ContainsKey(Orientation.OUEST))
            {

                /*point1 = new Point(x, y + hauteur / 2);
                g.DrawLine(BlackPen, point1, point2);*/

                DessinerSegment(g, Orientation.OUEST, Route.DictionnaireObstacles[Orientation.OUEST], x, y, largeur, hauteur);

            }
        }

        public void DessinerSegment(Graphics g, Orientation orientation, Obstacle obstacle, int x, int y, int largeur, int hauteur)
        {
            Point point2 = new Point(x + hauteur / 2, y + hauteur / 2);
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
                    point1 = new Point(x + largeur / 2, y);
                    g.DrawLine(pen, point1, point2);
                    break;
                case Orientation.EST:
                    point1 = new Point(x + largeur, y + hauteur/ 2);
                    g.DrawLine(pen, point1, point2);
                    break;
                case Orientation.SUD:
                    point1 = new Point(x + largeur / 2, y + hauteur);
                    g.DrawLine(pen, point1, point2);
                    break;
                case Orientation.OUEST:
                    point1 = new Point(x, y + hauteur / 2);
                    g.DrawLine(pen, point1, point2);
                    break;
                default:
                    break;
            }
        }

    }
}
