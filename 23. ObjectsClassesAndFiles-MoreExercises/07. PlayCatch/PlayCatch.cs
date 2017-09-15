using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.PlayCatch
{
    public class PlayCatch
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int exceptions = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string command = input[0];
                try
                {
                    if (command == "Replace")
                    {
                        int index = int.Parse(input[1]);
                        nums[index] = int.Parse(input[2]);
                    }
                    else if (command == "Print")
                    {
                        int index = int.Parse(input[1]);
                        int endIndex = int.Parse(input[2]);
                        Console.WriteLine(string.Join(", ", nums.GetRange(index, endIndex - index + 1)));
                    }
                    else if (command == "Show")
                    {
                        int index = int.Parse(input[1]);
                        Console.WriteLine(nums[index]);
                    }
                }
                catch
                {
                    if (input.Length > 2)
                    {
                        int number = 0;
                        if (int.TryParse(input[1], out number) && int.TryParse(input[2], out number))
                        {
                            Console.WriteLine("The index does not exist!");
                        }
                        else
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                        }
                    }
                    else
                    {
                        int number = 0;
                        if (int.TryParse(input[1], out number))
                        {
                            Console.WriteLine("The index does not exist!");
                        }
                        else
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                        }
                    }
                    exceptions++;
                }

                if (exceptions == 3)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
