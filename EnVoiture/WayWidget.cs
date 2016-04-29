using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    public class WayWidget
    {
        public Way Way { get; set; }

        public WayWidget(Way way)
        {
            this.Way = way;
        }

        public void Paint(Graphics g)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(Way.Left * 100, Way.Top * 100, 100, 100));
        }

        public void PaintOnOrigin(Graphics g)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 100, 100));
        }
    }
}
