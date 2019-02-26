using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// TO BE REVISITED
/*
    Homework 2: The Animal farm! 
    1. Create an abstract class Animal. Even though I did not explain what an abstract class is, please just write public abstract class Animal {...} and that would do it!. 
    Add inside that class declaration for 2 properties: int ID and string Name which are protected. Override the ToString() method to return a string with the ID and Name
    Also create a protected constructor that takes as arguments an int id and a string name and populate the properties with the parameters passed in the constructor.
    2. create a class Pig which inherits from Animal and adds an additional public property int Weight {get;set;}
    3. create a class Dog which inherits : from Animal and that adds an additional public property int EnemiesBitten
    4. create a class Cat which inherits from Animal and declares/adds an additional public property int MiceKilled 
    5. create a class Cow which inherits from Animal and declares an additional public property int MilkProduced
    6. For all four concrete classes created at points 2-5 override their ToString methods to return the Type of the class and the ToString property defined in Animal 
    (for Dog class should be something like this: return "Dog " + base.ToString();
    7. Create a class AnimalFarm with one method ArrayList GenerateAnimals() which will return an array list with 100 animals inside! 
    those with ID divisible with 4 will be Pigs, those with the remainder of ID divided by 4 equal to 1 will be Dogs , 
    those with the remainder of ID divided by 4 equal to 2 will be Cats and those with the remainder of ID divided by 4 equal to 3 will be Cows. 
    Add into each object of the concrete class (Pigs, Dogs Cats and Cows) into their specific property a random number for Weight, EnemiesBitten and so on.
    8. invoke for each animal created at point 7 with GenerateAnimals() their ToString() methods!
*/

namespace ConsoleApp1
{

    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Animal a1 = new Pig();
        //    //a1.ToString();
        //    //Animal a2 = new Dog();
        //    //a1.ToString();
        //    //Animal a3 = new Cat();
        //    //a1.ToString();
        //    //Animal a4 = new Cow();
        //    //a1.ToString();
        //}



        public abstract class Animal // base class
        {
            protected int _id;
            protected string _name;
            //abstract public string GenerateAnimals();

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            protected Animal(int id, string name)
            {
                _id = id;
                _name = name;
            }

            public override string ToString()
            {
                return $" Base class animal name : {_name} and ID :{_id}";
            }
        }




        class Pig : Animal // derived from Animal - pig is an animal
        {
            private int _weight;
            public int Weight
            {
                get { return _weight; }
                set { _weight = value; }
            }

            public Pig(int id, string name, int weight) : base(id, name)
            {
                _weight = weight;
            }

            public override string ToString()
            {
                return "Pig " + base.ToString();
            }

        }



        class Dog : Animal // derived from Animal - dog is an animal
        {

            private int _enemiesBItten;

            public int EnemiesBitten
            {
                get { return _enemiesBItten; }
                set { _enemiesBItten = value; }
            }
            public Dog(int id, string name, int enemiesBitted) : base(id, name)
            {
                _enemiesBItten = enemiesBitted;
            }

            public override string ToString()
            {
                return "Dog " + base.ToString();
            }
        }


        class Cat : Animal // derived from Animal - dog is an animal
        {
            public int _miceKilled;
            public int MiceKilled
            {
                get { return _miceKilled; }
                set { _miceKilled = value; }
            }
            public Cat(int id, string name, int miceKilled) : base(id, name)
            {
                _miceKilled = miceKilled;
            }

            public override string ToString()
            {
                return "Cat " + base.ToString();
            }
        }

        class Cow : Animal // derived from Animal - dog is an animal
        {
            public int _milkProduced;
            public int MilkProduced
            {
                get { return _milkProduced; }
                set { _milkProduced = value; }
            }
            public Cow(int id, string name, int milkProduced) : base(id, name)
            {
                _milkProduced = milkProduced;
            }

            public override string ToString()
            {
                return "Cow " + base.ToString();
            }
        }

        public interface IAnimalFarm
        {
            ArrayList GenerateAnimals();
        }

        public class AnimalFarm : IAnimalFarm
        {
            public ArrayList GenerateAnimals()
            {
                ArrayList myAnimalList = new ArrayList();
                int iteratorY = 0;
                while (iteratorY < 100)
                {
                    // NOTE: Realise that instance cannot be created for the abstruct class. Would you possibly advise how this could be resolved? 
                    Animal myAnimal = new Animal();

                    myAnimal.Id = iteratorY;
                    myAnimal.Name = "Animal Name " + iteratorY;
                    myAnimalList.Add(myAnimal);
                    iteratorY++;
                }

                if (iteratorY % 4 == 0)
                {
                    Console.WriteLine("Pig {0}");
                }
                if (iteratorY % 4 == 1)
                {
                    Console.WriteLine("Dog {0}");
                }
                if (iteratorY % 4 == 2)
                {
                    Console.WriteLine("Cat {0}  ");
                }
                if (iteratorY % 4 == 3)
                {
                    Console.WriteLine("Cat {0}");
                }
                else
                {
                    Console.WriteLine("This does not belong to my animal list.");
                }

                return myAnimalList;
            }

        }
    }
}
