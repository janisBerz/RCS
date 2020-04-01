using System;

namespace MD2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarēt programmā bool tipa mainīgo, kura sākotnējā vērtība ir TRUE.
            //Izveidot while ciklu, kurš atkārtojas tik ilgi, kamēr mainīgā vērtība ir TRUE. 
            //Mainīgā vērtību uz FALSE ir jānomaina, tad, kad cikls ir atkārtojies 20 reizes.

            bool isTrue = true;
            int i = 0;

            while (isTrue == true)
            {
                Console.WriteLine($"{i}: {isTrue}");
                if (i == 20)
                {
                    isTrue = false;
                }
                i++;
            }

            Console.WriteLine(isTrue);
        }
    }
}
