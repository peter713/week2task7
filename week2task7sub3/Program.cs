using System;

namespace week2task7sub3
{
    class Program
    {
        static void Main(string[] args)
        {//check if number is + or -
            Console.WriteLine("Enter number, please");
            string strNum = Console.ReadLine();
            bool isNum = double.TryParse(strNum, out double myNumber);

            if (isNum)
            {
                if (myNumber < 0)
                {
                    Console.WriteLine($"{myNumber} is minus number");
                }
                else if (myNumber > 0)
                {
                    Console.WriteLine($"{myNumber} is plus number");
                }
                else if (myNumber == 0)
                {
                    Console.WriteLine($"{myNumber} is zero");
                }
            }
            else
            {
                Console.WriteLine("Please check if your input is correct, then run app again.");
            } 
            Console.ReadKey();
        }
    }
}
