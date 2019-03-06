using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IArmy
    {
        List<Soldier> RetrieveSoldiers();

        List<Country> GetCountries();

        List<Soldier> GetTopFiveSoldiers();

        List<Soldier> GetChineseSoldiers();

        List<dynamic> GetFullReport();

        int GetLethality();
    }
}