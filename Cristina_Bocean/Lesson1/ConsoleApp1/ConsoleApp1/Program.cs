using System;
using System.Collections;

namespace ConsoleApp1
{
    public enum Medals
    {
        Bronze = 2, // 0 is default
        Silver = 6,
        Gold,
        Platinium
    }
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Hello I'm Cris");
            int i1 = 2;
            int i2 = 0; // doesn't compile if it hasn't a value assigned
            Console.WriteLine($"{i1} {i2}");
            var i3 = 5;
            Console.WriteLine($"{i1} {i2} {i3}");

            float f1 = 2.5f;
            var f2 = 3.5; // dc nu pun "f" il recunoaste ca fiind double
            Console.WriteLine($"{f1} {f2}");

            char c1 = 'd', c2 = 'E';
            Console.WriteLine($"{c1} {c1.GetTypeCode()} {c2} {c2.GetTypeCode()}");
            Console.WriteLine($"{c1} {(int)c1} {c2} {(int)c2}");

            bool b1 = true, b2 = false;
            Console.WriteLine($"{b1} {b2}");

            byte by1 = 13;
            byte by2 = 255;
            Console.WriteLine($"{by1} {by2}");
            //  byte by3 = (int)(by2 + by1);
            Medals m1 = Medals.Gold;
            Console.WriteLine($"{m1}, {(int)m1}");

            string s1 = "Hello World!";
            Console.WriteLine($"{s1}");

            // by2 = by2 + 34; // doesn't compile
            by2++; // by2 = by2+1
            by2++;
            Console.WriteLine($"{by2}");

            int ii1 = 13 / 3, ii2 = 13 % 3;
            double dd1 = 13 / 3d;
            Console.WriteLine($"{ii1}, {ii2}");
            Console.WriteLine($"{dd1}");
            double dd2 = dd1 + 34;
            Console.WriteLine($"{dd2}");

            // Console.WriteLine("Enter: ");
            // double dd3 = Console.Read();
            double dd3 = 0;
            double dd4 = 1000 / dd3;
            Console.WriteLine($"{dd4}"); // infinity displayed as question mark

            bool b11 = false;
            bool b12 = !b11;
            Console.WriteLine($"True value: {0}", b12);

            if (!b11)
            {

            }
            else
            {

            }

            //  int ii3 = 4;

