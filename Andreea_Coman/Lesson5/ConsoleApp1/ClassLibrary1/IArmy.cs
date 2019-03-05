using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface IArmy
    {
        List<Soldier> RetrieveSoldier();

        List<Country> GetCountries();

        List<Soldier> GetTopFive();

        List<Soldier> GetChineseSoldiers();

        List<dynamic> GetFullReport();
    }
}