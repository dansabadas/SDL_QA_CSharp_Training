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
        public Army()  // constructor 
        {
            soldiers = CreateSoldier(20);
            countries = CreateCountries();
        }
        private List<Soldier> CreateSoldier(int soldiers)
        {
            List<Soldier> army = new List<Soldier>();
            Random rnd = new Random();

            for (int soldier = 0; soldier < soldiers; soldier++)
            {
                Soldier sol = new Soldier(soldier, "Soldier " + soldier);
                sol.CountryId = soldier % 5;
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
            new Country(2, "Japan"),
            new Country(3, "UK"),
            new Country(4, "Germany"),
            new Country(5, "China")

            };
        return countries;
        }

        public List<Soldier> RetrieveSoldier()
        {
            return soldiers;
        }

        public List<Country> GetCountries()
        {
            return countries;
        }

        public List<Soldier> GetTopFive()
        {
            List<Soldier> TopFive = new List<Soldier>();
            TopFive = soldiers.OrderByDescending(soldier => soldier.NrOfKills).Take(5).ToList();
            return TopFive;
        }

        public List<Soldier> GetChineseSoldiers()
        {
            List<Soldier> ChineseSoldiers = new List<Soldier>();
            //foreach (var soldier in soldiers)
            //{
            //    if (soldier.CountryId == 5)
            //        ChineseSoldiers.Add(soldier);
            //}
            ChineseSoldiers = soldiers.Where(soldiers => soldiers.CountryId == 5).ToList();
            return soldiers;
        }

        public List<dynamic> GetFullReport()
        {
            //chinese and USA soldiers, whithout theyr ID's (name=" ", country = "", kills = "") ordered by number of kills
            List < dynamic > SoldiersInReport = new List<dynamic>();
            SoldiersInReport = soldiers.Where(soldier => soldier.CountryId == 1 || soldier.CountryId == 5)
                .Select(soldier => (dynamic)new { Name = soldier.Name, kills = soldier.NrOfKills, Country = countries.Single(Country => Country.Id == soldier.CountryId).Name})
                .OrderByDescending(anonSoldier => anonSoldier.kills)
                .Select(anonSoldier => (dynamic)anonSoldier)
                .ToList();

            return SoldiersInReport;
                 }

        public int GetLethality()
        {
            return soldiers.Sum(soldier => soldier.NrOfKills);
        }
    }
  }
