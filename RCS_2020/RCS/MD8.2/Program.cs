using System;

namespace MD8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Izveidot klasi skolai un studentiem. Skolā var būt vairāki studenti. Izdomājiet nepieciešamās metodes un īpašības.
            ///Skolā var pievienot studentu tikai tad, ja tas ir vecāks kā 7 gadi (izmantojiet papildus metodi).
            ///Jāvar izdrukāt informāciju par skolu un visiem studentiem.
            ///

            Console.WriteLine("Adding school...");
            School RTK = new School();
            RTK.Name = "Rigas Tehniska koledža";
            RTK.Address = "Baložu iela 20, Rīga, LV-1019";

            Console.WriteLine();
            Console.WriteLine("Adding students...");

            RTK.AddStudnet("Juris", "Balodis", 12);
            RTK.AddStudnet("Peteris", "Balodis", 7);
            RTK.AddStudnet("Karlis", "Lielasi", 34);
            RTK.AddStudnet("Janis", "Berzs", 2);
            RTK.AddStudnet("Kristaps", "Mazias", 64);
            RTK.AddStudnet("Liene", "Burka", 12);
            RTK.AddStudnet("Stivs", "Gulbis", 3);

            Console.WriteLine();
            RTK.GetInfo();


            
        }
    }
}
