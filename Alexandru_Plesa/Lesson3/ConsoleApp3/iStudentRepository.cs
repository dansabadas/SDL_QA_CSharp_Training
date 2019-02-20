using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface iStudentRepository
    {
        ArrayList CreateAllStudents(int nr);
        ArrayList CreateAllStudents2(int nr);
    }
}
