using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyReporting
{
    class Program
    {
        public class Student
        {

        }
        static void Main(string[] args)
        {
            RunSamples();
        }

        public static void RunSamples()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(1);                   // struct => value type; because arraylist only accepts objects, it will first cast the integer to an object (autoboxing) => performance affected
            arr1.Add("hello, world!");     // class => reference type
            arr1.Add(DateTime.Now.Date);
            arr1.Add(new Student());

            Console.WriteLine($"{arr1.Count}");

            var retrievedData = (DateTime)arr1[2];
            List<string> stringList1 = new List<string>();
            stringList1.Add("hello1");
            // stringList1.Add(new Student());
            List<int> intList2 = new List<int>() { 1, 2, 3 };
            List<Student> studentList3 = new List<Student>() { new Student() };
            studentList3.Add(new Student());
            Student studentRetrieved = studentList3[1];

            IArmy myFirstArray = new Army();
            IArmy mySecondArray = new Army();
            IArmy mythirdArray = new Army();
            IArmy myFourthArray = new Army();
            foreach (var soldier in myFirstArray.RetrieveSoldiers())
            {
                Console.WriteLine(soldier);
            }

            foreach (var country in mySecondArray.GetCountries())
            {
                Console.WriteLine(country);
            }
            foreach (var chinese in mythirdArray.GetChineseSoldiers())
            {
                Console.WriteLine(chinese);
            }
            foreach (var top in myFourthArray.GetTopFiveSoldiers())
            {
                Console.WriteLine($"top{top}");
            }
            foreach (var kills in myFourthArray.GetFullReport())
            {
                Console.WriteLine(kills);
            }

            Console.WriteLine($"lethality=" + myFirstArray.GetLethality());

            // Homework 

            Console.WriteLine($"Top Romanian killer = " + myFirstArray.GetTheMostLethalRomaniaSoldier());

            Console.WriteLine($"Total number of USA soldiers = " + myFirstArray.GetNumberOfEnglishSoldiers());

            Console.WriteLine($"Average number of kills in the USA = " + myFirstArray.GetAverageNumberOfKillsForAmericanSoldiers());

            string[] countryList = { "USA", "Romania", "Germany", "China", "Italy" };
            for (int i = 0; i < 5; i++)
            {
                Country myCountry = new Country(i + 1, countryList[i]);
                Console.WriteLine($"Average number of kills in {myCountry.Name} = " + myFirstArray.GetAverageNumberOfKillsForSoldiersBelongingToCountry(myCountry));
            }
        }
    }
}
