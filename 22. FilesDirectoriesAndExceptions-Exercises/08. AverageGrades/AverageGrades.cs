using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _08.AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            string[] allLines = File.ReadAllLines(@"..\..\Input.txt");
            int n = int.Parse(allLines[0]);

            for (int i = 1; i <= n; i++)
            {
                string[] input = allLines[i].Split(' ').ToArray();
                List<double> grades = new List<double>();
                for (int j = 1; j < input.Length; j++)
                {
                    grades.Add(double.Parse(input[j]));
                }
                Student student = new Student
                {
                    Name = input[0],
                    Grades = grades
                };
                students.Add(student);
            }

            foreach (var student in students.Where(s => s.Average >= 5.00).OrderBy(s => s.Name).ThenByDescending(s => s.Average))
            {
                File.AppendAllText(@"..\..\Output.txt", $"{student.Name} -> {student.Average:F2}" + Environment.NewLine);
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<Double> Grades { get; set; }
        public double Average { get { return Grades.Average(); } }
    }
}
