using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture.Modele
{
    public class Generateur
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
            bool obstacle = false;

            //test si le dictonnaire contient une clef
            if (Route.GetDictionaire.ContainsKey(orientation))
            {
                obstacle = Route.GetDictionaire[orientation];
            }

            //Change l'état de l'obstacle de false à true et vice-versa.
            switch (obstacle)
            {
                case true:
                    Route.GetDictionaire[orientation] = false;
                    break;
                case false:
                    Route.GetDictionaire[orientation] = true;
                    break;
                default:
                    break;
            }
        }
    }
}
