using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

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
        private List<Soldier> CreateArmy()
        {
            List<Soldier> myList = new List<Soldier>();
            Random r = new Random();
            for (int i = 1; i <= 100; i++)
            {
                myList.Add(new Soldier(i, $"Robot {i}")
                {
                    CountryId = i % 5 + 1,
                    NumberOfKills = r.Next(10, 500)

                });
            }
            return myList;
        }

        private List<Country> CreateCountries()
        {
            List<Country> myCountries = new List<Country>()

            {
                new Country(1, "USA"),
                new Country(2, "France"),
                new Country(3, "Germany"),
                new Country(4, "China"),
                new Country(5, "Italy"),

            };
            return myCountries;
        }

        public List<Soldier> GetTopFiveSoldiers()
        {
            List<Soldier> topFive = new List<Soldier>();
            topFive = soldiers.OrderByDescending(soldier => soldier.NumberOfKills).Take(5).ToList();
            return topFive;
        }
        public List<Country> GetCountries()
        {
            return countries;
        }

        public List<Soldier> RetrieveSoldiers()
        {
            List<Soldier> topFive= new List<Soldier>();
            topFive = soldiers.OrderByDescending(soldier => soldier.NumberOfKills).Take(5).ToList();
            return topFive;
        }
       
        public List<Soldier> GetChineseSoldiers()
        {
            List<Soldier> chineseSoldiers = new List<Soldier>();
            /*  foreach (var soldier in soldiers)
              {
                  if(soldier.CountryId == 4)
                  {
                      chineseSoldiers.Add(soldier);
                  }
              }*/

            chineseSoldiers = soldiers.Where(soldier => soldier.CountryId == 4).ToList();
            return chineseSoldiers;
        }

        public List<dynamic> GetFullReport()
        {
            //retrieve Chinese and US soldiers without their IDs (Name ="", Country="", Kills ="") ordered by number of Kills
            List<dynamic> reportedSoldiers = new List<dynamic>();
            reportedSoldiers = soldiers
                .Where(soldier => soldier.CountryId == 1 || soldier.CountryId == 4)
                .Select(soldier => (dynamic)new
                {
                    soldier.Name,
                    Kills = soldier.NumberOfKills,
                    Country = countries.Single(country => country.ID == soldier.CountryId).Name
                })
                .OrderByDescending(anonSoldier => anonSoldier.Kills)
                .Select(anotherSoldier => (dynamic)anotherSoldier).ToList();
            return reportedSoldiers;
        }

        public int GetLethality()
        {
            return soldiers.Sum(soldier => soldier.NumberOfKills);
        }
    }

   
}
