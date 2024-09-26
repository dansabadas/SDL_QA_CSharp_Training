using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class StudentRepository : iStudentRepository
    {
        string nameOfRepository;

        public ArrayList CreateAllStudents(int nr)
        {
            ArrayList students = new ArrayList();

            for (int i = 0; i < nr; i++)
            {
                Student student = new Student();

                student.ID = i;
                student.Name = "Some Name " + i;
                student.DateOfBirth = DateTime.Now.AddYears(-i);

                students.Add(student);
            }

            return students;
        }

        public ArrayList CreateAllStudents2(int nr)
        {
            ArrayList students = new ArrayList();

            for (int i = 0; i < nr; i++)
            {
                if (i % 2 == 0)
                {
                    Student student = new Student();

                    student.ID = i;
                    student.Name = "Some Name " + i;
                    student.DateOfBirth = DateTime.Now.AddYears(-i);

                    students.Add(student);
                }

            }

            return students;
        }
    }
}
