using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture.Modele
{
    class Generateur
    {
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
            
            /*switch ()
            {
                case Obstacle.ROUTE : 
            break;
                case Obstacle.PASROUTE :
                    break;
                default:
                    break;
            }*/
        }
    }

    public enum Obstacle
    {
        ROUTE, PASROUTE
    }
}
