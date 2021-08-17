using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Of 3 Float Values");

            double checkNumber = FloatMximum.FloatMximumNumber(50.3, 50.6, 50.8);
            Console.WriteLine("\nThe Largest Of 3 Float Number Is "+checkNumber);
        }
    }
}
