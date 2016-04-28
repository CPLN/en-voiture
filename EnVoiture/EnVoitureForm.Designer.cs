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
            this.tlpEnVoiture = new System.Windows.Forms.TableLayoutPanel();
            this.pEditor = new System.Windows.Forms.Panel();
            this.pToolsBox = new System.Windows.Forms.Panel();
            this.tlpEnVoiture.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerDirection
            // 
            this.timerDirection.Enabled = true;
            this.timerDirection.Interval = 10;
            this.timerDirection.Tick += new System.EventHandler(this.timerDirection_Tick);
            // 
            // tlpEnVoiture
            // 
            this.tlpEnVoiture.ColumnCount = 2;
            this.tlpEnVoiture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.56266F));
            this.tlpEnVoiture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.43734F));
            this.tlpEnVoiture.Controls.Add(this.pEditor, 1, 0);
            this.tlpEnVoiture.Controls.Add(this.pToolsBox, 0, 0);
            this.tlpEnVoiture.Location = new System.Drawing.Point(12, 12);
            this.tlpEnVoiture.Name = "tlpEnVoiture";
            this.tlpEnVoiture.RowCount = 1;
            this.tlpEnVoiture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.07407F));
            this.tlpEnVoiture.Size = new System.Drawing.Size(760, 513);
            this.tlpEnVoiture.TabIndex = 0;
            // 
            // pEditor
            // 
            this.pEditor.Location = new System.Drawing.Point(235, 3);
            this.pEditor.Name = "pEditor";
            this.pEditor.Size = new System.Drawing.Size(522, 507);
            this.pEditor.TabIndex = 0;
            // 
            // pToolsBox
            // 
            this.pToolsBox.Location = new System.Drawing.Point(3, 3);
            this.pToolsBox.Name = "pToolsBox";
            this.pToolsBox.Size = new System.Drawing.Size(226, 507);
            this.pToolsBox.TabIndex = 1;
            // 
            // EnVoitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.tlpEnVoiture);
            this.Name = "EnVoitureForm";
            this.Text = "En Voiture !";
            this.Load += new System.EventHandler(this.EnVoitureForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EnVoiture_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyUp);
            this.tlpEnVoiture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerDirection;
        private System.Windows.Forms.TableLayoutPanel tlpEnVoiture;
        private System.Windows.Forms.Panel pEditor;
        private System.Windows.Forms.Panel pToolsBox;
    }
}

