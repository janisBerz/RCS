using System;

namespace WebShop
{
    class Program
    {
        static void Main(string[] args)
        {
            WebShop webShop = new WebShop("Interneta veikals 55B")
            {
                Address = "Brīvības iela 99X",
                WarehouseAddress = "Duntes iela 9",
                Anno = 1990,
                WebAddress = "https://www.55b.lv"
            };

            //webShop.PrintTutorial(); //nestrādās
            //webShop.IzveidotoObjektuSkaits = 9; //nestrādās

            webShop.PrintInfo();

            Console.WriteLine("Cik daudz preces vēlies pievienot?");
            int itemCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"Prece nr.{i + 1}");
                webShop.AddNewItem(ReadItemInfo());
            }

            webShop.PrintItemsInfo();

            Console.WriteLine();

            //static piemērs.
            //WebShop.IzveidotoObjektuSkaits ir vērtiba, kas nemainās no objekta uz objektu, bet tā ir klasei
            //Līdz ar to no otrā PrintTutorial, mēs iegūsim izveidoto interneta veikalu skaitu
            Console.WriteLine(WebShop.IzveidotoObjektuSkaits);
            WebShop.PrintTutorial();

            var jaunsItem1 = new WebShop("Nosaukums1");
            var jaunsItem2 = new WebShop("Nosaukums2");
            var jaunsItem4 = new WebShop();
            var jaunsItem5 = new WebShop("Nosaukums3", 1992);

            WebShop.PrintTutorial();
        }

        static ShopItem ReadItemInfo()
        {
            var result = new ShopItem();

            Console.WriteLine("Ievadi ID:");
            result.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi nosaukumu:");
            result.Name = Console.ReadLine();

            Console.WriteLine("Ievadi skaitu:");
            result.Count = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi krāsu (1 - melna, 2 - sarakana, utt):");
            result.Color = (ColorEnum)int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadi kategoriju (1 - tehnika, 2 - skaistums, utt):");
            result.Category = (CategoryEnum)int.Parse(Console.ReadLine());

            return result;
        }
    }
}
