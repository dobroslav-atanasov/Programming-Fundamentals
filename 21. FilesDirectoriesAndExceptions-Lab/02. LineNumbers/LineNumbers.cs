using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _02.LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines(@"..\..\Input.txt");

            var lines = text.Select((line, index) => $"{index + 1}. {line}");
            File.WriteAllLines(@"..\..\Output.txt", lines);
        }
    }
}
