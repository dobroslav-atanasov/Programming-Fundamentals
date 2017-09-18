using System;

namespace _08.SMSTyping
{
    public class SMSTyping
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = "";

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 0: text += " "; break;
                    case 2: text += 'a'; break;
                    case 22: text += 'b'; break;
                    case 222: text += 'c'; break;
                    case 3: text += 'd'; break;
                    case 33: text += 'e'; break;
                    case 333: text += 'f'; break;
                    case 4: text += 'g'; break;
                    case 44: text += 'h'; break;
                    case 444: text += 'i'; break;
                    case 5: text += 'j'; break;
                    case 55: text += 'k'; break;
                    case 555: text += 'l'; break;
                    case 6: text += 'm'; break;
                    case 66: text += 'n'; break;
                    case 666: text += 'o'; break;
                    case 7: text += 'p'; break;
                    case 77: text += 'q'; break;
                    case 777: text += 'r'; break;
                    case 7777: text += 's'; break;
                    case 8: text += 't'; break;
                    case 88: text += 'u'; break;
                    case 888: text += 'v'; break;
                    case 9: text += 'w'; break;
                    case 99: text += 'x'; break;
                    case 999: text += 'y'; break;
                    case 9999: text += 'z'; break;
                    default: break;
                }
            }

            Console.WriteLine(text);
        }
    }
}
