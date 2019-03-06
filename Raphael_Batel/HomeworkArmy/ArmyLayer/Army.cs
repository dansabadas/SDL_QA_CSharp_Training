using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyLayer
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
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    Kills = s.NumberKills,
                    Country = countries.Single(c => c.Id == s.CountryId).Name,
                    CountryId = s.CountryId
                })
                .OrderByDescending(ds => ds.Kills)
                .Select(ds => (dynamic)ds)
                .ToList();
            return reportedSoldiers;
        }

        public List<Soldier> GetTopFiveSoldiers()
        {
            List<Soldier> returnSoldiers =
                soldiers.OrderByDescending(s => s.NumberKills).Take(5).ToList();
            return returnSoldiers;
        }

        public Soldier GetTheMostLethalRomaniaSoldier()
        {
            int? idRomania = countries.SingleOrDefault(c => c.Name == "Romania")?.Id;
            IEnumerable<Soldier> romanianSoldiers = soldiers.Where(s => s.CountryId == idRomania);
            if (!romanianSoldiers.Any())
                return null;
            int maxKillsRomania = romanianSoldiers.Max(s => s.NumberKills);
            return soldiers.First(s => s.NumberKills == maxKillsRomania);
        }

        public int GetNumberOfEnglishSoldiers()
        {
            int? idUK = countries.SingleOrDefault(c => c.Name == "UK")?.Id;
            return soldiers.Count(s => s.CountryId == idUK);
        }

        public double GetAverageNumberOfKillsForAmericanSoldiers()
        {
            int? idUSA = countries.SingleOrDefault(c => c.Name == "USA")?.Id;
            IEnumerable<Soldier> usSoldiers = soldiers.Where(s => s.CountryId == idUSA);
            if (!usSoldiers.Any())
                return double.NaN;
            return usSoldiers.Average(s => s.NumberKills);
        }

        public double GetAverageNumberOfKillsForSoldiersBelongingToCountry(Country country)
        {
            if (country == null)
            {
                throw new ArgumentNullException(nameof(country));
            }

            IEnumerable<Soldier> countrySoldiers = soldiers.Where(s => s.CountryId == country.Id);
            if (!countrySoldiers.Any())
                return double.NaN;
            return countrySoldiers.Average(s => s.NumberKills);
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
                new Country(4, "UK"),
                new Country(5, "China")
            };
        }
    }
}
