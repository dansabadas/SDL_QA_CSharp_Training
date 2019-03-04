using ArmyLayer;
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
        static void Main(string[] args)
        {
            RunSamples();

            Console.Read();
        }

        public static void RunSamples()
        {
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

            Console.WriteLine(myFirstArmy.GetTheMostLethalRomaniaSoldier());

            Console.WriteLine($"English soldiers: {myFirstArmy.GetNumberOfEnglishSoldiers()}");

            Console.WriteLine($"Average kills per US Soldier: {myFirstArmy.GetAverageNumberOfKillsForAmericanSoldiers()}");

            Country setCountry = new Country(1, "USA");
            Console.Write($"Average lethality for {setCountry.Name} soldiers: {myFirstArmy.GetAverageNumberOfKillsForSoldiersBelongingToCountry(setCountry)}");
        }
    }
}
