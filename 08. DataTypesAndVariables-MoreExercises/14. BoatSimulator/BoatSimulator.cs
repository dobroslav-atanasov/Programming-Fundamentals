using System;

namespace _14.BoatSimulator
{
    public class BoatSimulator
    {
        static void Main()
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int firstBoatSpeed = 0;
            int secondBoatSpeed = 0;
            bool isWinFirstBoat = false;
            bool isWinSecondBoat = false;
            
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                
                if (input.Equals("UPGRADE"))
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        firstBoatSpeed += input.Length;
                        if (firstBoatSpeed >= 50)
                        {
                            isWinFirstBoat = true;
                            break;
                        }
                    }
                    else
                    {
                        secondBoatSpeed += input.Length;
                        if (secondBoatSpeed >= 50)
                        {
                            isWinSecondBoat = true;
                            break;
                        }
                    }
                }                
            }

            if (isWinFirstBoat)
            {
                Console.WriteLine(firstBoat);
            }
            else if (isWinSecondBoat)
            {
                Console.WriteLine(secondBoat);
            }
            else
            {
                if (firstBoatSpeed > secondBoatSpeed)
                {
                    Console.WriteLine(firstBoat);
                }
                else
                {
                    Console.WriteLine(secondBoat);
                }
            }            
        }
    }
}
