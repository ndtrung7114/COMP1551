using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    internal class lab1
    {
        //squareroot function
        static double SquareRoot(double x)
        {
            return(Math.Sqrt(x));
        }

        //aquadratic function
        static void quadratic(double a, double b, double c)
        {
            if (a == 0 && b != 0) {
                double x = -c / b;
                Console.WriteLine("function have only one result is: " + x);
            } else if (a == 0 && b == 0)
            {
                Console.WriteLine("can not divided by 0");
            }
            else
            {
                double discriminant = (b * b) - (4 * a * c);
                if (discriminant > 0)
                {
                    double x1 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);

                    Console.WriteLine("function have two reseult are {0:F2} and {1:F2}", x1, x2);
                }
                
                 else if (discriminant == 0) {
                    double x1 = -b / (2 * a);
                    double x2 = x1;
                    Console.WriteLine("function dont have only one result is: " + x1);
                } else if (discriminant < 0)
                {
                    Console.WriteLine("function dont have any result");
                    
                }
            }

        }
        static void Main(string[] args)
        {
            /* double num1;
            
            Console.WriteLine("Enter number to calculate squareroot: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            if (num1 >= 0)
            {
                double result = SquareRoot(num1);
                Console.WriteLine("result squareroot of {0} is {1}: ", num1, result);
            } else
            {
                Console.WriteLine("Negative number can not calculate squareroot");
            } 
            */

            double a;
            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());
            double b;
            Console.WriteLine("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            Console.WriteLine("Enter c: ");
            c = Convert.ToDouble(Console.ReadLine());


            quadratic(a, b, c);





        }
    }
}
