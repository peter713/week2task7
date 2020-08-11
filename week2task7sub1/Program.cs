using System;

namespace week2task7sub1
{
    class Program
    {
        static void Main(string[] args)
        {//check if two typed in numbers are equal

            Console.WriteLine("Type in two numbers, please");
            int firstNo=0;
            string firstNumber = Console.ReadLine();

            int seconNo;
            string secondNumber = Console.ReadLine();

            if (int.TryParse(firstNumber, out firstNo) && int.TryParse(secondNumber, out seconNo)) 
            {
                if (firstNo==seconNo)
                {
                    Console.WriteLine($"{firstNo} and {seconNo} are equal");
                }
                else
                {
                    Console.WriteLine($"{firstNo} and {seconNo} are unequal");
                }
            }
            else
            {
                Console.WriteLine("Your input data isn't correct data type. Please restard program and type in proper data.");
            }

            Console.ReadKey();
        }
    }
}
