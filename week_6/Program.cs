using System.ComponentModel.Design;
using System.Security.Principal;
using System.Threading.Channels;

namespace week_6
{
    internal class Program
    {
        public enum Role
        {
            teacher,
            admin,
            student
        }
        class Person
        {
            private string name;
            private int telephone;
            private string email;
            private Role role;

            public Person(string name, int telephone, string email, Role role)
            {
                this.name = name;
                this.telephone = telephone;
                this.email = email;
                this.role = role;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Telephone
            {
                get { return telephone; }
                set { telephone = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public Role Role
            {
                get { return role; }
                set { role = value; }
            }

        }

        class Teacher : Person
        {
            private int salary;
            private string[] subject;

            public Teacher(string name, int telephone, string email, Role role, int salary, string[] subject) : base(name, telephone, email, role)
            {
                this.salary = salary;
                this.subject = subject;
            }

            public int Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public string[] Subject
            {
                get { return subject; }
                set { subject = value; }
            }

        }

        class Administration : Person
        {
            private int salary;
            private string work_type;
            private double working_hours;

            public Administration(string name, int telephone, string email, Role role, int salary,string work_type, double working_hours) : base(name, telephone,email, role)
            {
                this.salary = salary;
                this.work_type = work_type;
                this.working_hours = working_hours;
            }

            public int Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public string Work_type
            {
                get { return work_type; }
                set { work_type = value; }
            }

            public double Working_hours
            {
                get { return working_hours;}
                set { working_hours = value; }
            }
        }


        class Student: Person 
        {
            private string[] current_subject;
            private string[] previous_subject;

            public Student(string name, int telephone, string email, Role role, string[] current_subject, string[] previous_subject) : base(name, telephone, email, role)
            {
                this.current_subject = current_subject;
                this.previous_subject = previous_subject;
            }
        }

        static void View_specific(List<Person> list)
        {

            int role_option;
            Console.WriteLine("-----Choose your role to see-----");
            Console.WriteLine("1. Teacher");
            Console.WriteLine("2. Administration");
            Console.WriteLine("3. Student");
            Console.Write("Enter your role: ");
            role_option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("All person belong to {0} group", (Role)(role_option - 1));
            int i = 1;
            foreach (Person p in list)
            {
                if (p.Role == (Role)(role_option-1))
                {
                    Console.WriteLine("{0}. Name: {1} - Role: {2}", i, p.Name, p.Role);
                    i++;
                }
            }
            

        }

        static (string name, int telephone, string email) GetPersonDetails()
        {
            string name; int telephone; string email;
       

            Console.Write("Enter name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter telephone: ");
            telephone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter email: ");
            email = Convert.ToString(Console.ReadLine());

            return (name, telephone, email);
        }

        static void Add_data(List<Person> list)
        {

            int option;
            Console.WriteLine("---------Add a new data---------");
            Console.WriteLine("1. Teacher");
            Console.WriteLine("2. Administration");
            Console.WriteLine("3. Student");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var infor = GetPersonDetails();
                    int salary; string[] subject = new string[2];
                    Console.Write("Enter salary: ");
                    salary = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= subject.Length; i++)
                    {
                        string sub;
                        Console.Write("Enter subject{0}: ", i);
                        sub = Console.ReadLine();
                        subject[i-1] = sub;

                    }

                    Teacher teacher = new Teacher(infor.name, infor.telephone, infor.email, Role.teacher, salary, subject);
                    list.Add(teacher);
                    Console.WriteLine("Add successfully!");
                    break;

                case 2:
                    var infor_2 = GetPersonDetails();
                    int salary_2; string work_type; double work_hours;
                    Console.Write("Enter salary: ");
                    salary = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter work type: ");
                    work_type = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter work hours: ");
                    work_hours = Convert.ToDouble(Console.ReadLine());

                    Administration administration = new Administration(infor_2.name, infor_2.telephone, infor_2.email, Role.admin, salary, work_type, work_hours);
                    list.Add(administration);
                    Console.WriteLine("Add successfully!");
                    break;

                case 3:
                    var infor_3 = GetPersonDetails();
                    Console.Write("Enter Names of 2 Current Subjects (comma separated): ");
                    string[] currentSubjects = Console.ReadLine().Split(',');
                    Console.Write("Enter Names of 2 Previous Subjects (comma separated): ");
                    string[] previousSubjects = Console.ReadLine().Split(',');

                    Student student = new Student(infor_3.name, infor_3.telephone, infor_3.email, Role.student, currentSubjects, previousSubjects);
                    list.Add(student);
                    Console.WriteLine("Add successfully");
                    break;
                default:
                    Console.WriteLine("enter valid number please");
                    break ;




            }
        }

        static void Edit(List<Person> list)
        {
            Console.WriteLine("-----Edit information-----");
            View_all(list);
            int option;
            Console.Write("Enter numer person who you want to edit: ");
            option = Convert.ToInt32(Console.ReadLine());
            string new_name;
            Console.Write("Enter new name: ");
            new_name = Console.ReadLine();
            list[option - 1].Name = new_name;
            Console.WriteLine("Edit successfully");
        }

        static void Delete(List<Person> list)
        {
            Console.WriteLine("-----Delete information-----");
            View_all(list);
            int option;
            Console.Write("Enter numer person who you want to delete: ");
            option = Convert.ToInt32(Console.ReadLine());


            list.RemoveAt(option - 1);
            Console.WriteLine("Delte successfully");

        }

        static void View_all(List<Person> list)
        {
            Console.WriteLine("-----List all person-----");
            int i = 1;
            foreach (Person p in list)
            {
                
                Console.WriteLine("{0}. Name: {1} - Role: {2}", i, p.Name, p.Role);
                i++;
            }
        }

        static void Menu()
        {
            Console.WriteLine("--------------Desktop Information System--------------");
            Console.WriteLine("1. Add new data");
            Console.WriteLine("2. View all existing data");
            Console.WriteLine("3. View existing data by user group");
            Console.WriteLine("4. Edit existing data");
            Console.WriteLine("5. Delete existing data");
            Console.WriteLine("6. Exit");
        }
        static void Main(string[] args)
        {
            List<Person> list_person = new List<Person>();
            bool running = true;
            while (running)
            {
                
                Menu();
                int choose;
                Console.Write("Enter your choose: ");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Add_data(list_person);
                        break;
                    case 2:
                        View_all(list_person);
                        break;
                    case 3:
                        View_specific(list_person);
                        break;
                    case 4:
                        Edit(list_person);
                        break;
                    case 5:
                        Delete(list_person);
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Enter valid number please!");
                        break;






                }
                
                    

            }
            
        }
    }
}
