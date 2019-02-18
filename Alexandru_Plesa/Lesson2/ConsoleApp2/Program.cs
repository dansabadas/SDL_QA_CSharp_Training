using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I am Alex!");

            int int1 = 0;
            double average = 1.0f;
            string name = "Alex";
            DateTime date = new DateTime(1990, 7, 10);

            Console.WriteLine($"{int1} {average} {name} {date}");

            for (int i = 1; i <= 10; i++)
            {
                Student student = new Student();
                student.Name = "Alex " + i;
                student.birthDate = new DateTime(1990, 7, i);
                Console.WriteLine($"{student.Name} {student.birthDate}");
            }

            Student alex = new Student();
            alex.Name = "Alex";
            alex.Average = 5.5f;
            alex.birthDate = new DateTime(1990, 7, 10);
            alex.Id = 1;

            ArrayList students = new ArrayList();

            for (int i = 1; i <= 10; i++)
            {
                Student student = new Student();
                student.Name = "Alex " + i;
                student.birthDate = new DateTime(1990, 7, i);
                students.Add(student);
            }


            Console.WriteLine($"{alex.Id} {alex.Name} {alex.Average} {alex.birthDate}");

            foreach (Student student in createStudents(20))
            {
                Console.WriteLine($"{student.Name} {student.birthDate}");
            }


            Console.ReadLine();


        }
        public static Student[] createStudents(int numberOfStudents)
        {

            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                student.Name = "Alex " + i;
                student.birthDate = new DateTime(1990, 7, i+1);
                students[i] = student;
            }
            return students;
        }
    }
}
