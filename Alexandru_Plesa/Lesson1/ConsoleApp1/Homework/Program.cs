using System;
using System.Collections;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacii fibonacii = new Fibonacii();
            ManualSort manualSort = new ManualSort();
            Student student = new Student();

            long fibonaciiResult1 = fibonacii.ManualFibonacii(10);
            long fibonaciiResult2 = fibonacii.ManualFibonacii2(10);

            Console.WriteLine($"Fibonaci manualy calculated with array {fibonaciiResult1}");
            Console.WriteLine($"Fibonaci manualy calculated with addition {fibonaciiResult2}");

            int[] unsortedValues = new int[] { 20, 5, 3, 4, 0, 99, -1, 0 };

            foreach (int number in unsortedValues)
            {
                Console.WriteLine(number);
            }

            int[] sortedVales = manualSort.ManualSortArray(unsortedValues);

            foreach (int number in sortedVales)
            {
                Console.WriteLine(number);
            }

            ArrayList students = student.createStudents2(10);
        }
    }
}
