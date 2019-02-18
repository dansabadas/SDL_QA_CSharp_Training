using System;
using System.Collections;

namespace Lesson2
{
    public class Student
    {
        int Id;
        public double Average;
        public string  Name;
        public DateTime DateOfBirth;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("buum");

            int id = 1;
            double average = 3.545;
            string name = "Dan";
            DateTime dateOfBirth = new DateTime(year: 1974, month: 11, day: 2);

            Console.WriteLine($"{id} {average} {name} {dateOfBirth.ToShortDateString()}");

            Student student1 = new Student();

            Console.WriteLine($"{student1.Average} {student1.Name} {student1.DateOfBirth}");

            for (int i = 1; i < 10; i++)
            {
                Student student = new Student();
                student.Name = "Dan " + i;
                student.DateOfBirth = new DateTime(year: i, month: i, day: i);
                Console.WriteLine($"{student.Average} {student.Name} {student.DateOfBirth}");
            }

            ArrayList students = new ArrayList();
            for (int i = 1; i <= 9; i++)
            {
                Student student = new Student();
                student.Name = "Dan " + i;
                student.DateOfBirth = new DateTime(year: i, month: i, day: i);
                students.Add(student);
            }

            Console.WriteLine(students.Count);

            Student[] students1 = CreateStudents(20);
            Console.WriteLine(students1.Length);
            foreach (Student student in students1)
            {
                Console.WriteLine(student.Name);
            }

        }

        public static Student[] CreateStudents(int numberOfStudents)
        {
            Student[] students = new Student[numberOfStudents];
            for (int i = 0; i < students.Length; i++)
            {
                Student student = new Student();
                student.Name = "Dan " + i;
                students[i] = student;
            }
            return students;
        }
    }


}
