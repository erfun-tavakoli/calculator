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
        private string Number2 = "";
        private string Number1 = "";
        private DataTable dt = new DataTable();
        private List<char> Symbols = new List<char> { '+', '-', '/', '*' };

        public Form1()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Number2 != "")
            {
                Number2 = Number2.Remove(Number2.Length - 1);
                UpdateInput();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Number2 += "9";
            UpdateInput();
        }

        private void UpdateInput()
        {
            textBox1.Text = Number1 + Environment.NewLine;

            if (Number2 == "")
                textBox1.Text += 0;
            else
                textBox1.Text += Number2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Number2 += "0";
            UpdateInput();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Number2 += "1";
            UpdateInput();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Number2 += "2";
            UpdateInput();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Number2 += "3";
            UpdateInput();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Number2 += "4";
            UpdateInput();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Number2 += "5";
            UpdateInput();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Number2 += "6";
            UpdateInput();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Number2 += "7";
            UpdateInput();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Number2 += "8";
            UpdateInput();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Operation('+');
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Operation('-');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Operation('*');
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Operation('/');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Number2 != "")
            {
                Number1 += Number2;
                string value = dt.Compute(Number1, null).ToString();
                Number2 = "";
                textBox1.Text = Number1 + " =" + Environment.NewLine + value;
                Number1 = value;
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (!Number2.Any(ch => ch == '.'))
            {
                if (Number2 == "")
                {
                    Number2 += "0.";
                }
                else
                {
                    Number2 += ".";
                }
                
                UpdateInput();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Number2 = "";
            UpdateInput();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Number2 = "";
            Number1 = "";
            UpdateInput();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void Operation(char Symbol)
        {
            if (Number1 != "")
            {
                if (Number2 != "" && !Symbols.Contains(Number1.TrimEnd()[Number1.TrimEnd().Length - 1]))
                {
                    Number1 += " " + Symbol + " " + Number2;
                    Number2 = "";
                }
                else if (Number2 != "" && Symbols.Contains(Number1.TrimEnd()[Number1.TrimEnd().Length - 1]))
                {
                    Number1 += Number2 + " " + Symbol + " ";
                    Number2 = "";
                }
                else if (Symbols.Contains(Number1.TrimEnd()[Number1.TrimEnd().Length - 1]))
                {
                    Number1 = Number1.Remove(Number1.Length - 3) + " " + Symbol + " ";
                }
                else
                {
                    Number1 += " " + Symbol + " ";
                }
            }
            else if (Number2 != "")
            {
                Number1 += Number2 + " " + Symbol + " ";
                Number2 = "";
            }

            UpdateInput();
        }
    }
}
