using System;

namespace MD2.c
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot konsoles aplikāciju, kura prasa ievadīt vienu skaitli. Neļaut ievadīt lielāku skaitli par 20,
            //tādā gadījumā neizpildīt kodu, bet paziņot par neatļautu skaitli lietotājam. Izmantojot while ciklu, izvadīt reizrēķinu līdz šim skaitlim.
            //Piemērs ievadot skaitli 5(piefiksēt, ka katrā rindā ir 5 skaitļi un ir 5 rindas un visi skaitļi atdalīti ar atstarpēm):
            //1 2 3 4 5
            //2 4 6 8 10
            //3 6 9 12 15
            //4 8 12 16 20
            //5 10 15 20 25

            Console.WriteLine("Ievadi skaitli.");
            int y = int.Parse(Console.ReadLine());

            while (y > 20)
            {

            }

            int a = 100;

            while (a > 20)
            {
                Console.WriteLine("Ievadi skaitli.");
                a = int.Parse(Console.ReadLine());
                if (true)
                {

                }
            }


        }
    }
}
