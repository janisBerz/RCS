using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD1_U5
{
    class Program
    {
        static void Main(string[] args)
        {
            ievadiVecumu();
            Console.Read();
        }

        static void ievadiVecumu()
        {
            Console.Write("Ievadi skaitli #1: ");
            int nr1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi skaitli #2: ");
            int nr2 = int.Parse(Console.ReadLine());

            if (nr1 == nr2)
            {
                Console.WriteLine("Skaitli ir vienadi");
            }
            else
            {
                //Console.WriteLine("Skaitli nav vienadi");
            }

            if (nr1 == nr2 && nr1 == 5)
            {
                Console.WriteLine("Skaitli ir vienadi");
            }
            else
            {
                //Console.WriteLine("Skaitli nav vienadi");
            }




            Console.Write(nr1 == nr2 ? "Skaittli vienadi" : "sakitli nav vienadi");

           
        }
    }
}
