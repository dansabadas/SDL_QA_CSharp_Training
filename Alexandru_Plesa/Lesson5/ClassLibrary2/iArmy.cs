using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    interface IArmy
    {
        List<Soldier> RetrueveSoldiers();
        List<Country> GetCountries();
        List<Soldier> GetTopFiveSoldiers(List<Soldier> soldiers);
        List<Soldier> GetNationSoldiers(List<Soldier> soldiers, Country country);
        List<dynamic> GetFullReport(List<Soldier> soldiers);
        int GetLetality();
    }
}
