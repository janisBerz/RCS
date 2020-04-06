using System;

namespace MD4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ir definēti divi string tipa masīvi, pirmajā masīvā atrodas cilvēku vārdi, otrajā cilvēku uzvārdi.
            //Abu masīvu lielums ir identisks (10 ieraksti).
            //Izveidot tādu programmu, kur Vārdi un Uzvārdi tiek apvienoti vienā jaunā masīvā un izdrukāti uz ekrāna.
            //Jaunā masīva elementu skaits arī ir desmit un vērtības – “Vārds Uzvārds” (nevis string vērtība "Vārds Uzvārds",
            //bet iegūtās vērtības vārds un uzvārds no pirmā un otrā masīva).


            string[] personName = { "Anna","Juta","Aigars","Uldis", };
            string[] personSurname = { "Burka", "Zarina", "Upitis", "Garais" };
            string[] persoinNameSurname = new string[personName.Length];

            for (int i = 0; i < personName.Length; i++)
            {
                persoinNameSurname[i] = personName[i] + " " + personSurname[i];
                Console.WriteLine(persoinNameSurname[i]);
            }


        }
    }
}
