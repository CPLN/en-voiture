using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnVoiture
{
    class ToolsBox : UserControl
    {
        private int _waysSize = 100;

        public List<WayWidget> WayWidgets
        {
            get
            {
                List<WayWidget> ww = new List<WayWidget>();
                ww.Add(new WayWidget(new Way(20, 100, _waysSize, _waysSize, new List<Orientation>() { Orientation.NORTH, Orientation.SOUTH })));
                ww.Add(new WayWidget(new Way(20, 300, _waysSize, _waysSize, new List<Orientation>() { Orientation.EAST, Orientation.SOUTH })));
                return ww;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ToolsBox
            // 
            this.Name = "ToolsBox";
            this.Size = new System.Drawing.Size(122, 150);
            this.ResumeLayout(false);
        }

        /*
        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragAndDropSource = sender as WayWidget;
                Invalidate();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dragAndDropSource != null)
            {
                Way thenewway = new Way(20, 100, _waysSize, _waysSize, new List<Orientation>() { Orientation.NORTH, Orientation.SOUTH });
                thenewway.Size.Width = e.X - thenewway.Size.Width;
                thenewway.Size.Height = e.Y - thenewway.Size.Height;
                thenewway.X = e.X - thenewway.X;
                thenewway.Y = e.Y - thenewway.Y;
                Invalidate();
                dragAndDropSource = null;
            }
        }
*/
    }
}
