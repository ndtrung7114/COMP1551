using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp = this.textBox2.Text;
             
            this.textBox2.Text = this.textBox1.Text;
            this.textBox1.Text = temp;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_equal_Click(object sender, EventArgs e)
        {
            int first_number = Convert.ToInt32(this.firt_number.Text);
            int second_number = Convert.ToInt32(this.second_number.Text);

            if (cb.Text == "+")
            {
                int result = first_number + second_number;
                this.tex_result.Text = result.ToString();
            } else if ( cb.Text == "-" )
            {
                int result = first_number - second_number;
                this.tex_result.Text = result.ToString();
            } else if ( cb.Text == "*" )
            {
                int result = first_number * second_number;
                this.tex_result.Text = result.ToString();
            } else
            {
                int result = first_number / second_number;
                this.tex_result.Text = result.ToString();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string first_number, second_number;
            string result;

            StreamWriter textwriter = new StreamWriter("myfile.txt");
            first_number = Convert.ToString(this.firt_number.Text);
            second_number = Convert.ToString(this.second_number.Text);
           
            result = Convert.ToString(this.tex_result);
            textwriter.Write("{0} {1} {2} = {3}",first_number, this.cb.Text, second_number, result);
            textwriter.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader textreader = new StreamReader("myfile.txt");
            richTextBox1.Text = textreader.ReadToEnd();
        }
    }
}
