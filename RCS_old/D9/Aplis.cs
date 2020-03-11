using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9
{
    class Aplis : IGeometriskaFigura
    {
        public double Radius;


        public Aplis()
        {

        }

        public Aplis(double a)
        {
            Radius = a;
        }


        public double Laukums()
        {
            return Math.Pow(Radius, 2) * Math.PI;

                
        }

        public string Nosaukums()
        {

            return "Aplis"; 
                }

        public double Perimetrs()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
