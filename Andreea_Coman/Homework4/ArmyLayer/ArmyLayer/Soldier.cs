namespace ArmyLayer
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
