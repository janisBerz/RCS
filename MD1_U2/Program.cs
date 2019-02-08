using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD1_U2
{
    class Program
    {
        static void Main(string[] args)
        {
            varduIevadeIzvade();
            Console.Read();
        }

        static void varduIevadeIzvade()
        {
            Console.Write("Ievadi vardu #1: ");
            string vnr1 = Console.ReadLine();

            Console.Write("Ievadi vardu #2: ");
            string vnr2 = Console.ReadLine();

            Console.Write("Ievadi vardu #3: ");
            string vnr3 = Console.ReadLine();

            Console.WriteLine(vnr1 + ", " + vnr2 + ", " + vnr3);
        }
    }
}
