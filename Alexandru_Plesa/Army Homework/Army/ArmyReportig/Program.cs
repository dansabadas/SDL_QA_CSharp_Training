using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyLayer;

namespace ArmyReportig
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSamples();
        }

        static void RunSamples()
        {
            IArmy army = new Army();

            List<Country> countries = army.GetCountries();
            List<Soldier> soldiers = army.RetrueveSoldiers();

            printSoldiers(soldiers);

            Country romania = countries.FirstOrDefault(country => country.ID == 2);
            Country unitedKingdom = countries.FirstOrDefault(country => country.ID == 3);
            Country unitedStates = countries.FirstOrDefault(country => country.ID == 1);

            List<Soldier> UkSoldiers = army.GetSoldiersByCountry(soldiers, unitedKingdom);
            printSoldiers(UkSoldiers);

            List<Soldier> UsaSoldiers = army.GetSoldiersByCountry(soldiers, unitedStates);
            printSoldiers(UsaSoldiers);

            Soldier mostLethalRomanianSoldier = army.GetTheMostLethalSoldierFromCountry(soldiers, romania);
            printSoldiers(mostLethalRomanianSoldier);


            double averageNumberOfKillsForUsaSildiers = army.GetAverageNumberOfKillsFromCountry(soldiers, unitedStates);
            Console.WriteLine(averageNumberOfKillsForUsaSildiers);

            Console.ReadLine();
        }

        static void printSoldiers(List<Soldier> soldiers)
        {
            foreach (Soldier soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        static void printSoldiers(Soldier soldier)
        {
            Console.WriteLine(soldier);
        }
    }
}
