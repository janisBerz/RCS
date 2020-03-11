using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_U1
{
    class Kvadrats
    {
        public int malasGarums;

        // Konstruktors
        // this.malasGarums - norada uz klases mainigo
        public Kvadrats(int malasGarums/*, citi parametri... */)
        {
            this.malasGarums = malasGarums;
        }

        public Kvadrats()
        {

        }

        public int laukums()
        {
            return malasGarums * malasGarums;
        }

        public int perimetrs()
        {
            return malasGarums * 4;
        }

        public void KonsolesIzvade()
        {
            Console.WriteLine("Laukums  = {0}", laukums());
            Console.WriteLine("Perimetrs  = {0}", perimetrs());
        }


        public static void FigurasNosaukums()
        {
            Console.WriteLine("Sis ir Kvadrats!");
        }
    }
}
