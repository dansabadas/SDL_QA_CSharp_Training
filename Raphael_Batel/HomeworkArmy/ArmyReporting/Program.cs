using ArmyLayer;
using System;
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
        }

        static void RunSamples()
        {
            Army army = new Army();
            List<Soldier> soldiers = army.RetrieveArmy();
            foreach (Soldier s in soldiers)
            {
                Console.WriteLine(s);
            }

            List<Country> countries = army.GetCountries();
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            List<Soldier> chineseSoldiers = army.GetChineseSoldiers();
            foreach (Soldier s in chineseSoldiers)
            {
                Console.WriteLine(s);
            }

            List<Soldier> topSoldiers = army.GetTopFiveSoldiers();
            foreach (Soldier s in topSoldiers)
            {
                Console.WriteLine(s);
            }

            List<dynamic> reportedSoldiers = army.GetReportChinaAndUSA();
            foreach (dynamic s in reportedSoldiers)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(army.GetLethality());

            Console.WriteLine(army.GetTheMostLethalRomaniaSoldier());

            Console.WriteLine(army.GetNumberOfEnglishSoldiers());

            Console.WriteLine(army.GetAverageNumberOfKillsForAmericanSoldiers());

            foreach(Country c in army.GetCountries())
            {
                Console.WriteLine($"Average number of kills for country {c.Name}: {army.GetAverageNumberOfKillsForSoldiersBelongingToCountry(c)}");
            }
        }
    }
}
