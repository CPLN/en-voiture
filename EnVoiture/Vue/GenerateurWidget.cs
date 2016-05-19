using EnVoiture.Modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture.Vue
{
   
    class GenerateurWidget
    {
        const int HAUTEUR = 200;
        const int LARGEUR = 200;

        public Generateur Generateur { get; set; }

        public RouteWidget RouteWidget { get; set; }
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
            throw new NotImplementedException();
        }

        
    }
}
