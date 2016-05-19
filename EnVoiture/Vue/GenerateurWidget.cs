using EnVoiture.Modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnVoiture.Vue
{
   
  public class GenerateurWidget
    {
        const int HAUTEUR = 200;
        const int LARGEUR = 200;
        const int MARGEX = 20;
        const int MARGEY = 20;

        public Generateur Generateur { get; set; }

        public RouteWidget RouteWidget { get; set; }
        public GenerateurWidget(Route r)
        {
            //Route r = new Route(0,0, 1,1, new List<Orientation>());
            RouteWidget = new RouteWidget(r);
            Generateur = new Generateur(r);
        }
        public GenerateurWidget()
        {
            Route r = new Route(0,0, 1,1, new List<Orientation>());
            RouteWidget = new RouteWidget(r);
            Generateur = new Generateur(r);
        }


        /// <summary>
        /// Cette fonction reçoit en paramètre un point et permet de le transformer en orientation.
        /// </summary>
        /// <param name="point"></param>
        public Orientation DetectionOrientation(Point point)
        {
            //fonctionne que pour le NORTH et le WEST
            int posGauche = point.X - MARGEX;
            int posHaut = point.Y - MARGEY;
            int posDroite = (LARGEUR+MARGEX)-(point.X+MARGEX);
            int posBas = (HAUTEUR+MARGEY)-(point.Y+MARGEY);
            int minX = Math.Min(posGauche, posDroite);
            int minY = Math.Min(posBas, posHaut);
            int min = Math.Min(minX, minY);
            if (min == posGauche)
            {
                return Orientation.WEST;
            }
            else
            {
                if (min == posDroite)
                {
                    return Orientation.EAST;
                }
                else
                {
                    if (min == posHaut)
                    {
                        return Orientation.NORTH;
                    }
                    else
                    {
                        return Orientation.SOUTH;
                    }
                }
            }
        }

        public void DessinerSurOrigine(Graphics g)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(MARGEX, MARGEY, HAUTEUR, LARGEUR));
        }

        public bool Detectcontenu(Point point) 
        {
            if (point.X < MARGEX + LARGEUR && point.X > MARGEX && point.Y < MARGEY + HAUTEUR && point.Y > MARGEY)
            {
                return true;
            }

            return false;
        }
 

    }
}
