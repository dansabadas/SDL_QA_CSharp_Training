﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyLayer
{
    public class Country
    {
        public int ID { get; }
        public string Name { get; }

        public Country(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ID}, {Name}";
        }
    }

    public class Army : IArmy
    {
        private List<Soldier> soldiers;
        private List<Country> countries;

        public Army()
        {
            soldiers = CreateArmy();
            countries = CreateCountries();
        }

        public double GetAverageNumberOfKillsForAmericanSoldiers()
        {
            var usSoldiers = soldiers.Where(soldier => soldier.CountryId == 1).Select(soldier => (double) soldier.NumberOfKills).ToArray();
            return usSoldiers.Sum() / usSoldiers.Length;
        }

        public double GetAverageNumberOfKillsForSoldiersBelongingToCountry(Country country)
        {
            var usSoldiers = soldiers.Where(soldier => soldier.CountryId == country.ID).Select(soldier => (double)soldier.NumberOfKills).ToArray();
            return usSoldiers.Sum() / usSoldiers.Length;
        }

        public List<Soldier> GetChineseSoldiers()
        {
            List<Soldier> chineseSoldiers = new List<Soldier>();
            //foreach (var soldier in soldiers)
            //{
            //    if(soldier.CountryId == 5)
            //    {
            //        chineseSoldiers.Add(soldier);
            //    }
            //}
            chineseSoldiers = soldiers
                .Where(soldier => soldier.CountryId == 5)
                .ToList();
            return chineseSoldiers;
        }

        public List<Country> GetCountries()
        {
            return countries;
        }

        public List<dynamic> GetFullReport()
        {
            // Retrieve chinese and US soldiers only
            // without their IDs ( Name = '', Country = '', Kills = '')
            List<dynamic> reportedSoldiers = new List<dynamic>();
            reportedSoldiers = soldiers.Where(soldier => soldier.CountryId == 1 || soldier.CountryId == 5)
                .Select(soldier => new
                {
                    Name = soldier.Name,
                    Kills = soldier.NumberOfKills,
                    Country = countries.Single(country => country.ID == soldier.CountryId).Name
                })
                .OrderByDescending(anonSoldier => anonSoldier.Kills)
                .Select(anonSoldier => (dynamic)anonSoldier)
                .ToList();

            return reportedSoldiers;
        }

        public int GetLethality()
        {
            return soldiers.Sum(soldiers => soldiers.NumberOfKills);
        }

        public int GetNumberOfEnglishSoldiers()
        {
            return soldiers.Where(soldiers => soldiers.CountryId == 3).ToList().Count;
        }

        public Soldier GetTheMostLethalRomaniaSoldier()
        {
            List<Soldier> mostLethal = soldiers.Where(soldier => soldier.CountryId == 2).OrderByDescending(soldier => soldier.NumberOfKills).ToList();
            return mostLethal[0];
        }

        public List<Soldier> GetTopFiveSoldiers()
        {
            List<Soldier> topFive = new List<Soldier>();
            topFive = soldiers
                .OrderByDescending(soldiers => soldiers.NumberOfKills)
                .Take(5)
                .ToList();
            return topFive;
        }

        public List<Soldier> RetrieveSoldiers()
        {
            return soldiers;
        }

        private List<Soldier> CreateArmy()
        {
            List<Soldier> soldiers = new List<Soldier>();
            int numberOfSoldiers = 100;
            Random random = new Random();
            for (int i = 1; i <= numberOfSoldiers; i++)
            {
                soldiers.Add(new Soldier(i, $"Robot {i}")
                {
                    CountryId = i % 5 + 1,
                    NumberOfKills = random.Next(10, 500)
                });
            }

            return soldiers;
        }

        private List<Country> CreateCountries()
        {
            List<Country> countries = new List<Country>
            {
                new Country(1, "USA"),
                new Country(2, "Romania"),
                new Country(3, "UK"),
                new Country(4, "Germany"),
                new Country(5, "China")
            };

            return countries;
        }
    }

    public interface IArmy
    {
        List<Soldier> RetrieveSoldiers();

        List<Country> GetCountries();

        List<Soldier> GetTopFiveSoldiers();

        List<Soldier> GetChineseSoldiers();

        List<dynamic> GetFullReport();

        int GetLethality();

        Soldier GetTheMostLethalRomaniaSoldier();

        int GetNumberOfEnglishSoldiers();

        double GetAverageNumberOfKillsForAmericanSoldiers();

        double GetAverageNumberOfKillsForSoldiersBelongingToCountry(Country country);
    }

    public class Soldier
    {
        public int ID { get; }
        public string Name { get; }
        public int CountryId { get; set; }
        public int NumberOfKills { get; set; }

        public Soldier(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ID}, {Name}, {CountryId}, {NumberOfKills}";
        }
    }
}
