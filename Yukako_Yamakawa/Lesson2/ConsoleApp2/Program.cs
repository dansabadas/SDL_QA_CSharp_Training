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
            Console.WriteLine("Hello I'm Yukako Yamakawa");

            int id = 1;
            double average = 3.4;
            string name = "Yukako";
            DateTime dateOfBirth = new DateTime(year: 1900, month: 1, day: 11);
            Console.WriteLine(value: $"{id}, {average}, {name}, {dateOfBirth}");

            // the default value for "Student" = 0, 0, , 01/01/0001 00:00:00
            Student student1 = new Student();
            Console.WriteLine(value: $"{student1.Id}, {student1.Average}, {student1.Name}, {student1.DateOfBirth}");
            for (int i = 1; i < 10; i++) //not advisable to use i=0; as 0 value is not supported.
            {
                Student student = new Student();
                student.Name = "Yukako" + i;
                student.DateOfBirth = new DateTime(year: i, month: i, day: i);
                Console.WriteLine(value: $"{student.Name}, {student.DateOfBirth}");
            }

            ArrayList students = new ArrayList();
            for (int i = 1; i < 10; i++)
            {
                Student student = new Student();
                student.Name = "Yukako" + i;
                //student.DateOfBirth = new DateTime(year: i, month: i, day: i);
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
                student.Name = "Yukako" + i;
                returnArray[i] = student;
            }
            
                return returnArray;
        }

        //Homework 3: Create a function called CreateStudents2 that returns an ArrayList with students
        //(as a source of inspiration use the existing public static Student[] CreateStudents(int numberOfStudents)
        //just that instead of an array of students the function CreateStudents2 should return an ArrayList populated with the students.
        public static Student[] CreateStudents2(string nameOfStudents)
        {    
            ArrayList arrayOfStudents = new ArrayList();
            arrayOfStudents.Add("Andy");
            arrayOfStudents.Add("Bob");
            string stud = (string)arrayOfStudents[0];

            return CreateStudents2(nameOfStudents);
           
        }
        



    }
}
