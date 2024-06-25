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

namespace WindowsFormsApp3
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            tb_password.PasswordChar = '*';
        /* try
            {
                StreamReader reader = new StreamReader("login.txt");
                string line = reader.ReadLine();
                if (line != null)
                {
                    string[] infor = line.Split(',');
                    tb_user.Text = infor[0];
                    tb_password.Text = infor[1];
                }
                reader.Close();

            } catch
            {
                MessageBox.Show("can not find login.txt");
            }*/
            
            
        }

        private bool check_login()
        {
            try
            {
                StreamReader reader = new StreamReader("login1.txt");
                string line = reader.ReadLine();
                while(line != null)
                {
                        
                    string text = tb_user.Text + "," + tb_password.Text + "," + cb_role.Text;
                    if (line == text)
                    {
                        reader.Close();
                        return true;
                        
                        
                    }
                    line = reader.ReadLine();
                }

            }
            catch
            {

            }
            return false;
        }



        

        

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(check_login())
            {
                if (this.checkBox1.Checked)
                {
                    StreamWriter write = new StreamWriter("login1.txt", true);
                    write.WriteLine("{0},{1},{2}", tb_user.Text, tb_password.Text, cb_role.Text);
                    write.Close();
                    MessageBox.Show("You have remeber this account");
                }
                MessageBox.Show("login successfull");
                Form_admin form_Admin = new Form_admin();
                form_Admin.ShowDialog();
            } else
            {
                MessageBox.Show("login fail");
            }
            

        }

       
    }
}
