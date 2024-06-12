using System;
using System.Collections;
using System.Collections.Generic;

namespace MyNamespace
{
    public enum Role
    {
        Manager,
        Associate,
        Admin,
        Intern
    }

    class Employee
    {
        private string name = "";
        private double salary;
        private DateTime date;
        private Role role;


        public string Name
        {
            get { return (name); }
            set { name = value; }
        }
        public double Salary
        {
            get { return (salary); }
            set { if ((value > 10000) && (value < 100000)) { salary = value; } }
        }

        public DateTime Date
        {
            get { return date; }
        }

        public Role Role
        {
            get { return role; }
            set { role = value; }
        }
        public Employee()
        {
            this.date = DateTime.Now;
        }
    }

    public class MyClass
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine("\n **************** \n");           

            // Declare a list of objects
            List<Employee> MyList = new List<Employee>();

            int length_employee;
            Console.Write("Enter number of employee: ");

            length_employee = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= length_employee; i++)
            {
                string name;
                double salary;
                int role;
                Employee employee = new Employee();
                Console.Write("Enter name employee {0}: ", i);
                name = Console.ReadLine();
                Console.Write("Enter salary employee {0} (10.000, 100.000): ", i);
                salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter role employee {0}. (1.Manager, 2.Associate, 3.Admin, 4.Intern): ", i);
                role = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n **************** \n");
                switch (role)
                {
                    case 1:
                        employee.Name = name;
                        employee.Salary = salary;
                        employee.Role = (Role)0; break;
                    case 2:
                        employee.Name = name;
                        employee.Salary = salary;
                        employee.Role = (Role)1; break;

                    case 3:
                        employee.Name = name;
                        employee.Salary = salary;
                        employee.Role = (Role)2; break;

                    case 4:
                        employee.Name = name;
                        employee.Salary = salary;
                        employee.Role = (Role)3; break;

                    default:
                        Console.WriteLine("Enter valid number");
                        break;
                }

                MyList.Add(employee);

                


            }

            Console.WriteLine("List all employee");

            // Display all items from the list
            foreach (Employee b in MyList)
            {

                Console.WriteLine("Name: {0}, Salary: {1}, Role: {2}, Work from: {3}", b.Name, b.Salary, b.Role, b.Date);
            }

            Console.WriteLine("\n **************** \n");

            int option;

            Console.Write("Do you want to select all employee belong to specific role? (1. Yes, 2. No, 3.Sort): ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int role_selected;
                    Console.Write("Enter role to see all empployee belong to this role (1.Manager, 2.Associate, 3.Admin, 4.Intern): ");
                    role_selected = Convert.ToInt32(Console.ReadLine());

                    int employee_found = 0;
                    foreach (Employee a in MyList)
                    {
                        if (a.Role == (Role)(role_selected - 1))
                        {

                            employee_found++;
                        }
                    }
                    Console.WriteLine("There are {0} employee belong to {1} role", employee_found, (Role)(role_selected - 1));
                    Console.WriteLine();
                    foreach (Employee a in MyList)
                    {
                        if (a.Role == (Role)(role_selected - 1))
                        {

                            Console.WriteLine("Name: {0}, Salary: {1}, Role: {2}, Work from: {3}", a.Name, a.Salary, a.Role, a.Date);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Bye");
                    break;

                case 3:
                    List<Employee> list_order = MyList.OrderBy(o=>o.Salary).ToList();
                    foreach (Employee c in list_order)
                    {
                        Console.WriteLine("Name: {0}, Salary: {1}, Role: {2}, Work from: {3}", c.Name, c.Salary, c.Role, c.Date);
                    }
                    break;


                default:
                    Console.WriteLine("not valid number");
                    break ;


                  

            }



            


        }
    }
}