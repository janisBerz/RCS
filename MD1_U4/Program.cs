using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD1_U4
{
    class Program
    {
        static void Main(string[] args)
        {
            vardsToUpper();
            Console.Read();
        }

        static void vardsToUpper()
        {
            Console.Write("Ievadi vardu: ");
            string a = Console.ReadLine();

            
            Console.WriteLine("Vards ar lieliem burtiem " + a.ToUpper());



        }
    }
}
