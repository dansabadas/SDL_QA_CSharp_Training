using System;

namespace ConsoleApp1
{
    public enum Medals
    {
        Bronze =2,
        Silver,
        Gold,
        Platinum
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 0;
            var i3 = 5;
            float i4 = 2.5f;
            var f2 = 2.5f;
            char c1 = 'd'; char c2 = 'E';
            bool b1 = true, b2 = false;
            byte by1 = 13; 
            byte by2 = 255;
            Medals m1 = Medals.Gold;
            string s1 = "Hello world!";
            by2++; //b2= b2+1
            by2++;
            int ii1 = 13 / 3, ii2 = 13 % 3;
            double dd1 = 13 / 3d;
            double dd2 = dd1 + 34;

            Console.WriteLine("please enter a number: ");
            //double dd3 = Console.Read();
           // double dd4 = 1000 / dd3;

            bool b11 = true;
            bool b12 = !b11;
            Console.WriteLine("Truth value: {0}", b12);
            if (b11)
            {

            }

            //else
            //{

            //}

            bool isOdd = true;
            int ii3 = 4;
            if (ii3 % 2 == 0)
                Console.WriteLine(isOdd);
            else
                Console.WriteLine(!isOdd);




            Console.WriteLine("Hello I'm Catalina");
            Console.WriteLine($"{i1} {i2} {i3} ");
            Console.WriteLine($"{i4}");
            Console.WriteLine($"{c1} {(int)c1} {c2} {(int)c2}");
            Console.WriteLine($"{b1} {b2}");
            Console.WriteLine($"{m1} {(int)m1}");
            Console.WriteLine(s1);
            Console.WriteLine(by2);
            Console.WriteLine($"{ii1} {ii2} {dd1}");
            Console.WriteLine($"{dd2}");
          //  Console.WriteLine($"{dd4}");

            for (int i = 0; i<1000; i++)
            {
                Console.WriteLine($"i={i}");

            }

            int j = 0;
            while (j < 1000) ;
            {
                Console.WriteLine($"j:{j}");
                j++;
            }

            Medals m3 = Medals.Silver;
            switch(m3)
            {
                case Medals.Gold:
                    Console.WriteLine("Nice gold medal");
                    break;

                case Medals.Silver:
                    Console.WriteLine("This is my favourite metal");
                    break;

                default:
                    Console.WriteLine("I'm not interested in these");
                    return;
                    
            }

            int result1 = AddTwoNumbers(4, 5);
            Console.WriteLine($"result={result1}");
            int result2 = Sum(10);
            Console.WriteLine(result2);

        }
        public static int AddTwoNumbers(int a, int b)
        {
            int calculatedValue = 2 * a + b;

            return calculatedValue;
        }

        //public static int Sum (int n)
        //{
        //    if (n==0)
        //    {
        //        return 0;
        //    }
        //    return n + Sum(n - 1);
        //}

        public static int SumIterative (in n)
        {
            int finalValue = 0;
            while (n >= 0)
            {
                finalValue = finalValue + n;
                n--;
            }
            return finalValue;
        }

        //Homework: 

    }
}
