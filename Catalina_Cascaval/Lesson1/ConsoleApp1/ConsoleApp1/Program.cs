using System;
using System.Collections;

namespace ConsoleApp1
{
    public enum Medals
    {
        Bronze = 2,
        Silver,
        Gold,
        Platinum
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 0;
            var i3 = 5;
            float i4 = 2.5f;
            var f2 = 2.5f;
            char c1 = 'd'; char c2 = 'E';
            bool b1 = true, b2 = false;
            byte by1 = 13;
            byte by2 = 255;
            Medals m1 = Medals.Gold;
            string s1 = "Hello world!";
            by2++; //b2= b2+1
            by2++;
            int ii1 = 13 / 3, ii2 = 13 % 3;
            double dd1 = 13 / 3d;
            double dd2 = dd1 + 34;

            Console.WriteLine("please enter a number: ");
            //double dd3 = Console.Read();
            // double dd4 = 1000 / dd3;

            bool b11 = true;
            bool b12 = !b11;
            Console.WriteLine("Truth value: {0}", b12);
            if (b11)
            {

            }

            //else
            //{

            //}

            bool isOdd = true;
            int ii3 = 4;
            if (ii3 % 2 == 0)
                Console.WriteLine(isOdd);
            else
                Console.WriteLine(!isOdd);




            Console.WriteLine("Hello I'm Catalina");
            Console.WriteLine($"{i1} {i2} {i3} ");
            Console.WriteLine($"{i4}");
            Console.WriteLine($"{c1} {(int)c1} {c2} {(int)c2}");
            Console.WriteLine($"{b1} {b2}");
            Console.WriteLine($"{m1} {(int)m1}");
            Console.WriteLine(s1);
            Console.WriteLine(by2);
            Console.WriteLine($"{ii1} {ii2} {dd1}");
            Console.WriteLine($"{dd2}");
            //  Console.WriteLine($"{dd4}");

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"i={i}");

            }

            int j = 0;
            while (j < 1000) ;
            {
                Console.WriteLine($"j:{j}");
                j++;
            }

            Medals m3 = Medals.Silver;
            switch (m3)
            {
                case Medals.Gold:
                    Console.WriteLine("Nice gold medal");
                    break;

                case Medals.Silver:
                    Console.WriteLine("This is my favourite metal");
                    break;

                default:
                    Console.WriteLine("I'm not interested in these");
                    return;

            }

            int result1 = AddTwoNumbers(4, 5);
            Console.WriteLine($"result={result1}");
            // int result2 = Sum(10);
            //Console.WriteLine(result2);
            int result3 = SumIterative(10);
            Console.WriteLine(result3);

            int[] intArr1 = new int[10];
            int[] intArr2 = new int[5] { 1, 2, 4, 8, 11 };

            for (int i = 0; i < intArr2.Length; i++)
            {
                Console.WriteLine(intArr2[i]);
            }

            string[] stringArr4 = { "bla", "hey", "123", "one", "two" };

            for (int i = 0; i < stringArr4.Length; i++)
            {
                Console.WriteLine(stringArr4[i]);
            }

            ArrayList arr11 = new ArrayList();
            arr11.Add(3);
            arr11.Add(4);

            foreach (object element in arr11) ;
            Console.WriteLine(arr11);

            arr11.Add("hello");
            arr11.Add(4.5);

            for (int i = 0; i < arr11.Count; i++)
            {
                Console.WriteLine(arr11[i]);
            }


        }
        public static int AddTwoNumbers(int a, int b)
        {
            int calculatedValue = 2 * a + b;

            return calculatedValue;
        }

        //public static int Sum (int n)
        //{
        //    if (n==0)
        //    {
        //        return 0;
        //    }
        //    return n + Sum(n - 1);
        //}

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
            long finalResult = 1;
            while (n > 0)
            {
                finalResult = finalResult * n;
                n--;
            }

            return finalResult;
        }

        public static int SumIterative(int n)
        {
            int finalValue = 0;
            while (n >= 0)
            {
                finalValue = finalValue + n;
                n--;
            }
            return finalValue;
        }

        public static int SumFormula(int n)
        {
            return n * (n + 1) / 2;
        }



        //Homework: 1. given any array as insput, produce as output the sorted array (do not use built-in functions like array.sort() but create your own implementation
        //           2. make the Fibonacci function itterated   (implement Fibonacci function intterative) 

        //        int unsortedArray = { 3, 2, 1, 45, 0 };
        //        int[] whateverArray = MySort(unsortedArray);
        //        int fiboResult = Fibonacci(5);
        //        Console.WriteLine (fiboResult);

        //            for (int =0; i<11; i++)
        //            {
        //               int fiboResult1 = Fbonacci(i);
        //        Console.WriteLine($"{i}:{fiboResult1}");

        //        public static int Fibonacci (int n)
        //        {
        //            if (n == 0 || n == 1)
        //            {
        //                return 1;
        //            }
        //            return Fibonacci(n - 1) + Fibonacci(n - 2);
        //        }

        //        public static int[] (int[] a)
        //            {
        //            //...

        //        return new int[0];
        //            }

        //    }
    }
}
//}
