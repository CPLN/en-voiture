namespace EnVoiture.Controller
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.alignment = new System.Windows.Forms.TableLayoutPanel();
            this.enVoiturePanel = new EnVoiture.Controller.EnVoiturePanel();
            this.toolsBox = new EnVoiture.Controller.BoiteAOutils();
            this.alignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // alignment
            // 
            this.alignment.ColumnCount = 2;
            this.alignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.alignment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.alignment.Controls.Add(this.enVoiturePanel, 1, 0);
            this.alignment.Controls.Add(this.toolsBox, 0, 0);
            this.alignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alignment.Location = new System.Drawing.Point(0, 0);
            this.alignment.Name = "alignment";
            this.alignment.RowCount = 1;
            this.alignment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.alignment.Size = new System.Drawing.Size(762, 537);
            this.alignment.TabIndex = 0;
            // 
            // enVoiturePanel
            // 
            this.enVoiturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enVoiturePanel.Location = new System.Drawing.Point(183, 3);
            this.enVoiturePanel.Name = "enVoiturePanel";
            this.enVoiturePanel.Size = new System.Drawing.Size(576, 531);
            this.enVoiturePanel.TabIndex = 0;
            this.enVoiturePanel.BoiteAOutils = null;
            this.enVoiturePanel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyDown);
            this.enVoiturePanel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyUp);
            this.enVoiturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnVoitureForm_MouseDown);
            // 
            // toolsBox
            // 
            this.toolsBox.AutoScroll = true;
            this.toolsBox.BackColor = System.Drawing.Color.Silver;
            this.toolsBox.Location = new System.Drawing.Point(0, 0);
            this.toolsBox.Margin = new System.Windows.Forms.Padding(0);
            this.toolsBox.Name = "toolsBox";
            this.toolsBox.Size = new System.Drawing.Size(180, 537);
            this.toolsBox.TabIndex = 1;
            this.toolsBox.Visible = false;
            // 
            // EnVoitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 537);
            this.Controls.Add(this.alignment);
            this.Name = "EnVoitureForm";
            this.Text = "En Voiture !";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnVoitureForm_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnVoitureForm_MouseDown);
            this.alignment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel alignment;
        private EnVoiturePanel enVoiturePanel;
        private BoiteAOutils toolsBox;
    }
}

