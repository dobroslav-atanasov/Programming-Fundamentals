using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Office.Interop.Excel;

namespace _06.EXCELlentKnowledge
{
    public class EXCELlentKnowledge
    {
        public static void Main()
        {
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\PROJECTS\Programming Fundamentals\23. ObjectsClassesAndFiles-MoreExercises\06. EXCELlentKnowledge\Input.xlsx");
            _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;


            for (int i = 1; i <= 5; i++)
            {
                string text = "";
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 && i != 1)
                    {
                        Console.WriteLine();
                    }
                    text += xlRange.Cells[i, j].Value + "|";
                }
                File.AppendAllText(@"..\..\Output.txt", text + Environment.NewLine);
            }
        }
    }
}
