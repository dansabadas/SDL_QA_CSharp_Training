﻿namespace ClassLibrary1
{
    public class Car
    {
        public string Name { get; }

        public Engine Engine { get; set; }

        public Wheel[] Wheels {
            get;
            set;
        }

        public Car(string name)
        {
            Name = name;
            Wheels = new Wheel[4];
        }
    }
}