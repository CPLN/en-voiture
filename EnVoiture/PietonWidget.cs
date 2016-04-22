using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    class PietonWidget : RoadUserWidget
    {

        private Pieton p1;

        public Pieton Pieton { get; private set; }

        public PietonWidget(Rectangle rectangle)
        {
            this.Pieton = new Pieton(rectangle,0.0,100.0);
        }

        public PietonWidget(int x,int y,int width, int height, double v, double vmax)
        {
            this.Pieton = new Pieton(x, y, width, height, 15, 30);
        }
        public override void Paint(Graphics g)
        {
            g.FillEllipse(Brushes.Azure, Pieton.Bounds);
        }
    }
}
