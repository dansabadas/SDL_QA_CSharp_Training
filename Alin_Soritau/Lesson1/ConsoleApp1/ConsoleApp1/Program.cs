using System;

namespace ConsoleApp1
{
    public enum Metals
    {
        Bronze = 2,
        Silver = 6,
        Gold,
        Platinum,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(value: "Hello I'm Alin");
            int i1 = 2;
            int i2 = 0;
            var i3 = 5;
            Console.WriteLine(value: $"{i1} {i2} {i3}");

            float f1 = 2.5f;
            var f2 = 3.5;
            Console.WriteLine($"{f1} {f2}");

            char c1 = 'd', c2 = 'E';
            Console.WriteLine(value: $"{c1} {(int)c1} {c2} {(int)c2}");

            bool b1 = true, b2 = false;
            Console.WriteLine($"{ b1}, { b2}");

            byte by1 = 13, by2 = 255;
            //byte by3 = by2 + by1;
            Console.WriteLine($"{ by1}, { by2}");

            var m1 = Metals.Gold;
            Console.WriteLine($"{m1} {(int)m1}");

            string s1 = "Hello World!";
            Console.WriteLine(s1);

            by2++;//by2 = by2 + 1
            by2++;
            Console.WriteLine(by2);

            int ii1 = 13 / 3, ii2 = 13%3;
            double dd1 = 13 / 3d;
            Console.WriteLine($"{ii1}, {ii2}, {dd1}");

            var dd2 = dd1 + 34;
            Console.WriteLine(dd2);

            Console.WriteLine("Please enter a number");
            //double dd3 = Convert.ToDouble(Console.ReadLine());
            double dd3 = 0;
            double dd4 = 1000 / dd3;
            Console.WriteLine(dd4);

            Console.Read();
        }
    }
}
