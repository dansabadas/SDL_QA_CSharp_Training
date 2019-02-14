using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class student
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
            Console.WriteLine(value:$"{id}, {average}, {name}, {dateOfBirth}");

            student student1 = new student();
            Console.WriteLine(value: $"{student1.Average}, {student1.Name}, {student1.DateOfBirth}");
            
            for (int i = 1; i < 10; i++)
            {
                student student = new student();
                student.Name = "Ligia"+i;
                student.DateOfBirth = new DateTime(i, i, i);
                Console.WriteLine(value: $"{student.Name},{student.DateOfBirth}");
            }

            ArrayList students = new ArrayList();
            for (int i = 1; i < 10; i++)
            {
                student student = new student();
                student.Name = "Ligia" + i;
                //student.DateOfBirth = new DateTime(i, i, i);
                Console.WriteLine(value: $"{student.Name},{student.DateOfBirth}");
            }
            Console.WriteLine(students.Count);

            student[] myStudentsArray = CreateStudents(20);
            foreach(student currentStudent in myStudentsArray)
            {
                Console.WriteLine(currentStudent.Name);

            }
        }
        public static student[] CreateStudents(int NumberOfStudents)
        {
            student[] returnArray = new student[NumberOfStudents];
            for (int i = 0; i < NumberOfStudents; i++)
            {
                student student = new student();
                student.Name = "Ligia" + i;
                returnArray[i] = student;
            }
            return returnArray;
        }
    }
}
