using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
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
            ar1.Add("Hellow World!");
            ar1.Add(DateTime.Now.Date);
            ar1.Add(new Student());

            Console.WriteLine(ar1.Count);

            var retrivedData = (DateTime)ar1[2];

            List<string> stringList1 = new List<string>();
            stringList1.Add("Hello 1");
            List<int> intList2 = new List<int>() { 1, 2, 3 };

            List<Student> myStudentList3 = new List<Student>() { new Student()};
            myStudentList3.Add(new Student());
            Student studentRetreived = myStudentList3[1];

            IArmy myFirstArmy = new Army();
            foreach(var soldier in myFirstArmy.RetrieveSoldiers())
            {
                Console.WriteLine(soldier);
            }

            foreach(var country in myFirstArmy.GetCountries())
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

            foreach (var soldier in myFirstArmy.GetFullReport())
            {
                Console.WriteLine(soldier);
            }

            Console.WriteLine($"Lethality= {myFirstArmy.GetLethality()}");

            Console.Read();
        }
    }
}
