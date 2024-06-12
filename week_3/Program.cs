//using System;

//namespace week_3
//{
//    internal class Program
//    {

//        class Person
//        {
//            //Data
//            public string name;
//            public int age;

//            // Constructor

//            public Person(string name, int age)
//            {
//                this.name = name;
//                this.age = age;
//            }

//            public Person()
//            {
//                Console.WriteLine("Default construct");
//            }

//            // Functionality

//            public void Prininfor()
//            {
//                Console.WriteLine("{0}: {1}", name, age);
//            }
//        }

//        class Myclass
//        {
//            private double? Z = null;
//            public double a, b;

//            public Myclass() 
//            {
//                Console.WriteLine("Enter number a: ");
//                this.a = Convert.ToDouble(Console.ReadLine());

//                Console.WriteLine("Enter number b: ");
//                this.b = Convert.ToDouble(Console.ReadLine());

//            }

//            public void Logarithm()
//            {
//                Z = Math.Log(a, b);
//            }

//            public double? getresult() { return Z; }

//            public void sum()
//            {
//                Z = a + b;
//                Console.WriteLine("Sum of {0} and {1} is {2} ", a, b, Z);
//            }

//        }

//        public static class MyMath
//        {
//            public static int sum(int a, int b)
//            {
//                return a + b;
//            }
//            public static int multiplication(int a, int b)
//            {
//                return a * b;
//            }

//        }

//        class Exercise
//        {
//            Random random = new Random();
//            int[] num_array;
//            private int min_position;
//            private int max_position;
//            int[] array_minmax_position = new int[2];

//            public Exercise()

//            {
//                this.num_array = new int[10];
//                for(int i = 0;  i < num_array.Length; i++)
//                {
//                    num_array[i] = random.Next(0, 100);
//                }


//            }

//            public void display_array()
//            {
//                for(int i = 0; i < num_array.Length; i++)
//                {
//                    Console.WriteLine("num_array[{0}]: {1}", i+ 1, num_array[i]);
//                }
                
//            }

//            public int[] find_minmax()
//            {
//                int max_value = num_array[0];
//                int min_value = num_array[0];
//                int[] array_minmax = new int[2];
                

//                for (int i = 1; i < num_array.Length; i++)
//                {
//                    if (num_array[i] > max_value)
//                    {
//                        max_value = num_array[i];
//                    }

//                    if (num_array[i] < min_value)
//                    {
//                        min_value = num_array[i];
//                    }
//                }

//                array_minmax[0] = min_value;
//                array_minmax[1] = max_value;

//                return array_minmax;
//            }

//            public void find_minmax_position()
//            {
//                int max_value = num_array[0];
//                int min_value = num_array[0];

//                for (int i = 1; i < num_array.Length; i++)
//                {
//                    if (num_array[i] > max_value)
//                    {
//                        max_value = num_array[i];
//                        this.max_position = i;
//                    }

//                    if (num_array.Length < min_value)
//                    {
//                        min_value = num_array[i];
//                        this.min_position = i;
//                    }
//                }              

   
//            }

//            public int[] get_minmax_position()
//            {
                
//                this.array_minmax_position[0] = min_position + 1;
//                this.array_minmax_position[1] = max_position + 1;
//                return array_minmax_position;
//            }







//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("------------Lecture 3-------------");
//            /*Person p1 = new Person("Trung", 20);
//            p1.Prininfor();

//            Person p2 = new Person();*/

//            /*Myclass myclass = new Myclass();
//            myclass.Logarithm();
//            Console.WriteLine("The algorithm of {0} to the base {1} is {2}", myclass.a, myclass.b, myclass.getresult());
//            myclass.sum();*/

//          /*  Console.WriteLine("Result sum: {0}", MyMath.sum(2, 2));*/

//            Exercise exercise = new Exercise();
//            exercise.display_array();

//            int[] array_minmax;
//            array_minmax = exercise.find_minmax();
//            Console.WriteLine("max value is: {0}", array_minmax[1]);
//            Console.WriteLine("min value is: {0}", array_minmax[0]);

//            exercise.find_minmax_position();

//            int[] array_minmax_position;
//            array_minmax_position = exercise.get_minmax_position();

//            Console.WriteLine("Min position is number: {0}", array_minmax_position[0]);
//            Console.WriteLine("Max position is number: {0}", array_minmax_position[1]);

//        }
//    }
//}
