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
        private TableLayoutPanel tableLayoutPanel;
        private int _waysSize = 100;

        public List<WayWidget> WayWidgets
        {
            get
            {
                List<WayWidget> ww = new List<WayWidget>();
                ww.Add(new WayWidget(new Way(20, 100, _waysSize, _waysSize, new List<Orientation>() { Orientation.NORTH, Orientation.SOUTH })));
                ww.Add(new WayWidget(new Way(20, 300, _waysSize, _waysSize, new List<Orientation>() { Orientation.EAST, Orientation.SOUTH })));
                ww.Add(new WayWidget(new Way(20, 300, _waysSize, _waysSize, new List<Orientation>() { Orientation.EAST, Orientation.SOUTH })));
                return ww;
            }
        }

        public ToolsBox()
        {
            InitializeComponent();

            foreach (WayWidget w in WayWidgets)
            {
                Panel panel = new Panel();
                panel.Paint += new PaintEventHandler((source, e) => { w.PaintOnOrigin(e.Graphics); });
                panel.Size = w.Way.Size;
                tableLayoutPanel.Controls.Add(panel);
            }
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel1";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(52, 194);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // ToolsBox
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ToolsBox";
            this.Size = new System.Drawing.Size(311, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

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
