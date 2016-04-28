using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class WayWidget : RoadUserWidget
    {
        private Way _way;

        public Way Way
        {
            get
            {
                return _way;
            }
        }

        public WayWidget(Way way)
        {
            this._way = way;
        }

        public override void Paint(Graphics g)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(_way.Location, _way.Size));
        }
    }
}
