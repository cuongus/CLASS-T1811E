using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string sign;
        double val1;
        double val2;
        int trackkeypoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button1.Text;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button2.Text;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button3.Text;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button4.Text;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button5.Text;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button6.Text;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button7.Text;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button8.Text;
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button9.Text;
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            text.Text = text.Text + button0.Text;
        }
        private void Button12_Click(object sender, EventArgs e) // xoa
        {
            text.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";
        }
        private void Button13_Click(object sender, EventArgs e) //nut / chia
        {
            sign = "/";
            val1 = double.Parse(text.Text);
            text.Text = "";
        }
        private void Button16_Click(object sender, EventArgs e) // nut + cong
        {
            sign = "+";
            val1 = double.Parse(text.Text);
            text.Text = "";
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tru_Click(object sender, EventArgs e) // nut - tru
        {
            sign = "-";
            val1 = double.Parse(text.Text);
            text.Text = "";
        }
        private void Nhan_Click(object sender, EventArgs e) //nut * nhan
        {
            sign = "*";
            val1 = double.Parse(text.Text);
            text.Text = "";
        }

        private void Bang_Click(object sender, EventArgs e) // ket qua
        {
            val2 = double.Parse(text.Text);
            double result;
            if (sign == "+")
            {
                result = val1 + val2;
                text.Text = result.ToString();
            }
            else if (sign == "-")
            {
                result = val1 - val2;
                text.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = val1 * val2;
                text.Text = result.ToString();
            }
            else
            {
                result = val1 / val2;
                text.Text = result.ToString();
            }
        }

        private void Cham_Click(object sender, EventArgs e) //dau cham
        {
            text.Text = text.Text + cham.Text;
        }
    }
}
