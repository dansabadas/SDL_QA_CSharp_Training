using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStudentsII

{
    public class Student
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
            int numberStudents = 10;
            ArrayList array2 = new ArrayList();
            array2 = CreateStudentList(numberStudents);

            for (int t = 0; t < numberStudents; t++)
            {
                var student = array2[t] as Student;

                Console.WriteLine(student.Name);
            }
        }

        public static Student[] CreateStudents(int numberOfStudents)
        {
            Student[] students = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                int j = i + 1;
                student.Name = "Catalina" + j;
                students[i] = student;
            }
            return students;
        }

        public static ArrayList CreateStudentList(int numberOfStudents)
        {

            ArrayList returnArray = new ArrayList();
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();

                int j = i + 1;
                student.Name = "Catalina " + j;
                returnArray.Add(student);
            }
            return returnArray;
        }
    }
}
