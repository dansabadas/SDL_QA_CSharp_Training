using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Student
    {
        public string Name;
        public int ID;
        public DateTime DateOfBirth;
    }

    public class StudentRepository
    {
        public ArrayList GetAllStudents(int nr)
        {
            ArrayList students = new ArrayList();

            for (int i = 0; i < nr; i++)
            {
                Student student = new Student();

                student.ID = i;
                student.Name = "Some Name" + i;
                student.DateOfBirth = DateTime.Now.AddYears(-i);

                students.Add(student);
            }
            
            return students;
        }
    }
    class Program
    {
    
        static void Main(string[] args)
        {
            Student student = new Student();
            StudentRepository studentRepository = new StudentRepository();

            ArrayList students = studentRepository.GetAllStudents(100);

            foreach(Student stud in students)
            {
                Console.WriteLine($"Student {stud.Name} has the ID {stud.ID} and was born {stud.DateOfBirth}");
            }

            Console.WriteLine("Hello");
            Console.ReadLine();
            
            
        }
    }
}
