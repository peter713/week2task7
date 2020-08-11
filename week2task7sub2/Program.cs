using System;

namespace week2task7sub2
{
    class Program
    {
        static void Main(string[] args)
        {//check if entered number is odd or even

            Console.WriteLine("If you want to check, if number is even or odd, please type in this number");
            string myString = Console.ReadLine();

            int myNumber;
            bool isNumerical = int.TryParse(myString, out myNumber);

            if (isNumerical)
            {
                if (myNumber % 2 == 0)
                {
                    Console.WriteLine($"{myNumber} is even");
                }
                else
                {
                    Console.WriteLine($"{myNumber} is odd");
                }
            }
            else
            {
                Console.WriteLine("No possibility to check if this data is even or odd, please launch app again and type in correct data.");
            }

            Console.ReadKey();
        }
    }
}
