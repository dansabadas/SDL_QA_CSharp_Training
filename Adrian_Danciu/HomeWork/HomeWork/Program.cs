using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework: 1. given any array as input, produce as output the sorted array 
            //(do not use built-in functions like Array.Sort() but create your own sorting implementation

            int[] unsortedRawArray = { 3, 2, 1, 45, 0 };
            int[] sorted = MySort(unsortedRawArray);

            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i] + " ");
            }
            Console.WriteLine();

            //Homework: 2.Implement Fibonacci iteratively, not recursively
            int fiboResult = Fibonacci(5);

            Console.WriteLine(fiboResult);
                                        
        }

        public static int[] MySort (int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                int temp;

                for (int j = i;  j < unsorted.Length; j++)
                {
                    if (unsorted[j] < unsorted[i])
                    {
                        temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }

            return unsorted;
        }

        public static int Fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            int b = 0;
            int a = 1;
            int i = 2;
            int currentValue = a + b;
            while(i<=n)
            {
                int temp1 = a;
                int temp2 = currentValue;
                currentValue = currentValue + a;
                a = temp2;
                b = temp1;

                i++;
            }
            return currentValue;
        }

    }
}
