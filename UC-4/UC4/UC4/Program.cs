using System;

namespace UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            int IntegercheckNumber = GenericMaximum<int>.MaxValue(10, 20, 100, 400);
            Console.WriteLine("The Largest Of Three Integer Number Is: " + IntegercheckNumber);
            double FloatCheckNumber = GenericMaximum<double>.MaxValue(20.3, 30.5, 50.6, 65.95);
            Console.WriteLine("The Largest Of Three Float Number Is: " + FloatCheckNumber);
            string StringCheckNumber = GenericMaximum<string>.MaxValue("1000", "2000", "4000", "8000");
            Console.WriteLine("The Largest Of Three String Number: " + StringCheckNumber);
        }
    }
}
