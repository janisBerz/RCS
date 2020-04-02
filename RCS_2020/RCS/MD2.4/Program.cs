using System;

namespace MD2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ir trīs krustojumi. Lietotājs, ievada informāciju par to, vai konkrētajam krustojumam var izbraukt cauri.
            //Programmai ir jāpārbauda, vai ir iespējams visiem krustojumiem izbraukt cauri.

            string[] intersections = { "A", "B", "B" };
            bool[] intersectionsTrue = new bool[intersections.Length];
            int results = 0;

            for (int i = 0; i < intersections.Length; i++)
            {
                Console.WriteLine($"Vai krustojumama {intersections[i]} var izbraukt cauri (y/n)?");

                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    intersectionsTrue[i] = true;
                }
                else if (answer == "n")
                {
                    intersectionsTrue[i] = false;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    break;
                }
            }

            for (int i = 0; i < intersectionsTrue.Length; i++)
            {
                if (intersectionsTrue[i])
                {
                    results++;
                }
            }

            if (results == 3)
            {
                Console.WriteLine("Kurstojumiem var izbraukt cauri!");
            }
            else
            {
                Console.WriteLine("Kurstojumiem NEVAR izbraukt cauri :(");
            }
        }
    }
}
