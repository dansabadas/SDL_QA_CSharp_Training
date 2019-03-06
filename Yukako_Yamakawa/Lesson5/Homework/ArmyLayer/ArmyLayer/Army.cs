using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyLayer
{
    // Create a new solution where you add 2 projects: a. first project is a class library called ArmyLayer b a console application called ArmyReporting
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

    public class Army : IArmy
    {
        private List<Soldier> soldiers;
        private List<Country> countries;
        
        public Army()
        {
            soldiers = CreateArmy();
            countries = CreateCountries();
        }

        public List<Soldier> RetrieveArmy()
        {
            return soldiers;
        }

        private List<Soldier> CreateArmy()
        {
            List<Soldier> myList = new List<Soldier>();
            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                myList.Add(new Soldier(i, $"Robocop {i}")
                {
                    CountryId = i % 5 + 1,
                    NumberOfKills = random.Next(10, 500)
                }
                );
            }
            return myList;
        }

        private List<Country> CreateCountries()
        {
            List<Country> countries = new List<Country>

            {
                new Country(1, "USA"),
                new Country(2, "Romania"),
                new Country(3, "UK"),
                new Country(4, "Germany"),
                new Country(5, "China"),
                
            };

            return countries;



        }
        public List<Soldier> RetrieveSoldiers()
        {
            return soldiers;
        }

        public List<Country> GetCountries()
        {
            return countries;
        }

        public List<Soldier> GetTopFiveSoldiers()
        {
            List<Soldier> topFive = new List<Soldier>();
            topFive = soldiers.OrderBy(soldier => soldier.NumberOfKills)
                .Take(5)
                .ToList();
            return topFive;

        }

        public List<Soldier> GetChineseSoldiers()
        {
            List<Soldier> chineseSoldiers = new List<Soldier>();
            chineseSoldiers = soldiers
                .Where(soldier => soldier.CountryId == 5)
                .ToList();

            return chineseSoldiers;

        }

        public List<dynamic> GetFullReport()
        {
            // retrieve Chinese and US soldiers only without their IDs (Name ='', Kills =''), ordered by the number of kills
            List<dynamic> reportedSoldiers = new List<dynamic>();
            reportedSoldiers = soldiers
                .Where(soldier => soldier.CountryId == 1 || soldier.CountryId == 5)
                .Select(soldier => new
                {
                    Name = soldier.Name,
                    Kills = soldier.NumberOfKills,
                    Country = countries.Single(country => country.Id == soldier.CountryId).Name
                }
                )
                .OrderByDescending(anonSoldier => anonSoldier.Kills)
                .Select(anonSoldier => (dynamic)anonSoldier)
                .ToList();

            return reportedSoldiers;

        }

        public int GetLethality()
        {
            return soldiers.Sum(soldier => soldier.NumberOfKills);
        }




        //The following method returns no value in the console. May I ask what may be missing here?
        public Soldier GetTheMostLethalRomanianSoldier()
        {
            List<Soldier> romanianSoldiers = new List<Soldier>();
            romanianSoldiers = GetSoldiersByCountryID(2);

            var soldier = soldiers
                .OrderByDescending(s => s.NumberOfKills)
                .Take(1);

            return soldier as Soldier;
        }

        public int GetNumberOfEnglishSoldiers()
        {
            int counter = 0;
            foreach (var soldier in soldiers)
            {
                if (soldier.CountryId == 3)
                {
                    counter++;
                }
            }

            return counter;
        }




        private List<Soldier> GetSoldiersByCountryID(int countryID)
        {
            List<Soldier> soldiersByCountryID = new List<Soldier>();
            soldiersByCountryID = soldiers
                .Where(soldier => soldier.CountryId == countryID)
                .ToList();

            return soldiersByCountryID;
        }
        public double GetAverageNumberOfKillsForAmericanSoldiers()
        {
            List<Soldier> americanSoldiers = new List<Soldier>();
            americanSoldiers = GetSoldiersByCountryID(1);

            return americanSoldiers.Average(soldier => soldier.NumberOfKills);

        }

        public double GetAverageNumberOfKillsForSoldiersBelongingToCountry(Country country)
        {
            throw new NotImplementedException();
        }

        //// Unfinished method
        //public double GetAverageNumberOfKillsForSoldiersBelongingToCountry(Country country)
        //{

        //    return soldiersByCountryID.Average(soldier => soldier.NumerOfKills);
        //}
    }
}
