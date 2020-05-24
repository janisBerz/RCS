using System;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            string tavsVards;
            string mansVards = "test";

            Manufacturer manufacturer1 = new Manufacturer();
            manufacturer1.Anno = 1950;
            manufacturer1.Address = "Ventspils iela 4, Jelgava";
            manufacturer1.Name = "Dell";

            Manufacturer manufacturer2 = new Manufacturer();
            manufacturer2.Anno = 1960;
            manufacturer2.Address = "Zemgales iela 3, Cēsis";
            manufacturer2.Name = "Lenovo";

            Computer computer = new Computer();
            computer.Model = "Latitude E730";
            computer.Year = 2015;
            computer.Manufacturer = manufacturer1;
            computer.HasBluetooth = true;
            computer.HasWiFi = true;

            computer.AddHardDrive("GoodDisk", "HDD", 512, manufacturer1);
            computer.AddHardDrive("BestDisk", "SSD", 512, manufacturer2);

            Computer computer2 = new Computer()
            {
                Model = "P48f",
                Year = 2017,
                Manufacturer = manufacturer2,
                HasBluetooth = true,
                HasWiFi = false
            };

            computer.PrintComputerInfo();
            Console.WriteLine();
            computer2.PrintComputerInfo();
        }
    }
}
