using System;

namespace week2task7sub10
{
    class Program
    {
        static void Main(string[] args)
        {//if you got 3 different values, is it possible to bulid the triangle if these values are the sides lenght
            Console.WriteLine("Please type in 3 lenghts of sides, this app will check if is possible to bulid the triangle using your typed in values");
            Console.WriteLine("Give your three lenghts please:");
            string strA = Console.ReadLine();
            string strB = Console.ReadLine();
            string strC = Console.ReadLine();
            bool isLenghtA = double.TryParse(strA, out double lenghtA);
            bool isLenghtB = double.TryParse(strB, out double lenghtB);
            bool isLenghtC = double.TryParse(strC, out double lenghtC);


            if (isLenghtA && isLenghtB && isLenghtB && lenghtA >0 && lenghtB>0 && lenghtC>0 )
            {
                if (lenghtA >= lenghtB && lenghtA >= lenghtC && lenghtB + lenghtC > lenghtA)
                {
                    Console.WriteLine("Using these lenghts you can build the triangle, the longest side is {0}", lenghtA);
                }
                else if (lenghtA <= lenghtB && lenghtC <= lenghtB && lenghtA + lenghtC > lenghtB)
                {
                    Console.WriteLine("Using these lenghts you can build the triangle, the longest side is {0}", lenghtB);
                }
                else

                {
                    Console.WriteLine("using these lenghts you can build the triangle, the longest side is {0}", lenghtC);
                }
            }
            else
            {
                Console.WriteLine("Your input data don't meet the terms of application, pleas type in correct values. Thank you" );
            }
           
            Console.ReadKey();
        }
    }
}
