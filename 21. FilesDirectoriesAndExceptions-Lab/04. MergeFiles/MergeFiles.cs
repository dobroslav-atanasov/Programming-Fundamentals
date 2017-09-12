using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.MergeFiles
{
    public class MergeFiles
    {
        public static void Main()
        {
            string[] first = File.ReadAllLines(@"..\..\Input1.txt");
            string[] second = File.ReadAllLines(@"..\..\Input2.txt");

            for (int i = 0; i < first.Length; i++)
            {
                File.AppendAllText(@"..\..\Output.txt", first[i] + Environment.NewLine);
                File.AppendAllText(@"..\..\Output.txt", second[i] + Environment.NewLine);
            }
        }
    }
}
