using System;
using System.Collections;
using System.Collections.Generic;

// work in progress 

public abstract class  IAnimal
{
    string Name { get; set; }
    public int Id { get; }
}

class Pig : IAnimal
{
    public string Name { get; set; }
    public int Weight { get; set; }
    public override string ToString() => GetType().Name;
}

class Dog : IAnimal
{
    public string Name { get; set; }
    public int EnnemiesBitten { get; set; }
    public override string ToString() => GetType().Name;
}

class Cat : IAnimal
{
    public string Name { get; set; }
    public int MiceKilled { get; set; }
    public override string ToString() => GetType().Name;
}

class Cow : IAnimal
{
    public string Name { get; set; }
    public int MilkProduced { get; set; }
    public override string ToString() => GetType().Name;
}

public interface IAnimalFarm
{
    ArrayList GenerateAnimals();
    //ArrayList PrintAnimals();
  }

public class Animal : IAnimalFarm
{
   
    public ArrayList GenerateAnimals()
    {
        ArrayList Ferma = new ArrayList();

        for (int i = 0; i < 10; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine("animalul este porc");
                Ferma.Add(new Pig { Name = "Buhuhu", Weight = 200 });
                 Console.WriteLine("{Pig.Name}");
            }
            else if (i % 4 == 1)
            {
                Console.WriteLine("animalul este caine");
                Ferma.Add(new Dog { Name = "Rubby", EnnemiesBitten = 7 });
            }
            else if (i % 4 == 2)
            {
                Console.WriteLine("animalul este pisica ");
                Ferma.Add(new Cat { Name = "Fluffy", MiceKilled = 2 });
            }
            else if (i % 4 == 3)
            {
                Console.WriteLine("animalul este vacuta");
                Ferma.Add(new Cow { Name = "Zuzu", MilkProduced = 5 });
            }
        }
        return Ferma;
    }
    //public ArrayList PrintAnimals(IEnumerable<IAnimal> animals)
    //{
    //    foreach (IAnimal animal in animals)
    //         { Console.WriteLine("{  }"); }
    //    return null;
    //}
}


class Program
{

    static void Main(string[] args)
    {
        IAnimal animalut = new Animal;
        
        

        
        Console.ReadKey();
    }
}