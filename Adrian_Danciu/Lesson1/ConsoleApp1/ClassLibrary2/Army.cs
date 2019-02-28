using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
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
        public List<Soldier> CreateArmy()
        {

            List<Soldier> myList = new List<Soldier>();
            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                myList.Add(new Soldier(i, $"Robot {1}")
                {
                    CountryID = i % 5 + 1,
                    NumberOfKill = random.Next(10, 100)
                });
            }

            return myList;
        }

        public List<Country> CreateCountries()
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

        public List<Soldier> GetChineseSoldiers()
        {
            List<Soldier> chineseSoldiers = new List<Soldier>();
            //foreach (var soldier in soldiers)
            //{
            //    if (soldier.CountryID == 5)
            //    {
            //        chineseSoldiers.Add(soldier);
            //    }

            chineseSoldiers = soldiers.Where(soldier => soldier.CountryID == 5)
            .ToList();
            return chineseSoldiers;
        }

        public List<Country> GetCountries()
        {
            return countries;
        }

        public List<Soldier> GetTopFiveSoldiers()
        {

            List<Soldier> topFive = new List<Soldier>();
            topFive = soldiers
              .OrderByDescending(soldier => soldier.NumberOfKill)
              .Take(5)
              .ToList();

            return topFive;
        }

        public List<Soldier> RetrieveSoldiers()
        {
            return soldiers;
        }

        public List<dynamic> GetFullReport()
        {
            //retieve chinese and Us soldiers only
            //witout their IDs
            List<dynamic> reportedSoldiers = new List<dynamic>();
            reportedSoldiers = soldiers
                .Where(soldier => soldier.CountryID == 1 || soldier.CountryID == 5)
                .Select(soldier => new
                {
                    Name = soldier.Name,
                    Kills = soldier.NumberOfKill,
                    Country = countries.Single(country => country.Id == soldier.CountryID).Name
                })
                .OrderByDescending(anonSoldier => anonSoldier.Kills)
                .Select(anonSoldier => (dynamic)anonSoldier)
                .ToList();
            return reportedSoldiers;
        }

        public int GetLethality()
        {
            return soldiers.Sum(soldier => soldier.NumberOfKill);
        }
    }

}
