using EnVoiture.Modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class Route : ICloneable
    {
        private Dictionary<Orientation, Obstacle> _orientationsRoutes = new Dictionary<Orientation, Obstacle>()
                {
                    { Orientation.NORD, Obstacle.RIEN },
                    { Orientation.EST, Obstacle.RIEN },
                    { Orientation.SUD, Obstacle.RIEN },
                    { Orientation.OUEST, Obstacle.RIEN }
                };

        /// <summary>
        /// Location of the way
        /// </summary>
        public Point Position
        {
            get;
            set;
        }
        
        /// <summary>
        /// Taille de la route
        /// </summary>
        public Size Taille
        {
            get;
            private set;
        }

        /// <summary>
        /// Orientations de la route
        /// </summary>
        public List<Orientation> Orientations
        {
            get;
            private set;
        }

        private Route()
        {

        }

        /// <summary>
        /// Constructeur utilisant un x, y, largeur, hauteur et une liste d'orientations en paramètres
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="orientations"></param>
        public Route(int x, int y, int largeur, int hauteur, List<Orientation> orientations)
            : this()
        {
            this.Position = new Point(x, y);
            this.Taille = new Size(largeur, hauteur);
            this.Orientations = orientations;
            this.Position = new Point(x, y);
        }

        /// <summary>
        /// Constructeur utilsant une localisation, une taille et une liste d'orientations en paramètre
        /// </summary>
        /// <param name="location">Contient x et y</param>
        /// <param name="size">contient Widht et height</param>
        /// <param name="orientations"></param>
        public Route(Point position, Size taille, List<Orientation> orientations)
            : this()
        {
            this.Position = position;
            this.Taille = taille;
            this.Orientations = orientations;
        }

        /// <summary>
        /// Constructeur utilisant une localisation, une taille et un dictionnaire d'orientations et de booléans
        /// </summary>
        /// <param name="location"></param>
        /// <param name="size"></param>
        /// <param name="_orientsWays"></param>
        public Route(Point position, Size taille, Dictionary<Orientation, Obstacle> orientationsRoutes)
        {
            this.Position = position;
            this.Taille = taille;
            this._orientationsRoutes = orientationsRoutes;
        }

        /// <summary>
        /// Get sur Dictionaire d'orientations
        /// <param name="point"></param>
        /// <param name="size"></param>
        /// <param name="orientations"></param>
        /// <summary>
        /// Get sur Dictionaire
        /// </summary>
        public Dictionary<Orientation, Obstacle> DictionnaireObstacles
        {
            get
            {
                return _orientationsRoutes;
            }
            set
            {
                _orientationsRoutes = value;
            }
        }

        /// <summary>
        /// Création de la route qui sera crée dans EnvoitureVoiturePanel ("Drag and Drop") 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Route VersPositionCase(int x, int y, Route way)
        {
            if (way != null)
            {
                way.Position = new Point(x / 100, y / 100);
                return way.Clone() as Route;
            }
            return null;
        }
        /// <summary>
        /// Création de liste de Ways selon les paramètres entrés. Chaque Way fait 25cm2
        /// </summary>
        /// <param name="largeurVille"></param>
        /// <param name="hauteurVille"></param>
        /// <returns>Liste de Ways</returns>
        public static List<Route> Generer(int largeurVille, int hauteurVille)
        {
            int nbWays = largeurVille * hauteurVille;
            List<Route> _routesVille = new List<Route>();

            Random rand = new Random();
            for (int n = 0; n < nbWays; n++)
            {
                    int x = n % largeurVille;
                    int y = n / largeurVille;

                    Obstacle sortieN;
                    Obstacle sortieE;
                    Obstacle sortieS;
                    Obstacle sortieW;
                    int icpt;
                    Dictionary<Orientation, Obstacle> _bList = new Dictionary<Orientation, Obstacle>();
                    do
                    {
                        icpt = 0;
                        int quantiteObstacles = Enum.GetNames(typeof(Obstacle)).Length;
                        sortieN = (Obstacle)rand.Next(quantiteObstacles);
                        sortieE = (Obstacle)rand.Next(quantiteObstacles);
                        sortieS = (Obstacle)rand.Next(quantiteObstacles);
                        sortieW = (Obstacle)rand.Next(quantiteObstacles);

                        if (x != 0)
                        {
                            sortieW = _routesVille[n-1]._orientationsRoutes[Orientation.EST];
                        }

                        if (y != 0)
                        {
                            sortieN = _routesVille[n - largeurVille]._orientationsRoutes[Orientation.SUD];
                        }

                        //if (sortieE)
                        //{
                        //    icpt++;
                        //}
                        //if (sortieN)
                        //{
                        //    icpt++;
                        //}
                        //if (sortieS)
                        //{
                        //    icpt++;
                        //}
                        //if (sortieW)
                        //{
                        //    icpt++;
                        //}
                        if (sortieE != Obstacle.RIEN)
                        {
                            icpt++;
                        }
                        if (sortieN != Obstacle.RIEN)
                        {
                            icpt++;
                        }
                        if (sortieS != Obstacle.RIEN)
                        {
                            icpt++;
                        }
                        if (sortieW != Obstacle.RIEN)
                        {
                            icpt++;
                        }
                        
                    } while (icpt < 2);
                    _bList.Add(Orientation.NORD, sortieN);
                    _bList.Add(Orientation.EST, sortieE);
                    _bList.Add(Orientation.SUD, sortieS);
                    _bList.Add(Orientation.OUEST, sortieW);

                    _routesVille.Add(new Route(new Point(x, y), new Size(1, 1), _bList));
            }
            return _routesVille;
        }

        internal static Route VersPositionCase(int p1, int p2, Vue.GenerateurWidget generateurWidget)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            Route clone = new Route();
            clone.Position = new Point(this.Position.X, this.Position.Y);
            clone.Taille = new Size(this.Taille.Width, this.Taille.Height);
            clone.DictionnaireObstacles = new Dictionary<Orientation, Obstacle>();
            foreach (Orientation orientation in this.DictionnaireObstacles.Keys)
            {
                clone.DictionnaireObstacles.Add(orientation, this.DictionnaireObstacles[orientation]);
            }
            return clone;
        }
    }
}
