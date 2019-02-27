using System;
using System.Collections;

namespace ConsoleApp1
// 1. Create a class Person which defines a phisical human being with three public properties: int ID string Name and DateTime BirthDate, all with Getters only
{
    public class Person
        {
        private bool v1;
        private string v2;

        public int Id { get; }
            public string Name { get; }
            public DateTime Birthdate { get; }

            public Person(int id, string name, DateTime birthDate)
            {
                Id = id;
                Name = name;
                Birthdate = birthDate;
            }

        public Person(bool v1, string v2, DateTime birthDate)
        {
            this.v1 = v1;
            this.v2 = v2;
            Birthdate = birthDate;
        }
    }
}

