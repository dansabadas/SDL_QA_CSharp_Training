using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7 , 3, 5, 6, 0, 10, 4 , 6, 0, 34954, 456, 100, 254, 43534, 4554, 665,44,0, -4, 5, 66, 666};
            int[] b = Sort(array);
            foreach (var i in b)
            {
                Console.WriteLine(i);
            }
        }

        static int[] Sort(int[] array)
        {
            Sort(array, 0, array.Length);
            return array;
        }

        static void Sort(int[] array, int beginIndex, int endIndexExcluding)
        {
            int lengthToSort = endIndexExcluding - beginIndex;
            if (lengthToSort == 1 || lengthToSort == 0)
                return;

            int pivotIndex = beginIndex + Partition(array, beginIndex, endIndexExcluding);
            Sort(array, beginIndex, pivotIndex);
            Sort(array, pivotIndex + 1, array.Length);
        }

        private static int Partition(int[] array, int beginIndex, int endIndexExcluding)
        {
            int lengthToSort = endIndexExcluding - beginIndex;

            if (lengthToSort <= 0)
                throw new ArgumentException("The subarray to partition contains no elements.");

            if (lengthToSort == 1)
                return 0;

            if (array[beginIndex] <= array[beginIndex + 1])
            {
                Swap(array, beginIndex + 1, endIndexExcluding - 1);
                return Partition(array, beginIndex, endIndexExcluding - 1);
            }
            else
            {
                Swap(array, beginIndex, beginIndex + 1);
                return 1 + Partition(array, beginIndex + 1, endIndexExcluding);
            }
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            (array[index1], array[index2]) = (array[index2], array[index1]);
        }
    }
}
