using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _01.OddLines
{
    public class OddLines
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines(@"..\..\Input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    File.AppendAllText(@"..\..\Output.txt", text[i] + Environment.NewLine);
                }
            }
        }
    }
}
