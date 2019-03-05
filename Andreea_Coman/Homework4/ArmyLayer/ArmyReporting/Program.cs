using ArmyLayer;
using System;

namespace ArmyReporting
{
    class Program

    {
        static void Main(string[] args)
        
            {           
            RunSamples();
            Console.ReadKey();
        }      

        public static void RunSamples()
        {
            Army myArmy = new Army();
            Console.WriteLine("afisam toti soldatii: ");
            foreach (var soldier in myArmy.RetrieveSoldier())
            {
                Console.WriteLine(soldier);
            }
            Console.WriteLine("afisam tarile: ");
            foreach (var country in myArmy.GetCountries())
            {
                Console.WriteLine(country);
            }
            Console.WriteLine("afisam soldatii chinezi: ");
            foreach (var soldier in myArmy.GetChineseSoldiers())
            {
                Console.WriteLine(soldier);
            }
            Console.WriteLine("afisam primii 5 cei mai buni soldati: ");
            foreach (var soldier in myArmy.GetTopFive())
            {
                Console.WriteLine(soldier);
            }

            Console.WriteLine("afisam raportul soldatilor --- ");
            foreach (var soldierReport in myArmy.GetFullReport())
            {
                Console.WriteLine(soldierReport);
            }

            Console.WriteLine($"lethality = { myArmy.GetLethality()}");

            Console.WriteLine("tema ");

            Console.WriteLine("afisez cel mai bun sldat roman: ");

            foreach (var soldier in myArmy.GetTheMostLethalRomanianSoldier())
            {
                Console.WriteLine(soldier);
            }

            Console.WriteLine($"Numarul soldatilor englezi este {myArmy.GetNumberofEnglishSoldiers()}");

            Console.WriteLine($"Media soldatilor ucisi de americani = {myArmy.GetAverageNumberOfKillsForAmericanSoldiers()}");
        }
    }
 }
