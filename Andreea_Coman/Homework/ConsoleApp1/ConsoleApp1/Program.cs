using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti un numar pentru care sa afisam sirul fibonacci: ");
            int n = Convert.ToInt16(Console.ReadLine());
            FibonacciIterativ(n);
            Console.ReadKey();
            }

        public static int FibonacciIterativ(int fib)
        {
            int suma = 0;
            int n1 = 0;
            int n2 = 1;
            suma = n1 + n2;
            Console.WriteLine("rezultate");
            Console.WriteLine($"0");
            Console.WriteLine($"1 ");

            for (int i = 2; i <= fib; i++)
            {
                suma = n1 + n2;
                Console.WriteLine($"{suma}", suma);
                n1 = n2;
                n2 = suma;

            }
            return suma;
        }
    }
}
