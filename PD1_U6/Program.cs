using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1_U6
{
    class Program
    {
        static void Main(string[] args)
        {
            DzerienuAutomats();
            Console.ReadLine();
        }

        static void DzerienuAutomats()
        {
            Automats automats = new Automats();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Tev ir pieejams sadas darbibas:");
                Console.WriteLine("Iemaksat");
                Console.WriteLine("PirktDzerienu");
                Console.WriteLine("SanemtAtlikumu");
                Console.Write("Ievadi savu darbibu:");
                Console.Write("e - partraukt");

                string darbiba = Console.ReadLine().ToLower();

                switch (darbiba)
                {
                    case "iemaksat":
                        Console.Write("Ievadi darbibas summu:");
                        double ievaditaSumma = double.Parse(Console.ReadLine());
                        automats.Iemaksat(ievaditaSumma);
                        break;
                    case "pirktdzerienu":
                        automats.PirktDzerienu();
                        break;
                    case "sanemtatlikumu":
                        automats.SanemtAtlikumu();
                        break;
                    case "e":
                        return; // pārtrauc gan switch, gan while

                }

            }

        }
    }
}
