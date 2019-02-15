using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson2;

namespace Homework3_StudentsArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList students = CreateStudents2(100);
            foreach(Student s in students)
                Console.WriteLine(s.Name);
        }

        public static ArrayList CreateStudents2(int numberOfStudents)
        {
            ArrayList students = new ArrayList(numberOfStudents);
            for (int i = 1; i <= numberOfStudents; i++)
            {
                System.Diagnostics.Debug.WriteLine(i);
                Student student = new Student();
                student.Name = "Dan " + i;
                students.Add(student);
            }
            return students;
        }
    }
}
