using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    class HardDrive
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public string GetInfo()
        {
            return $"Name:{Name}, " +
                $"Size:{Size} " +
                $"Type:{Type} " +
                $"Manufacturer:[{Manufacturer.GetInfo()}].";
        }
    }
}
