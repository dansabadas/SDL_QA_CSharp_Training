using System;
using System.Collections;

namespace ConsoleApp1
{
    public class Student
    {
        public int id;
        public string name;
        public DateTime dateOfBirth;
    }

    public class StudentRepository
    {
        public ArrayList CreateAllStudents()
        {
            ArrayList myList = new ArrayList();
            for (int i = 1; i < 10; i++)
            {
                Student myStudent = new Student();
                myStudent.id = i;
                myStudent.name = "student name" + i;
                myStudent.dateOfBirth = DateTime.Today.AddYears(-i);
                myList.Add(myStudent);
                Console.WriteLine($"name { myStudent.name} data nasterii {myStudent.dateOfBirth}" );
            }
            return myList; 
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository myRepository= new StudentRepository();
            ArrayList myList = myRepository.CreateAllStudents();

            Console.ReadKey();

          //   Console.WriteLine("lesson3");
        }
    }
}
