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



namespace app_employee
{
    public partial class Form2 : Form
    {
        private List<Form1.Employees> employees; // Received from Form1

        public Form2(List<Form1.Employees> employees)
        {
            InitializeComponent();
            this.employees = employees; // Store reference to passed employee list
        }

        private void show_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\hoc tap\\ki5\\COMP1551\\app_employee\\sampleDB.mdf\";Integrated Security = True";
            // Initialize an empty string to hold the information
            string employeeDetails = "";
            listBox1.Items.Clear();
            listBox1.DisplayMember = "Name";

            // Iterate through the list of employees
            foreach (Form1.Employees employee in employees)
            {
                // Append each employee's information to the string
                employeeDetails += $"Name: {employee.Name}, Salary: {employee.Salary}, Role: {employee.Role}, Start Date: {employee.StartDate.ToShortDateString()}\n";
                listBox1.Items.Add(employee);

            }

            // Display the concatenated string in the show label
            this.show_text.Text = employeeDetails;
            
            
            

        }

        private void show_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Form1.Employees selectedEmployee = (Form1.Employees)listBox1.SelectedItem;
                show_text.Text = $"Name: {selectedEmployee.Name}, Salary: {selectedEmployee.Salary}, Role: {selectedEmployee.Role}, Start Date: {selectedEmployee.StartDate.ToShortDateString()}";
            }
        }

        private void write_file_Click(object sender, EventArgs e)
        {
            StreamWriter myfile = new StreamWriter("mytextfile.txt");
            string s = show_text.Text;
            myfile.WriteLine(s);
            myfile.Close();
        }

        private void read_file_Click(object sender, EventArgs e)
        {
            show_text.Clear();
            StreamReader readfile = new StreamReader("mytextfile.txt");
            show_text.Text = readfile.ReadToEnd();
            readfile.Close();
        }
    }
}
