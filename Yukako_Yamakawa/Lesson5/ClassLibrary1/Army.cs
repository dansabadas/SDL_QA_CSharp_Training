using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
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
                    CountryId = i % 5 +1,
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
                // there is no Army in JPN ;)
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
            List< Soldier > chineseSoldiers = new List<Soldier>();
            //foreach (var soldier in soldiers)
            //{
            //    if (soldier.CountryId == 5)
            //    {
            //        chineseSoldiers.Add(soldier);
            //    }
            //}
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
                    Name =soldier.Name,
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
    }
}
