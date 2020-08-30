using System;

namespace week2task7sub11
{
    class Program
    {
        static void Main(string[] args)
        {//type in your mark- the app is respond you equivalent name
            Console.WriteLine("Please give me you mark and you will receive in the screen name of mark in PL language");
            string strMark = Console.ReadLine();
            bool isMark = byte.TryParse(strMark, out byte mark);
            
            if (!isMark || mark>=7)
            {
                Console.WriteLine("This data isn't from correct range. Please type in correct data");
            }
            else
            {
                switch (mark)
                {
                    case 1:
                        Console.WriteLine("Niedostateczny");
                        break;

                    case 2:
                        Console.WriteLine("Dopuszczający");
                        break;

                    case 3:
                        Console.WriteLine("Dostateczny");
                        break;

                    case 4:
                        Console.WriteLine("Dobry");
                        break;

                    case 5:
                        Console.WriteLine("Bradzo dobry");
                        break;

                    case 6:
                        Console.WriteLine("Celujący");
                        break;  
                }
              
            }
            Console.ReadKey();
        }
    }
}
