namespace EnVoiture
{
    partial class EnVoitureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerDirection = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerDirection
            // 
            this.timerDirection.Enabled = true;
            this.timerDirection.Interval = 10;
            this.timerDirection.Tick += new System.EventHandler(this.timerDirection_Tick);
            // 
            // EnVoitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 537);
            this.Name = "EnVoitureForm";
            this.Text = "En Voiture !";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EnVoiture_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnVoitureForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerDirection;
    }
}

