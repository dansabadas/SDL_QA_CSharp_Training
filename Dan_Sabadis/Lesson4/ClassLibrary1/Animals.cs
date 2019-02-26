
namespace ClassLibrary1
{
    public interface IAnimal
    {
        int Id { get; }

        //int BlaBlaMethod(double myArg);
    }

    public abstract class Animal : IAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Animal {Id}";
        }
    }

    public class Pig : Animal
    {
        public override string ToString()
        {
            return $"Pig {Name} " + base.ToString();
        }
    }
}
