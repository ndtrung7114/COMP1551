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
        private Role role;
        private DateTime start_date;

        

        public Role Role
        {
            get { return role; }
            set { role = value; }
        }

        public DateTime StartDate
        {
            get { return start_date; }
            set
            {
                if (value <= DateTime.Now) { start_date = value; }
                else { throw new ArgumentException("Start date can not be in the future"); }
            }
        }

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
    }

    public class MyClass
    {
        public static void Main(string[] args)
        {
            int i;
            // Array of 5 elements
            // Each array element is an object
            Employee[] MyArray = new Employee[5];

            // Initialise the array
            for (i = 0; i < 5; i++)
            {
                MyArray[i] = new Employee();
            }

            // Update the records
            MyArray[0].Name = "John";
            MyArray[0].Salary = 50000;
            MyArray[0].Role = Role.Manager;
            MyArray[0].StartDate = new DateTime(2024, 5, 30);

            MyArray[1].Name = "Ann";
            MyArray[1].Salary = 25000;
            MyArray[1].Role = Role.Associate;
            MyArray[1].StartDate = new DateTime(2021, 5, 10);

            // Add third record
            MyArray[2].Name = "Mary";
            MyArray[2].Salary = 40000;
            MyArray[2].Role = Role.Admin;
            MyArray[2].StartDate = new DateTime(2019, 3, 25);


            // Display all elements from the array
            foreach (Employee a in MyArray)
            {
                Console.WriteLine("{0} {1} {2} {3}", a.Name, a.Salary, a.Role, a.StartDate.ToShortDateString());
            }

            Console.WriteLine("\n **************** \n");

            
            // Declare a list of objects
            List<Employee> MyList = new List<Employee>();

            // Add the objects to the list
            MyList.Add(MyArray[0]);
            MyList.Add(MyArray[1]);
            MyList.Add(MyArray[2]);

            // Display all items from the list
            foreach (Employee b in MyList)
            {
                Console.WriteLine("{0} {1} {2} {3}", b.Name, b.Salary, b.Role, b.StartDate.ToShortDateString());
            }

            Console.WriteLine("\n **************** \n");

            foreach (Role role in Enum.GetValues(typeof(Role)))
            {
                Console.WriteLine("Employee with the role {0}: ", role);
                foreach (Employee b in MyList)
                {
                    if (b.Role == role)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", b.Name, b.Salary, b.Role, b.StartDate.ToShortDateString());
                    }
                }
                Console.WriteLine();
            }
        }
    }
}