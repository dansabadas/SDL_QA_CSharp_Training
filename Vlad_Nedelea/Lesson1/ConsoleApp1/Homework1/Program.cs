using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Student
    {
        public Student()
        {
        }
        int Id;
        public double Average;
        public string Name;
        public DateTime DateOfBirth;
    }

   

    class Program
    {
        static void Main(string[] args)
        {
            //sorted array
            int[] array1 = new int[] { 3, 1, 2 };

            int[] sortedArray = GetArraySorted(array1);

            for (int k = 0; k < array1.Length; k++)
            {
                Console.WriteLine(sortedArray[k]);
            }

            //fibonacci
            FibonacciIterative(9);

            //array of students
            int numberStudents = 10;
            ArrayList array2 = new ArrayList();
            array2 = CreateStudentsList(numberStudents);

            for (int t = 0; t < numberStudents; t++)
            {
                var student = array2[t] as Student;

                Console.WriteLine(student.Name);
            }

            Console.ReadKey();
        }

      
        public static int[] GetArraySorted(int[] givenArray)
        {
            int aux;

            for (int i = 0; i < givenArray.Length; i++)
            {
                for (int j = i + 1; j < givenArray.Length; j++)
                {
                    if (givenArray[i] > givenArray[j])
                    {
                        aux = givenArray[i];
                        givenArray[i] = givenArray[j];
                        givenArray[j] = aux;
                    }
                }

            }
            return givenArray;
        }

        public static void FibonacciIterative(int number)
        {
            int x = 0, y = 1, z = 0;
            Console.Write("0 1 ");

            for (int i = 2; i <= number; i++)
            {
                z = x + y;
                Console.Write(z);
                Console.Write(" ");
                x = y;
                y = z;
            }
        }


        public static Student[] CreateStudents(int numberOfStudents)
        {
            Student[] students = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                int j = i + 1;
                student.Name = "dan" + j;
                students[i] = student;
            }
            return students;
        }


        public static ArrayList CreateStudentsList(int numberOfStudents)
        {
            ArrayList students = new ArrayList();

            for(int i=0; i < numberOfStudents; i++)
            {
                Student student = new Student();

                int j = i + 1;

                student.Name = "dan" + j;
                students.Add(student);
            }
            return students;
        }

    }



}
