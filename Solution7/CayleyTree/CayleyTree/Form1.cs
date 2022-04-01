using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        int depth = 10;
        double length = 100;
        double th1 = 30 * Math.PI / 180;
        double th2 = 30 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = Pens.Blue;
        public Form1()
        {
            InitializeComponent();
        }

        //怎么让画出的树可以随着窗口变化而变化？
        private void draw_button_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel2.CreateGraphics();
            graphics.Clear(panel2.BackColor);
            drawCayleyTree(depth, panel2.Width/2, panel2.Height, length, -Math.PI / 2);
        }
        void drawCayleyTree(int n, double x0, double y0, double length, double th)
        {
            if (n == 0) return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * length, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * length, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void per1_box_TextChanged(object sender, EventArgs e)
        {
            if(per1_box.Text!= "") per1 = double.Parse(per1_box.Text);
        }

        private void per2_box_TextChanged(object sender, EventArgs e)
        {
            if( per2_box.Text!= "") per2 = double.Parse(per2_box.Text);
        }

        private void th1_box_TextChanged(object sender, EventArgs e)
        {
            if(th1_box.Text!= "") th1 = double.Parse(th1_box.Text) * Math.PI / 180;
        }
        private void th2_box_TextChanged(object sender, EventArgs e)
        {
            if(th2_box.Text!= "") th2 = double.Parse(th2_box.Text) * Math.PI / 180;
        }

        private void color_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pen[] pens = new Pen[] { Pens.Blue, Pens.Black, Pens.Red, Pens.Green };
            pen = pens[color_box.SelectedIndex];
        }

        private void depth_box_TextChanged(object sender, EventArgs e)
        {   
            if(depth_box.Text!= "") depth = int.Parse(depth_box.Text);
        }

        private void length_box_TextChanged(object sender, EventArgs e)
        {
            if(length_box.Text!= "") length = double.Parse(length_box.Text);
        }

        private void depth_label_Click(object sender, EventArgs e)
        {

        }

        private void length_label_Click(object sender, EventArgs e)
        {

        }

        private void per1_label_Click(object sender, EventArgs e)
        {

        }

        private void per2_label_Click(object sender, EventArgs e)
        {

        }

        private void th1_label_Click(object sender, EventArgs e)
        {

        }

        private void th2_label_Click(object sender, EventArgs e)
        {

        }

        private void color_label_Click(object sender, EventArgs e)
        {

        }
    }
}
