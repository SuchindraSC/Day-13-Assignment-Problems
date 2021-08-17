using System;
using System.Collections.Generic;
using System.Text;

namespace UC3
{
    class StringMaximum
    {
        public static string StringMaximumValue(string firstValue, string secondValue, string thirdValue)
        {
            if(firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }

            if(secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }

            if(thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(thirdValue) >= 0)
            {
                return thirdValue;
            }

            throw new Exception("First Value, Second Value & Third Value Are Same");
        }
    }
}
