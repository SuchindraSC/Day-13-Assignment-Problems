using System;

namespace UC5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 200, 500, 800, 1000, 6000 };
            double[] floatarr = { 200.5, 306.10, 410.8, 550.85, 670.97 };
            string[] stringarr = { "100", "300", "500", "8000", "9000" };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            GenericMaximum<double> generic1 = new GenericMaximum<double>(floatarr);
            GenericMaximum<string> generic2 = new GenericMaximum<string>(stringarr);
            generic.PrintMaxValue();
            generic1.PrintMaxValue();
            generic2.PrintMaxValue();
        }
    }
}
