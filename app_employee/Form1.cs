using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_employee
{
    public partial class Form1 : Form
    {
        public enum Role
        {
            manager,
            association,
            admin,
            intern
        }
        public class Employees
        {

            private string name;
            private double salary;
            private Role role;
            private DateTime startDate;

            public string Name
            {
                 get { return name; } set { name = value; } 
            }

            public double Salary
            {
                get { return salary; }
                set
                {
                    try
                    {
                        if (value < 10000 || value > 100000 )
                        {
                            throw new ArgumentException("Salary must be between (10.000, 100000)");
                        }
                        salary = value;

                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }

            public Role Role
            {
                get { return role; }

                set { role = value; }
            }

            public DateTime StartDate
            {
                get { return startDate;}
                set { startDate = value; }
            }


            public Employees(string name, double salary, Role role, DateTime startdate)
            {
                this.name = name;
                
                    if (salary < 10000 || salary > 100000)
                    {
                        throw new ArgumentException("Salary must be between (10.000, 100000)");
                    }
                    this.salary = salary;

                
                
                

                

                this.role = role;
                this.startDate = startdate;
            }
        }

        public List<Employees> employees = new List<Employees>();
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.name.Text;
                double salary = Convert.ToDouble(this.salary.Text);
                int role = this.role.SelectedIndex + 1;
                DateTime start_date = date.Value;

                Employees employee = new Employees(name, salary, (Role)role, start_date);

                employees.Add(employee);
                SaveEmployeeToDatabase(employee);
                

                Form2 form = new Form2(employees); // Pass employee list reference
                form.ShowDialog(this);
            } catch (ArgumentException ex)
            { 
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void SaveEmployeeToDatabase(Employees employee)
        {
            // Connection string (modify according to your database configuration)
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\hoc tap\\ki5\\COMP1551\\app_employee\\sampleDB.mdf\";Integrated Security = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Employee (Name, Salary, Role, StartDate) VALUES (@Name, @Salary, @Role, @StartDate)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);
                    command.Parameters.AddWithValue("@Role", employee.Role.ToString());
                    command.Parameters.AddWithValue("@StartDate", employee.StartDate);

                    command.ExecuteNonQuery();
                }
            }
        }
    }

    
}
