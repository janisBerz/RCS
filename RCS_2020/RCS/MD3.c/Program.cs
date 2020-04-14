using System;

namespace MD3.c
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot konsoles aplikāciju, kas ievada no lietotāju teikumu. 
            //Ar cikla palīdzību izvadīt izvadīt teikumu pretējā virzienā. Ja ievads būtu “abc def!?#”,
            //tad rezultāts būtu “#?! fed cba”.
            //Uzdevumā nedrīkst izmantot nekādas iebūvētas gatavas metodes, jāizmanto tikai kursā apgūtais.

            Console.Write("Ievadi tekstu: ");

            string inputText = Console.ReadLine();
            string outputText = "";

            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                outputText += inputText[i];
            }

            Console.WriteLine(outputText);
        }
    }
}
