using Lesson5_ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Console
{
    class Student
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar1 = new ArrayList();
            ar1.Add(1);
            ar1.Add("Hello");
            ar1.Add(DateTime.Now);
            ar1.Add(new Student());

            Console.WriteLine(ar1.Count);

            var retrievedData = (DateTime) ar1[2];

            List<string> stringList2 = new List<string>();
            stringList2.Add("Hello1");

            List<int> intList = new List<int>() { 1, 2, 3 };

            List<Student> studentList = new List<Student> { new Student() };
            studentList.Add(new Student());
            Student studentRetrieved = studentList[1];

            Army army = new Army();
            List<Soldier> soldiers = army.RetrieveArmy();
            foreach(Soldier s in soldiers)
            {
                Console.WriteLine(s);
            }

            List<Country> countries = army.GetCountries();
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            List<Soldier> chineseSoldiers = army.GetChineseSoldiers();
            foreach (Soldier s in chineseSoldiers)
            {
                Console.WriteLine(s);
            }

            List<Soldier> topSoldiers = army.GetTopFiveSoldiers();
            foreach (Soldier s in topSoldiers)
            {
                Console.WriteLine(s);
            }

            List<dynamic> reportedSoldiers = army.GetReportChinaAndUSA();
            foreach (dynamic s in reportedSoldiers)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(army.GetLethality());
        }
    }
}
