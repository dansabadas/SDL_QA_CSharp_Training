using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyLayer
{
    public class Army : IArmy
    {
        private List<Soldier> _soldiers;
        private List<Country> _countries;

        public Army()
        {
            _soldiers = CreateArmy();
            _countries = CreateCountries();
        }

        private List<Soldier> CreateArmy()
        {
            List<Soldier> army = new List<Soldier>();
            Random rnd = new Random();

            for (int soldier = 1; soldier <= 100; soldier++)
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

        public List<Soldier> GetSoldiersByCountry(List<Soldier> soldiers, Country country)
        {
            List<Soldier> sameCountrySoldiers = soldiers.Where(sold => sold.CountryId == country.ID).ToList();
            return sameCountrySoldiers;
        }

        public Soldier GetTheMostLethalSoldierFromCountry(List<Soldier> soldiers, Country country)
        {
            List<Soldier> sameCountrySoldiers = GetSoldiersByCountry(soldiers, country);
            List<Soldier> soldiersOrderdByKills = OrderSoldiersByKills(sameCountrySoldiers);
            Soldier mostLethalSoldier = soldiersOrderdByKills[0];

            return mostLethalSoldier;
        }

        private List<Soldier> OrderSoldiersByKills(List<Soldier> soldiers)
        {
            return soldiers.OrderByDescending(soldier => soldier.NrOfKills).ToList();
        }

        public double GetAverageNumberOfKillsFromCountry(List<Soldier> soldiers, Country country)
        {
            List<Soldier> sameCountrySoldiers = GetSoldiersByCountry(soldiers, country);
            return sameCountrySoldiers.Average(soldier => soldier.NrOfKills);
        }
    }
}
