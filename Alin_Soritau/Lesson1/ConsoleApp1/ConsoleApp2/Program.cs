using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I'm Alin");
            int id = 1;
            double average = 3.4;
            string name = "Alin";
            DateTime dateOfBirth = new DateTime(year: 1992, month: 8, day: 2);
            Console.WriteLine($"{id} {average} {name} {dateOfBirth}");

            Student student1 = new Student();
            Console.WriteLine($"{student1.Average} {student1.Name} {student1.DateOfBirth}");

            for (int i = 1; i <= 10; i++)
            {
                Student student = new Student();
                student.Name = "Alin" + i;
                student.DateOfBirth = new DateTime(year: i, month: i, day: i);
                Console.WriteLine($"{student.Name} {student.DateOfBirth}");
            }

            ArrayList students = new ArrayList();
            for (int i = 1; i <= 10; i++)
            {
                Student student = new Student();
                student.Name = "Alin" + i;
                student.DateOfBirth = new DateTime(year: i, month: i, day: i);
                students.Add(student);
            }
            Console.WriteLine(students.Count);

            Student[] myStudentArray = CreateStudents(20);
            foreach (Student student in myStudentArray)
            {
                Console.WriteLine(student.Name);
            }
            var hwStudentArray = CreateStudentsList(20, "HW");
            foreach(Student s  in hwStudentArray)
            {
                Console.WriteLine(s.Name);
            }

            Console.Read();
        }

        public static Student[] CreateStudents(int numberOfStudents)
        {
            Student[] students = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                int j = i + 1;
                student.Name = "Alin" + j;
                students[i] = student;
            }
            return students;
        }

        public static ArrayList CreateStudentsList (int numberOfStudents, string prefix)
        {
            ArrayList students = new ArrayList();
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                int j = i + 1;
                student.Name = prefix + "-Alin-" + j;
                students.Add(student);
            }
            return students;
        }

    }
    class Student
    {
        int Id;
        public double Average;
        public string Name;
        public DateTime DateOfBirth;
    }
}
