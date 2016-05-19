using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class Route
    {
        private Dictionary<Orientation, bool> _orientationsRoutes;

        /// <summary>
        /// Location of the way
        /// </summary>
        public Point Position
        {
            get;
            set;
        }

        public int Left
        {
            get
            {
                return Position.X;
            }
            set
            {
                Position = new Point(value, Position.Y);
            }
        }
        public int Top
        {
            get
            {
                return Position.Y;
            }
            set
            {
                Position = new Point(Position.X, value);
            }
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

        /// <summary>
        /// Constructeur utilisant un x, y, largeur, hauteur et une liste d'orientations en paramètres
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="orientations"></param>
        public Route(int x, int y, int largeur, int hauteur, List<Orientation> orientations)
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
        public Route(Point position, Size taille, Dictionary<Orientation, bool> orientationsRoutes)
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
        public Dictionary<Orientation, bool> GetDictionaire
        {
            get
            {
                return _orientationsRoutes == null ? new Dictionary<Orientation, bool>() : _orientationsRoutes;
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
                return way.MemberwiseClone() as Route;
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

                    bool sortieN;
                    bool sortieE;
                    bool sortieS;
                    bool sortieW;
                    int icpt;
                    Dictionary<Orientation, bool> _bList = new Dictionary<Orientation, bool>();
                    do
                    {
                        icpt = 0;
                        sortieN = rand.Next(2) == 0;
                        sortieE = rand.Next(2) == 0;
                        sortieS = rand.Next(2) == 0;
                        sortieW = rand.Next(2) == 0;

                        if (x != 0)
                        {
                            sortieW = _routesVille[n-1]._orientationsRoutes[Orientation.EAST];
                        }

                        if (y != 0)
                        {
                            sortieN = _routesVille[n - largeurVille]._orientationsRoutes[Orientation.SOUTH];
                        }

                        if (sortieE)
                        {
                            icpt++;
                        }
                        if (sortieN)
                        {
                            icpt++;
                        }
                        if (sortieS)
                        {
                            icpt++;
                        }
                        if (sortieW)
                        {
                            icpt++;
                        }

                    } while (icpt < 2);
                    _bList.Add(Orientation.NORTH, sortieN);
                    _bList.Add(Orientation.EAST, sortieE);
                    _bList.Add(Orientation.SOUTH, sortieS);
                    _bList.Add(Orientation.WEST, sortieW);

                    _routesVille.Add(new Route(new Point(x, y), new Size(1, 1), _bList));
            }
            return _routesVille;
        }
    }
}
