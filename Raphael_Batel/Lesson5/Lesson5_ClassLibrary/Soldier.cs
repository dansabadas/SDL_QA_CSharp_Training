using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_ClassLibrary
{
    public class Soldier
    {
        public Soldier(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int CountryId { get; set; }
        public int Id { get;  }
        public string Name { get; }
        public int NumberKills { get; set; }

        public override string ToString()
        {
            return $"Soldier {Name}, Country {CountryId}, killed {NumberKills}";
        }
    }
}
