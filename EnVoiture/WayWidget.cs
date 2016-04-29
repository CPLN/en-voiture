using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnVoiture
{
    class WayWidget
    {
        public static int SIZE = 100;
        public Way Way { get; set; }

        public WayWidget(Way w)
        {
            Way = w;
        }
        public void Paint(Graphics g)
        {
            int Left = Way.Location.X * SIZE;
            int Top = Way.Location.Y * SIZE;
            int TailleX = Way.Size.Width * SIZE;
            int TailleY = Way.Size.Height * SIZE;

            g.FillRectangle(Brushes.Gray, Left, Top,TailleX, TailleY);
            Pen BlackPen = new Pen(Color.Black, 20);
            Point point2 = new Point(Left + TailleY / 2, Top + TailleY / 2);
            Point point1;
            if (Way.GetDictionaire.ContainsKey(Orientation.NORTH) && Way.GetDictionaire[Orientation.NORTH])
            {
                point1 = new Point(Left + TailleX / 2,Top);
                g.DrawLine(BlackPen, point1, point2);

            }
            if (Way.GetDictionaire.ContainsKey(Orientation.SOUTH) && Way.GetDictionaire[Orientation.SOUTH])
            {
                point1 = new Point(Left + TailleX / 2, Top + TailleY);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (Way.GetDictionaire.ContainsKey(Orientation.EAST) && Way.GetDictionaire[Orientation.EAST])
            {
                point1 = new Point(Left + TailleX, Top + TailleY / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (Way.GetDictionaire.ContainsKey(Orientation.WEST) && Way.GetDictionaire[Orientation.WEST])
            {
                point1 = new Point(Left, Top + TailleY / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
        }
    }
}
