using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
            Console.WriteLine("Hello I'm Ady");

            int id = 1;
            double average = 3.4;
            string name = "Ady";
            DateTime dateofBirth = new DateTime(2010, 10, 01);

            Console.WriteLine($"{id}, {average}, {name}, {dateofBirth}");

            Student student1 = new Student();
            Console.WriteLine($"{student1.Id}, {student1.Average}, {student1.Name}, {student1.DateOfBirth}");

            for (int i = 1; i < 10; i++)
            {
                Student student = new Student();
                student.Name = "Ady" + i;
                student.DateOfBirth = new DateTime(2010, 10, 01);
                Console.WriteLine($" {student.Name}, {student.DateOfBirth}");
            }


            ArrayList students = new ArrayList();
            for (int i = 1; i < 10; i++)
            {
                Student student = new Student();
                student.Name = "Ady" + i;
                //student.DateOfBirth = new DateTime(2010, 10, 01);
                students.Add(student);
            }

            Console.WriteLine(students.Count);

            Student[] myStudentArray = CreateStudents(20);
            foreach (Student currentStudent in myStudentArray)
            {
                Console.WriteLine(currentStudent.Name);
            }


        }

        public static Student[] CreateStudents(int numberOfStudents)
        {
            Student[] returnArray = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                student.Name = "Ady" + i;
                returnArray[i] = student;
            }

            return returnArray;
        }

    }
}

