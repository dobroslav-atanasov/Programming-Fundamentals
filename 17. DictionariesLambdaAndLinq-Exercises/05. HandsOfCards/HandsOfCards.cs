using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsOfCards
{
    public class HandsOfCards
    {
        static void Main()
        {            
            Dictionary<string, List<string>> hands = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] inputParts = input.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = inputParts[0];
                List<string> cards = inputParts[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

                if (!hands.ContainsKey(name))
                {
                    hands[name] = new List<string>();
                }

                foreach (var card in cards)
                {
                    if (!hands[name].Contains(card))
                    {
                        hands[name].Add(card);
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, long> belot = new Dictionary<string, long>();

            foreach (var player in hands)
            {
                if (!belot.ContainsKey(player.Key))
                {
                    belot[player.Key] = 0;
                }

                belot[player.Key] += CalculateSum(player.Value);
            }

            foreach (var pair in belot)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        public static long CalculateSum(List<string> value)
        {
            long sum = 0;

            for (int i = 0; i < value.Count; i++)
            {
                char[] cardParts = value[i].ToCharArray();
                char power = default(char);
                char type = default(char);
                if (cardParts.Length == 2)
                {
                    power = cardParts[0];
                    type = cardParts[1];
                }
                else
                {
                    power = cardParts[0];
                    type = cardParts[2];
                }

                int powerNum = 0;
                int typeNum = 0;

                switch (power)
                {
                    case '2': powerNum = 2; break;
                    case '3': powerNum = 3; break;
                    case '4': powerNum = 4; break;
                    case '5': powerNum = 5; break;
                    case '6': powerNum = 6; break;
                    case '7': powerNum = 7; break;
                    case '8': powerNum = 8; break;
                    case '9': powerNum = 9; break;
                    case '1': powerNum = 10; break;
                    case 'J': powerNum = 11; break;
                    case 'Q': powerNum = 12; break;
                    case 'K': powerNum = 13; break;
                    case 'A': powerNum = 14; break;
                    default: break;
                }

                switch (type)
                {
                    case 'S': typeNum = 4; break;
                    case 'H': typeNum = 3; break;
                    case 'D': typeNum = 2; break;
                    case 'C': typeNum = 1; break;
                    default: break;
                }

                sum += powerNum * typeNum;
            }

            return sum;
        }
    }
}
