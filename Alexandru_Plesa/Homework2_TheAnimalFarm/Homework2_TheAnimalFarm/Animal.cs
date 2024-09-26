using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_TheAnimalFarm
{
    public abstract class Animal
    {
        protected int _id;
        protected string _name;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        protected Animal(int Id, string Name)
        {
            _id = Id;
            _name = Name;
        }

        public override string ToString()
        {
            return $"Animal ID: {_id}, Animal Name: {_name}, ";
        }
    }
}
