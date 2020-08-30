using System;
using System.Reflection.Metadata;

namespace week2task7sub5
{
    class Program
    {
        static void Main(string[] args)
        {//check if age type in by user permit to canditate on presindency, prime minister, senator, member of parliament (represenative)
            string strAge;
            byte age;
            Console.WriteLine("Please type in your age or other example age");
            strAge = Console.ReadLine();
            bool isAge = byte.TryParse(strAge, out age);

            if (isAge)
            {
                if (age >= 21 && age < 30)
                {
                    Console.WriteLine("Your age gives you warranty to be canditate of the member of parliament or even prime minister");
                }
                else if (age >= 30 && age < 35)
                {
                    Console.WriteLine("Your age gives you warranty to be canditate of the member of parliament, prime minister or senator");
                }
                else if (age >= 35)
                {
                    Console.WriteLine("Your age gives you warranty to be canditate of the member of parliament, prime minister, senator or president");
                }
                else
                {
                    Console.WriteLine("Your age doesn't give you warranty to be canditate of the member of parliament, prime minister, senator or president");
                }
            }
            else
            {
                Console.WriteLine("Your input is incorrect, please try again with proper data");
            }
            
            Console.ReadKey();

        }
    }
}
