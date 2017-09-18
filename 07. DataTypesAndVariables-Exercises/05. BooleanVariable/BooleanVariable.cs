using System;

namespace _05.BooleanVariable
{
    public class BooleanVariable
    {
        static void Main()
        {
            string str = Console.ReadLine();
            bool boolean = Convert.ToBoolean(str);

            if (boolean)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
