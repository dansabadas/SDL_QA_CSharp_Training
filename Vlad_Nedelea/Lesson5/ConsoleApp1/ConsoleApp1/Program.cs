using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar1= new ArrayList();
            ar1.Add(value: 1);
            ar1.Add(value: "string");
            ar1.Add(DateTime.Now.Date);
            ar1.Add(new Student());

            Console.WriteLine(ar1.Count);

            var retrievedData = (DateTime)ar1[2];

            List<string> stringList1 = new List<string>();
            stringList1.Add("hello1");
            List<int> list2 = new List<int>();
            List<Student> list3 = new List<Student>() { new Student()};
            list3.Add(new Student());
            Student st = list3[1];

            IArmy army1 = new Army();

            var army2 = army1.RetrieveSoldiers();
            var army3 =army1.RetrieveCountries();
            foreach(object o in army2)
            {
                Console.WriteLine(o.ToString());
            }

            foreach (object o in army3)
            {
                Console.WriteLine(o.ToString());
            }

            foreach(var o in army1.GetTop())
            {
                Console.WriteLine(o.Name);
            }



        }
    }
}
