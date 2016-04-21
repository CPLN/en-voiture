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

        public List<Orientation> Orientations
        {
            get;
            private set;
        }
        public Way(List<Orientation> orientations)
        {
            this.Orientations = orientations;
        }

        public bool canGo(Orientation orientation)
        {
            bool can = false;
            if (Orientations.Contains(orientation))
            {
                can = true;
            }
            return can;
        }
    }
}
