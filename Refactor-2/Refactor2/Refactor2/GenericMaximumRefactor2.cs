using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor2
{
    class GenericMaximumRefactor2<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public GenericMaximumRefactor2(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }

        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }

            if (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0) 
            {
                return secondValue;
            }

            if (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }

            return default;
        }
    }
}
