using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    public class CameraView
    {
        public static void Main()
        {
            int[] tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int skipElement = tokens[0];
            int takeElement = tokens[1];
            string text = Console.ReadLine();
            string pattern = @"(\|\<)(\w*)";
            List<string> pictures = new List<string>();

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                string picture = match.Groups[2].ToString();
                if (skipElement + takeElement <= picture.Length)
                {
                    picture = picture.Substring(skipElement, takeElement);
                }
                else
                {
                    picture = picture.Substring(skipElement);
                }
                pictures.Add(picture);
            }
            Console.WriteLine(string.Join(", ", pictures));
        }
    }
}
