using System;

namespace Refactor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int IntegercheckNumber = GenericMaximumRefactor2<int>.MaxValue(10, 20, 100);
            Console.WriteLine("The Largest Of Three Integer Number Is: "+IntegercheckNumber);
            double FloatCheckNumber = GenericMaximumRefactor2<double>.MaxValue(20.3, 30.5, 50.6);
            Console.WriteLine("The Largest Of Three Float Number Is: "+FloatCheckNumber);
            string StringCheckNumber = GenericMaximumRefactor2<string>.MaxValue("1000", "2000", "4000");
            Console.WriteLine("The Largest Of Three String Number: "+StringCheckNumber);
        }
    }
}
