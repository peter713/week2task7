using System;

namespace week2task7sub7
{
    class Program
    {
        static void Main(string[] args)
        {//app will point max from typed in numbers
            Console.WriteLine("Type in 3 numbers:" );
            double firstNo, secondNo, thirdNo;
            firstNo = double.Parse(Console.ReadLine());
            secondNo = double.Parse(Console.ReadLine());
            thirdNo = double.Parse(Console.ReadLine());

            if (firstNo <= thirdNo && secondNo <= thirdNo)
            {
                Console.WriteLine($"{thirdNo} is the biggest from typed in numbers");
            }
            else if (firstNo>=secondNo && firstNo>=thirdNo)
            {
                Console.WriteLine($"{firstNo} is the biggest from typed in numbers");
            }
            else if (secondNo>=firstNo && secondNo>=thirdNo)
            {
                Console.WriteLine($"{secondNo} is the biggest from typed in numbers");
            }

            Console.ReadKey();
        }
    }
}
