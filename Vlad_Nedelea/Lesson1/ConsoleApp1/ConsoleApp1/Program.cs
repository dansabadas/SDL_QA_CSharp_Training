using System;
using System.Collections;
using ConsoleApp2;

namespace ConsoleApp1
{
    class Program
    {
        public enum Medals
        {
            gold,
            silver
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm vLAFD");

            var i3 = 7;
            float f1 = 2.4f;

            Console.WriteLine(value: $"{i3 } {f1}");


            char c1 = 'b';

            bool b1 = true;


            byte by2 = 10;
            by2++;
            string s1 = "hello";

            int ii1 = 13 / 3;
            double dd1 = 13 / 3d;
            var dd2 = dd1 + 23;

            double dd3 = 0;

            double dd4 = 1000 / dd3;

            bool b11 = true;
            int ii3 = 4;

            if (ii3 % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }



            Medals m3 = Medals.gold;
            switch (m3)
            {
                case Medals.gold:
                    Console.WriteLine("gold");
                    break;
                case Medals.silver:
                    Console.WriteLine("silver");

                    break;
            }

            int result1 = AddNumbers(4, 5);

            Console.WriteLine(result1);





            int n = 10;

            Console.WriteLine(Sum(n));

            Console.WriteLine(FactorialIterative(3));

            //  Console.WriteLine( $"{(int)c1},{b1}, {by2}, {s1}, {ii1}, {dd1}, {dd2}, {dd4}");

            Console.WriteLine(Factorial(3));

            int[] array1 = new int[10];
            int[] array2 = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < array2.Length; i++) Console.WriteLine(array2[i]);

            string[] stringArray1 = new string[10];
            string[] stringArray2 = new string[5] { "aaa", "grg", "jjj", "rgr", "rgr" };

            for (int i = 0; i < stringArray2.Length; i++) Console.WriteLine(stringArray2[i]);

            ArrayList arls = new ArrayList();
            arls.Add(3);
            arls.Add(4);
            arls.Add(78);


            // foreach (object element in arls) Console.WriteLine(element);

            arls.Add("fg");
            arls.Add(4.6);
            arls.Add(78);

            for (int i = 0; i < 6; i++) Console.WriteLine(arls[i]);

            //homework
            // 1. sorted array
            // 2. fibonacci iterative

            Console.WriteLine(Fibonacci(5));

            for (int i = 0; i < 11; i++)
            {
                

                Console.WriteLine(Fibonacci(i));

            }
                Console.ReadKey();

        }

        public static int AddNumbers(int a, int b)
        {
            int calculate = a + b;
            return calculate;
        }

        public static int Sum(int n)
        {
            if (n == 0) return 0;

            return n + Sum(n - 1);
        }

        public static long Factorial(int n)
        {
            if ((n == 1) || (n == 0)) return 1;

            return n * Factorial(n - 1);

        }

        public static long FactorialIterative(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;

            }

            return result;
        }

        public static int SumFormula(int n)
        {

            return (n * (n + 1)) / 2;
        }

        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
