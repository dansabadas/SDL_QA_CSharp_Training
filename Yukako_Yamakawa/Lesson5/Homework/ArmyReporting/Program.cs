using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyLayer;

namespace ArmyReporting
// Create a new solution where you add 2 projects: a. class library called ArmyLayer b. the second project is a console application called ArmyReporting
// 2. Copy-paste the Army related code (along with IArmy interface and Country and Soldier classes) into the first project (ArmyLayer library project) created above.
// Run all samples that we created in the Main method putting them in a new static method called RunSamples.
// This RunSamples should be created in the Program.cs class of the ArmyReporting console application and invoked from the Main method.
// 3. Enrich the IArmy interface by declaring a method 'Soldier GetTheMostLethalRomaniaSOldier()' and implement this method in the Army class. 
// Then call this method in the RunSamples static method and print to the console the most lethal romanian soldier
// 4. Enrich the IArmy interface by declaring a method 'int GetNumberOfEnglishSoldiers()' and implement it in the Army class. 
// If in the whole army list of soldiers we have let's say 53 (or whatever number) soldiers that have the COuntryId equal to the Id of UK, 
// then I want this number 53 returned. Please also print this info to the console by adding the code into the RunSamples method.
// 5. Enrich the IArmy interface by declaring a method 'double GetAverageNumberOfKillsForAmericanSoldiers()' and implement it and 
// display it to the console repeating the approach described above. I want the average of kills for the americans.
// 6. Refine the method at point 6 by declaring another method in the IArmy called 'double GetAverageNumberOfKillsForSoldiersBelongingToCountry(Country country)' 
// where if I pass a country object, let's say China, or UK, it will basically do what you did at point 5 but will match the country-id of the country object passed as parameter,
// so later I can iterate through all the countries and print this report for each country.
// that's all, folks!

{
    static class Program
    {
        static void Main(string[] args)
        {
            RunSamples();
        }

        public static void RunSamples()
        {
            IArmy myArmy = new Army();

            Console.WriteLine($"Number of English soldiers : {myArmy.GetNumberOfEnglishSoldiers()}");

            Console.WriteLine($"Most lethal Romanian soldier : {myArmy.GetTheMostLethalRomanianSoldier()}");

            Console.WriteLine($"Average of kills for American soldiers : { myArmy.GetAverageNumberOfKillsForAmericanSoldiers()}");

            // Unfinished method
            // Console.WriteLine($"Average of kills for the soldiers from the country : { myArmy.GetAverageNumberOfKillsForSoldiersBelongingToCountry()}");

        }
    }
}
