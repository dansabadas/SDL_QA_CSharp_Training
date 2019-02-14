using System;

namespace ConsoleApp1
{
    public enum Medals
    {
        bronze=2,
        gold=6,
        silver,
        platinum
       
    }
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Hello I'm Ligia");

            int i1 = 2;
            int i2 = 0;
            var i3 = 5;
            Console.WriteLine(value: $"{i1} {i2} {i3}");

            float f1 = 2.5f;
            var f2 = 3.5;
            Console.WriteLine(value: $"{f1} {f2}");

            char c1 = 'd',c2 = 'I';
            Console.WriteLine(value: $"{c1} {(int)c1} {c2} {(int)c2}");

            bool b1 = true, b2 = false;
            Console.WriteLine(value: $"{b1} {b2}");

            byte by1 = 13, by2 = 255;
            //byte by3 = by2 + 10;
            Console.WriteLine(value: $"{by1} {by2}");

            by2++;//by 2+ 1
            by2++;
            Console.WriteLine(value: $"{by2}");

            Medals m1 = Medals.gold;
            Console.WriteLine(value: $"{m1} {(int)m1}");
             
            String s1 = "Hello wold!";
            Console.WriteLine(s1);
            

            int ii1 = 13 / 3, ii2= 13 % 3;
            double dd1 = 13 / 3d;
            Console.WriteLine(value: $"{ii1} {ii2} {dd1}");

            double dd2 = dd1 + 34;
            Console.WriteLine(value: $"{dd2}");

            int dd3 = 4;
            double dd4 = 1000/ dd3;
            Console.WriteLine(value: $"{dd4}");

            bool bb1 = true;
            bool bb2 = !bb1;
            Console.WriteLine("Truth value:{0}",bb2);
            
            int ii3 = 4;
            if (ii3 % 2 == 0)
            {
                Console.WriteLine(value: $"{ii3}is odd");
            }
            else
            {
                Console.WriteLine(value: $"{ii3}is even");
            }

            int ii4 = 5;
            int ii5 = 5;
            if (ii4 == ii5)
            {
                Console.WriteLine(value: "Values are the same ");
            }

            for (int i = 0; i < 10; i++)
                Console.WriteLine(value: $"i={i}");

            int j=0;
            while (j< 10)
            {
                Console.WriteLine(value: $"j={j}");
                j++;
            }

            Medals m2 = Medals.silver;
            switch (m2)
            {
                case Medals.gold:
                    Console.WriteLine(value: $"nice gold medal");
                    break;
                case Medals.silver:
                    Console.WriteLine(value: $"this is ok");
                    break;
                default:
                    Console.WriteLine(value: $"i am not inerested in these");
                    return;

            }

            int result1 = AddTwoNubers(4, 5);
            Console.WriteLine(value: $"result={result1}");

            int result2 = Sum(10);
            Console.WriteLine(result2);

        }
        public static int AddTwoNubers (int a, int b)
        {
            int calculatedVlues = 2 * a + b;
            return calculatedVlues;
        }
        public static int Sum(int n)
        {
            if (n==0)
            {
                return 0;
            }
            return n + Sum(n - 1);
        }
        public static int SumIterative(int n)
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