            Console.WriteLine("Enter: ");
            string input = Console.ReadLine();
            int ii3 = Convert.ToInt32(input);
            if (ii3 % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"i={i}");

            }
            //while
            int j = 0;
            while (j < 1000)
            {
                Console.WriteLine($"j={j}");
                j++;
            }

            //switch

            Medals m3 = Medals.Silver;

            switch (m3)
            {
                case Medals.Gold:
                    Console.WriteLine($"Nice gold medal.");
                    break;
                case Medals.Silver:
                    Console.WriteLine($"Nice silver medal.");
                    break; //stops the case
                default:
                    Console.WriteLine($"Not interested.");
                    return; // stops the method
            }
            
            int result1 = AddTwoNumbers(4, 5);
            Console.WriteLine($"sum={result1}");

            int result2 = Sum(10);
            Console.WriteLine(result2);
            int result3 = SumIterative(10);
            Console.WriteLine(result3);

            long result4 = Factorial(3);
            Console.WriteLine(result4);

            long result5 = SumFormula(3);
            Console.WriteLine(result5);

            int[] intArr1 = new int[10];
            int[] intArr2 = new int[] { 1, 2, 4, 8, 11 };
            int[] intArr3 = { 1, 2, 4, 8, 11 };
            for (int i = 0; i < intArr2.Length; i++)
            {
                Console.WriteLine(intArr2[i]);
            }
            string[] stringArr4 = { "I", " am", " happy,", " oh", " joy!" };
            for (int i = 0; i < stringArr4.Length; i++)
            {
                Console.Write(stringArr4[i]);
            }
            Console.WriteLine();

            ArrayList arl1 = new ArrayList();
            arl1.Add(3);
            arl1.Add(4);

            for (int i = 0; i < arl1.Count; i++)
            {
                Console.Write(arl1[i]);
            }
            Console.WriteLine();

            foreach (var i in arl1) // a bit slower becaus eit has to transform it to a for
            {
                Console.WriteLine(i);
            }

            arl1.Add("jjj");
            arl1.Add(4.5f);

            for (int i = 0; i < arl1.Count; i++)
            {
                Console.Write(arl1[i]);
            }
            Console.WriteLine();
            int fiboResult = Fibonacci(11);

            Console.WriteLine(fiboResult);
            for (int i=0; i< 11; i++)
             {
                 int fiboResult1 = Fibonacci(i);
                 Console.WriteLine($"{i}:{fiboResult1}");
             }
            */


            //Homework

            //1. Given an array as input, produce the sorted array
            // do not use any built in functions like Array.Sort(). but create your own sorting implementation


            int[] unsortedArray = { 3, 2, 1, 4 };

            Console.Write("The unsorted array is: ");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write(unsortedArray[i] + " ");
            }

            int[] sortedArray = QuickSort(unsortedArray, 0, unsortedArray.Length - 1);
            Console.WriteLine();
            Console.Write("The sorted array is: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.WriteLine();

            //2. Implement Fibonacci iteratively
            //Save the homework in the consoleapp


            int fibonacciIterativeResult = FibonacciIterative(11);

            Console.WriteLine(fibonacciIterativeResult);
            for (int i = 0; i < 11; i++)
            {
                int fibonacciIterativeResult1 = FibonacciIterative(i);
                Console.WriteLine($"{i}:{fibonacciIterativeResult1}");
            }
        }
        
        public static int[] QuickSort(int[] unsortedArray, int left, int right)
        {
            int l = left;
            int r = right;
            int p = unsortedArray[(l + r) / 2];
            while (l <= r)
            {
                while (unsortedArray[l] < p)
                {
                    l++;
                }
                while (p < unsortedArray[r])
                {
                    r--;
                }
                if (l <= r)
                {
                    int temp = unsortedArray[l];
                    unsortedArray[l] = unsortedArray[r];
                    unsortedArray[r] = temp;
                    l++;
                    r--;
                }
                if (left < r)
                {
                    QuickSort(unsortedArray, left, r);
                }
                if (l < right)
                {
                    QuickSort(unsortedArray, l, right);
                }
            }
            return unsortedArray;
        }

       
        
        public static int FibonacciIterative(int n)
        /* {

                         int[] fibonacci = new int[n+2];
                         fibonacci[0] = 0;
                         fibonacci[1] = 1;            
                         for (int i = 2; i <= n; i++)
                         {
                             fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

                         }

                         return fibonacci[n];

                     }*/
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        public static int AddTwoNumbers(int a, int b)
        {
            int calculatedValue = 2 * a + b;
            return calculatedValue;
        }


        public static int Sum(int n) // not so efficient
        {
            if (n == 0)
            {
                return 0;
            }
            return n + Sum(n - 1);
        }

        public static int SumIterative(int n) // most efficient
        {
            int finalValue = 0;
            while (n >= 0)
            {
                finalValue = finalValue + n;
                n--;
            }
            return finalValue;
        }

        /* public static long Factorial (int n)
         {
             if (n == 0)
             {
                 return 1;
             }
             return n *= n - 1;
         }
        public static long Factorial(int n)
        {
            if (n == 0) // or n==1
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }*/

        public static long Factorial(int n) // most efficient
        {
            int finalValue = 1;
            while (n > 0)
            {
                finalValue *= n;
                n--;
            }
            return finalValue;
        }

        public static long SumFormula(int n)
        {
            return (n * (n + 1) / 2);
        }
    }
}
