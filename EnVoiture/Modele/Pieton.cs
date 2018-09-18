using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture.Modele
{
    public class Pieton : Usager
    {
        /// <summary>
        /// Constructeur Pieton 
        /// </summary>
        /// <param name="x">Position X</param>
        /// <param name="y">Position Y</param>
        /// <param name="largeur">Hauteur</param>
        /// <param name="hauteur">Largeur</param>
        /// <param name="v">Vitesse de Base</param>
        /// <param name="vMax">Vitesse Max</param>
        public Pieton(int x, int y, int largeur, int hauteur, float v, float vMax)
            : base(x, y, largeur, hauteur, v, vMax)
        {
            
        }
        public Pieton(Rectangle rectangle, float v, float vMax)
           :base(rectangle, v, vMax)
        {

        }
    }
}

