using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Soldier
    {
        public int NumberOfKills { get; set; }
        public int CountryId { get; set; }
        public int Id { get; }
        public string Name { get; }
        public Soldier(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id},{Name},{CountryId},{NumberOfKills}";
        }
    }
}
