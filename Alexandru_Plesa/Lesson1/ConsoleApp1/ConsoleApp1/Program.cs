using System;

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
            Console.WriteLine("Hello I'm Alex");
            int i1 = 2;
            int i2 = 0;
            int i3 = 5;
            Console.WriteLine($"{i2} {i2}");

            float f1 = 2.5f;
            var f2 = 3.5;
            Console.WriteLine($"{f1} {f2}");

            char c1 = 'd', c2 = 'E';
            Console.WriteLine($"{c1} {(int)c1} {c2} {(int)c2}");

            bool b1 = true, b2 = false;
            Console.WriteLine($"{b1} {b2}");

            byte by1 = 13, by2 = 255;
            Console.WriteLine($"{by1} {by2}");

            Medals m1 = Medals.Gold;
            Console.WriteLine($"{m1} {(int)m1}");

            string s1 = "Hello World!";
            Console.WriteLine(s1);

            int ii1 = 13 / 3;
            int ii2 = 13 % 2;
            double dd1 = 13 / 3;

            Console.WriteLine($"{ii1} {ii2} {dd1}");

            bool b11 = false;
            bool b12 = !b11;
            Console.WriteLine("truth value: {0}", b12);

            if (!b11)
            {

            }
            else
            {

            }

            int ii3 = 5;
            int result = ii3 % 2;
            if (result != 0)
            {
                Console.WriteLine($"{ii3} is odd");
            } else
            {
                Console.WriteLine($"{ii3} is even");
            }

            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine($"{i} is a even number");
                }
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"{j}");
                j++;
            }

            Medals medals = Medals.Silver;

            switch (medals)
            {
                case Medals.Silver:
                    Console.WriteLine($" nice {Medals.Silver}");
                    break;
                case Medals.Gold:
                    Console.WriteLine($" nice {Medals.Gold}");
                    break;
                default:
                    Console.WriteLine("This is the default value");
                    return;
            }

            int result1 = AddTwoNumbers(9, 10);
            Console.WriteLine(result1);

            int result2 = Sum(10);
            Console.WriteLine(result2);

            int result3 = SumIterative(11);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
        public static int AddTwoNumbers(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public static int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            return n + Sum(n - 1);
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

    }
    
}
