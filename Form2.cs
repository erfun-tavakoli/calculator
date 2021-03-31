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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != "2")
                textBox1.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != "2")
                textBox1.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != "2")
                textBox1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != "2")
                textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != "2")
                textBox1.Text += "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != "2")
                textBox1.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != "2")
                textBox1.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != "2")
                textBox1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        public string DecimalToBinary(string decValue)
        {
            bool complete = false;
            StringBuilder BinaryValue = new StringBuilder();
            int deci = int.Parse(decValue);

            while (!complete)
            {
                if (deci >= 2)
                {
                    if (deci % 2 == 0)
                    {
                        BinaryValue.Insert(0, "0");
                    }
                    else
                    {
                        BinaryValue.Insert(0, "1");
                    }
                    deci = deci / 2;
                }
                else
                {
                    BinaryValue.Insert(0, deci.ToString());
                    complete = true;
                }
            }

            return BinaryValue.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.SelectedItem == comboBox2.SelectedItem)
                {
                    textBox2.Text = textBox1.Text;
                }
                else if (comboBox1.SelectedItem == "10" && comboBox2.SelectedItem == "2")
                {
                    textBox2.Text = DecimalToBinary(textBox1.Text);
                }
                else if (comboBox2.SelectedItem == "10")
                {
                    int ConvertTo = int.Parse(comboBox1.SelectedItem.ToString());
                    textBox2.Text = Convert.ToInt32(textBox1.Text, ConvertTo).ToString();
                }
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
