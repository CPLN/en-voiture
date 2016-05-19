﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    class PietonWidget : RoadUserWidget
    {
        public Pieton Pieton { get; private set; }

        public PietonWidget(Rectangle rectangle, float v, float vmax)
        {
            this.Pieton = new Pieton(rectangle,v,vmax);
        }

        public PietonWidget(int x, int y, int width, int height, float v, float vmax)
        {
            this.Pieton = new Pieton(x, y, width, height, 15, 30);
        }
        public override void Dessiner(Graphics g)
        {
            g.FillEllipse(Brushes.Black, Pieton.Bounds);
        }
        
    }
}
