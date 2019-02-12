using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D9
{
    class Program
    {
        static void Main(string[] args)
        {
            Taisnsturis t1 = new Taisnsturis(10,25);
            Aprekini(t1);


            try
            {
                Console.Write("Ievadi Apla radiusiu");
                double r = double.Parse(Console.ReadLine());
                Aplis a1 = new Aplis(r);
                Aprekini(a1);

            }
            catch (FormatException)
            {
                Console.WriteLine("Ievadita nekorekta vertiba!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kluda!!!");
                Console.Write(ex.Message);
            }



            Kvadrats k1 = new Kvadrats(10);
            Aprekini(k1);

            Console.ReadLine();
        }

        static void Aprekini(IGeometriskaFigura t)
        {
            Console.WriteLine("{1} laukaums {0}", t.Laukums(), t.Nosaukums() );
            Console.WriteLine("{1} perimetrs {0}", t.Perimetrs(), t.Nosaukums());
        }
    }
}
