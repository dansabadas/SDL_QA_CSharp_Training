﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Car
    {
        public string Name { get; }
        public Engine Enfine { get; set; }


        public Car (string name)
        {
            Name = name;
        }
        
        public Wheel[] Wheels
        {
            get;
        }
    }
}
