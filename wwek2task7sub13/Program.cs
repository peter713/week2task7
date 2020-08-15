using System;

namespace wwek2task7sub13
{
    class Program
    {
        static void Main(string[] args)
        {//some breif of calculator app
            Console.WriteLine("Please type in two numbers, then choose mathematic operation and you will get the result");
            Console.WriteLine("Give your first number");
            string strFristNo = Console.ReadLine();
            bool isFirstNo = double.TryParse(strFristNo, out double firstNo);

            if (!isFirstNo)
            {
                goto BadInput;
            }


            Console.WriteLine("Give your second number");
            string strSecondNo = Console.ReadLine();
            bool isSecondNo = double.TryParse(strSecondNo, out double secondNo);

            if (!isSecondNo)
            {
                goto BadInput;
            }

            Console.WriteLine("\r\nChoose mathematic operation, type in relevant nubmer for:");
            Console.WriteLine("1 -Adding \r\n2 -Subtraction\r\n3 -Multiplication \r\n4- Division");
            Console.Write("Your choice is: ");
            string strNum = Console.ReadLine();
            bool isNumerical = byte.TryParse(strNum, out byte userNumber);

            Console.WriteLine();
            if (isNumerical)
            {
                switch (userNumber)
                {
                    case 1:
                        Console.WriteLine($"Your result for Adding {firstNo}+{secondNo} = " + (firstNo + secondNo));
                        break;

                    case 2:
                        Console.WriteLine("Your result for Subtraction : {0}", firstNo - secondNo);
                        break;

                    case 3:
                        Console.WriteLine("Your result for Multiplication : {0}", (firstNo * secondNo));
                        break;

                    case 4:
                        if (secondNo == 0)
                        {
                            Console.WriteLine("You can't divide by 0"); ;
                        }
                        else
                        {
                            Console.WriteLine($"Your result for Division  {firstNo}:{secondNo} = " + (firstNo / secondNo));
                        }
                        break;

                    default:
                        goto BadInput;
                }
                goto Finish;
            }

        BadInput:
            Console.WriteLine("Your input is out of range, please check and try again");
            Console.ReadKey();
            Environment.Exit(0);

        Finish:
            Console.ReadKey();
        }
    }
}
