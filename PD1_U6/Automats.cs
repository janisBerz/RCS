using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1_U6
{
    class Automats
    {
        private double IemaksataSumma;

        public Automats()
        {
           IemaksataSumma = 0;
        }

        public void Iemaksat( double summa)
        {
            IemaksataSumma += summa;
            Console.WriteLine("Atlikums EUR: {0}", IemaksataSumma);
        }

        public void PirktDzerienu()
        {
            double minIemksataSumma = 0.80;

            if (IemaksataSumma >= minIemksataSumma)
            {
                IemaksataSumma -= minIemksataSumma;
                Console.WriteLine("Dzeriens iegadats! Atlikums no iemaksas: {0}", IemaksataSumma);
            }
            else
            {
                Console.WriteLine("Nepietiek lidzeklu");
            } 
        }

        public void SanemtAtlikumu()
        {
            Console.WriteLine("Atlikums: {0}", IemaksataSumma);
            IemaksataSumma = 0;
        }
    }
}
