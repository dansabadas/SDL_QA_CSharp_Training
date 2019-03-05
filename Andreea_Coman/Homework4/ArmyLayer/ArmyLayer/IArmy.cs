using System.Collections.Generic;

namespace ArmyLayer
{
    interface IArmy
    {
        List<Soldier> RetrieveSoldier();

        List<Country> GetCountries();

        List<Soldier> GetTopFive();

        List<Soldier> GetChineseSoldiers();

        List<dynamic> GetFullReport();

        List<Soldier> GetTheMostLethalRomanianSoldier();

        //List<Soldier> GetNumberofEnglishSoldiers();
    }
}
