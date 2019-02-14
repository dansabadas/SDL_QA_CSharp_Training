using System;
using System.Collections;

namespace ConsoleApp1
{
    public enum Medals
    {
        Bronze = 2,
        Silver = 6,
        Gold,
        Platinum
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Dan");
            int i1 = 2;
            System.Int32 i2 = 0;
            var i3 = 5;
            Console.WriteLine($"{i1} {i2} {i3}");

            float f1 = 2.5f;
            var f2 = 3.5;
            Console.WriteLine($"{f1} {f2}");

            char c1 = 'd', c2 = 'E';
            Console.WriteLine($"{c1} {(int)c1} {c2} {(int)c2}");

            bool b1 = true, b2 = false;
            Console.WriteLine($"{b1} {b2}");

            byte by1 = 13;
            byte by2 = 255;
            //byte by3 = by1 + by2;

            Medals m1 = Medals.Gold;
            Console.WriteLine($"{m1} {(int)m1}");

            string s1 = "Hello World!";
            Console.WriteLine(s1);

            by2++;//by2 = by2 + 1
            by2++;
            Console.WriteLine(by2);

            int ii1 = 13 / 3, ii2 = 13 % 3;
            double dd1 = 13 / 3d;
            Console.WriteLine($"{ii1} {ii2} {dd1}");

            var dd2 = dd1 + 34; // * / % - +
            Console.WriteLine($"{dd2}");

           // Console.WriteLine("Please enter a number: ");
            //double dd3 = (double)Console.Read();

            double dd3 = 0;
            double dd4 = 1000 / dd3;
            Console.WriteLine($"{dd4}");

            bool b11 = false;
            bool b12 = !b11;
            Console.WriteLine("Truth value: {0}", b12);
            if (!b11)
            {

            }
            //else
            //{
                
            //}

            int ii3 = 5;
            bool isOdd = (ii3 % 2) == 1;
            // == !=

            int ii4 = 4;
            int ii5 = 4;
            if (ii4 != ii5)
            {
                Console.WriteLine("Values are not the same");
            }

            if (isOdd)
            {
                Console.WriteLine($"{ii3} is odd");
            }
            else
            {
                Console.WriteLine($"{ii3} is even");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i={i}");
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"j: {j}");
                j++;
            }

            Medals m3 = Medals.Silver;

            switch (m3)
            {
                case Medals.Gold:
                    Console.WriteLine($"nice gold medal!");
                    break;
                case Medals.Silver:
                    Console.WriteLine($"this is my favorite metal");
                    break;
                default:
                    Console.WriteLine("I'm not interested in these!");
                    return;
            }

            int result1 = AddTwoNumbers(4, 5);
            Console.WriteLine($"result={result1}");

            int result2 = Sum(10);
            Console.WriteLine(result2);

            int result3 = SumIterative(10);
            Console.WriteLine(result3);

            int result6 = SumFormula(10);
            Console.WriteLine(result6);

            long result4 = Factorial(3);
            Console.WriteLine(result4);

            //long result5 = FactorialIterative(3);
            //Console.WriteLine(result5);

            int[] intArr1 = new int[10];
            int[] intArr2 = new int[5] { 1, 2, 4, 8, 11};
            int[] intArr3 = { 1, 2, 4, 8, 11 };
            for (int i = 0; i < intArr2.Length; i++)
            {
                Console.WriteLine(intArr2[i]);
            }

            string[] stringArr4 = { "bla", "hey", "123", "one", "two" };
            for (int i = 0; i < stringArr4.Length; i++)
            {
                Console.WriteLine(stringArr4[i]);
            }

            ArrayList arl1 = new ArrayList();
            arl1.Add(3);
            arl1.Add(4);

            foreach (object element in arl1)
            {
                Console.WriteLine(element);
            }

            arl1.Add("hello");
            arl1.Add(4.5);

            for (int i = 0; i < arl1.Count; i++)
            {
                Console.WriteLine(arl1[i]);
            }
            //homework
            //1. Homework: 1. given any array as input, produce as output the sorted array
            // (do not use built-in functions like Array.Sort() but create your own sorting
            // implementation
            //2. Implement Fibonacci iteratively
            int[] unsortedRawArray = {3, 2, 1, 45, 0};
            int[] whateverArray = MySort(unsortedRawArray);

            int fiboResult = Fibonacci(5);
            Console.WriteLine(fiboResult);

            for (int i = 0; i < 11; i++)
            {
                int fiboResult1 = Fibonacci(i);
                Console.WriteLine($" {i}: {fiboResult1}");
            }
        }

        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int[] MySort(int[] a)
        {
            //.....

            return new int[0];
        }

        public static int AddTwoNumbers(int a, int b)
        {
            int calculatedValue = 2 * a + b;

            return calculatedValue;
        }

        public static int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + Sum(n - 1);
        }

        public static int SumFormula(int n)
        {
            return (n * (n + 1)) / 2;
        }

        public static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n-1);
        }

        ////public static long FactorialIterative(int n)
        ////{
        ////    long finalResult = 1;
        ////    while (n > 0)
        ////    {
        ////        finalResult = finalResult * n;
        ////        n--;
        ////    }
        ////    return finalResult;
        ////}

        public static int SumIterative(int n)
        {
            int finalValue = 0;
            while (n >= 0)
            {
                finalValue += n;
                n--;
            }

            return finalValue;
        }
    }
}
