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

            foreach (Soldier soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }

            Country romania = countries.FirstOrDefault(country => country.ID == 2);
            Country unitedKingdom = countries.FirstOrDefault(country => country.ID == 3);
            Country unitedStates = countries.FirstOrDefault(country => country.ID == 1);

            List<Soldier> uKsoldiers = army.GetSoldiersByCountry(soldiers, unitedKingdom);
            Soldier mostLethalRomanianSoldier = army.GetTheMostLethalSoldierFromCountry(soldiers, romania);
            double averageNumberOfKillsForUsaSildiers = army.GetAverageNumberOfKillsFromCountry(soldiers, unitedStates);

            Console.WriteLine("");
        }
    }
}
