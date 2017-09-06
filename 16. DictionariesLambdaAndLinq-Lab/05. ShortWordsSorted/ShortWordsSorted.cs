using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortWordsSorted
{
    public class ShortWordsSorted
    {
        static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = words.Where(w => w.Length < 5).OrderBy(w => w).Distinct().ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
