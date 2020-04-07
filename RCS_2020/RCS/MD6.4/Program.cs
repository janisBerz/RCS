using System;

namespace MD6._4
{
    class Program
    {

        enum months
        {

        }
        static void Main(string[] args)
        {
            //Izveidot konsoles aplikāciju, kurā ievada no konsoles cilvēka personas kodu. Izveidot divas metodes –
            //ValidatePersonId(string personId) un PrintBirthday(string personId).

            //ValidatePersonId – saņemot personas kodu, pārbauda, ka personas koda garums ir precīzi 12 un
            //ka domu zīme atrodas pareizajā vietā tekstā. (Izmantojam vai nu Substring vai teksta uztveršanu kā masīva simbolu)

            //PrintBirthday – saņemot personas kodu, nepieciešams izņemt ārā dzimšanas datumu, mēnesi un gadu.
            //Piemēram ievadē 120594 - 12345 izdrukātos – 12.maija 1994.gads.Izmantojam teksta uztveršanu kā masīvu vai Substring,
            //lai saņemtu konkrētus 2 elementus blakus. Savukārt, apstrādātu mēnesi izmantojam switch,
            //kad ar katru skaitli tiktu piemeklēts mēnesis, jeb “05” -> maijs.
            //Lai izvadītu gadu pieņemsim, ka, ja PK gads ir lielāks par 19 tad rakstam, piemēram 1920.gads.Taču,
            //ja gads ir mazāks par 20, tad rakstam 2019.gads.


            Console.WriteLine("Ievadi personas kodu.");
            string personId = Console.ReadLine();

            ValidatePersonId(personId);


        }

        private static void ValidatePersonId(string personId)
        {

            if (personId.Length != 12 && personId[7].ToString() != "-")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Personas kods ievadits nepareizi");
                Console.ResetColor();
            }
        }
    }
}
