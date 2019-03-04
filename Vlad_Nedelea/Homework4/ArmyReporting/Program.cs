using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyLayer;
using ClassLibrary1;

namespace ArmyReporting
{
    class Program
    {
        public static void RunSamples()
        {         
            IArmy army1 = new Army();

            var army2 = army1.RetrieveSoldiers();
            var army3 = army1.RetrieveCountries();
            foreach (object o in army2)
            {
                Console.WriteLine(o.ToString());
            }

            foreach (object o in army3)
            {
                Console.WriteLine(o.ToString());
            }

            foreach (var o in army1.GetTop())
            {
                Console.WriteLine(o.Name);
            }

            //Homewrok

            Soldier s1 = army1.GetTheMostLethalRomaniaSoldier();

            Console.WriteLine("Most lethal romania soldier is "+s1);

            int numberOfEnglishSoldiers = army1.GetNumberOfEnglishSoldiers();

            Console.WriteLine("Number of english soldiers is " + numberOfEnglishSoldiers);

            double  americanKills = army1.GetAverageNumberOfKillsForAmericanSoldiers();

            Console.WriteLine("Average Number Of Kills For American Soldiers is " + americanKills);

            double allAverage = army1.GetAverageNumberOfKillsForSoldiersBelongingToCountry(new Country(1, "USA"));

            Console.WriteLine("Average nr of kills belonging to country is " + allAverage);

        }

        static void Main(string[] args)
        {
            RunSamples();
        }
    }
}
