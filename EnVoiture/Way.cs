using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    class Way
    {
        public Point Location
        {
            get;
            private set;
        }

        public Size Size
        {
            get;
            private set;
        }

        public List<Orientation> Orientations
        {
            get;
            private set;
        }
        public Way(int x, int y, int width, int height, List<Orientation> orientations)
        {
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);
            this.Orientations = orientations;
        }

        public Way(Point location, Size size, List<Orientation> orientations)
        {
            this.Location = location;
            this.Size = size;
            this.Orientations = orientations;
        }

        public bool canGo(Orientation orientation)
        {
            return Orientations.Contains(orientation);
        }
    }
}
