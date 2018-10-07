namespace Image_Processing_Ilk_Proje
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griYöntemlerşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakbox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.islembox = new System.Windows.Forms.PictureBox();
            this.bT709ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desaturationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalÇıkarımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islembox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.griYöntemlerşToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 0;
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
            // griYöntemlerşToolStripMenuItem
            // 
            this.griYöntemlerşToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ortalamaYöntemiToolStripMenuItem,
            this.bT709ToolStripMenuItem,
            this.lumaYöntemiToolStripMenuItem,
            this.desaturationToolStripMenuItem,
            this.kanalÇıkarımıToolStripMenuItem});
            this.griYöntemlerşToolStripMenuItem.Name = "griYöntemlerşToolStripMenuItem";
            this.griYöntemlerşToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.griYöntemlerşToolStripMenuItem.Text = "Gri Yöntemleri";
            this.griYöntemlerşToolStripMenuItem.Click += new System.EventHandler(this.griYöntemlerşToolStripMenuItem_Click);
            // 
            // ortalamaYöntemiToolStripMenuItem
            // 
            this.ortalamaYöntemiToolStripMenuItem.Name = "ortalamaYöntemiToolStripMenuItem";
            this.ortalamaYöntemiToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ortalamaYöntemiToolStripMenuItem.Text = "Ortalama Yöntemi";
            this.ortalamaYöntemiToolStripMenuItem.Click += new System.EventHandler(this.ortalamaYöntemiToolStripMenuItem_Click);
            // 
            // kaynakbox
            // 
            this.kaynakbox.Location = new System.Drawing.Point(12, 27);
            this.kaynakbox.Name = "kaynakbox";
            this.kaynakbox.Size = new System.Drawing.Size(280, 376);
            this.kaynakbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaynakbox.TabIndex = 1;
            this.kaynakbox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // islembox
            // 
            this.islembox.Location = new System.Drawing.Point(323, 27);
            this.islembox.Name = "islembox";
            this.islembox.Size = new System.Drawing.Size(280, 376);
            this.islembox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.islembox.TabIndex = 2;
            this.islembox.TabStop = false;
            // 
            // bT709ToolStripMenuItem
            // 
            this.bT709ToolStripMenuItem.Name = "bT709ToolStripMenuItem";
            this.bT709ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bT709ToolStripMenuItem.Text = "BT-709";
            this.bT709ToolStripMenuItem.Click += new System.EventHandler(this.bT709ToolStripMenuItem_Click);
            // 
            // lumaYöntemiToolStripMenuItem
            // 
            this.lumaYöntemiToolStripMenuItem.Name = "lumaYöntemiToolStripMenuItem";
            this.lumaYöntemiToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.lumaYöntemiToolStripMenuItem.Text = "Luma Yöntemi";
            this.lumaYöntemiToolStripMenuItem.Click += new System.EventHandler(this.lumaYöntemiToolStripMenuItem_Click);
            // 
            // desaturationToolStripMenuItem
            // 
            this.desaturationToolStripMenuItem.Name = "desaturationToolStripMenuItem";
            this.desaturationToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.desaturationToolStripMenuItem.Text = "Desaturation";
            this.desaturationToolStripMenuItem.Click += new System.EventHandler(this.desaturationToolStripMenuItem_Click);
            // 
            // kanalÇıkarımıToolStripMenuItem
            // 
            this.kanalÇıkarımıToolStripMenuItem.Name = "kanalÇıkarımıToolStripMenuItem";
            this.kanalÇıkarımıToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.kanalÇıkarımıToolStripMenuItem.Text = "Kanal Çıkarımı";
            this.kanalÇıkarımıToolStripMenuItem.Click += new System.EventHandler(this.kanalÇıkarımıToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 491);
            this.Controls.Add(this.islembox);
            this.Controls.Add(this.kaynakbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islembox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griYöntemlerşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamaYöntemiToolStripMenuItem;
        private System.Windows.Forms.PictureBox kaynakbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox islembox;
        private System.Windows.Forms.ToolStripMenuItem bT709ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaYöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desaturationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalÇıkarımıToolStripMenuItem;
    }
}