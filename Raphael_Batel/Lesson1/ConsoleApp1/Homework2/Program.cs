using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_FibonacciIterative
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 91; i++)
            {
                Console.WriteLine($"{i}: {FibonacciIterative(i)}");
            }
        }

        public static long FibonacciIterative(int n)
        {
            //for 92 an overflow of long occcurs
            const int maxSupportedN = 91;

            if (n < 0 || n > maxSupportedN)
                throw new ArgumentOutOfRangeException(nameof(n), n, $"Values supported for n are between 0 and {maxSupportedN}.");


            long nthFibonacci = 1;
            long secondLastFibonacci = 1;
            long lastFinacci = 1;

            int currentN = 2;
            while (currentN <= n)
            {
                nthFibonacci = secondLastFibonacci + lastFinacci;
                currentN++;
                secondLastFibonacci = lastFinacci;
                lastFinacci = nthFibonacci;
            }
            return nthFibonacci;
        }
    }
}
