using System;

namespace ArmyLayer
{
    public class Soldier
    {
        public int Id { get; }
        public string Name { get; }

        public int CountryId { get; set; }

        public int NumberOfKills { get; set; }
        public Soldier(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"({Id}, {Name}, {CountryId}, {NumberOfKills})";
        }
    }
}
