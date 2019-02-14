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

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(value: $"i={i}");  //iterations for the value
            }

            int j = 0;
            while (j < 1000) //up to the number put after <
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