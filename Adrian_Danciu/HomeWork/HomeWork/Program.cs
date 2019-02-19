using ConsoleApp2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework: 1. given any array as input, produce as output the sorted array 
            //(do not use built-in functions like Array.Sort() but create your own sorting implementation

            int[] unsortedRawArray = { 3, 2, 1, 45, 0 };
            int[] sorted = MySort(unsortedRawArray);

            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i] + " ");
            }
            Console.WriteLine();

            //Homework: 2.Implement Fibonacci iteratively, not recursively
            int fiboResult = Fibonacci(5);

            Console.WriteLine(fiboResult);

            //Homework 3: Create a function called CreateStudents2 that returns an ArrayList with students
            //(as a source of inspiration use the existing public static Student[] CreateStudents
            //(int numberOfStudents) just that instead of an array of students the function CreateStudents2 
            //should return an ArrayList populated with the students.

            ArrayList s1 = CreateStudents2(100);
            for (int i=0; i<s1.Count; i++)
            {
                Student s = (Student)s1[i];
                Console.WriteLine(s.Name);
            }
                       
        }

        public static int[] MySort (int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                int temp;

                for (int j = i;  j < unsorted.Length; j++)
                {
                    if (unsorted[j] < unsorted[i])
                    {
                        temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }

            return unsorted;
        }

        public static int Fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            int b = 0;
            int a = 1;
            int i = 2;
            int currentValue = a + b;
            while(i<=n)
            {
                int temp1 = a;
                int temp2 = currentValue;
                currentValue = currentValue + a;
                a = temp2;
                b = temp1;

                i++;
            }
            return currentValue;
        }

        public static ArrayList CreateStudents2 (int numberOfStudents)
        {

            ArrayList students = new ArrayList();
         
            for (int i = 0; i<100; i++)
            {
                Student student = new Student();
                student.Name = "Ady" + i;
                //student.DateOfBirth = new DateTime(2010, 10, 01);
                students.Add(student);
            }

            return students;
        }

    }
}
