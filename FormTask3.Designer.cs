namespace CS332_Lab2
{
    partial class FormTask3
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBarH = new System.Windows.Forms.TrackBar();
            this.trackBarS = new System.Windows.Forms.TrackBar();
            this.trackBarV = new System.Windows.Forms.TrackBar();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(304, 50);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(747, 489);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // trackBarH
            // 
            this.trackBarH.Location = new System.Drawing.Point(16, 139);
            this.trackBarH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarH.Maximum = 360;
            this.trackBarH.Name = "trackBarH";
            this.trackBarH.Size = new System.Drawing.Size(279, 56);
            this.trackBarH.TabIndex = 1;
            this.trackBarH.TickFrequency = 60;
            this.trackBarH.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarS
            // 
            this.trackBarS.Location = new System.Drawing.Point(16, 202);
            this.trackBarS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarS.Maximum = 100;
            this.trackBarS.Minimum = -100;
            this.trackBarS.Name = "trackBarS";
            this.trackBarS.Size = new System.Drawing.Size(279, 56);
            this.trackBarS.TabIndex = 2;
            this.trackBarS.TickFrequency = 10;
            this.trackBarS.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // trackBarV
            // 
            this.trackBarV.Location = new System.Drawing.Point(16, 265);
            this.trackBarV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarV.Maximum = 100;
            this.trackBarV.Minimum = -100;
            this.trackBarV.Name = "trackBarV";
            this.trackBarV.Size = new System.Drawing.Size(279, 56);
            this.trackBarV.TabIndex = 3;
            this.trackBarV.TickFrequency = 10;
            this.trackBarV.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 50);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 16);
            this.label.TabIndex = 4;
            this.label.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveImageToolStripMenuItem.Text = "Save image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // FormTask3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label);
            this.Controls.Add(this.trackBarV);
            this.Controls.Add(this.trackBarS);
            this.Controls.Add(this.trackBarH);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTask3";
            this.Text = "FormTask3";
            this.Load += new System.EventHandler(this.FormTask3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar trackBarH;
        private System.Windows.Forms.TrackBar trackBarS;
        private System.Windows.Forms.TrackBar trackBarV;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
    }
}