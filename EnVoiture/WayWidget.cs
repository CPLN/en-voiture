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
        private Way Way;
        public WayWidget(Way w)
        {
            Way = w;
        }
        public void Paint(Graphics g)
        {
            Way.Left = Way.Location.X * 100;
            Way.Top = Way.Location.Y * 100;
            Way.TailleX = 100;
            Way.TailleY = 100;
            if (Way.Location.X < 0 || Way.Location.X >= g.VisibleClipBounds.Width)
            {
                return;
            }
            if (Way.Location.Y < 0 || Way.Location.Y >= g.VisibleClipBounds.Height)
            {
                return;
            }
            g.FillRectangle(Brushes.Gray, Way.Location.X, Way.Location.Y, Way.Size.Width, Way.Size.Height);
            Pen BlackPen = new Pen(Color.Black, 20);
            Point point2 = new Point(Way.Location.X + Way.Size.Width / 2, Way.Location.Y + Way.Size.Height / 2);
            Point point1;
            if (Way.GetDictionaire.ContainsKey(Orientation.NORTH) && Way.GetDictionaire[Orientation.NORTH])
            {
                point1 = new Point(Way.Location.X + Way.Size.Width / 2, Way.Location.X);
                g.DrawLine(BlackPen, point1, point2);

            }
            if (Way.GetDictionaire.ContainsKey(Orientation.SOUTH) && Way.GetDictionaire[Orientation.SOUTH])
            {
                point1 = new Point(Way.Location.X + Way.Size.Width / 2, Way.Location.Y + Way.Size.Height);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (Way.GetDictionaire.ContainsKey(Orientation.EAST) && Way.GetDictionaire[Orientation.EAST])
            {
                point1 = new Point(Way.Location.X, Way.Location.Y + Way.Size.Height / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
            if (Way.GetDictionaire.ContainsKey(Orientation.WEST) && Way.GetDictionaire[Orientation.WEST])
            {
                point1 = new Point(Way.Location.X + Way.Size.Width, Way.Location.Y + Way.Size.Height / 2);
                g.DrawLine(BlackPen, point1, point2);
            }
        }
    }
}
