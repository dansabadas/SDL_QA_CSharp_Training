using System;
using System.Collections;

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
            int[] intArr1 = new int[10];
            int[] intArr2 = new int[5] { 1, 2, 3, 4, 5 };

            for (int i=0; i<intArr1.Length; i++)
            {
                Console.WriteLine(intArr1[i]);
            }

            for (int x = 1; x < 5; x++)
            {
                Console.WriteLine(intArr2[x]);
            }

            string[] stringArr4 = { "unu", "doi", "trei", "patru", "cinci" };

            for (int y = 0; y< stringArr4.Length; y++)
            {
                Console.WriteLine(stringArr4[y]);
            }

            ArrayList ar1 = new ArrayList();
            ar1.Add("idiot");
            ar1.Add(4.5);
            // display a list 
            for (int y = 0; y < ar1.Count; y++)
            {
                Console.WriteLine(ar1[y]);
            }

            // afisezi cu foreach lista

            foreach (object element in ar1)
            {
                Console.WriteLine(element);
            }

            // FOR THE HOMEWORK 
            // int[] unsortedRawArray = {}
            // int [] whateverArray = MySort(unsortedRawArray);

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

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i}");
            }
            int j = 0;
            while (j < 22)
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

            int result4 = SumIterative(12);
            Console.WriteLine(result4);

            long result = Factorial(6);
            Console.WriteLine($"rezultatul este {result}");

            long result5 = FactorialIterative(4);
            Console.WriteLine($"rezultatul pentru varianta doi este {result5}");

            for (int a = 1; a < 10; a++)
            {
                int fiboResult = Fibonacci(a); 
                Console.WriteLine($"a = {fiboResult}" );
            }
        }
        // make the fibonacci function iterative 

        public static int AddTwoNumbers(int a, int b)
        {
            int calculateValue = 2 * (a + b);
            return calculateValue;
        }
        // functii recursive  
        public static int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + Sum(n - 1);
        }
        // while loop 
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


        public static long Factorial(int n)
        {
            if (n == 1)
            { return 1; }
            return  n * Factorial(n - 1);            
           
        }

        public static long FactorialIterative(int n)
        {
            long FinalValue = 1;
            while (n>1)
            {
                FinalValue = n * FinalValue;
                n = n - 1;
            }
            return FinalValue;
        }

        public static int SumFormula(int n)
        {
            return (n * (n + 1)) / 2;
        }

        public static int Fibonacci(int n)
        {
            if (n==0 || n==1)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
