using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_U1
{
    class Program
    {
        static void Main(string[] args)
        {
            SkaitluIzvade();

            Console.Read();
        }



        static void SkaitluIzvade()
        {

            Console.WriteLine("Ievadi skaitli: ");

            int skaitlisN = int.Parse(Console.ReadLine());

            int i = 0;
            int skaitlaSumma = 0;


            while (i <= skaitlisN)
            {

                if(i % 2 == 0 )
                {
                    Console.WriteLine(i);
                }


                //Console.WriteLine(skaitlisN);
                i++;

                skaitlaSumma += i;
            }

            Console.WriteLine("skaitlu summa ir {0}", skaitlaSumma); 

        }
    }
}
