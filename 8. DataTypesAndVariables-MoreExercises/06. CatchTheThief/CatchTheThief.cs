using System;

namespace _06.CatchTheThief
{
    public class CatchTheThief
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

            Console.WriteLine(thiefId);
        }
    }
}
