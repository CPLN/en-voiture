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
        public override void Paint(Graphics g)
        {
            g.FillEllipse(Brushes.Azure);
        }
        private pieton p1;

        public Pieton Pieton { get; private set; }

        public PietonWidget(int x,int y,int width, int height)
        {
            this.pieton = new Pieton(x, y, width, height);
        }

    }
}
