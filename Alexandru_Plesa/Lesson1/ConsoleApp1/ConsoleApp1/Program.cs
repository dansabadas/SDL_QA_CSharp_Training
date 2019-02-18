﻿using System;
using System.Collections;

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

            long result4 = Factorial(5);
            Console.WriteLine(result4);

            long result5 = FactorialIterative(5);
            Console.WriteLine(result5);

            int result6 = SumFormula(5);
            Console.WriteLine(result6);

            int[] intArr1 = new int[10];
            int[] intArr2 = new int[6] { 1, 2, 3, 4, 5, 9 };
            string[] stringArr1 = new string[3] { "some string 1", "some string 2", "some string 3"};

            foreach (int number in intArr2)
            {
                Console.WriteLine(number);
            }

            foreach (string word in stringArr1)
            {
                Console.WriteLine(word);
            }

            ArrayList arrList = new ArrayList();
            arrList.Add(3);
            arrList.Add(4);
            arrList.Add("string");
            arrList.Add(9.9);


            foreach (object word in arrList)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine($"Fibonaci {Fibonacii(10)}");

            #region Homework

            int[] unsortedValues = new int[] { 20, 5, 3, 4, 0, 99, -1, 0 };

            foreach (int number in unsortedValues)
            {
                Console.WriteLine(number);
            }

            int[] nr = ManualSort(unsortedValues);

            Console.WriteLine($"Fibonaci manualy calculated with array {ManualFibonacii(10)}");
            Console.WriteLine($"Fibonaci manualy calculated with addition {ManualFibonacii2(10)}");
            
            

            #endregion

            Console.ReadLine();
        }
       
        #region Fibonacii methods
        // Fibonacii
        public static long ManualFibonacii(int n)
        {
            long[] arrayOfFibonaciNumbers = new long[n];
            arrayOfFibonaciNumbers[0] = 0;
            arrayOfFibonaciNumbers[1] = 1;
            for (int i = 2; i < n; i++)
            {
                arrayOfFibonaciNumbers[i] = arrayOfFibonaciNumbers[i - 1] + arrayOfFibonaciNumbers[i - 2];
            }

            return arrayOfFibonaciNumbers[arrayOfFibonaciNumbers.Length - 1];
        }

        public static long ManualFibonacii2(int n)
        {
            long smallValue = 0;
            long largeValue = 1;
            long result = 0;

            for (var i = 0; i < n - 2; i++)
            {
                result = largeValue + smallValue;
                smallValue = largeValue;
                largeValue = result;
                
            }

            return result;
        }

        public static int Fibonacii(int n)
        {

            if (n == 0 || n  == 1)
            {
                return 1;
            }
            return  Fibonacii(n - 1) + Fibonacii(n - 2);
        }

        #endregion

        #region Sort Methods

        public static int[] MySort(int[] myarray)
        {
            Array.Sort(myarray);

            return myarray;
        }

        // Manual sort
        public static int[] ManualSort(int[] myarray)
        {
            for (int i = 0; i < myarray.Length - 1; i++)
            {
                int smallNumber = myarray[i];
                int indexOfSmallNumber = i;

                for (int j = i + 1; j < myarray.Length; j++)
                {
                    if (myarray[j] < smallNumber)
                    {
                        smallNumber = myarray[j];
                        indexOfSmallNumber = j;
                    }
                }

                myarray[indexOfSmallNumber] = myarray[i];
                myarray[i] = smallNumber;
            }
            return myarray;
        }

        #endregion

        #region Sum methods

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

        public static int SumFormula(int n)
        {
            return (n * (n + 1)) / 2;
        }

        public static long Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        public static long FactorialIterative(int n)
        {
            long finalValue = 1;
            while (n >= 1)
            {
                finalValue = finalValue * n;
                n--;
            }

            return finalValue;
        }

        public static int AddTwoNumbers(int a, int b)
        {
            int result = a + b;
            return result;
        }

        #endregion

    }

}
