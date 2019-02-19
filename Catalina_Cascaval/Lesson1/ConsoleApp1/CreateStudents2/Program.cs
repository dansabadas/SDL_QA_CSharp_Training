using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CreateStudents2
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
        static void Main (string []args)
        {
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            ArrayList array = new ArrayList();
            array = CreateStudents2(numberOfStudents);
        }
    }

    public static ArrayList CreateStudents (int numberOfStudents)
    {
        ArrayList students = new ArrayList();
        for (int i=0; i<numberOfStudents-1; i++)
        {
            Student student = new Student();
            int j = i + 1;
            student.Name = "Catalina +" + j;
            student.Add(student);

        }
        return students;
    }
}


