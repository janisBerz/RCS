using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_U1
{
    class Darbinieks
    {
        public string Vards;
        public string Uzvards;
        public Adrese Dzivesvieta;
        public Adrese Darbavieta;

        public void Info()
        {
            Console.WriteLine("Darbinieku sauc: {0}, {1}", Vards, Uzvards);

            Console.WriteLine("Darbinieka dzivesvieta: {0}", Dzivesvieta.PilnaAdrese());
            Console.WriteLine("Darbinieka darbavieta: {0}", Darbavieta.PilnaAdrese());

        }

    }
}
