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
            ar1.Add("Hello World!");
            ar1.Add(DateTime.Now.Date);
            ar1.Add(new Student());

            Console.WriteLine($"{ar1.Count}");

            var retrieveData = (DateTime)ar1[2];

            List<string> stringList1 = new List<string>();
            stringList1.Add("Hello 1");
            //stringList1.Add();  //new Student will be rejected
            List<int> intList2 = new List<int>() { 1, 2, 3 };

            List<Student> myStudentList3 = new List<Student>() { new Student () };
            myStudentList3.Add(new Student());
            Student studentRetrieved = myStudentList3[1];

            IArmy myFirstArmy = new Army();
            foreach (var soldier in myFirstArmy.RetrieveArmy())
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

            foreach (var soldier in myFirstArmy.GetFullReport())
            {
                Console.WriteLine(soldier);
            }

            Console.WriteLine($"lethality={myFirstArmy.GetLethality()}");

        }
    }
}
