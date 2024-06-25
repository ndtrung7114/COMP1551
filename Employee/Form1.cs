using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        
        
        
        public class Employees
        {
            
            public string Name { get; set; }
            public double Salary { get; set; }
            public string Role { get; set; }
            public DateTime StartDate { get; set; }

            public Employees(string name, double salary, string role, DateTime startdate)
            {
                this.Name = name;
                this.Salary = salary;
                this.Role = role;
                this.StartDate = startdate;
            }
        }

        public  List<Employees> employees = new List<Employees>();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = this.name.Text;
            double salary = Convert.ToDouble(this.salary.Text);
            string role = this.role.Text;
            DateTime start_date = date.Value;

            Employees employee = new Employees(name, salary, role, start_date);
          
            employees.Add(employee);
            
            Form2 form = new Form2(employees); // Pass employee list reference
            form.ShowDialog(this);

        }

        
    }
}
