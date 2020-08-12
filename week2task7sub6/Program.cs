using System;

namespace week2task7sub6
{
    class Program
    {
        static void Main(string[] args)
        {//please enter your height and I will define 
            Console.WriteLine("Please enter you height in cm and I will deinfe");
            string strHeight = Console.ReadLine();
            bool isHeight = uint.TryParse(strHeight, out uint height);

            if (isHeight)
            {
                if (height<=160)
                {
                    Console.WriteLine($"{height}cm - hmm, it's quite short");
                }
                else if (height>160 && height<=180)
                {
                    Console.WriteLine($"Your height - {height}cm is medium");
                }
                else if (height>180 && height<=195)
                {
                    Console.WriteLine($"This height -{height}cm- looks like tall");
                }
                else if(height>195 && height<=220)
                {
                    Console.WriteLine($"{height}cm!!! Very tall!!!");
                }
                else
                {
                    Console.WriteLine($"{height}cm - are you kidding me? - Skyscraping?!");
                }
            }
            else
            {
                Console.WriteLine("Wrong data, please check your input. Then try again.");
            }
            Console.ReadKey();
        }
    }
}
