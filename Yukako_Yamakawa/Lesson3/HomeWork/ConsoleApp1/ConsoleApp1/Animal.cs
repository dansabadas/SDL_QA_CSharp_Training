using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
}
