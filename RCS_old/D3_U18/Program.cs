﻿using System;
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
            zimejums();

            Console.Read();
        }

        static void zimejums()
        {
            Console.Write("Ievadi skaitli:");

            int skaitlis = int.Parse(Console.ReadLine());



            for (int rinda = 1; rinda <= skaitlis; rinda++)
            {
                for (int kolona = 1; kolona <= skaitlis; kolona++)
                {

                    Console.Write("#");
                }

                Console.WriteLine();
            }


             /*                                     
            string simbols = new String('#', skaitlis);

            for (int i = 1; i <= skaitlis; i++)
            {

                Console.WriteLine(simbols);
            }
            */

        }
    }
}
