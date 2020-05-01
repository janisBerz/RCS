using System;

namespace Day4_Loops_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            //GuesNumber();

            

            Console.WriteLine(RaiseInt(2, 3));
        }

        //1) Patstāvīgi atrast kā ģenerēt random skaitli.Lietotājs cenšas uzminēt skaitli piecas reizes, ja neizdodas, tad zaudē, ja izdodas, tad uzvar.

        public static void GuesNumber()
        {
            Random random = new Random();
            int a = random.Next(0, 10);
            Console.WriteLine("Gues the number from 0 to 10!");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Try {i}: ");
                int inputB = int.Parse(Console.ReadLine());

                if (inputB == a)
                {
                    Console.WriteLine($"You won! The secret number is {a}!");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("You did not guess te number :(");
                }
            }
        }



        //2) Izveidot metodi, kas padod divus int tipa skaitļus kā parametrus- bāzi un pakāpi.Metode atgriež kāpinājumu.
        //Piemērs, padod 2 un 3, tātad 2^3 = 2* *2 * 2 = 8

        public static int RaiseInt(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        //3) Izvadīt šādu piramīdu, izmantojot for ciklu.
        //1
        //2 3
        //4 5 6
        //7 8 9 10 



    }
}
