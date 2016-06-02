using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnVoiture.Modele
{
    public class Generateur
    {
        private Obstacle obstacle;

        public Route Route { get; set; }

        public Generateur(Route route)
        {
            this.Route = route;
        }
        
        public Generateur()
        {
            this.Route = new Route(0,0,1,1,new List<Orientation>());
        }
        
        /// <summary>
        /// Cette fonction permet de changer l'état de l'orientation
        /// </summary>
        /// <param name="orientation"> Orientation de la route</param>
        public void EditionRoute(Orientation orientation)
        {
            //test si le dictonnaire contient une clef
            if (Route.DictionnaireObstacles.ContainsKey(orientation))
            {
                obstacle = Route.DictionnaireObstacles[orientation];
            }

            //Change l'état de l'obstacle de false à true et vice-versa.
            Dictionary<Orientation, Obstacle> dico = Route.DictionnaireObstacles;
            switch (obstacle)
            {
                case Obstacle.RIEN:
                    dico[orientation] = Obstacle.ROUTE;
                    break;
                case Obstacle.ROUTE:
                    dico[orientation] = Obstacle.ROUTETROTTOIR;
                    break;
                case Obstacle.ROUTETROTTOIR:
                    dico[orientation] = Obstacle.RIEN;
                    break;
                default:
                    break;
            }
            Route.DictionnaireObstacles = dico;
        }
    }
}
