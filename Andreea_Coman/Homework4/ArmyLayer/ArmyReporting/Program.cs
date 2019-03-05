using ArmyLayer;
using System;

namespace ArmyReporting
{
    class Program

    {
        static void Main(string[] args)
        
            {
            Army myArmy = new Army();
            foreach (var soldier in myArmy.RetrieveSoldier())
            {
                Console.WriteLine(soldier);
            }
            foreach (var country in myArmy.GetCountries())
            {
                Console.WriteLine(country);
            }

            foreach (var soldier in myArmy.GetChineseSoldiers())
            {
                Console.WriteLine(soldier);
            }

            foreach (var soldier in myArmy.GetTopFive())
            {
                Console.WriteLine(soldier);
            }

            foreach (var soldierReport in myArmy.GetFullReport())
            {
                Console.WriteLine(soldierReport);
            }

            Console.WriteLine($"lethality = { myArmy.GetLethality()}");

            Console.ReadKey();
        }      
    }
 }
