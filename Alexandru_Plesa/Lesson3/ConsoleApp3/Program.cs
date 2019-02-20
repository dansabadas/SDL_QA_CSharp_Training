using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {
    
        static void Main(string[] args)
        {
            Student student = new Student();
            iStudentRepository studentRepository = new StudentRepository();

            ArrayList students = studentRepository.CreateAllStudents(10);

            foreach(Student stud in students)
            {
                Console.WriteLine($"Student {stud.Name} has the ID {stud.ID} and was born {stud.DateOfBirth}");
            }

            ArrayList students2 = studentRepository.CreateAllStudents2(10);

            foreach (Student stud in students2)
            {
                Console.WriteLine($"Student {stud.Name} has the ID {stud.ID} and was born {stud.DateOfBirth}");
            }

            iGeometryFactory randomPoints = new GeometryFactory();
            ArrayList points = randomPoints.GetMyPoints(20);
            
            foreach (Point2D pnt in points)
            {  
                Console.WriteLine(pnt.ToString());
            }

            Point2D point2D = randomPoints.GetRandomPoint(10, 10);
            Point3D point3D = randomPoints.GetRandomPoint(10, 10, 10);

            double distanceBetween2DPoints = randomPoints.CalculateDistance(point2D);
            double distanceBetween3DPoints = randomPoints.CalculateDistance(point3D);

            Console.WriteLine(point2D);
            Console.WriteLine(point3D);

            Console.WriteLine($"Distance between the 2 points is: {distanceBetween2DPoints}");
            Console.WriteLine($"Distance between all 3 points is: {distanceBetween3DPoints}");

            Console.ReadLine();
            
            
        }
    }
}
