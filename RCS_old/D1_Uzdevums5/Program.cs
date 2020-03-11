using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Uzdevums5
{
    class Program
    {
        static void Main(string[] args)
        {
            temperaturasAprekins();
            Console.ReadLine();
        }

        static void temperaturasAprekins()
        {
            Console.Write("Ievadi temperaura (°C): ");

            float gradiCelsijs = float.Parse(Console.ReadLine());

            // Izvade Kelvins
            float gradiKelvins = gradiCelsijs + (float)273.15;

            //Izvade Farenheits
            float gradiFarenheits = ((gradiCelsijs * 9 / 5) + 32);

            Console.WriteLine("Grādi pēc Farenheita: " + gradiFarenheits);
            Console.WriteLine("Grādi pēc Kelvina: " + gradiKelvins);
        }
    }
}
