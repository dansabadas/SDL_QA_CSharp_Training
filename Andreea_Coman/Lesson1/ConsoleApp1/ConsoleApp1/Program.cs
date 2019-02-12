using System;

namespace ConsoleApp1
{

    public enum Medals
    {
        Bronze = 1,
        Silver,
        Gold = 5,
        Platinum
    }
    class Program
    {
        static void Main(string[] args)
        {
            // afisam un mesaj 
            Console.WriteLine("Hello I'm Andre");

            //diferenta dintre a declara sau nu tipul unei variabile 
            int i1 = 2;
            var i2 = 0;
            int i3 = 5;
            Console.WriteLine($"{i1} {i2} {i3}");

            // 2 metode de a scrie o var float 
            float f1 = 12f;
            var f2 = 3.5;
            Console.WriteLine($"{f1} {f2}");

            //afisare char si valoarea ascii (cred, de verificat) 
            char c1 = 'd';
            Console.WriteLine($"{c1} {(int)c1}");

            // cum afisam double 
            double dd3 = 0;
            double dd2 = 1000 / dd3;
            Console.WriteLine($"salut: {dd2}");

            // 

            // if statement 
            bool b11 = true;
            bool b12 = !b11;
            if (!b11)
            {
                Console.WriteLine("Truth value: {0}", b12);
            }
            else
            {
                Console.WriteLine("xx");
            };

            int ii3 = 15;
            if ((ii3 % 2) != 0)
            {
                Console.WriteLine($"{ii3} este impar");
            }
            else
            {
                Console.WriteLine($"{ii3} este par");
            };

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}");
            }
            int j = 0;
            while (j < 20)
            {
                Console.WriteLine($"{j}");
                j++;
            }

            Medals m3 = Medals.Silver;
            switch (m3)
            {
                case Medals.Gold:
                    Console.WriteLine($"nice medal");
                    break;
                case Medals.Silver:
                    Console.WriteLine("bla bla");
                    break;
            }

            int result2 = AddTwoNumbers(3, 4);
            Console.WriteLine(result2);
            int result3 = Sum(10);
        }

        public static int AddTwoNumbers(int a, int b)
        {
            int calculateValue = 2 * (a + b);
            return calculateValue;
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
                finalValue += finalValue;
                n--;
            }
            return finalValue;
        }

    }
}
