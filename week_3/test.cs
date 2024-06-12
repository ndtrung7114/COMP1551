namespace Lecture3
{

    internal class Program
    {   

        class Student
        {
            public string name;
            public int age;
            public string school;

            public Student(string name, int age, string school)
            {
                this.name = name;
                this.age = age;
                this.school = school;
            }
        }

        public static void Menu()
        {
            Console.WriteLine("-------------Menu:------------");
            Console.WriteLine("0->add a new student");
            Console.WriteLine("1->remove a student");
            Console.WriteLine("2->print all current students");
            Console.WriteLine("3->sort students");
            Console.WriteLine("4->exit");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------------Lecture 16--------------");

            Console.Write("Enter number of students: ");
            var n = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter student  {0}: ", i);
                var input = Console.ReadLine().Split(" ");
                string name = input[0];
                int age = int.Parse(input[1]);
                string school = input[2];

                Student student = new Student(name, age, school);
                students.Add(student);
            }

            bool finish = false;
            Menu();

            while (finish != true)
            {
                Console.Write("\nEnter your option (0-3): ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Enter a new student: ");
                        var input = Console.ReadLine().Split(" ");
                        string name = input[0];
                        int age = int.Parse(input[1]);
                        string school = input[2];

                        Student student = new Student(name, age, school);
                        students.Add(student);
                        break;

                    case 1:
                        Console.WriteLine("Enter student position where you want to remove: ");
                        int pos = int.Parse(Console.ReadLine());
                        students.RemoveAt(pos);
                        Console.WriteLine("remove successfully");
                        break;
                    case 2:
                        Console.WriteLine("\nInfo of all students: ");

                        foreach (Student stu in students)
                        {
                            Console.Write("name: " + stu.name + "; ");
                            Console.Write("age: " + stu.age + "; ");
                            Console.Write("school: " + stu.school + "; ");
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        var students_sorted = students.OrderBy(p => p.name).ThenBy(p => p.age).ToList();
                        Console.WriteLine("\nInfo of all students after sorting: ");
                        foreach (Student stu in students_sorted)
                        {
                            Console.Write("name: " + stu.name + " ");
                            Console.Write("age: " + stu.age + " ");
                            Console.Write("school: " + stu.school + " ");
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("Please only enter a number from 0 to 4");
                        Menu();
                        break;
                }
            }
        }
    }
}