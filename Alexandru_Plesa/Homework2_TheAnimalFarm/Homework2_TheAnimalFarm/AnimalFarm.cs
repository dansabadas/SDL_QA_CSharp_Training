using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_TheAnimalFarm
{
    public class AnimalFarm
    {
        public ArrayList GenerateAnimals(int animals)
        {
            Random rnd = new Random();
            ArrayList animalsInFarm = new ArrayList();

            for (int animalNr = 0; animalNr < animals; animalNr++)
            {
                
                int generatedNr = rnd.Next(0, animals);
                int animalOrganizer = animalNr % 4;
                

                switch (animalOrganizer)
                {
                    case 0:
                        Pig pig = new Pig(animalNr, "Pig Nr. " + animalNr, generatedNr);
                        animalsInFarm.Add(pig);
                        break;
                    case 1:
                        Dog dog = new Dog(animalNr, "Dog Nr. " + animalNr, generatedNr);
                        animalsInFarm.Add(dog);
                        break;
                    case 2:
                        Cat cat = new Cat(animalNr, "Cat Nr. " + animalNr, generatedNr);
                        animalsInFarm.Add(cat);
                        break;
                    default:
                        Cow cow = new Cow(animalNr, "Cow Nr. " + animalNr, generatedNr);
                        animalsInFarm.Add(cow);
                        break;
                }
            }
            return animalsInFarm;
        }
    }
}
