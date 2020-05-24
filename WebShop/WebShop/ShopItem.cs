using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop
{
    class ShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryEnum Category { get; set; }
        public ColorEnum Color { get; set; }
        public int Count { get; set; }
        //Pārbaudam, vai skaits ir lielāks kā 0, ja jā, tad ir pieejama prece
        public bool IsAvailable { get { return Count > 0; } }

        public void PrintInfo()
        {
            Console.WriteLine($"Preces info: id - {Id}, nosaukums - {Name}, kategorija - {Category}, krāsa - {Color}, " +
                $"skaits - {Count}, vai ir pieejams - {IsAvailable}!");
        }
    }
}
