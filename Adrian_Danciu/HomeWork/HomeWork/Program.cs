using ConsoleApp2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework: 1. 
            //given any array as input, produce as output the sorted array 
            //(do not use built-in functions like Array.Sort() but create your own sorting implementation

            int[] unsortedRawArray = { 3, 2, 1, 45, 0 };
            int[] sorted = MySort(unsortedRawArray);

            for (int i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i] + " ");
            }
            Console.WriteLine();

            //Homework: 2.Implement Fibonacci iteratively, not recursively

            int fiboResult = Fibonacci(5);

            Console.WriteLine(fiboResult);

            //Homework 3: Create a function called CreateStudents2 that returns an ArrayList with students
            //(as a source of inspiration use the existing public static Student[] CreateStudents
            //(int numberOfStudents) just that instead of an array of students the function CreateStudents2 
            //should return an ArrayList populated with the students.

            ArrayList s1 = CreateStudents2(100);
            for (int i = 0; i < s1.Count; i++)
            {
                Student s = (Student)s1[i];
                Console.WriteLine(s.Name);
            }

            //Homework 2.1 to the classes Point2D and Point3d that you created add for each class one 
            //new method double CalculateDistanceTo(Point2D/Point3D) which will calculate the physical 
            //distance between two points! It is just basic trigonometry! 😄 Then on the main function 
            //please create 2 random 2D points and calculate the distance between them using a call like this:
            //myFirstpoint2d.CalculateDistanceTo(mySecondPoint2d) and display that distance on Console.

            Random random = new Random();
            Point2D myFirstpoint2d = new Point2D(random.NextDouble(), random.NextDouble());
            Point2D mySecondpoint2d = new Point2D(random.NextDouble(), random.NextDouble());

            Console.WriteLine("myFirstpoint2d is:" + myFirstpoint2d + " " + "mySecondpoint2d is:" + mySecondpoint2d);

            Console.WriteLine("The distance between two points is: " + myFirstpoint2d.CalculateDistanceTo(mySecondpoint2d));

            //Homework 2.1 The Animal farm! 😄
            //Create an abstract class Animal. Even though I did not explain what an abstract class is, please just write public abstract class Animal {...}
            //and that would do it!. Add inside that class declaration for 2 properties: int ID and string Name which are protected. Override the ToString() method to return a string with the ID and Name
            //Also create a protected constructor that takes as arguments an int id and a string name and populate the properties with the parameters passed in the constructor.
            //2. create a class Pig which inherits from Animal and adds an additional public property int Weight { get; set; }
            //3. create a class Dog which inherits : from Animal and that adds an additional public property int EnemiesBitten
            //4. create a class Cat which inherits from Animal and declares/adds an additional public property int MiceKilled 
            //5. create a class Cow which inherits from Animal and declares an additional public property int MilkProduced
            //6. For all four concrete classes created at points 2-5 override their ToString methods to return the Type of the class and the ToString p////roperty 
            //defined in Animal(for Dog class should be something like this: return "Dog " + base.ToString();
            //7. Create a class AnimalFarm with one method ArrayList GenerateAnimals() which will return an array list with 100 animals inside! those 
            // with ID divisible with 4 will be Pigs, those with the remainder of ID divided by 4 equal to 1 will be Dogs , those with the remainder of ID divided by 
            //4 equal to 2 will be Cats and those with the remainder of ID divided by 4 equal to 3 will be Cows.Add into each object of the concrete
            //class (Pigs, Dogs Cats and Cows) into their specific property a random number for Weight, EnemiesBitten and so on.
            //8. invoke for each animal created at point 7 with GenerateAnimals() their ToString() methods!

            AnimalFarm animalFarm = new AnimalFarm();
            ArrayList animalList = animalFarm.GenerateAnimals();

            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal);
            }

            //The Homework: The Bank!!
            //1. create a class Person which defines a phisical human being with three public properties: int ID string Name and DateTime BirthDate, 
            //all with Getters only
            //2. create a class FinancialTransaction with 3 getter only properties: Person From, Person To and double Amount so this class represents a financial 
            //transaction where the From person sends the Amount of money to the To person
            //3. Create a interface IBank with one method: ArrayList GenerateFinancialTransactions(). Then create a class Bank which implements 
            //the interface IBank, so in the method implementation you will generate some(let's say around 20) FinancialTransaction objects. 
            //In the implementation let's say that at every 3 transactions the To person repeats and at every 5 transactions the From person repeats.
            //Also the amount will be some random number between 100 and 200 (so we don't waste too much money).
            //4. At the end please print at the console the transactions: the From person's name, the To Person's name and the Amount!

            IBank pBank = new Bank();
            ArrayList transactions = pBank.GenerateFinancialTransactions();

            foreach (FinancialTransaction transaction in transactions)
            {
                Console.WriteLine(transaction);
            }



        }

        public static int[] MySort(int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                int temp;

                for (int j = i; j < unsorted.Length; j++)
                {
                    if (unsorted[j] < unsorted[i])
                    {
                        temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }

            return unsorted;
        }

        public static int Fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            int b = 0;
            int a = 1;
            int i = 2;
            int currentValue = a + b;
            while (i <= n)
            {
                int temp1 = a;
                int temp2 = currentValue;
                currentValue = currentValue + a;
                a = temp2;
                b = temp1;

                i++;
            }
            return currentValue;
        }

        public static ArrayList CreateStudents2(int numberOfStudents)
        {

            ArrayList students = new ArrayList();

            for (int i = 0; i < 100; i++)
            {
                Student student = new Student();
                student.Name = "Ady" + i;
                //student.DateOfBirth = new DateTime(2010, 10, 01);
                students.Add(student);
            }

            return students;
        }

    }
}
