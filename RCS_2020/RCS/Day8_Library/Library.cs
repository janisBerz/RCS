using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day8_Library
{
    class Library
    {
        private List<Book> _books = new List<Book>();

        public string AddBook(string author, string name, int year)
        {
            _books.Add(new Book()
            {
                Author = author,
                Name = name,
                Year = year

            });

            return $"Book was added succsessfuly";
        }

        public void GetBook(string author)
        {
            foreach (var book in _books)
            {
                if (book.Author.ToString() == author)
                {
                    Console.WriteLine($"Nosaukusm: {book.Name}");
                }
            }
            
        }

        public List<Book> GetBookByYear(int year)
        {
            return _books.Where(b => b.Year.Equals(year)).ToList();
        }
    }
}
