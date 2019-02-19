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
        int Id;
        public double Average;
        public string Name;
        public DateTime DateOfBirth;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ligia");

            int id = 1;
            double average = 3.4;
            string name = "Ligia";
            DateTime dateOfBirth = new DateTime(1997, 12, 22);
            Console.WriteLine(value: $"{id}, {average}, {name}, {dateOfBirth}");

            Student student1 = new Student();
            Console.WriteLine(value: $"{student1.Average}, {student1.Name}, {student1.DateOfBirth}");

            for (int i = 1; i < 10; i++)
            {
                Student sudent1 = new Student();
                sudent1.Name = "Ligia" + i;
                sudent1.DateOfBirth = new DateTime(i, i, i);
                Console.WriteLine(value: $"{sudent1.Name},{sudent1.DateOfBirth}");
            }

            ArrayList students = new ArrayList();
            for (int i = 1; i < 10; i++)
            {
                Student student2 = new Student();
                student2.Name = "Ligia" + i;
                //student.DateOfBirth = new DateTime(i, i, i);
                Console.WriteLine(value: $"{student2.Name},{student2.DateOfBirth}");
            }
            Console.WriteLine(students.Count);

            Student[] myStudentsArray = CreateStudents(20);
            foreach (Student currentStudent in myStudentsArray)
            {
                Console.WriteLine(currentStudent.Name);

            }
            Console.WriteLine("homework 3:");
            ArrayList student = new ArrayList();
            for (int i = 1; i <= 10; i++)
            {
                Student student3 = new Student();
                student3.Name = "Ligia" + i;
                student3.DateOfBirth = new DateTime(year: i, month: i, day: i);
                students.Add(student3);
            }
            Console.WriteLine(students.Count);
            Student[] myStudentArray = CreateStudents(20);
            foreach (Student student4 in myStudentArray)
            {
                Console.WriteLine(student4.Name);
            }
           
            Console.ReadKey();
        }
        public static Student[] CreateStudents(int NumberOfStudents)
        {
            Student[] returnArray = new Student[NumberOfStudents];
            for (int i = 0; i < NumberOfStudents; i++)
            {
                Student student = new Student();
                student.Name = "Ligia" + i;
                returnArray[i] = student;
            }
            return returnArray;
        }
        public static ArrayList CreateStudentsList(int numberOfStudents, string prefix)
        {
            ArrayList students = new ArrayList();
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                int j = i + 1;
                student.Name = prefix + "Ligia" + j;
                students.Add(student);
            }
            return students;
        }

        
    }
}
