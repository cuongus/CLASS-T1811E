using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cmd0_Click_1(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd0.Text;
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd1.Text;
        }

        private void Cmd2_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd2.Text;
        }

        private void Cmd3_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd3.Text;
        }

        private void Cmd4_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd4.Text;
        }

        private void Cmd5_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd5.Text;
        }

        private void Cmd6_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd6.Text;
        }

        private void Cmd7_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd7.Text;
        }

        private void Cmd8_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd8.Text;
        }

        private void Cmd9_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + cmd9.Text;
        }

        private void CmdEqual_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(txtBox.Text);
            double result;
            if (sign == "+")
            {
                result = val1 + val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "-")
            {
                result = val1 - val2;
                txtBox.Text = result.ToString();
            }
            else if (sign == "*")
            {
                result = val1 * val2;
                txtBox.Text = result.ToString();
            }
            else
            {
                result = val1 / val2;
                txtBox.Text = result.ToString();
            }
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void CmdSubtract_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void CmdMultiply_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void CmDivide_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(txtBox.Text);
            txtBox.Text = "";
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";
        }

        private void CmdSquare_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Pow(v, 2).ToString();
        }

        private void CmdSin_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Sin(v).ToString();
        }

        private void CmdCos_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Cos(v).ToString();
        }

        private void CmdSqtr_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Sqrt(v).ToString();
        }

        private void CmdTan_Click(object sender, EventArgs e)
        {
            double v;
            v = double.Parse(txtBox.Text);
            txtBox.Text = Math.Tan(v).ToString();
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
