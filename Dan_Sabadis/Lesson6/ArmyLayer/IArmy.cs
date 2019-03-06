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

        List<Country> GetCountries();

        List<Soldier> GetTopFiveSoldiers();

        List<Soldier> GetChineseSoldiers();

        List<dynamic> GetFullReport();

        List<dynamic> GetFullReportByCountry(int countryId);

        int GetLethality();
    }
}
