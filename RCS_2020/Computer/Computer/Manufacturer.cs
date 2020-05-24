using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public int Anno { get; set; }
        public string Address { get; set; }

        public string GetInfo()
        {
            return $"Manufacturer name:{Name}, " +
                $"Manufacturer anno:{Anno}, " +
                $"Manufacturer address:{Address}.";
        }
    }
}
