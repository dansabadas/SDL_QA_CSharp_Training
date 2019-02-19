using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[10] { 0, 9, 3, 1, 4, 2, 6, 8, 5, 7 };
            int t = 0;

            for (int i=0; i<array.Length; i++)
            {
                for (int j = i+1; j<array.Length; j++)

                    if (array[i]>array[j])
                    {
                        t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }
                Console.Write(array[i]+" ");
            }

        }

       
    }

}
