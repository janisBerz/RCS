using System;

namespace Day8_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //Izveidot klasi grāmatu bibliotēkai. Grāmatu bibliotēka var saturēt vairākas grāmatas.
            //Savukārt katrai grāmatai ir viens autors. Bibliotēka var atrast grāmatas pēc nosaukuma vai pēc autora.
            //Izveidot konsoles aplikāciju. Tajā izveidot bibliotēkas objektu, pievienot grāmatas un to autorus.
            //Izmantot grāmatu atrašanu gan pēc nosaukuma, gan pēc autora.

            Library library = new Library();

            library.AddBook("Janis", "Zilais kalns", 2020);
            library.AddBook("Karlis", "Brunais kalns", 2020);

            Console.WriteLine("Searching for book by author");

            library.GetBook(author:"Janis");
            library.GetBookByYear(2020);

            Console.WriteLine();

        }
    }
}
