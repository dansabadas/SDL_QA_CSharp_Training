using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Soldier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public int NrOfKills { get; set; }
        public Soldier(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {ID} Name: {Name} Country Id: {CountryId} Nr of Kills: {NrOfKills}";
        }
    }
}
