using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abueg_Assignment_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DEG_Click(object sender, EventArgs e)
        {

        }

      
        private void F_E_Click(object sender, EventArgs e)
        {

        }

        private void MC_Click(object sender, EventArgs e)
        {

        }

        private void MR_Click(object sender, EventArgs e)
        {

        }

        private void mPlus_Click(object sender, EventArgs e)
        {

        }

        private void mMinus_Click(object sender, EventArgs e)
        {

        }

        private void MS_Click(object sender, EventArgs e)
        {

        }

        private void Trigonometry_Click(object sender, EventArgs e)
        {

        }

        private void Function_Click(object sender, EventArgs e)
        {

        }

        private void second_Click(object sender, EventArgs e)
        {

        }

        private void pi_Click(object sender, EventArgs e)
        {

        }

        private void e_Click(object sender, EventArgs e)
        {

        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if(textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void xExponent_Click(object sender, EventArgs e)
        {

        }

        private void overX_Click(object sender, EventArgs e)
        {

        }

        private void absX_Click(object sender, EventArgs e)
        {

        }

        private void exp_Click(object sender, EventArgs e)
        {

        }

        private void mod_Click(object sender, EventArgs e)
        {

        }

        private void rootX_Click(object sender, EventArgs e)
        {

        }

        private void openP_Click(object sender, EventArgs e)
        {

        }

        private void closeP_Click(object sender, EventArgs e)
        {

        }

        private void factorial_Click(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {

        }

        private void expSqrtY_Click(object sender, EventArgs e)
        {

        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void tenTwoExpX_Click(object sender, EventArgs e)
        {

        }

        private void four_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {

        }

        private void natLog_Click(object sender, EventArgs e)
        {

        }

        private void signChange_Click(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {

        }

        private void point_Click(object sender, EventArgs e)
        {

        }

        private void equals_Click(object sender, EventArgs e)
        {

        }
    }
}
