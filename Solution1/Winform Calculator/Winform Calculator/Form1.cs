using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Calculator
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
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button1.Text;
            }
            else
                textBox3.Text = textBox3.Text + button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button2.Text;
            }
            else
                textBox3.Text = textBox3.Text + button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button3.Text;
            }
            else
                textBox3.Text = textBox3.Text + button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button4.Text;
            }
            else
                textBox3.Text = textBox3.Text + button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button5.Text;
            }
            else
                textBox3.Text = textBox3.Text + button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button6.Text;
            }
            else
                textBox3.Text = textBox3.Text + button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button7.Text;
            }
            else
                textBox3.Text = textBox3.Text + button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button8.Text;
            }
            else
                textBox3.Text = textBox3.Text + button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button9.Text;
            }
            else
                textBox3.Text = textBox3.Text + button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button10.Text;
            }
            else
                textBox3.Text = textBox3.Text + button10.Text;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + button12.Text;
            }
            else
                textBox3.Text = textBox3.Text + button12.Text;
        }
        public double num1, num2, sum = 0;
        public String symbol;
        private void button13_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox2.Text = textBox2.Text + button13.Text;
            symbol = "+";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox2.Text = textBox2.Text + button14.Text;
            symbol = "-";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox2.Text = textBox2.Text + button15.Text;
            symbol = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox2.Text = textBox2.Text + button16.Text;
            symbol = "/";
        }
        private void button17_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox3.Text);
            switch (symbol)
            {
                case "+":
                    sum = num1 + num2;
                    break;
                case "-":
                    sum = num1 - num2;
                    break;
                case "*":
                    sum = num1 * num2;
                    break;
                case "/":
                    sum = num1 / num2;
                    break;
                default:
                    label1.Text = "You input the incorrect symbol,please delete.";
                    break;                   
            }
            textBox4.Text = sum.ToString();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
