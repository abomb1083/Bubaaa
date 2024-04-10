using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RectangleF rectf = new RectangleF(70, 90, 799, 799);
            Bitmap bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            gr.FillRectangle(Brushes.Black, 10, 10, 799, 799);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawString(textBox3.Text, new Font("Tahoma", 128.8f), Brushes.Red, rectf);

            g.Flush();
            pictureBox1.Image = bmp;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
