using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyLayer
{
    public interface IArmy
    {
        List<Soldier> RetrieveSoldiers();

        List<Country> RetrieveCountries();

        List<Soldier> GetTop();

        List<Soldier> GetChina();

        List<dynamic> GetFull();

        int GetLethality();

        Soldier GetTheMostLethalRomaniaSoldier();

        int GetNumberOfEnglishSoldiers();

        double GetAverageNumberOfKillsForAmericanSoldiers();

        double GetAverageNumberOfKillsForSoldiersBelongingToCountry(Country country);

        List<dynamic> GetFullByCountry();
    }
}
