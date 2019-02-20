using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStudentsII

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
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            for (int i =0; i<numberOfStudents-1; i++)
            {
                Console.WriteLine(CreateStudents(numberOfStudents));
            }
        }

        public static ArrayList CreateStudents(int numberOfStudents)
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
