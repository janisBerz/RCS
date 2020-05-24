using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    class Computer
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public bool HasBluetooth { get; set; }
        public bool HasWiFi { get; set; }

        private List<HardDrive> HardDrives = new List<HardDrive>();
        private string secretKey = "%%T^Y&7ASKJFSADF&^$W";

        public void PrintComputerInfo()
        {
            Console.WriteLine($"Datora {Model} info:");
            Console.WriteLine($"Year:{Year}, " +
                $"Manufacturer:[{Manufacturer.GetInfo()}] " +
                $"Bluetooth:{HasBluetooth}, WiFi:{HasWiFi}");
            if (HardDrives.Count > 0)
            {
                Console.WriteLine($"Datora cieto disku info:");
                foreach (var hardDrive in HardDrives)
                {
                    Console.WriteLine($" {hardDrive.GetInfo()}");
                }
            }
        }

        public void AddHardDrive(string name, string type, int size, Manufacturer manufacturer)
        {
            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(type) ||
                size <= 0 ||
                string.IsNullOrEmpty(manufacturer.Name))
            {
                Console.WriteLine("Hard drive was not added!!!!");
            }
            else
            {
                HardDrives.Add(new HardDrive()
                {
                    Name = name,
                    Type = type,
                    Size = size,
                    Manufacturer = manufacturer
                });
            }
        }
    }
}
