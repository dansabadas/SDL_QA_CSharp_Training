using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_ClassLibrary
{
    public class Army : IArmy
    {
        private const int numberSoldiers = 100;
        private List<Country> countries = new List<Country>();
        private List<Soldier> soldiers = new List<Soldier>();

        public Army()
        {
            countries = CreateCountries();
            soldiers = CreateArmy();
        }

        public List<Soldier> GetChineseSoldiers()
        {
            int idChina = countries.Where(c => c.Name == "China").Single().Id;
            return soldiers.Where(s => s.CountryId == idChina).ToList();
        }

        public List<Country> GetCountries()
        {
            return countries;
        }

        public int GetLethality()
        {
            return soldiers.Sum(s => s.NumberKills);
        }

        public List<dynamic> GetReportChinaAndUSA()
        {
            List<dynamic> reportedSoldiers;
            reportedSoldiers =
                soldiers.Where(s => s.CountryId == 1 || s.CountryId == 5)
                .Select(s => (dynamic) new
                {
                    Name = s.Name,
                    Kills = s.NumberKills,
                    Country = countries.Single(c => c.Id == s.CountryId).Name
                    })
                .OrderByDescending(ds => ds.Kills)
                //.Select( ds => (dynamic) ds)
                .ToList();
            return reportedSoldiers;
        }

        public List<Soldier> GetTopFiveSoldiers()
        {
            List<Soldier> returnSoldiers =
                soldiers.OrderByDescending(s => s.NumberKills).Take(5).ToList();
            return returnSoldiers;
        }

        public List<Soldier> RetrieveArmy()
        {
            return soldiers;
        }

        private List<Soldier> CreateArmy()
        {
            List<Soldier> soldiers = new List<Soldier>();
            Random rand = new Random();
            for (int i = 0; i < numberSoldiers; i++)
            {
                soldiers.Add(new Soldier(i, $"Soldier {i}") { CountryId = 1 + i % countries.Count, NumberKills = rand.Next(0, 1000) });
            }
            return soldiers;
        }

        private List<Country> CreateCountries()
        {
            return new List<Country>
            {
                new Country(1, "USA"),
                new Country(2, "Romania"),
                new Country(3, "Germany"),
                new Country(4, "Russia"),
                new Country(5, "China")
            };
        }
    }
}
