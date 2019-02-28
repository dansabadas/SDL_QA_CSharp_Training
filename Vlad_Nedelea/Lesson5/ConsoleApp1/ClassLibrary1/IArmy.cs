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

        List<Country> RetrieveCountries();

        List<Soldier> GetTop();

        List<Soldier> GetChina();

        List<Soldier> GetFull();

        int GetLethality();

    }
}
