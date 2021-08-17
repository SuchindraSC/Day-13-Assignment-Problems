using System;
using System.Collections.Generic;
using System.Text;

namespace UC4
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue, fourthValue;
        public GenericMaximum(T firstValue, T secondValue, T thirdValue, T fourthValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
            this.fourthValue = fourthValue;
        }

        public static T MaxValue(T firstValue, T secondValue, T thirdValue, T fourthValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0 && firstValue.CompareTo(fourthValue) >= 0)
            {
                return firstValue;
            }

            if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(fourthValue) >= 0)
            {
                return secondValue;
            }

            if (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0 && thirdValue.CompareTo(fourthValue) >= 0)
            {
                return thirdValue;
            }

            if (fourthValue.CompareTo(firstValue) >= 0 && fourthValue.CompareTo(secondValue) >= 0 && fourthValue.CompareTo(thirdValue) >= 0)
            {
                return fourthValue;
            }

            return default;
        }
    }
}
