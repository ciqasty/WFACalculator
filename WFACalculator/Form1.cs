using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFACalculator
{
    public partial class Form1 : Form
    {

        public double result { get; set; }

        bool plusActive, minusActive, divideActive, multiplyActive = false;

        public Form1()
        {
            InitializeComponent();
            textBoxResult.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += button0.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operationFinisher();
            plusActive = true;
            textBoxOperation.Text = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operationFinisher();
            minusActive = true;
            textBoxOperation.Text = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operationFinisher();
            multiplyActive = true;
            textBoxOperation.Text = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operationFinisher();
            divideActive = true;
            textBoxOperation.Text = "/";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operationFinisher();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += buttonDot.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cE();
        }
        public void operationFinisher()
        {
            if (plusActive && textBoxValue.Text != "")
            {
                result += double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                textBoxOperation.Clear();
                textBoxValue.Clear();
                plusActive = false;
            }
            else if (minusActive && textBoxValue.Text != "")
            {
                result -= double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                textBoxOperation.Clear();
                textBoxValue.Clear();
                minusActive = false;
            }
            else if (divideActive && textBoxValue.Text != "")
            {
                result /= double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                textBoxOperation.Clear();
                textBoxValue.Clear();
                divideActive = false;
            }
            else if (multiplyActive && textBoxValue.Text != "")
            {
                result *= double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                textBoxOperation.Clear();
                textBoxValue.Clear();
                multiplyActive = false;
            }
            else if (textBoxValue.Text!="")
            {
                result = double.Parse(textBoxValue.Text);
                textBoxResult.Text = result.ToString();
                textBoxValue.Clear();
            }
        }
        public void cE()
        {
            textBoxOperation.Clear();
            textBoxResult.Text = "0";
            textBoxValue.Clear();
            result = 0;
        }
    }
}
