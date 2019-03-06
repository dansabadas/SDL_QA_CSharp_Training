using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
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
            ar1.Add("hello world");
            ar1.Add(DateTime.Now.Date);
            ar1.Add(new Student());

            Console.WriteLine($"{ar1.Count}");

            var retrievedData = (DateTime)ar1[2];

            List<string> stringList1 = new List<string>();
            stringList1.Add("hello 1");
            List<int> intList2 = new List<int>() { 1, 2, 3 };

            List<Student> myStudentList3 = new List<Student>() { new Student() };
            myStudentList3.Add(new Student());
            Student studentRetrieved = myStudentList3[1];

            IArmy myFirstArmy = new Army();
            foreach (var soldier in myFirstArmy.RetrieveSoldiers())
            {
                Console.WriteLine(soldier);
            }

            foreach (var country in myFirstArmy.GetCountries())
            {
                Console.WriteLine(country);
            }

            foreach (var soldier in myFirstArmy.GetChineseSoldiers())
            {
                Console.WriteLine(soldier);
            }

            foreach (var soldier in myFirstArmy.GetTopFiveSoldiers())
            {
                Console.WriteLine(soldier);
            }

            foreach (var soldierReport in myFirstArmy.GetFullReport())
            {
                Console.WriteLine(soldierReport);
            }

            Console.WriteLine($"lethality={myFirstArmy.GetLethality()}");
        }
    }
}