using System;

namespace _08.GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type.Equals("int"))
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetMax(a, b);

                Console.WriteLine(result);
            }
            else if (type.Equals("char"))
            {
                char symbol1 = char.Parse(Console.ReadLine());
                char symbol2 = char.Parse(Console.ReadLine());
                char result = GetMax(symbol1, symbol2);

                Console.WriteLine(result);
            }
            else
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string result = GetMax(str1, str2);

                Console.WriteLine(result);
            }
        }

        public static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static char GetMax(char symbol1, char symbol2)
        {
            if (symbol1 >= symbol2)
            {
                return symbol1;
            }
            else
            {
                return symbol2;
            }
        }

        public static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
    }
}
