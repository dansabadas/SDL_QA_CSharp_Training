using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_ClassLibrary
{
    public interface IArmy
    {
        List<Soldier> RetrieveArmy();
        List<Country> GetCountries();
        List<Soldier> GetTopFiveSoldiers();
        List<Soldier> GetChineseSoldiers();
        List<dynamic> GetReportChinaAndUSA();
        int GetLethality();
    }

}
