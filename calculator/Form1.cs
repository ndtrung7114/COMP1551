using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed == true))
            {
                textBox1.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            this.textBox1.Text = this.textBox1.Text + button.Text;

        }

        private void operater_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btn_equal(this, EventArgs.Empty);

                operationPerformed = button.Text;

                currentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = double.Parse(textBox1.Text);
                currentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void btn_equal(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                   
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                  
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:

                    break;

            }
            resultValue = double.Parse(textBox1.Text);  // Update resultValue with the latest result
            operationPerformed = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
