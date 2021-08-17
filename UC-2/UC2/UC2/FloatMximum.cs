using System;
using System.Collections.Generic;
using System.Text;

namespace UC2
{
    class FloatMximum
    {
        public static Double FloatMximumNumber(double firstValue, double secondValue, double thirdValue)
        {
            if(firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }

            if(secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }

            if(thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }

            throw new Exception("First Value, Second Value & Third Value Are Same");
        }
    }
}
