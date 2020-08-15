using System;

namespace week2task7sub12
{
    class Program
    {
        static void Main(string[] args)
        {//give app the number and will receive name of the week in PL language
            string result = "";
            Console.WriteLine("Type in number from 1 to 7 and you will receive name of the week in PL language");
            string strDayNo = Console.ReadLine();
            bool isNumDay = byte.TryParse(strDayNo, out byte dayNo);
            
            if (isNumDay)
            {
                    result = dayNo  switch
                {
                    1=> "Poniedziałek",
                    2=> "Wtorek",
                    3 => "Środa",
                    4 => "Czwartek",
                    5 => "Piątek",
                    6 => "Sobota",
                    7 => "Niedziela",
                    _ => "Your input is out of range. Please close app and tehn lanuch it again and type in coorect value."
                };
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please check if your input data type relate to correct type or your value is from correct range. Close app then lanuch it again with proper data.");
            }
            Console.ReadKey();
        }

    }
}
