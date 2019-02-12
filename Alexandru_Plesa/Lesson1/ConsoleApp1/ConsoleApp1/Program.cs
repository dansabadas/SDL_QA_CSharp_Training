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
            Console.ReadLine();
        }
    }
}
