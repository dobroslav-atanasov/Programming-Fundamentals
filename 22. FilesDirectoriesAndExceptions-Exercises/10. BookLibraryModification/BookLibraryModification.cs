using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace _10.BookLibraryModification
{
    public class BookLibraryModification
    {
        public static void Main()
        {
            Library libary = new Library
            {
                Name = "BNB",
                Books = new List<Book>()
            };
            string[] allLines = File.ReadAllLines(@"..\..\Input.txt");
            int n = int.Parse(allLines[0]);
            for (int i = 1; i <= n; i++)
            {
                string[] input = allLines[i].Split(' ').ToArray();
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
            DateTime date = DateTime.ParseExact(allLines[allLines.Length - 1], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in libary.Books.Where(a => a.ReleaseDate > date).OrderBy(a => a.ReleaseDate).ThenBy(a => a.Title))
            {
                File.AppendAllText(@"..\..\Output.txt", $"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}" + Environment.NewLine);
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
