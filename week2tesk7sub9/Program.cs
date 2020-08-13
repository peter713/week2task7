using System;
using System.Threading;

namespace week2tesk7sub9
{
    class Program
    {
        static void Main(string[] args)
        {//how can ou define temprature
            Console.WriteLine("Type in temprature, the app will determine its name" );
            double tempValue = double.Parse(Console.ReadLine());

            if (tempValue < 0)
            {
                Console.WriteLine("F**king frezzing");
            }
            else if (tempValue >= 0 && tempValue < 10)
            {
                Console.WriteLine("Cold");
            }
            else if (tempValue>=10 && tempValue<20)
            {
                Console.WriteLine("Coldly - Coolly");
            }
            else if (tempValue>=20 && tempValue<30)
            {
                Console.WriteLine("I like it- it's ok");
            }
            else if (tempValue>=30 && tempValue<40)
            {
                Console.WriteLine("It's getting hot in here, not good");
            }
            else if (tempValue>=40)
            {
                Console.WriteLine("It's out of range!!! Very hot!!!");
            }

            Console.ReadKey();
        }
    }
}
