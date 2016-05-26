using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class Pieton : RoadUser
    {
        /// <summary>
        /// Constructeur Pieton 
        /// </summary>
        /// <param name="x">Position X</param>
        /// <param name="y">Position Y</param>
        /// <param name="x1">Hauteur</param>
        /// <param name="y1">Largeur</param>
        /// <param name="v">Vitesse de Base</param>
        /// <param name="vMax">Vitesse Max</param>
        public Pieton(int x, int y, int width, int height, float v, float vMax)
            : base(x,y,width,height,v,vMax)
        {
            
        }
        public Pieton(Rectangle rectangle, float v, float vMax)
           :base(rectangle,v,vMax)
        {

        }
    }
}

