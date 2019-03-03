using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyLayer
{
    public class Soldier
    {
        public int ID { get; }
        public string Name { get; }
        public int CountryId { get; set; }
        public int NrOfKills { get; set; }

        public Soldier(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {ID} Name: {Name} Country Id: {CountryId} Nr of Kills: {NrOfKills}";
        }
    }
}
