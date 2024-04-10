using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            int x = 5;
            int y = 5;
            int z = 5;
            int m = 5;
            int a = 2;
            int b = 2;
            float a1 = 1.47f;
            float b1 = 1.33f;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Pen p2 = new Pen(Color.Black, 4); // Ширина 4 пиксела
            for (int i = 1; i < 10; i++)
            {
                gr.FillRectangle(Brushes.Gray, x + 5, y + 5, z + 5, m + 5);
                gr.DrawRectangle(p2, x + 5, y + 5, z + 5, m + 5);
                for (int j = 1; j < 10; j++)
                {
                    gr.DrawRectangle(p2, x + 7, y + 7, z + 7, m + 7);
                    gr.ScaleTransform(a1, b1);
                    gr.TranslateTransform(a , b);
                    gr.FillRectangle(Brushes.Gray, x + 7, y + 7, z + 7, m + 7);
                    
                    i++; ;
                }
                Console.WriteLine();
            }

            pictureBox1.Image = bmp;
            
           
            
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
