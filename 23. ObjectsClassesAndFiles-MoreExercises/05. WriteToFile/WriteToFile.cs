using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.WriteToFile
{
    public class WriteToFile
    {
        public static void Main()
        {
            string text = File.ReadAllText(@"..\..\Input.txt");
            text = text.Replace(".", "");
            text = text.Replace(",", "");
            text = text.Replace("!", "");
            text = text.Replace("?", "");
            text = text.Replace(":", "");

            File.WriteAllText(@"..\..\Output.txt", text);
        }
    }
}
