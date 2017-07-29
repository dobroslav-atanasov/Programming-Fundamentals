using System;

namespace _07.SentenceTheThief
{
    public class SentenceTheThief
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long thiefId = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                long id = long.Parse(Console.ReadLine());

                if (type.Equals("sbyte"))
                {
                    if (id >= sbyte.MinValue && id <= sbyte.MaxValue)
                    {
                        long currentId = id;
                        if (currentId > thiefId)
                        {
                            thiefId = currentId;
                        }
                    }
                }
                else if (type.Equals("int"))
                {
                    if (id >= int.MinValue && id <= int.MaxValue)
                    {
                        long currentId = id;
                        if (currentId > thiefId)
                        {
                            thiefId = currentId;
                        }
                    }
                }
                else if (type.Equals("long"))
                {
                    if (id >= long.MinValue && id <= long.MaxValue)
                    {
                        long currentId = id;
                        if (currentId > thiefId)
                        {
                            thiefId = currentId;
                        }
                    }
                }
            }

            double yearsInPrison = 0;

            if (thiefId < 0)
            {
                yearsInPrison = Math.Ceiling((double)thiefId / sbyte.MinValue);
            }
            else
            {
                yearsInPrison = Math.Ceiling((double)thiefId / sbyte.MaxValue);
            }

            if (yearsInPrison == 1)
            {
                Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {yearsInPrison} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {yearsInPrison} years");
            }            
        }
    }
}
