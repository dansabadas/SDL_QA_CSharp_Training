namespace ClassLibrary1
{
    public class Engine
    {
        public string Name { get; }

        public int HorsePower { get; }

        public Engine(string name, int power)
        {
            Name = name;
            HorsePower = power;
        } 
    }
}
