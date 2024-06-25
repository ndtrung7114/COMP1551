using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form_admin : Form
    {
        public Form_admin()
        {
            InitializeComponent();
        }

        private void Form_admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] newrow = {tb_id.Text, tb_fullname.Text, tb_email.Text, tb_role.Text};
            dataGridView1.Rows.Add(newrow);
        }
    }
}
