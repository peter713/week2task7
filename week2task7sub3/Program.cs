using System;

namespace week2task7sub3
{
    class Program
    {
        static void Main(string[] args)
        {//check if number is + or -

            double myNumber;

            Console.WriteLine("Enter number, please");
            myNumber = double.Parse(Console.ReadLine());

            if (myNumber < 0)
            {
                Console.WriteLine($"{myNumber} is minus number");
            }
            else if (myNumber > 0)
            {
                Console.WriteLine($"{myNumber} is plus number");
            }
            else
            {
                Console.WriteLine($"{myNumber} is zero");
            }
            Console.ReadKey();
        }
    }
}
