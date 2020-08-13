using System;

namespace week2task7sub8
{
    class Program
    {
        static void Main(string[] args)
        {//check specific criteria of participating in recruitment         
         //result=180<che+mat+phy or mat+che>resultTwo=150 or mat+phy>resultTwo=150

            double resultTwo = 150; 
            double resultThree= 180;
            Console.WriteLine("Give me results that canditate achieved in:\r\nmathematics:");
            double mathScore = double.Parse(Console.ReadLine());
            Console.WriteLine("chemistry:");
            double chemScore = double.Parse(Console.ReadLine());
            Console.WriteLine("physics:");
            double phyScore = double.Parse(Console.ReadLine());


            if (mathScore+chemScore+phyScore>resultThree || mathScore+chemScore>resultTwo || mathScore+phyScore>resultTwo)
            {
                Console.WriteLine("Candidate is allowed to participate in recruitment");
            }
            else
            {
                Console.WriteLine("Candidate results doesn't allow him to participate in recruitment");
            }
            Console.ReadKey();
        }
    }
}
