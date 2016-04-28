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
            this.pEnVoiture = new System.Windows.Forms.Panel();
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
            this.tlpEnVoiture.AutoSize = true;
            this.tlpEnVoiture.BackColor = System.Drawing.SystemColors.GrayText;
            this.tlpEnVoiture.ColumnCount = 2;
            this.tlpEnVoiture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEnVoiture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEnVoiture.Controls.Add(this.pEnVoiture, 1, 0);
            this.tlpEnVoiture.Controls.Add(this.pToolsBox, 0, 0);
            this.tlpEnVoiture.Location = new System.Drawing.Point(12, 12);
            this.tlpEnVoiture.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEnVoiture.Name = "tlpEnVoiture";
            this.tlpEnVoiture.RowCount = 1;
            this.tlpEnVoiture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEnVoiture.Size = new System.Drawing.Size(760, 513);
            this.tlpEnVoiture.TabIndex = 0;
            // 
            // pEnVoiture
            // 
            this.pEnVoiture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pEnVoiture.BackColor = System.Drawing.Color.DimGray;
            this.pEnVoiture.Location = new System.Drawing.Point(226, 0);
            this.pEnVoiture.Margin = new System.Windows.Forms.Padding(0);
            this.pEnVoiture.Name = "pEnVoiture";
            this.pEnVoiture.Size = new System.Drawing.Size(534, 513);
            this.pEnVoiture.TabIndex = 0;
            this.pEnVoiture.Paint += new System.Windows.Forms.PaintEventHandler(this.pEnVoiture_Paint);
            // 
            // pToolsBox
            // 
            this.pToolsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pToolsBox.BackColor = System.Drawing.Color.Green;
            this.pToolsBox.Location = new System.Drawing.Point(0, 0);
            this.pToolsBox.Margin = new System.Windows.Forms.Padding(0);
            this.pToolsBox.Name = "pToolsBox";
            this.pToolsBox.Size = new System.Drawing.Size(226, 513);
            this.pToolsBox.TabIndex = 1;
            this.pToolsBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pToolsBox_MouseDown);
            // 
            // EnVoitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.tlpEnVoiture);
            this.Name = "EnVoitureForm";
            this.Text = "En Voiture !";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyUp);
            this.tlpEnVoiture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerDirection;
        private System.Windows.Forms.TableLayoutPanel tlpEnVoiture;
        private System.Windows.Forms.Panel pEnVoiture;
        private System.Windows.Forms.Panel pToolsBox;
    }
}

