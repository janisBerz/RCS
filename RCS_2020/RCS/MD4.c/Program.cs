using System;
using System.Linq;

namespace MD4.c
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Izveidot nosacītu spēli LINGO. Programmas kodā saglabāt string mainīgajā minamo vārdu ar garumu 5,
            ///kā jau īstajā LINGO. Pēc tam iedot lietotājam informāciju par uzdevumu un likt lietotājam minēt tik ilgi,
            ///kamēr viņš uzraksta “apnika”. Uzdevuma vienkāršības nolūkos iesaku izmantot un ievadīt tikai mazos burtus un
            ///neizmantot latviešu speciālos burtus (kā čģūīķ utt.). Sākuma izvadīt vārda pirmo burtu un
            ///atlikušos simbolus zvaigznītes. Piemēram, ja būtu minamais vārds “piens”,
            ///tad lietotājam sākumā izvada “p****”. Lietotājs visu laiku min un
            ///pirms katra minējuma viņam tiek izvadīts esošais progress.
            ///Savukārt, ja kaut vienu burtu uzmin ĪSTAJĀ pozīcijā, tad turpināt drukāt ārā visus jau zināmos burtus.
            ///Piemēram, ja lietotājs min vārdu “pirms”, tad turpināt drukāt ārā “pi**s” un tā, kamēr uzminēti visi burti.
            ///Uzminētos burtus izdrukāt zaļajā krāsā. Uzvaras gadījumā uzrakstīt apsveicošu paziņojumu.
            ///Spēle beidzas tad, kad lietotājs uzvar vai kad lietotājs ir uzrakstījis “apnika”.
            ///Lietotājs drīkst ievadīt tikai vārdus ar 5 burtiem vai vārdu “apnika” citādāk jāpaziņo,
            ///ka kļūda un jāliek vadīt atkārtoti.
            ///

            Console.WriteLine("Spele LINGO ir sakusies! Ievadi slepeno vardu: ");
            Console.WriteLine("Lai pārtrauktu spēli ievadi vāedu \"apnika\".");
            Console.WriteLine();
            Console.Write("Ievadi slepeno vardu (max 5 zimes): ");

            string inputChar = "";
            string[] output = new string[5];
            string outputStirng = "";

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = "*";
            }

            string inputWord = Console.ReadLine();
            output[0] = inputWord[0].ToString();

            do
            {
                if (inputWord.Length == 5)
                {
                    Console.Write("Uzmini vardu: ");
                    for (int i = 0; i < output.Length; i++)
                    {
                        if (output[i] != "*")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(output[i]);
                            Console.ResetColor();
                            continue;
                        }
                        Console.Write(output[i]);
                    }

                    Console.WriteLine();
                    Console.Write("Ievadi burutu: ");
                    inputChar = Console.ReadLine();

                    if (inputChar == "apnika")
                    {
                        Console.WriteLine("Tu izvēlējies pārtraukt spēli");
                        break;
                    }

                    for (int i = 0; i < inputWord.Length; i++)
                    {
                        if (inputWord[i].ToString() == inputChar.ToString())
                        {
                            output[i] = inputChar;
                        }
                    }

                    outputStirng = "";
                    for (int i = 0; i < output.Length; i++)
                    {
                        outputStirng += output[i];
                    }
                }
                else if (inputWord == "apnika")
                {
                    Console.WriteLine("Tu izvēlējies pārtraukt spēli");
                    break;
                }
                else
                {
                    Console.WriteLine("Ievdits nekorekta garuma minamais vards!");
                    Console.WriteLine("Mēģini vēlreiz.");
                    continue;
                }

            } while (outputStirng != inputWord );

            if (outputStirng == inputWord)
            {
                Console.WriteLine($"Tu uzvarēji! Minamais vārds ir {outputStirng}");
            }
        }
    }
}
