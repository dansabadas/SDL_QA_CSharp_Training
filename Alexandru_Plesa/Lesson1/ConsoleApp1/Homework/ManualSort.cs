using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class ManualSort
    {
        public int[] ManualSortArray(int[] myarray)
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
    }
}
