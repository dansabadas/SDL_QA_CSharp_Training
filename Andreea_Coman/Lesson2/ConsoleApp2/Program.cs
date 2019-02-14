using System;
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
            Console.WriteLine("hello project 2");

            int id = 1;
            double average = 3.4;
            string name = "andreea";
            DateTime dateOfBirth = new DateTime(year: 1984, month: 09, day: 10);
            // Console.WriteLine($"id = {id}, name = {name}, IQ = {average}, birthDay= {dateOfBirth}");

            Student student1 = new Student();
            Console.WriteLine($"{student1.Id}, {student1.Average}, {student1.Name}, {student1.DateOfBirth}");

            for (int i = 1; i <= 10; i++)
            {
                Student student = new Student();
                student.Name = "Andreea" + i;
                student.DateOfBirth = new DateTime(i, i, i);

                Console.WriteLine($"{student.Name}, {student.DateOfBirth}");
            }

            ArrayList students = new ArrayList();
            for (int i = 1; i <= 10; i++)
            {
                Student student = new Student();
                student.Name = "Andreea" + i;
                student.DateOfBirth = new DateTime(i, i, i);
                students.Add(student);
            }
            Console.WriteLine(students.Count);
            Student[] myStudentArray = CreateStudents(20);
            foreach (Student currentStudent in myStudentArray)
            {
                Console.WriteLine(currentStudent);
            }
        }
        public static Student[] CreateStudents(int numberOfStudents)
        {
            Student[] returnArray = new Student[numberOfStudents];
            for (int i = 1; i < numberOfStudents; i++)
            {
                Student student = new Student();
                student.Name = "Andreea" + i;
                returnArray[i] = student;
            }
            return returnArray;
        }        

    }
}
