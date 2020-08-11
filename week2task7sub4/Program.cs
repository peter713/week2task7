using System;

namespace week2task7sub4
{
    class Program
    {
        static void Main(string[] args)
        {//type in year I will answer you, if it is leap year

            Console.WriteLine("Type in year I will answer you, if it is leap year");

            string strYear = Console.ReadLine();
            bool isNum = int.TryParse(strYear, out int intYear);

            if (isNum && intYear >= 0)
            {
                if (intYear % 4 == 0)
                {
                    Console.WriteLine($"{intYear} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{intYear} isn't a leap year");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong, please try again.");
            }
            Console.ReadKey();
        }
    }
}
