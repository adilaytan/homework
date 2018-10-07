namespace Image_Processing_Ilk_Proje
{
    partial class Form4
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
            this.kaynakbox = new System.Windows.Forms.PictureBox();
            this.islembox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalCevirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBGrbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rGBGBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBBGRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBBRGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBRBGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islembox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaynakbox
            // 
            this.kaynakbox.Location = new System.Drawing.Point(12, 37);
            this.kaynakbox.Name = "kaynakbox";
            this.kaynakbox.Size = new System.Drawing.Size(455, 445);
            this.kaynakbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaynakbox.TabIndex = 0;
            this.kaynakbox.TabStop = false;
            // 
            // islembox
            // 
            this.islembox.Location = new System.Drawing.Point(486, 37);
            this.islembox.Name = "islembox";
            this.islembox.Size = new System.Drawing.Size(455, 445);
            this.islembox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.islembox.TabIndex = 1;
            this.islembox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.kanalCevirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // kanalCevirToolStripMenuItem
            // 
            this.kanalCevirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBGrbToolStripMenuItem,
            this.rGBGBRToolStripMenuItem,
            this.rGBBGRToolStripMenuItem,
            this.rGBBRGToolStripMenuItem,
            this.rGBRBGToolStripMenuItem});
            this.kanalCevirToolStripMenuItem.Name = "kanalCevirToolStripMenuItem";
            this.kanalCevirToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.kanalCevirToolStripMenuItem.Text = "Kanal Cevir";
            // 
            // rGBGrbToolStripMenuItem
            // 
            this.rGBGrbToolStripMenuItem.Name = "rGBGrbToolStripMenuItem";
            this.rGBGrbToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rGBGrbToolStripMenuItem.Text = "RGB  - GRB";
            this.rGBGrbToolStripMenuItem.Click += new System.EventHandler(this.rGBGrbToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rGBGBRToolStripMenuItem
            // 
            this.rGBGBRToolStripMenuItem.Name = "rGBGBRToolStripMenuItem";
            this.rGBGBRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rGBGBRToolStripMenuItem.Text = "RGB - GBR";
            this.rGBGBRToolStripMenuItem.Click += new System.EventHandler(this.rGBGBRToolStripMenuItem_Click);
            // 
            // rGBBGRToolStripMenuItem
            // 
            this.rGBBGRToolStripMenuItem.Name = "rGBBGRToolStripMenuItem";
            this.rGBBGRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rGBBGRToolStripMenuItem.Text = "RGB - BGR";
            this.rGBBGRToolStripMenuItem.Click += new System.EventHandler(this.rGBBGRToolStripMenuItem_Click);
            // 
            // rGBBRGToolStripMenuItem
            // 
            this.rGBBRGToolStripMenuItem.Name = "rGBBRGToolStripMenuItem";
            this.rGBBRGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rGBBRGToolStripMenuItem.Text = "RGB - BRG";
            this.rGBBRGToolStripMenuItem.Click += new System.EventHandler(this.rGBBRGToolStripMenuItem_Click);
            // 
            // rGBRBGToolStripMenuItem
            // 
            this.rGBRBGToolStripMenuItem.Name = "rGBRBGToolStripMenuItem";
            this.rGBRBGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rGBRBGToolStripMenuItem.Text = "RGB - RBG";
            this.rGBRBGToolStripMenuItem.Click += new System.EventHandler(this.rGBRBGToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 604);
            this.Controls.Add(this.islembox);
            this.Controls.Add(this.kaynakbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islembox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kaynakbox;
        private System.Windows.Forms.PictureBox islembox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalCevirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBGrbToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem rGBGBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBBGRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBBRGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBRBGToolStripMenuItem;
    }
}