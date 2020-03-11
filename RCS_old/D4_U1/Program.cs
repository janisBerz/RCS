using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers();
            //Aplis();
            DarbiniekuKarte();
            Console.ReadLine();
        }

        static void Piemers()
        {

            // "new Kvadrats(5)" - konstruktors
            Kvadrats kv1 = new Kvadrats(5);

            int laukums = kv1.laukums();
            int perimetrs = kv1.perimetrs();

            Console.WriteLine("Laukums  = {0}", laukums);
            Console.WriteLine("Perimetrs  = {0}", perimetrs);

            Kvadrats kv2 = new Kvadrats(10);
            kv2.KonsolesIzvade();


            Kvadrats.FigurasNosaukums();

        }

        static void Aplis()
        {
            Aplis a1 = new Aplis(5, "zila");

            a1.aprekinLaukums();
            a1.aprekinPerimetrs();
            a1.aprekinKrasa();

        }


        static void DarbiniekuKarte()
        {
            Darbinieks darbinieks = new Darbinieks();
            darbinieks.Vards = "Janis";
            darbinieks.Uzvards = "Berzins";
            darbinieks.Dzivesvieta = new Adrese();
            darbinieks.Dzivesvieta.Valsts = "Latvija";
            darbinieks.Dzivesvieta.Pilseta = "Riga";
            darbinieks.Dzivesvieta.Iela = "Gertrudes 90";
            darbinieks.Darbavieta = new Adrese();
            darbinieks.Darbavieta.Valsts = "UK";
            darbinieks.Darbavieta.Pilseta = "LND";
            darbinieks.Darbavieta.Iela = "Anton Street";

            darbinieks.Info();
        }
    }
}
