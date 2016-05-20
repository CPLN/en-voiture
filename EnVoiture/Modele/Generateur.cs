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
        /// <summary>
        /// Cette fonction permet de changer l'état de l'orientation
        /// </summary>
        /// <param name="orientation"> Orientation de la route</param>
        public void EditionRoute(Orientation orientation)
        {
            //test si le dictonnaire contient une clef
            if (Route.GetDictionaire.ContainsKey(orientation))
            {
                obstacle = Route.GetDictionaire[orientation];
            }

            //Change l'état de l'obstacle de false à true et vice-versa.
            switch (obstacle)
            {
                case Obstacle.RIEN:
                    Route.GetDictionaire[orientation] = Obstacle.ROUTE;
                    break;
                case Obstacle.ROUTE:
                    Route.GetDictionaire[orientation] = Obstacle.ROUTETROTTOIR;
                    break;
                case Obstacle.ROUTETROTTOIR:
                    Route.GetDictionaire[orientation] = Obstacle.RIEN;
                    break;
                default:
                    break;
            }
        }
    }
}
