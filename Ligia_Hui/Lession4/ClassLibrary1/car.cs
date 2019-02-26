namespace ClassLibrary1
{
    public class car
    {
        public string Name { get; }
        public Engine Engine { get; set; }
        public wheel[] wheels {
            get;
            set;
        }

        public car(string name)
        {
            Name = Name;
            wheels = new wheel[4];

        }


    }
}
