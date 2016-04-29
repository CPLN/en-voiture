using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnVoiture
{
    class ToolsBox
    {
        public List<WayWidget> WayWidgets
        {
            get;
            private set;
        }

        public ToolsBox(List<WayWidget> wayWidgets)
        {
            WayWidgets = wayWidgets;
        }
    }
}
