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
        private Point point;
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
            Random rand = new Random();
            int nbWays = largeurVille * hauteurVille;
            List<Way> _waysVille = new List<Way>();

            for (int n = 0; n < nbWays; n++)
            {
                    int x = n % largeurVille;
                    int y = n / largeurVille;

                    Dictionary<Orientation, bool> _orientsWays = new Dictionary<Orientation, bool>();

                    if (n == 0)
                    {
                        bool sortieN = rand.Next(2) == 0;
                        bool sortieE = rand.Next(2) == 0;
                        bool sortieS = rand.Next(2) == 0;
                        bool sortieW = rand.Next(2) == 0;
                        _orientsWays.Add(Orientation.NORTH, sortieN);
                        _orientsWays.Add(Orientation.EAST, sortieE);
                        _orientsWays.Add(Orientation.SOUTH, sortieS);
                        _orientsWays.Add(Orientation.WEST, sortieW);
                    }
                    else if (y == 0)
                    {
                        bool sortieE = rand.Next(2) == 0;
                        bool sortieN = rand.Next(2) == 0;
                        bool sortieS = rand.Next(2) == 0;
                        bool sortieW = _waysVille[n - 1]._orientsWays[Orientation.EAST] == true;
                        _orientsWays.Add(Orientation.NORTH, sortieN);
                        _orientsWays.Add(Orientation.EAST, sortieE);
                        _orientsWays.Add(Orientation.SOUTH, sortieS);
                        _orientsWays.Add(Orientation.WEST, sortieW);
                    }
                    else
                    {
                            
                    }
                    _waysVille.Add(new Way(new Point(x, y), new Size(1, 1), _orientsWays));
            }
            return _waysVille;
        }

        public void Paint(Graphics g)
        {
            if (Location.X < 0 || Location.X >= g.VisibleClipBounds.Width)
            {
                return;
            }
            if (Location.Y < 0 || Location.Y >= g.VisibleClipBounds.Height)
            {
                return;
            }
            g.FillRectangle(Brushes.Gray, 100*Location.X, 100*Location.Y, Size.Width, Size.Height);
            Pen BlackPen = new Pen(Color.Black, 20);
            Point point2 = new Point(Location.X + Size.Width / 2, Location.Y + Size.Height / 2);
            Point point1;
            if (GetDictionaire.ContainsKey(Orientation.NORTH) && GetDictionaire[Orientation.NORTH])
            {
                point1 = new Point(Location.X + Size.Width / 2, Location.X);
                g.DrawLine(BlackPen, point1, point2);

            }
            if (GetDictionaire.ContainsKey(Orientation.SOUTH) && GetDictionaire[Orientation.SOUTH])
            {
                point1 = new Point(Location.X + Size.Width / 2, Location.Y + Size.Height);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (GetDictionaire.ContainsKey(Orientation.EAST) && GetDictionaire[Orientation.EAST])
            {
                point1 = new Point(Location.X, Location.Y + Size.Height / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (GetDictionaire.ContainsKey(Orientation.WEST) && GetDictionaire[Orientation.WEST])
            {
                point1 = new Point(Location.X + Size.Width, Location.Y + Size.Height / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
        }
    }
}
