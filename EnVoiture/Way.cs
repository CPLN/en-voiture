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
            WaysGenerator(3, 3);
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
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="size"></param>
        /// <param name="orientations"></param>
        /// <summary>
        /// Get sur Dictionaire
        /// </summary>
        public Dictionary<Orientation, bool> GetDictionaire { get { return _orientsWays; }}

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
            Dictionary<Orientation, bool> _orientsWays = new Dictionary<Orientation,bool>();
            for (int i = 1; i <= largeurVille; i++)
			{
                for (int j = 0; j < hauteurVille; j++)
                {
                _waysVille.Add(new Way(new Point(25*j, 25*i), new Size(25, 25), _orientsWays));
                }
			}
            return _waysVille;
        }

        public  void Paint(Graphics g)
        {
            g.FillRectangle(Brushes.Gray,Location.X, Location.Y, Size.Width, Size.Height);
        }
    }
}
