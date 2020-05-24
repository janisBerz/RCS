using System;
using System.Collections.Generic;
using System.Text;

namespace Day11
{
    abstract class Animal
    {
        public bool HasWings { get; set; }
        public int LegCount { get; set; }

        public abstract void AddAnimal();
    }
}
