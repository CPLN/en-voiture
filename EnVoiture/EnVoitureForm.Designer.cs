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
            this.lblToolsBox = new System.Windows.Forms.Label();
            this.pToolsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pToolsBox
            // 
            this.pToolsBox.Controls.Add(this.lblToolsBox);
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
            // lblToolsBox
            // 
            this.lblToolsBox.AutoSize = true;
            this.lblToolsBox.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolsBox.Location = new System.Drawing.Point(12, 9);
            this.lblToolsBox.Name = "lblToolsBox";
            this.lblToolsBox.Size = new System.Drawing.Size(109, 24);
            this.lblToolsBox.TabIndex = 0;
            this.lblToolsBox.Text = "Boîte à outils";
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
            this.pToolsBox.ResumeLayout(false);
            this.pToolsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pToolsBox;
        private System.Windows.Forms.Panel pLevelDesigner;
        private System.Windows.Forms.Label lblToolsBox;
    }
}

