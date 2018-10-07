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
    public partial class Form4 : Form
    {
        Bitmap islem;
        Bitmap kaynak;

        public Form4()
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

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "PNG Dosyaları |*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult ds = saveFileDialog1.ShowDialog();
            if (ds == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void rGBGrbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;

            islem = new Bitmap(wid, heg);
            for (int y = 0; y < heg; y++)
            {

                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x, y);
                    
                    Color inv = Color.FromArgb(select.G, select.R, select.B);
                    islem.SetPixel(x, y,inv);
                }
            }
            islembox.Image = islem;
        }

        private void rGBGBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;

            islem = new Bitmap(wid, heg);
            for (int y = 0; y < heg; y++)
            {

                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x, y);

                    Color inv = Color.FromArgb(select.G, select.B, select.R);
                    islem.SetPixel(x, y, inv);
                }
            }
            islembox.Image = islem;
        }

        private void rGBBGRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;

            islem = new Bitmap(wid, heg);
            for (int y = 0; y < heg; y++)
            {

                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x, y);

                    Color inv = Color.FromArgb(select.B, select.G, select.R);
                    islem.SetPixel(x, y, inv);
                }
            }
            islembox.Image = islem;
        }

        private void rGBBRGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;

            islem = new Bitmap(wid, heg);
            for (int y = 0; y < heg; y++)
            {

                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x, y);

                    Color inv = Color.FromArgb(select.B, select.R, select.G);
                    islem.SetPixel(x, y, inv);
                }
            }
            islembox.Image = islem;
        }

        private void rGBRBGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int wid = kaynak.Width;
            int heg = kaynak.Height;

            islem = new Bitmap(wid, heg);
            for (int y = 0; y < heg; y++)
            {

                for (int x = 0; x < wid; x++)
                {
                    Color select = kaynak.GetPixel(x, y);

                    Color inv = Color.FromArgb(select.R, select.B, select.G);
                    islem.SetPixel(x, y, inv);
                }
            }
            islembox.Image = islem;
        }
    }
}
