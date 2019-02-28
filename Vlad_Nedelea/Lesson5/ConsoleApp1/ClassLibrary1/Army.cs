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

        public List<Country> RetrieveCountries()
        {
            return countries;
        }

        public List<Soldier> RetrieveSoldiers()
        {
           return soldiers;
        }

        private List<Soldier> CreateArmy()
        {
            List<Soldier> list1 = new List<Soldier>();
            Random rnd = new Random();
            for (int i = 1; i <= 200; i++)
            {
                list1.Add(new Soldier(i, "robot" + i)
                {
                    CountryId = i % 5 + 1,
                    NumberOfKills = rnd.Next(20, 30)

                });
            }
            return list1;
        }

        private List<Country> CreateCountries()
        {
            List<Country> list2 = new List<Country>()
            {
                new Country(1, "USA"),
                new Country(2, "Romania"),
                new Country(3, "France"),
                new Country(4, "Germany"),
                new Country(5, "China")
            };
          return list2;
        }

       public List<Soldier> GetTop()
       {
            List<Soldier> topFive = new List<Soldier>();
            topFive = soldiers.OrderBy(soldier1 => soldier1.NumberOfKills)
                .Take(5)
                .ToList();
            return topFive;
       }

        public List<dynamic> GetFull()
        {
            List<dynamic> reportedSoldiers = new List<dynamic>();
            reportedSoldiers = soldiers.Where(soldier => soldier.CountryId == 1 || soldier.CountryId == 5)
                 .Select(soldier => (dynamic)new
                 {
                     Name = soldier.Name,
                     Kills =soldier.NumberOfKills,
                     Country = countries.Single(country => country.Id == soldier.CountryId).Name
                 })
                 .OrderByDescending(anonSoldier => anonSoldier.Kills)
                 .Select(anonSoldier => (dynamic)anonSoldier)
                 .ToList();

            return reportedSoldiers;
        }

        public int GetLethality()
        {
            return soldiers.Sum(soldier => soldier.NumberOfKills);
        }


        public List<Soldier> GetChina()
        {
            List<Soldier> chineseSoldiers = new List<Soldier>();
            //foreach(var soldier in soldiers)
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
    }     
 }       

    

