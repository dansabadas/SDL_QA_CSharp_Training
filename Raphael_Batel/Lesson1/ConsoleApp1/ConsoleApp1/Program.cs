using System;

namespace Training
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
            Console.WriteLine("Hello I'm Raphael");
            int i1 = 2;
            int i2 = 0;
            var i3 = 5;
            Console.WriteLine($"{i1} {i2} {i3}");

            float f1 = 2.5f;
            var f2 = 3.5;
            Console.WriteLine($"{f1} {f2}");

            char c1 = 'd', c2 = 'E';
            Console.WriteLine($"{c1} {(int)c1} {c2} {(int)c2}");

            bool b1 = true, b2 = false;
            Console.WriteLine($"{b1} {b2}");

            byte by1 = 13, by2 = 255;

            // byte by3 = ++by2;
            
            Console.WriteLine($"{by1} {by2}");

            Medals m1 = Medals.Gold;
            Console.WriteLine($"{m1} {(int)m1}");

            string s1 = "Hello World!";
            Console.WriteLine(s1);


                by2++;
                by2++;
            Console.WriteLine(by2);


            int ii1 = 13 / 3;
            int ii2 = 13 % 3;

            double dd1 = 13 / 3d;

            Console.WriteLine($"{ii1} {ii2} {dd1}");

            var dd2 = dd1 + 34;

            Console.WriteLine($"{dd2}");

            double dd3 = 0;
            double dd4 = 1000 / dd3;
            Console.WriteLine($"{dd4}");


            bool b11 = true;
            bool b12 = !b11;
            Console.WriteLine("Truth value: {0}", b12);
            if(!b11)
            {

            }
            //else
            //{

            //}

            int ii3 = 5;
            bool isEven = ii3.IsEven();// (ii3 % 2 == 0);
            if (isEven)
            {
                Console.WriteLine($"{ii3} is even");
            }
            else
            {
                Console.WriteLine($"{ii3} is odd");
            }

            Console.WriteLine($"{ii3} is " + ((ii3%2 == 0) ? "even" : "odd"));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{nameof(i)}: {i}");
            }

            int j = 0;
            while(j < 10)
            {
                Console.WriteLine($"{nameof(j)}: {j}");
                j++;
            }

            Medals m3 = Medals.Silver;
            switch (m3)
            {
                case Medals.Gold:
                    Console.WriteLine("Noice gold medal!");
                    break;
                case Medals.Silver:
                    Console.WriteLine("This is my favorite metal");
                    break;
                default:
                    Console.WriteLine("whatsevs!");
                    break;
            }

            int result1 = AddTwoNumbers(4, 5);
            Console.WriteLine($"result = {result1}");

            int result2 = Sum(10);
            Console.WriteLine(result2);

        }

        public static int AddTwoNumbers(int a, int b)
        {
            int result = 2 * a + b;
            return result;
        }

        public static int Sum(int n)
        {
            if (n == 0)
                return 0;
            return n + Sum(n - 1);
        }

        public static int SumIterative(int n)
        {
            int finalValue = 0;
            while(n >= 0)
            {
                finalValue += n;
                n--;
            }
            return finalValue;
        }


    }

    public static class Int32Extensions
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }
    }
}
