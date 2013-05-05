using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculator : Form
    {
        /* 
         * 1 => + 
         * 2 => -
         * 3 => x
         * 4 => /
         */
        double result = 0;
        int opp = 0;

        public calculator()
        {
            InitializeComponent();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox.Text += " + ";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox.Text += " - ";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            textBox.Text += " x ";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            textBox.Text += " / ";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox.Text[textBox.Text.Length - 1] == ' ')
            {
                if (textBox.Text[textBox.Text.Length - 2] == '+' || textBox.Text[textBox.Text.Length - 2] == '-' || textBox.Text[textBox.Text.Length - 2] == '*' || textBox.Text[textBox.Text.Length - 2] == '/')
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 3, 3);
                }
                else
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 2, 2);
                }
            }
            else
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            textBox.Text += " = ";
            string[] operands = textBox.Text.Split(' ');
            for (int i = 0; i < operands.Length; i++ )
            {
                if (operands[i] == "")
                {
                    continue;
                }
                else if (operands[i] == "+")
                {
                    opp = 1;
                }
                else if (operands[i] == "-")
                {
                    opp = 2;
                }
                else if (operands[i] == "x")
                {
                    opp = 3;
                }
                else if (operands[i] == "/")
                {
                    opp = 4;
                }
                else if (operands[i] == "=")
                {
                    textBox.Text += Convert.ToString(result);
                    result = 0;
                    break;
                }
                else
                {
                    switch (opp)
                    {
                        case 0: result = Convert.ToDouble(operands[i]);
                            break;

                        case 1: result += Convert.ToDouble(operands[i]);
                            break;

                        case 2: result -= Convert.ToDouble(operands[i]);
                            break;

                        case 3: result *= Convert.ToDouble(operands[i]);
                            break;

                        case 4: result /= Convert.ToDouble(operands[i]);
                            break;
                    }
                }
            }

        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
