using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnVoiture
{
    class ToolsBox : Panel
    {
        public List<Way> Ways
        {
            get;
            private set;
        }

        public ToolsBox(List<Way> ways)
        {
            Ways = ways;
        }
    }
}
