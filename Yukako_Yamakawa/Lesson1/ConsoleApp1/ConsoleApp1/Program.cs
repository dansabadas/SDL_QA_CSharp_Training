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
            Console.WriteLine("Hello I'm Yukako Yamakawa now");
            int i1 = 2;
            System.Int32 i2 = 0;
            var i3 = 5;
            Console.WriteLine(value: $"{i1} {i2} {i3}");

            float f1 = 2.5f;
            var f2 = 3.5;
            Console.WriteLine(value: $"{f1} {f2}");

            char c1 = 'd', c2 = 'E';
            Console.WriteLine(value: $"{c1} {(int)c1} {c2} {(int)c2}");

            bool b1 = true, b2 = false;
            Console.WriteLine(value: $"{b1} {b2}");

            byte by1 = 13;
            byte by2 = 255;
            //byte by3 = by1 + by2;

            Medals m1 = Medals.Gold;
            Console.WriteLine(value: $"{m1} {(int)m1}");

            string s1 = "Hello World!!";
            Console.WriteLine(s1);

            by2++;//meaning: by2 = by2 + 1
            by2++;
            Console.WriteLine(by2);

            int ii1 = 13 / 3, ii2 = 13 % 3;
            double dd1 = 13 / 3d; //adding d to the devision for 3 the dd1 shows correct non-round up number 
            Console.WriteLine(value: $"{ii1} {ii2} {dd1}");

            var dd2 = dd1 + 34;
            Console.WriteLine(value: $"{dd2}");

            //Console.WriteLine(value: $"Please enter a number");
            //double dd3 = (double)Console.Read();
            //double dd3 = Convert.ToDouble(Console.ReadLine()); this is from Alin

            double dd3 = 0;
            double dd4 = 1000 / dd3;
            Console.WriteLine(value: $"{dd4}");

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

            int ii4 = 4;
            int ii5 = 5;
            if (ii4 != ii5)
            {
                Console.WriteLine(value: "Values are not equal");
            }


            if (isOdd)
            {
                Console.WriteLine(value: $"{ii3} is odd");

                Console.WriteLine(value: $"{ii3} is even");
            }

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(value: $"i={i}");  //iterations for the value
            }

            int j = 0;
            while (j < 50) //up to the number put after <
            {
                Console.WriteLine(value: $"j: {j}");  //iteration for the value
                j++;
            }

            Medals m3 = Medals.Silver; //question - is silver m3?

            switch (m3)
            {
                case Medals.Gold:
                    Console.WriteLine(value: $"This is Gold!!");
                    break;
                case Medals.Silver:
                    Console.WriteLine(value: $"Great runnerup!");
                    break;
                default:
                    Console.WriteLine(value: $"No to mention!");
                    return;
            }

            int result1 = AddTwoNumbers(a: 4, b: 5);
            Console.WriteLine(value: $"result={result1}");

            int result2 = Sum(n: 10);
            Console.WriteLine(result2);

            int result3 = SumInteractive(n: 10);
            Console.WriteLine(result3);

            long result4 = Factorial(n: 3);
            Console.WriteLine(result4);

            long result5 = FactorialIterative(n: 3);
            Console.WriteLine(result5);

            int result6 = SumFormula(n: 3);
            Console.WriteLine(result6);

            int[] intArr1 = new int[10];
            int[] intArr2 = new int[5] { 1, 2, 4, 8, 11 };
            int[] intArr3 = { 1, 2, 4, 8, 11 };
            for (int i = 0; i < intArr2.Length; i++)
            {
                Console.WriteLine(intArr2[i]);
            }

            string[] stringArr4 = { "This", "is", "string array with number 123" };
            for (int i = 0; i < stringArr4.Length; i++)
            {
                Console.WriteLine(stringArr4[i]);
            }

            ArrayList arl1 = new ArrayList();
            arl1.Add(value: 3);
            arl1.Add(value: 4);
            arl1.Add(value: 5);
            foreach (object element in arl1)
            {
                Console.WriteLine(element);
            }

            arl1.Add(value: "hello");
            arl1.Add(value: 4.5);

            for (int i = 0; i < arl1.Count; i++)
            {
                Console.WriteLine(arl1[i]);
            }

            //HOMEWORK 01
            // given any array as input, produce as output the sorted array (WITHOUT using build-in functions such as 'Array.Sort')            
            int[] unsortedRawArray = new int[] { 3, 2, 1, 45 };
            int MySort = 0;
            for (int i = 0; i < unsortedRawArray.Length; i++)
             {
                 for (int h = i + 1; h < unsortedRawArray.Length; h++)
                 {
                        if (unsortedRawArray[i] > unsortedRawArray[h])
                        {
                            MySort = unsortedRawArray[h];
                            unsortedRawArray[h] = unsortedRawArray[i];
                            unsortedRawArray[i] = MySort;
                        }
                  }
                    Console.WriteLine(unsortedRawArray[i]);
             }
            int fiboResult = Fibonacci(n: 5);
            Console.WriteLine(fiboResult);

            for (int i = 0; i < 11; i++)
            {
                int fiboResult1 = Fibonacci(i);
                Console.WriteLine(value: $" {1}: {fiboResult1}");
            }
        }



        public static int Fibonacci(int n)
        /* Recursive Fibonacci implementation by Dan
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return Fibonacci(n: n - 1) + Fibonacci(n: n - 2);
        } 
        */


        //HOMEWORK 02: Iterative Fibonacci implementation
        {
            while (n <= 1)
            {
                return 1;
            }
            return Fibonacci(n: n - 1) + Fibonacci(n: n - 2);
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
            return n + Sum(n: n - 1);
        }

        public static int SumFormula(int n)
        {
            {
                return (n * (n - 1)) / 2;
            }
        }

        public static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n + Factorial(n: n - 1);
        }

        public static long FactorialIterative(int n)
        {
            long finalResult = 1;
            while (n >= 0)
            {
                finalResult = finalResult * n;
                n--;
            }
            return finalResult;
        }


        public static int SumInteractive(int n)
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