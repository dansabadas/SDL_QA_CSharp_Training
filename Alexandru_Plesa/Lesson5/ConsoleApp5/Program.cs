using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp5
{
    public class Student
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar1 = new ArrayList();
            ar1.Add(1);
            ar1.Add("hellow world");
            ar1.Add(DateTime.Now.Date);
            ar1.Add(new Student());

            //Console.WriteLine(ar1.Count);

            var retrievedData = ar1[3];

            IList<string> stringList = new List<string>();
            stringList.Add("Hello 1");

            IList<int> intList = new List<int>() { 1, 2, 3 };

            IList<Student> studentList = new List<Student>() { new Student() };
            studentList.Add(new Student());

            Student student = studentList[1];

            Army army = new Army();

            List<Soldier> army1 =  army.RetrueveSoldiers();

            //foreach(Soldier soldier in army1)
            //{
            //    Console.WriteLine(soldier);
            //}

            IList<Country> countries = army.GetCountries();

            //foreach (Country country in countries)
            //{
            //    Console.WriteLine(country);
            //}

            List<dynamic> army2 = army.GetFullReport(army1);

            foreach (var soldierReport in army2)
            {
                Console.WriteLine(soldierReport);
            }

            Console.ReadLine();
        }
    }
}
