using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonaciItterative
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibbonaci_itterative(n));
        
        }

       public static int Fibbonaci_itterative(int n)
            {
                int a= 0;
                int b = 1;

                for (int i = 0; i < n-1; i++)
                {
                    int c =a;
                    a = b;
                    b = c + a;

                }

                return b;

            }
     
    }
}

