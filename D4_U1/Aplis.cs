using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_U1
{
    class Aplis
    {
        public double radiuss;

        public string krasa;

        public Aplis(int radiuss, string krasa)
        {
            this.radiuss = radiuss;
            this.krasa = krasa;
        }

        public void aprekinLaukums()
        {
            Console.WriteLine("Apla Laukums ir {0}", Math.PI * Math.Pow(radiuss, 2.0) );
        }

        public void aprekinKrasa()
        {
            Console.WriteLine("Apla krasa ir {0}", krasa);
        }

        public void aprekinPerimetrs()
        {
            Console.WriteLine("Apla perimetrs ir {0}", 2 * Math.PI * radiuss);
        }

    }
}
