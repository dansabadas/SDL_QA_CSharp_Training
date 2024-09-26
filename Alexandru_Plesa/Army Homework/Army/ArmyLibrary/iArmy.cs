using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyLayer
{
    public interface IArmy
    {
        List<Soldier> RetrueveSoldiers();
        List<Country> GetCountries();
        List<Soldier> GetSoldiersByCountry(List<Soldier> soldiers, Country country);
        Soldier GetTheMostLethalSoldierFromCountry(List<Soldier> soldiers, Country country);
        double GetAverageNumberOfKillsFromCountry(List<Soldier> soldiers, Country country);
    }
}
