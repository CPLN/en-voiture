using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace EnVoiture.Vue
{
    public abstract class UsagerWidget
    {
        /// <summary>
        /// Permet de dessiner l'usager sur un context graphic.
        /// </summary>
        /// <param name="g">L'endroit où dessiner l'usager</param>
        public abstract void Dessiner(Graphics g);
    }
}
