/*using System.Security.Cryptography.X509Certificates;

namespace week_5
{
    internal class Program
    {

        static void Swap<T>( ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

            

        }

        static T Addition<T>(  T a,   T b )
        {
            dynamic x = a;
            dynamic y = b;
            dynamic z = x + y;
            
            return z;
        }

        
        
        enum Days
        {
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        class Person
        {
            private string FirstName = "";
            private string LastName = "";

            public string getFirstName()
            {
                return FirstName;
            }

            public string getLastName()
            {
                return LastName;
            }

            public void setFirstName( string firstName )
            {
                FirstName = firstName;
            }

            public void setLastName( string lastName )
            {
                LastName = lastName;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("---------------Lecture 5---------------");
            *//*Days day = (Days)5;
            Console.WriteLine(day);
            Console.WriteLine("current day: "+ day);
            Days next_day = day + 1;
            Console.WriteLine("next day: " + next_day);

            double a = 3.44444;
            double b = 1.222222;


            Swap<double>(ref a,  ref b);

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            double x = Addition<double>(a, b);
            Console.WriteLine("x: " + x);*/

            /*Person[] people = new Person[10];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
            }

            people[0].setFirstName("Trung");
            people[0].setLastName("Trun");
            people[1].setFirstName("Tru");
            people[1].setLastName("Tr");


            int j = 1;
            foreach(Person a in people)
            {
                Console.WriteLine("{0} {1} {2}", j, a.getFirstName(), a.getLastName());
                j ++;
            }
            

            List<Person> MyList = new List<Person>();
            MyList.Add(people[0]);
            MyList.Add(people[1]);
            MyList.Remove(people[0]);
            MyList.Insert(0, people[0]);

            foreach(Person b in MyList)
            {
                Console.WriteLine("{0} {1} {2}", j, b.getFirstName(), b.getLastName());
                j++;
            }

            List<int> MyList2 = new List<int>();
            MyList2.Add(1);
            MyList2.Add(2);

            for (int i = 0;i < MyList.Count;i++)
            {
                Console.WriteLine(i);
            }*//*

            DateTime a = new DateTime();
            Console.WriteLine(a.ToLongDateString());

            DateTime b = new DateTime(1945, 9, 2);
            Console.WriteLine(b.ToLongDateString());

            DateTime c = new DateTime(1945, 9, 2, 9, 10, 0);
            Console.WriteLine(c.ToLongTimeString());

            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToLongDateString());

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToLongTimeString());

            DateTime specificDate = new DateTime(2024, 6, 10, 15, 30, 0);

            // Adding or subtracting time intervals
            DateTime futureDate = specificDate.AddYears(1).AddMonths(2).AddDays(3);
            Console.WriteLine("Future Date: " + futureDate);

            DateTime pastDate = specificDate.AddYears(-1).AddMonths(-2).AddDays(-3);
            Console.WriteLine("Past Date: " + pastDate);

            // Formatting a DateTime object as a string
            string formattedDate = specificDate.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("Formatted Date: " + formattedDate);

            // Parsing a string into a DateTime object
            string dateString = "2024-12-25 08:00:00";
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", null);
            Console.WriteLine("Parsed Date: " + parsedDate);





        }
    }
}*/