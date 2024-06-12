/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    
    internal class generic
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int L = 5; 
            int R = 10;
            Console.WriteLine("1. Left: {0}, Right: {1}", L, R);
            Swap<int>(ref L, ref R);
            Console.WriteLine("2. Left: {0}, Right: {1}", L, R);

            string First = "first"; 
            string Second = "second";
            Console.WriteLine("1. Left: {0}, Right: {1}", First, Second);
            Swap<string>(ref First, ref Second);
            Console.WriteLine("2. Left: {0}, Right: {1}", First, Second);


        }
    }
}
*/