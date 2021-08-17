using System;

namespace Refactor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int checkIntNumber = GenericsRefactor1.IntegerMaximumNumber(50, 60, 70);
            Console.WriteLine("The Largest Of Three Integer Number Is: "+checkIntNumber);
            double checkFloatNumber = GenericsRefactor1.FloatMaximumNumber(20.5, 30.6, 40.7);
            Console.WriteLine("The Largest Of Three Float Number Is: "+checkFloatNumber);
            string checkSringNumber = GenericsRefactor1.StringMaximumNumber("1000", "5000", "10000");
        }
    }
}
