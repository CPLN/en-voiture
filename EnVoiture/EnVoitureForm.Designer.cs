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
            this.pToolsBox = new System.Windows.Forms.Panel();
            this.pLevelDesigner = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pToolsBox
            // 
            this.pToolsBox.Location = new System.Drawing.Point(0, 0);
            this.pToolsBox.Name = "pToolsBox";
            this.pToolsBox.Size = new System.Drawing.Size(200, 540);
            this.pToolsBox.TabIndex = 0;
            // 
            // pLevelDesigner
            // 
            this.pLevelDesigner.Location = new System.Drawing.Point(200, 0);
            this.pLevelDesigner.Name = "pLevelDesigner";
            this.pLevelDesigner.Size = new System.Drawing.Size(585, 540);
            this.pLevelDesigner.TabIndex = 1;
            // 
            // EnVoitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.pLevelDesigner);
            this.Controls.Add(this.pToolsBox);
            this.Name = "EnVoitureForm";
            this.Text = "En Voiture !";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EnVoiture_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pToolsBox;
        private System.Windows.Forms.Panel pLevelDesigner;
    }
}

