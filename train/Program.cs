/*namespace train
{
    internal class Program
    {   //find x1 and x2 when know sum and difference
        static void find_x_y(double sum, double difference)
        {
            double x1;
            double x2;

            x2 = (sum - difference) / 2;
            x1 = sum - x2;
            Console.WriteLine("We find x1 is {0} and x2 is {1}" , x1, x2);

        }
        static void Main(string[] args)
        {
            *//*double sum, difference;
            Console.WriteLine("enter Sum: ");
            sum = double.Parse(Console.ReadLine());
            Console.WriteLine("enter Difference: ");
            difference = double.Parse(Console.ReadLine());

            find_x_y(sum, difference);
            string toantu3ngoi = (sum % 2 == 0) ? "Sum is even number" : "Sum is odd number";
            Console.WriteLine(toantu3ngoi);*//*

            //switch case
            int number;
            Console.WriteLine("enter number: ");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case >= 10:
                    Console.WriteLine("number is larger than 10");
                    goto case 2;
                case 2:
                    Console.WriteLine("number is 2");
                    break;
                default:
                    Console.WriteLine("number is smaller than 10");
                    break;
            }

        }
    }
}
*/