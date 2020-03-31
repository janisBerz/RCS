using System;

namespace MD2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jūs esat ziemassvētku tirdziņā nopirkuši eglīti, eglīti raksturo trīs parametri augstums,
            //zaru diametrs un eglītes veids(tradicionālā eglīte vai sudrabegle).
            //Eglītes parametri var tikt definēti gan kā mainīgie programmā, gan tos var paprasīt arī lietotājam.
            //Atkarībā no eglītes augstuma, zaru diametra vai eglītes tipa,
            //to ir jānovieto atbilstošā telpā mājā.Ja eglīte ir sudrabegle, to drīkst novietot tikai kamīnzālē(neatkarīgi no izmēriem).

            //Augstums(cm) Zaru diametrs(cm) Telpa
            //50 <= x < 100 100 <= y < 150 Viesistaba 1
            //100 <= x < 150 150 <= y < 200 Viesistaba 2
            //150 <= x <= 300 200 <= y <= 300 Kamīnzāle

            int x = 160;
            int y = 110;
            string eglesVeids = "sudraba";

            Console.WriteLine("Vai velaties izveleties egles izmerus un veidu (y/n)?");
            string atbilde = Console.ReadLine();

            if (atbilde == "y")
            {
                Console.WriteLine("Ievadi egles augstumu.");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Ievadi zaru diametru.?");
                y = int.Parse(Console.ReadLine());

                Console.WriteLine("sudraba vai parasta?");
                eglesVeids = Console.ReadLine();
            }

            if (x <= 50 && x < 100 && y <= 100 && y < 150)
            {
                Console.WriteLine("Viesistaba 1");   
            }
            else if (x <= 100 && x < 150 && y <= 150 && y < 200)
            {
                Console.WriteLine("Viesistaba 2");
            }
            else if (x <= 150 && y <= 300 && y <= 200 && y <= 300 || eglesVeids == "sudraba")
            {
                Console.WriteLine("Kamīnzāle");
            }





        }
    }
}
