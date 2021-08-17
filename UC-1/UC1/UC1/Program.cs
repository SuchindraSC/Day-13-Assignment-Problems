using System;

namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Integer Maximum Number");

            int CheckNumber1 = IntegerMaximum.IntegerMaximumNumber(70, 50, 60);
            Console.WriteLine("\nLargest of The Three Number Is: "+CheckNumber1);

            int CheckNumber2 = IntegerMaximum.IntegerMaximumNumber(100, 500, 300);
            Console.WriteLine("\nLargest of The Three Number Is: " + CheckNumber2);

            int CheckNumber3 = IntegerMaximum.IntegerMaximumNumber(1000, 3000, 7000);
            Console.WriteLine("\nLargest of The Three Number Is: " + CheckNumber3);
        }
    }
}
