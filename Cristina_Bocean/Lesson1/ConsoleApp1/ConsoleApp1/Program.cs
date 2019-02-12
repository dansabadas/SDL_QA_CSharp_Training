using System;

namespace ConsoleApp1
{
    public enum Medals
    {
        Bronze = 2, // 0 is default
        Silver= 6,
        Gold,
        Platinium
    }
    class Program
    {
        static void Main(string[] args)
        {
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

            //      Console.WriteLine("Enter: ");
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
            int ii3 = Console.Read();
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


        }

        public static int AddTwoNumbers(int a, int b)
        {
            int calculatedValue = 2 * a + b;
            return calculatedValue;
        }

        
        public static int Sum(int n) // not efficient
        {
            if(n==0)
            {
                return 0;
            }
            return n + Sum(n-1);
        }

        public static int SumIterative(int n) // not efficient
        {
            int finalValue = 0;
            while (n>=0)
            {
                finalValue = finalValue + n;
                n--;
            }
            return finalValue;
        }
    }
}
