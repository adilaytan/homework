using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Ilk_Proje
{
    public partial class Form2 : Form
    {
        Bitmap kaynak;

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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

        private void renkAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xcoor.Text);
            int y = int.Parse(ycoor.Text);

            Color select = kaynak.GetPixel(x,y);
            Console.WriteLine("Secilen Renk R: " + select.R + " G: " + select.G + " B: " + select.B);
            pictureBox1.BackColor = select;
        }
    }
}
