using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FixEmails
{
    public class FixEmails
    {
        static void Main()
        {
            Dictionary<string, string> emailbook = new Dictionary<string, string>();

            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                
                if (!emailbook.ContainsKey(name))
                {
                    emailbook[name] = "";
                }

                emailbook[name] = email;

                string domain = email.ToLower().Substring(email.Length - 2, 2);

                if (domain.Equals("uk") || domain.Equals("us"))
                {
                    emailbook.Remove(name);
                }

                name = Console.ReadLine();
            }

            foreach (var pair in emailbook)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
