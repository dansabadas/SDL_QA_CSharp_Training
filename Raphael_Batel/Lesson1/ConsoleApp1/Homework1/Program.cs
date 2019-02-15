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
        }

        static int[] Sort(int[] array)
        {
            Sort(array, 0, array.Length);
            return array;
        }

        static void Sort(int[] array, int beginIndex, int endIndexExcluding)
        {
            int lengthToSort = endIndexExcluding - beginIndex;
            if (lengthToSort == 1)
                return;

            int pivotIndex = Partition(new ArraySegment<int>(array, beginIndex, lengthToSort));
            Sort(array, 0, pivotIndex);
            Sort(array, pivotIndex + 1, array.Length);
        }

        private static int Partition(ArraySegment<int> arraySegment)
        {
            throw new NotImplementedException();
        }
    }
}
