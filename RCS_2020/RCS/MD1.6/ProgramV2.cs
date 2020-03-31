using System;

namespace MD1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //sortHouseItemsV1();
            sortHouseItemsV2();
        }

        public static void sortHouseItemsV1()
        {
            Console.WriteLine("Ivadi majas prieksmetu. Piem. \"taburete\".");
            string houseItem = Console.ReadLine();

            if ("abcd".Contains(houseItem.Substring(0, 1)))
            {
                Console.WriteLine("Prieksments dodas uz pirmo stavu.");
            }
            else if ("efgh".Contains(houseItem.Substring(0, 1)))
            {
                Console.WriteLine("Prieksments dodas uz otro stavu.");
            }
            else if ("ijkl".Contains(houseItem.Substring(0, 1)))
            {
                Console.WriteLine("Prieksments dodas uz treso stavu.");
            }
            else if ("mnop".Contains(houseItem.Substring(0, 1)))
            {
                Console.WriteLine("Prieksments dodas uz ceturto stavu.");
            }
            else if ("rstv".Contains(houseItem.Substring(0, 1)))
            {
                Console.WriteLine("Prieksments dodas uz piekto stavu.");
            }
            else
            {
                Console.WriteLine("Prieksmets dodas uz pagrabu");
            }
        }

        public static void sortHouseItemsV2()
        {
            string[] storage = { "", "abcd", "efgh", "ijkl", "mnop", "rstv" };
            int floor = 0;

            Console.WriteLine("Ivadi majas prieksmetu. Piem. \"taburete\".");
            string houseItem = Console.ReadLine();

            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i].Contains(houseItem.Substring(0, 1)))
                {
                    floor = i;
                }
                else
                {
                    floor = 0;
                }                
            }

            switch (floor)
            {
                case 0:
                    Console.WriteLine($"Prieksments dodas uz pagrabu.");
                    break;
                case 1:
                    Console.WriteLine($"Prieksments dodas uz {floor}. stavu.");
                    break;
                case 2:
                    Console.WriteLine($"Prieksments dodas uz {floor}. stavu.");
                    break;
                case 3:
                    Console.WriteLine($"Prieksments dodas uz {floor}. stavu.");
                    break;
                case 4:
                    Console.WriteLine($"Prieksments dodas uz {floor}. stavu.");
                    break;
                case 5:
                    Console.WriteLine($"Prieksments dodas uz {floor}. stavu.");
                    break;
                default:
                    break;
            }
        }
    }
}
