using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.TakeSkipRope
{
    public class TakeSkipRope
    {
        static void Main()
        {
            char[] symbols = Console.ReadLine().ToCharArray();
            int[] numbers = symbols.Where(x => Char.IsDigit(x)).Select(x => int.Parse(x.ToString())).ToArray(); 
            char[] letters = symbols.Where(x => !Char.IsDigit(x)).ToArray();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            int totalSkip = 0;
            string word = "";
            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i];
                int skip = skipList[i];

                word += new string(letters.Skip(totalSkip).Take(take).ToArray());
                totalSkip += take + skip; 
            }

            Console.WriteLine(word);
        }
    }
}
