using System;
using System.Collections;

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
            Console.WriteLine("Hello I'm Dan");

            int id = 1;
            double average = 3.4;
            string name = "Dan";
            DateTime dateofBirth = new DateTime(1974, 11, 2);
            Console.WriteLine($"{id}, {average}, {name}, {dateofBirth}");

            Student student1 = new Student();
            Console.WriteLine($"{student1.Average}, {student1.Name}, {student1.DateOfBirth}");
            for (int i = 1; i < 10; i++)
            {
                Student student = new Student();
                student.Name = "Dan " + i;
                student.DateOfBirth = new DateTime(i, i, i);
                Console.WriteLine($"{student.Name}, {student.DateOfBirth}");
            }
            
            ArrayList students = new ArrayList();
            for (int i = 1; i < 10; i++)
            {
                Student student = new Student();
                student.Name = "Dan " + i;
                //student.DateOfBirth = new DateTime(i, i, i);
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
                student.Name = "Dan " + i;
                returnArray[i] = student;
            }
            //....
            return returnArray;
        }
    }
}
