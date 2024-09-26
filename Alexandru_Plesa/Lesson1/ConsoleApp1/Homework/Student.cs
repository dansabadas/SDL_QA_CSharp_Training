using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Student
    {
        public int Id;
        public double Average;
        public string Name;
        public DateTime birthDate;

        public ArrayList createStudents2(int numberOfStudents)
        {

            ArrayList students = new ArrayList();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student();
                student.Name = "Alex " + i;
                student.birthDate = new DateTime(1990, 7, i + 1);
                students.Add(student);
            }
            return students;
        }
    }
}
