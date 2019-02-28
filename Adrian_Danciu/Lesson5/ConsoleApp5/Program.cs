using ClassLibrary2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class student
    {

    }

    public class Program

    {
        static void Main(string[] args)
        {
            ArrayList ar1 = new ArrayList();
            ar1.Add(1);
            ar1.Add("Hello World");
            ar1.Add(DateTime.Now.Date);
            ar1.Add(new student());

            Console.WriteLine($"{ar1.Count}");

            var retrivedData = (DateTime)ar1[2];

            List<string> stringList1 = new List<string>();
            stringList1.Add("hello1");
            List<int> intList2 = new List<int>() { 1, 2, 3 };

            List<student> myStudentList3 = new List<student>() { new student() };
            myStudentList3.Add(new student());
            student studentRetived = myStudentList3[1];

            IArmy myFirstArmy = new Army();
            foreach (var soldier in myFirstArmy.CreateArmy())
            {
                Console.WriteLine(soldier);
            }

            foreach (var country in myFirstArmy.CreateCountries())
            {
                Console.WriteLine(country);
            }

            foreach (var chineseSoldier in myFirstArmy.GetChineseSoldiers())
            {
                Console.WriteLine(chineseSoldier);
            }

            foreach (var topFive in myFirstArmy.GetTopFiveSoldiers())
            {
                Console.WriteLine(topFive);
            }

            foreach (var soldierReport in myFirstArmy.GetFullReport())
            {
                Console.WriteLine(soldierReport);
            }

            Console.WriteLine($"lethality={myFirstArmy.GetLethality()}");

        }
    }
}
