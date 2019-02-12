using System;

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

            byte by1 = 234;
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

            int result1 = AddNumbers(4,5);

            Console.WriteLine(result1);

            int n = 10;

            Console.WriteLine(Sum(n));

          //  Console.WriteLine( $"{(int)c1},{b1}, {by2}, {s1}, {ii1}, {dd1}, {dd2}, {dd4}");

           
            Console.ReadKey();

        }

        public static int AddNumbers(int a, int b)
        {
            int calcuklatedvakue = a + b;
            return calcuklatedvakue;
        }

        public static int Sum(int n)
        {
            if (n == 0) return 0;

            return n + Sum(n - 1);
        }

    }
}
