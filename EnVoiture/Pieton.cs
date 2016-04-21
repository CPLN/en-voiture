using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    class Pieton : RoadUser
    {
        
        public Pieton(int x, int y, int x1, int y1, double v, double vMax)
            : base(x,y,x1,y1,v,vMax)
        {
            
        }
       
    }
}

