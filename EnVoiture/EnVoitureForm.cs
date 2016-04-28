using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EnVoiture
{
    /// <summary>
    /// Classe principale du projet.
    /// </summary>
    public partial class EnVoitureForm : Form
    {
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public EnVoitureForm()
        {
            InitializeComponent();
        }

        private void EnVoitureForm_KeyDown(object sender, KeyEventArgs e)
        {
            enVoiturePanel.OnKeyDown(sender, e);
        }

        private void EnVoitureForm_KeyUp(object sender, KeyEventArgs e)
        {
            enVoiturePanel.OnKeyUp(sender, e);
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            enVoiturePanel.Tick(sender, e);
        }

        private void EnVoitureForm_MouseDown(object sender, MouseEventArgs e)
        {
            enVoiturePanel.OnMouseDown(sender, e);
        }
    }
}
