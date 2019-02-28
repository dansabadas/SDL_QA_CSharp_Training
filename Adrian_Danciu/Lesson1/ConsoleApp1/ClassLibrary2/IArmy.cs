using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public interface IArmy
    {
        List<Soldier> CreateArmy();

        List<Country> CreateCountries();

        List<Soldier> GetTopFiveSoldiers();

        List<Soldier> GetChineseSoldiers();

        List<dynamic> GetFullReport();

        int GetLethality();

    }
}
