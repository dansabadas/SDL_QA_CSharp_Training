using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Fibonacii
    {
        public long ManualFibonacii(int n)
        {
            long[] arrayOfFibonaciNumbers = new long[n];
            arrayOfFibonaciNumbers[0] = 0;
            arrayOfFibonaciNumbers[1] = 1;
            for (int i = 2; i < n; i++)
            {
                arrayOfFibonaciNumbers[i] = arrayOfFibonaciNumbers[i - 1] + arrayOfFibonaciNumbers[i - 2];
            }

            return arrayOfFibonaciNumbers[arrayOfFibonaciNumbers.Length - 1];
        }

        public long ManualFibonacii2(int n)
        {
            long smallValue = 0;
            long largeValue = 1;
            long result = 0;

            for (var i = 0; i < n - 2; i++)
            {
                result = largeValue + smallValue;
                smallValue = largeValue;
                largeValue = result;

            }

            return result;
        }
    }
}
