using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Employee.Form1;

namespace Employee
{
    public partial class Form2 : Form
    {
        private List<Employees> employees; // Received from Form1

        public Form2(List<Employees> employees)
        {
            InitializeComponent();
            this.employees = employees; // Store reference to passed employee list
        }

        private void show_text_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void show_Click_1(object sender, EventArgs e)
        {
            // Initialize an empty string to hold the information
            string employeeDetails = "";

            // Iterate through the list of employees
            foreach (Employees employee in employees)
            {
                // Append each employee's information to the string
                employeeDetails += $"Name: {employee.Name}, Salary: {employee.Salary}, Role: {employee.Role}, Start Date: {employee.StartDate.ToShortDateString()}\n";
                listBox1.Items.Add(employee);
                
            }

            // Display the concatenated string in the show label
            this.show_text.Text = employeeDetails;
            foreach (Employees employee in employees)
            {
                this.listBox1.ValueMember = employee.Name;
            }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
