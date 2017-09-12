using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _05.FolderSize
{
    public class FolderSize
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("TestFolder");

            double sum = 0;
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;
            File.WriteAllText(@"..\..\Output.txt", sum.ToString());
        }
    }
}
