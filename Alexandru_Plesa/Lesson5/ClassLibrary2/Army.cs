using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Army : IArmy
    {
        private List<Soldier> _soldiers;
        private List<Country> _countries;
        public Army()
        {
            _soldiers = CreateArmy(100);
            _countries = CreateCountries();
        }
        private List<Soldier> CreateArmy(int soldiers)
        {
            List<Soldier> army = new List<Soldier>();
            Random rnd = new Random();
            
            for (int soldier = 1; soldier <= soldiers; soldier++)
            {
                Soldier sol = new Soldier(soldier, "Soldier " + soldier);
                sol.CountryId = (soldier % 5) + 1;
                sol.NrOfKills = rnd.Next(0, 100);
                army.Add(sol);
            }

            return army;
        }

        private List<Country> CreateCountries()
        {
            List<Country> countries = new List<Country>()
            {
                new Country(1, "USA"),
                new Country(2, "Romania"),
                new Country(3, "UK"),
                new Country(4, "Germany"),
                new Country(5, "China")
            };


            return countries;
        }

        public List<Soldier> RetrueveSoldiers()
        {
            return _soldiers;
        }

        public List<Country> GetCountries()
        {
            return _countries;
        }

        public List<Soldier> GetTopFiveSoldiers(List<Soldier> soldiers)
        {
            List<Soldier> topFive = new List<Soldier>();
            topFive = soldiers.OrderByDescending(soldier => soldier.NrOfKills).Take(5).ToList();

            return topFive;
        }

        public List<Soldier> GetNationSoldiers(List<Soldier> soldiers, Country country)
        {
            List<Soldier> army = soldiers.Where<Soldier>(sold => sold.ID == country.ID).ToList();
            return army;
        }

        public List<dynamic> GetFullReport(List<Soldier> soldiers)
        {
            List<dynamic> reportedSoldiers = new List<dynamic>();
            reportedSoldiers = soldiers.Where(soldier => soldier.CountryId == 1 || soldier.CountryId == 5)
                .Select(soldir => new
            {
                Name = soldir.Name,
                Kills = soldir.NrOfKills,
                country = _countries.Single(country => country.ID == soldir.CountryId).Name
            })
            .OrderByDescending(anonSoldier => anonSoldier.Kills)
            .Select(anonSoldier => (dynamic)anonSoldier)
            .ToList();

            return reportedSoldiers;
        }

        public int GetLetality()
        {
            return _soldiers.Sum(soldier => soldier.NrOfKills);
        }
    }
}
