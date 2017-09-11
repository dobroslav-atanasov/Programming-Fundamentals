using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05.BookLibrary
{
    public class BookLibrary
    {
        public static void Main()
        {
            Library libary = new Library
            {
                Name = "BNB",
                Books = new List<Book>()
            };
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InstalledUICulture),
                    ISBNNumber = input[4],
                    Price = double.Parse(input[5])
                };

                libary.Books.Add(book);
            }

            var filterList = libary.Books.Select(
                a => new
                {
                    Author = a.Author,
                    TotalPrice = libary.Books.Where(b => b.Author.Equals(a.Author)).Sum(b => b.Price)
                })
                .Distinct()
                .OrderByDescending(b => b.TotalPrice)
                .ThenBy(b => b.Author)
                .ToList();

            foreach (var book in filterList)
            {
                Console.WriteLine($"{book.Author} -> {book.TotalPrice:F2}");
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBNNumber { get; set; }
        public double Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
