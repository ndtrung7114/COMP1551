using System;

namespace week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int int_max = int.MaxValue; //int -> 4 byte -> 32 bits -> 214783647
            //int int_min = int.MinValue; 
            //uint uint_max = uint.MaxValue; // 4294967295
            //uint uint_min = uint.MinValue;
            //byte byte_max = byte.MaxValue; // byte -> 1 byte -> 8 bits -> 2^8 -> 0-255
            //byte byte_min = byte.MinValue;

            //Console.WriteLine("int min " + int_min);
            //Console.WriteLine("int max " + int_max);
            //Console.WriteLine("uint min " + uint_min);
            //Console.WriteLine("unit max " + uint_max);
            //Console.WriteLine("byte min " + byte_min);
            //Console.WriteLine("byte max " + byte_max);

            //var result = (double) 8 / 3; // method 1: 8/ 3.0, method 2: 8.0 /3; 
            //Console.WriteLine("data type " + result.GetType());
            //Console.WriteLine("result " + result);

            //int UserInput;
            //Console.WriteLine("enter value: ");
            //UserInput = Convert.ToInt32(Console.ReadLine());
            //if (UserInput == 0)
            //{
            //    Console.WriteLine("correct");
            //} else
            //{
            //    Console.WriteLine("wrong");
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //while (i < 4)
            //{
            //    Console.WriteLine("trung");
            //    i++;
            //}

            //int[] numbers = {5, 10, 30};
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            int length_array;
            int i = 0;
            Console.Write("please enter positive number: ");
            length_array = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[length_array];
            while (i < length_array)
            {
                int number;
                Console.Write("enter number for numbers[{0}]: ", i);
                number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
                i++;
            }

            Console.WriteLine("array before sort: ");
            foreach (int num in numbers)
            {

                Console.Write(num + " ");
            }


            Console.WriteLine(" ");

            for (int j = 0; j < length_array - 1; j++)
            {
                for (int k = j + 1; k <= length_array - 1; k++)
                {
                    if (numbers[j] > numbers[k])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[k];
                        numbers[k] = temp;
                    }

                }


            }

            Console.WriteLine("array after sort: ");
            foreach (int num in numbers)
            {

                Console.Write(num + " ");
            }



        }
    }
}
