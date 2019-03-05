using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyLayer
{
    public class Soldier
    {
        public int Id { get; }
        public string Name { get; }
        public int CountryID { get; set; }
        public int NumberOfKill { get; set; }

        public Soldier (int id, string name)
        {
            Id = id;
            Name = name;
        }

        public  override string ToString()
        {
            return $"({Id}, {Name}, {CountryID}, {NumberOfKill})";
        }
    }
}
