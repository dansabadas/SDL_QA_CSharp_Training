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
            Console.WriteLine("Hello I'm Ady");
            int i1 = 2;
            System.Int32 i111 = 2;
            int i2 = 0;
            var i3 = 5;
            Console.WriteLine($"{i1} {i2} {i3}");

            float f1 = 2.5f;
            var f2 = 3.5;
            Console.WriteLine($"{f1} {f2}");

            char c1 = 'd', c2 = 'E';
            Console.WriteLine($"{c1} {(int)c1} {c2} {(int)c2}  ");

            bool b1 = true, b2 = false;
            Console.WriteLine($"{b1} {b2}");

            byte by1 = 13, by2 = 255;
            //byte by3 = by2 + 10;
            Console.WriteLine($"{by1} {by2}");

            Medals m1 = Medals.Gold;
            Console.WriteLine($"{m1} {(int)m1}");

            string s1 = "Hello World";
            Console.WriteLine(s1);

            by2++; //by2 = by2 + 1
            by2++;
            Console.WriteLine($"{by2}");

            int ii1 = 13 / 3, ii2 = 13 % 3;
            double dd1 = 13 / 3d;
            Console.WriteLine($"{ii1} {ii2} {dd1}");

            var dd2 = dd1 + 34;
            Console.WriteLine($"{dd2}");

            Console.WriteLine("Plase Enter a number: ");
            // double dd3 = Console.Read();

            double dd3 = 0;
            double dd4 = 1000 / dd3;
            Console.WriteLine($"{dd4}");

            bool b11 = true;
            bool b12 = !b11;

            Console.WriteLine("Truth value: {0}", b12);

            if (!b11)
            {
                //To Do
            }
                       
            Console.WriteLine("Plase Enter a number: ");
            double number = Console.Read();

            if (number%2 == 0)
            {
                Console.WriteLine("The number is even: ");
            }

            else
            {
                Console.WriteLine("The number is odd : ");
            }


            int ii4 = 4;
            int ii5 = 5;

            if (ii4 != ii5)
            {
                Console.WriteLine("Values are not the same ");
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

            switch(m3)
            {
                case Medals.Gold:
                    Console.WriteLine("nice gold medal!");
                    break;
                case Medals.Silver:
                    Console.WriteLine("this is my favorite metal");
                    break;
                default:
                    Console.WriteLine("I am not intersted of these");
                    break;
            }

            int result = AddTwoNumbers(4, 5);
            Console.WriteLine("Result: {0}", result);

            int result2 = Sum(10);
            Console.WriteLine("Result2: {0}", result2);

            long result5 = Factorial(5);
            Console.WriteLine($"{result5}");


            int[] intArr1 = new int[10];
            int[] intArr2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] intArr3 = { 1, 2, 3, 4, 5 };

            
            for (int i = 0; i < intArr2.Length; i++)
            {
                Console.WriteLine($"i={intArr2[i]}");
            }

            string[] string1 = { "bla", "bla2", "bla3" };
            
            for (int i = 0; i < string1.Length; i++)
            {
                Console.WriteLine($"string={string1[i]}");
            }

            ArrayList arl1 = new ArrayList();
            arl1.Add("hello");
            arl1.Add(4.5);

            for (int i = 0; i < arl1.Count; i++)
            {
                Console.WriteLine($"List={arl1[i]}");
            }

            foreach(object element in arl1)
            {
                Console.WriteLine(element);
            }

            //homework
            //1.
            //int[] unsortedRawArray = { 3, 2, 1, 45, 0 };
            //int[] orice = MySort();

            int fiboResult = Fibonacci(5);
            Console.WriteLine(fiboResult);

            for (int i = 0; i < 11; i++)
            {
                int fiboResult1 = Fibonacci(i);
                Console.WriteLine($"{i}: {fiboResult1}");
            }



            //public static int[] MySort(int[] a)
            //{
            //    .....
            //}

        }

        public static int Fibonacci(int n)
        {

            if ((n == 0) || (n == 1))
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }


        public static int AddTwoNumbers(int a, int b)
        {
            int calcutatedValue = 2 * a + b;
            return calcutatedValue;
        }

        public static int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + Sum(n - 1);
        }

        public static int SumIterativ(int n)
        {
           int finalValue = 0;
           while (n >= 0)
            {
                finalValue = finalValue + n;
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

            return n * Factorial(n-1);            
        }
            

    }
}

