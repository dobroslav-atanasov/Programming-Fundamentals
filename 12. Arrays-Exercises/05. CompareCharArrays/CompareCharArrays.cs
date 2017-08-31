using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    public class CompareCharArrays
    {
        static void Main()
        {
            char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                if (first[i] < second[i])
                {
                    Console.WriteLine(string.Join("", first));
                    Console.WriteLine(string.Join("", second));
                    break;
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine(string.Join("", second));
                    Console.WriteLine(string.Join("", first));
                    break;
                }
                else if (first.Length == second.Length && first[i] == second[i])
                {
                    Console.WriteLine(string.Join("", first));
                    Console.WriteLine(string.Join("", second));
                    break;
                }
                else if (first.Length != second.Length && first[i] == second[i])
                {
                    Console.WriteLine(first.Length > second.Length ? string.Join("", second) : string.Join("", first));
                    Console.WriteLine(first.Length < second.Length ? string.Join("", second) : string.Join("", first));
                    break;
                }
            }
        }
    }
}
