using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Ilk_Proje
{
    public partial class Form3 : Form
    {
        Bitmap kaynak;
        Bitmap islem;

        public Form3()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ds = openFileDialog1.ShowDialog();
            if (ds == DialogResult.OK | ds == DialogResult.Yes)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakbox.Image = kaynak;
            }
        }

        private void ortalamaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;
            
            islem = new Bitmap(wid,heg);
            for(int y = 0; y < heg ; y++)
            {

                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x,y);
                    int av = (select.R + select.G + select.B) / 3;
                    Color gr = Color.FromArgb(av,av,av);
                    islem.SetPixel(x,y,gr);
                }
            }
            islembox.Image = islem;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Dosyaları |*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult ds = saveFileDialog1.ShowDialog();
            if (ds == DialogResult.OK){
                islem.Save(saveFileDialog1.FileName,format);
            }

        }

        private void griYöntemlerşToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;

            islem = new Bitmap(wid, heg);
            for (int y = 0; y < heg; y++)
            {

                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x, y);
                    float val = (select.R * 0.2125f) + (select.G * 0.7154f)+ (select.B * 0.072f);
                    int col = Convert.ToInt32(val);
                    Color gr = Color.FromArgb(col,col,col);
                    islem.SetPixel(x, y, gr);
                }
            }
            islembox.Image = islem;
        }

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;

            islem = new Bitmap(wid, heg);
            for (int y = 0; y < heg; y++)
            {

                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x, y);
                    float val = (select.R * 0.3f) + (select.G * 0.59f) + (select.B * 0.11f);
                    int col = Convert.ToInt32(val);
                    Color gr = Color.FromArgb(col, col, col);
                    islem.SetPixel(x, y, gr);
                }
            }
            islembox.Image = islem;
        }

        private void desaturationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;

            islem = new Bitmap(wid, heg);
            for (int y = 0; y < heg; y++)
            {

                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x, y);
                    int val = (Math.Max(Math.Max(select.R,select.G),select.B) + (Math.Min(Math.Min(select.R,select.G),select.B))) / 2; 
                    Color gr = Color.FromArgb(val, val, val);
                    islem.SetPixel(x, y, gr);
                }
            }
            islembox.Image = islem;
        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;

            islem = new Bitmap(wid, heg);
            for (int y = 0; y < heg; y++)
            {
                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x, y);
                    Color gr = Color.FromArgb(0, select.G, select.B); // Red kanalı çıkarıldı
                    islem.SetPixel(x, y, gr);
                }
            }
            islembox.Image = islem;
        }
    }
}
