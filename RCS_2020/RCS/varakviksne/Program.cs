using System;

namespace varakviksne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 1000000)
            {
                Random rand = new Random();
                int randomSkaitlis = rand.Next(15);
                var krasa = (ConsoleColor)randomSkaitlis;
                Console.ForegroundColor = krasa; //tintes krāsa
                Console.Write(" a ");
                n++;
            }
        }
    }
}
