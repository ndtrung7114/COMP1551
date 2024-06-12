/*class MonthName
{
    private int month = 1;
    public int Month
    {
        get { return month; }
        set { if ((value > 0) && (value < 13)) { month = value; } }
    }
}
static class Fun
{
    static public int sum(int x, int y) { return x + y; }

}

*//*class Vehicle

{   
    
    public int price;
    public Vehicle()
    {
        Console.WriteLine("This is a vehicle");
    }
    public void Say()
    {
        Console.WriteLine("Vehicle");
    }
}

class Car : Vehicle
{
    public Car() { Console.WriteLine("This is car"); }
    public new void Say() { Console.WriteLine("Car"); }
}

class Wave : Car
{
    public Wave(int price) {
        this.price = price;
        Console.WriteLine("This is Wave"); }
    public new void Say()
    {
        Console.WriteLine("Wave have price: {0}", price);
    }
}*//*

abstract class Animal
{
    public string name;
    public int weight;
    public int height;
    public int age;
    public Animal(string name, int weight, int height, int age)
    {
        this.name = name;
        this.weight = weight;   
        this.height = height;   
        this.age = age;
    }

    public abstract void Makesound();
}

class Cat : Animal
{
    public Cat(string name, int weight, int height, int age) : base(name, weight, height, age) { }
    public override void Makesound()
    {
        Console.WriteLine("meomeo");
    }
}


 class Vehicle
    {
        public string type;
        public int price;
        

        public Vehicle(string type, int price)
        {
            this.type = type;
            this.price = price;
            
            Console.WriteLine("Constructor of Class Vehicle");
        }
        public void display_name()
        {
            Console.WriteLine("Name class is Vehicle");
        }
        
    }

    class Honda : Vehicle
    {


        public Honda(int price) : base("motobike", price)
        {
            Console.WriteLine("Constructor of class Honda");
        }

        public new void display_name()
        {
            Console.WriteLine("Name class is Honda");
        }

    }

class Wave : Honda
{
    public string model;
    public Wave(int price, string model) : base( price)
    {
        this.model = model;
        Console.WriteLine("Constructor of class Wave");
    }
    public new void display_name()
    {
        Console.WriteLine("Name class is: {0}", this.model);
        Console.WriteLine("type: {0}", this.type);
    }
}  


        
    
    internal class Program
    {
        static void Main(string[] args)
        {
        *//*String S;
        System.Globalization.DateTimeFormatInfo Months = new System.Globalization.DateTimeFormatInfo();
        MonthName a = new MonthName();

        a.Month = -1;
        S = Convert.ToString(Months.GetMonthName(a.Month));

        Console.WriteLine("the month is: {0}", S);

    int y;
    y = Fun.sum( 3,  4);

    Console.WriteLine();*/

        /*Car car1 = new Car();
        car1.Say();
        Wave wave1 = new Wave(20);
        wave1.Say();*/
        /*Cat cat1 = new Cat("trung", 2, 2, 3);
        cat1.Makesound();*//*
        Wave wave1 = new Wave(30,"wave");
        wave1.display_name();
    }
        

    }





*/