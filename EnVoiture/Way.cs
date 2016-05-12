using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class Way
    {
        private Dictionary<Orientation, bool> _orientsWays;

        /// <summary>
        /// Location of the way
        /// </summary>
        public Point Location
        {
            get;
            private set;
        }

        public int Left
        {
            get
            {
                return Location.X;
            }
            set
            {
                Location = new Point(value, Location.Y);
            }
        }
        public int Top
        {
            get
            {
                return Location.Y;
            }
            set
            {
                Location = new Point(Location.X, value);
            }
        }
        
        /// <summary>
        /// Size of the way
        /// </summary>
        public Size Size
        {
            get;
            private set;
        }

        public int TailleX
        {
            get
            {
                return Size.Width;
            }
            set
            {
                Size = new Size(value, Size.Height);
            }

        }
        public int TailleY
        {
            get
            {
                return Size.Height;
            }
            set
            {
                Size = new Size(Size.Width, value);
            }
        }

        /// <summary>
        /// Orientations of the way
        /// </summary>
        public List<Orientation> Orientations
        {
            get;
            private set;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="orientations"></param>
        public Way(int x, int y, int width, int height, List<Orientation> orientations)
        {
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);
            this.Orientations = orientations;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="location"></param>
        /// <param name="size"></param>
        /// <param name="orientations"></param>
        public Way(Point location, Size size, List<Orientation> orientations)
        {
            this.Location = location;
            this.Size = size;
            this.Orientations = orientations;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="location"></param>
        /// <param name="size"></param>
        /// <param name="_orientsWays"></param>
        public Way(Point location, Size size, Dictionary<Orientation, bool> _orientsWays)
        {
            this.Location = location;
            this.Size = size;
            this._orientsWays = _orientsWays;
        }

        /// <summary>
        /// Get sur Dictionaire d'orientations
        /// <param name="point"></param>
        /// <param name="size"></param>
        /// <param name="orientations"></param>
        /// <summary>
        /// Get sur Dictionaire
        /// </summary>
        public Dictionary<Orientation, bool> GetDictionaire { get { return _orientsWays; } }

        /// <summary>
        /// Création de liste de Ways selon les paramètres entrés. Chaque Way fait 25cm2
        /// </summary>
        /// <param name="largeurVille"></param>
        /// <param name="hauteurVille"></param>
        /// <returns>Liste de Ways</returns>
        public static List<Way> WaysGenerator(int largeurVille, int hauteurVille)
        {
            
            int nbWays = largeurVille * hauteurVille;
            List<Way> _waysVille = new List<Way>();

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
                            sortieW = _waysVille[n-1]._orientsWays[Orientation.EAST];
                        }

                        if (y != 0)
                        {
                            sortieN = _waysVille[n - largeurVille]._orientsWays[Orientation.SOUTH];
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

                    _waysVille.Add(new Way(new Point(x, y), new Size(1, 1), _bList));
            }
            return _waysVille;
        }
    }
}
