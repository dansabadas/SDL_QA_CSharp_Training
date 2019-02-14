using System;
using System.Collections;

namespace ConsoleApp1
{
    public enum Metals
    {
        Bronze = 2,
        Silver = 6,
        Gold,
        Platinum,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(value: "Hello I'm Alin");
            int i1 = 2;
            System.Int32 i2 = 0;
            var i3 = 5;
            Console.WriteLine(value: $"{i1} {i2} {i3}");

            float f1 = 2.5f;
            var f2 = 3.5;
            Console.WriteLine($"{f1} {f2}");

            char c1 = 'd', c2 = 'E';
            Console.WriteLine(value: $"{c1} {(int)c1} {c2} {(int)c2}");

            bool b1 = true, b2 = false;
            Console.WriteLine($"{ b1}, { b2}");

            byte by1 = 13, by2 = 255;
            //byte by3 = by2 + by1;
            Console.WriteLine($"{ by1}, { by2}");

            var m1 = Metals.Gold;
            Console.WriteLine($"{m1} {(int)m1}");

            string s1 = "Hello World!";
            Console.WriteLine(s1);

            by2++;//by2 = by2 + 1
            by2++;
            Console.WriteLine(by2);

            int ii1 = 13 / 3, ii2 = 13 % 3;
            double dd1 = 13 / 3d;
            Console.WriteLine($"{ii1}, {ii2}, {dd1}");

            var dd2 = dd1 + 34;
            Console.WriteLine(dd2);

            Console.WriteLine("Please enter a number");
            //double dd3 = Convert.ToDouble(Console.ReadLine());
            double dd3 = 0;
            double dd4 = 1000 / dd3;
            Console.WriteLine(dd4);

            bool b11 = false;
            bool b12 = !b11;
            Console.WriteLine("Truth value: {0}", b12);
            if (!b11)
            {

            }

            int ii3 = 5;
            bool isOdd = (ii3 % 2) == 1;
            //if ((ii3 % 2) == 0)
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);

            if (isOdd)
                Console.WriteLine(value: $"{ii3} is odd");
            else
                Console.WriteLine(value: $"{ii3} is even");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(value: $"i = {i}");
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(value: $"j = {j}");
                j++;
            }

            Metals m3 = Metals.Silver;
            switch (m3)
            {
                case Metals.Gold:
                    Console.WriteLine(value: $"nice gold medal!");
                    break;
                case Metals.Silver:
                    Console.WriteLine(value: $"this is my favorite metal");
                    break;
                default:
                    Console.WriteLine(value: $"I'm not interested in these!");
                    return;
            }

            var result1 = AddTwoNumbers(a: 4, b: 5);
            Console.WriteLine(value: $"result = {result1}");

            int result2 = Sum(n: 15);
            Console.WriteLine(result2);
            int result3 = SumIterative(n: 15);
            Console.WriteLine(result3);
            int result4 = SumFormula(15);
            Console.WriteLine(result4);

            var result5 = Factorial(5);
            Console.WriteLine(result5);
            var result6 = FactorialIterative(5);
            Console.WriteLine(result6);

            int[] inArr1 = new int[10];
            int[] inArr2 = new int[5] { 1, 2, 4, 8, 11 };
            for (int i = 0; i < inArr2.Length; i++)
            {
                Console.WriteLine(inArr2[i]);
            }

            string[] stringArr4 = { "bla", "hey", "123", "one", "two" };
            for (int i = 0; i < stringArr4.Length; i++)
            {
                Console.WriteLine(stringArr4[i]);
            }

            ArrayList arl1 = new ArrayList();
            arl1.Add(value: 3);
            arl1.Add(value: 4);
            foreach (object n in arl1)
            {
                Console.WriteLine(n);
            }

            arl1.Add("hello");
            arl1.Add(4.5);

            for (int i = 0; i < arl1.Count; i++)
            {
                Console.WriteLine(arl1[i]);
            }

            // HOMEWORK
            // 1. Homework: 1. given any array as input, produce as output the sorted array
            // (do nout use build-in functions like Array.Sort() but create your own sorting implementation
            // 2. Implement Fibonacci function iterative
            int[] unsortedRawArray = { 3, 2, 1, 45, 0 };
            int[] whaterverArray = MySort(unsortedRawArray);


            int fiboResult = Fibonacci(5);
            Console.WriteLine(fiboResult);
            Console.Read();
        }

        public static int[] MySort(int[] a)
        {

            return new int[0];
        }

        public static int AddTwoNumbers(int a, int b)
        {
            int sum = 2 * a + b;
            return sum;
        }

        public static int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + Sum(n: n - 1);
        }

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

        public static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public static long FactorialIterative(int n)
        {
            long result = 0;
            if (n == 0)
                return 1;
            while (n > 0)
            {
                result = n * (n - 1);
            }
            return result;
        }

        public static int SumFormula(int n)
        {
            return (n * (n + 1) / 2);
        }

        public static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
