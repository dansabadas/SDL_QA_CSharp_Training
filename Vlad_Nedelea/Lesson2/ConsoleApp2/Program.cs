using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        public int Id;
        public double Average;
        public string Name;
        public DateTime DateOfBirth;

    }

    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            double average = 3.4;
            string name = "dan";
            DateTime dateOfBirth = new DateTime(1964, 03, 12);
            Console.WriteLine(value: $"{ dateOfBirth},{ id},{name},{average}");

            Student student1 = new Student();

            Console.WriteLine(value: $"{student1.Id}, { student1.Name},{ student1.Average},{student1.DateOfBirth}");

            for (int i = 1; i < 10; i++)
            {
                Student student = new Student();
                student.Name = "dan" + i;
                student.DateOfBirth = new DateTime(i, i, i);
                Console.WriteLine(value: $"{student.Name},{student.DateOfBirth}");


            }

            ArrayList students = new ArrayList();

            for (int i = 1; i < 10; i++)
            {
                Student student = new Student();
                student.Name = "dan" + i;
                student.DateOfBirth = new DateTime(i, i, i);
                //Console.WriteLine(value: $"{student.Name},{student.DateOfBirth}");
                students.Add(student);

            }

            Console.WriteLine(students.Count);
            var myStudentArray = CreateStudents(12);
            foreach (Student current in myStudentArray) Console.WriteLine(current.Name);


        }

        public static Student[] CreateStudents(int numberOfStudents)
        {
            Student[] array = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                student.Name = "dan" + i;
                array[i] = student;

            }

            return array;
        }
    }
}
