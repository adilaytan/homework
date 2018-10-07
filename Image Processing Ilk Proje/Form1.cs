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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void işlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           // Application.Exit();
        }

        private void renkAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.ShowDialog();
        }

        private void griYöntemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.ShowDialog();
        }

        private void tersRenkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            x.ShowDialog();
        }
    }
}
