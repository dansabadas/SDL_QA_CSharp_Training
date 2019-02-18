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
        int id;
        public double average;
        public string name;
        public DateTime dateOfBirth;

    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hey ya, I'm Cris!");
             int id = 1;
             double average = 3.4;
             string name = "Cris";
             DateTime dateOfBirth = new DateTime(1990, 6, 25);
             Console.WriteLine($"{id} {average} {name} {dateOfBirth}");

             Student student1 = new Student();
             Console.WriteLine($" {student1.average} {student1.name} {student1.dateOfBirth}");

             for (int i=1; i<10; i++)
             {
                 Student student = new Student();
                 student.name = "Cris " + i;
                 student.dateOfBirth = new DateTime(i,  i,  i);
                 Console.WriteLine($" {student.name} {student.dateOfBirth}");
             }

             // variables from struct are stored on the stack and are automatically removed 

             ArrayList students = new ArrayList();
             for (int i = 1; i < 10; i++)
             {
                 Student student = new Student();
                 student.name = "Cris " + i;
              //   student.dateOfBirth = new DateTime(i, i, i);
                 students.Add(student);
             }
                 Console.WriteLine(students.Count);*/

            Student[] myStudentArray = CreateStudents(10);
            foreach (Student stud in myStudentArray)
            {
                Console.WriteLine(stud.name);
            }

            //Homework : Create a function called CreateStudents2 that returns an ArrayList with students (as a source of inspiration use the existing 
            //public static Student[] CreateStudents(int numberOfStudents)just that instead of an array of students the function CreateStudents2 should
            //return an ArrayList populated with the students.

            ArrayList myStudentArray2 = CreateStudents2(10);
            foreach (Student stud in myStudentArray2)
            {
                Console.WriteLine(stud.name);
            }

        }

        public static Student[] CreateStudents(int numberOfStudents)
        {
            Student[] st = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                student.name = "Cris " + i;
                //   student.dateOfBirth = new DateTime(i, i, i);
                st[i] = student;
            }
            return st;
        }

        public static ArrayList CreateStudents2(int numberOfStudents)
        {
            ArrayList st2 = new ArrayList();
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                student.name = "Cris " + i;
                st2.Add(student);
            }
            return st2;
        }

    }
}
