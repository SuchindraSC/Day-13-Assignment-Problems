using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Maximum Of Three String");

            string checkNumber = StringMaximum.StringMaximumValue("50", "60", "70");
            Console.WriteLine("\nThe Largest Of Three Number Is: "+checkNumber);
        }
    }
}
