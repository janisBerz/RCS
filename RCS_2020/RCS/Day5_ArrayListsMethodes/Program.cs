using System;

namespace Day5_ArrayListsMethodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izmantojot for ciklu izdrukāt uz ekrāna skaitļu virkni. Ciklam ir jāatkārtojas 21 reizi. Gadījumā,
            //ja tekošā cikla vērtība (jeb reize, kad izpildās cikls) dalās ar trīs bez atlikuma tad uz jāizdrukā vārds Fizz,
            //ja cikla vērtība bez atlikuma dalās ar 5, tad jāizdrukā Buzz. Ja cikla vērtība bez atlikuma dalās ar 3 un 5,
            //tad jāizdrukā vārds FizzBuzz. Visos pārējos gadījumos ir jāizdrukā cikla vērtība (jeb reize, kad izpildās cikls).
            //Rezultātam jāizskatās šādi: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz utt.
            //Līdz ar to uzdevumā tiek izvadīti skaitļi no 1 līdz 21, bet daži no tiem tiks aizvietoti ar kādu tekstuālu vērtību.
            //Izmantojam %.Piemērs:
            //int atlikums = 20 % 6; //a = 2, 20 dalīts ar 6 ir 3 un atlikumā 2

            string output = "";

            for (int i = 1; i < 22; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    output += " FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    output += " Fizz";
                }
                else if (i % 5 == 0)
                {
                    output += " Buzz";
                }
                else
                {
                    output += i;
                }
                output += ",";
            }
            Console.WriteLine(output);
        }
    }
}
