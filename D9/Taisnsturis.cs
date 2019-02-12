using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9
{
     class Taisnsturis : IGeometriskaFigura
    {
        public double Mala1;

        public double Mala2;

        public Taisnsturis()
        {

        }

        public Taisnsturis(double a, double b)
        {
            Mala1 = a;
            Mala2 = b;
        }


        public double Laukums()
        {
            return Mala1 * Mala2;
        }

        public virtual string Nosaukums() // virtual atlaus mainit "Nosaukus()" mantotajas klases
        {
            return "taisnsturis";
        }

        public double Perimetrs()
        {
            return (Mala1 + Mala2) * 2;
        }
    }
}
