using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
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
                Console.WriteLine($"{student.Name} -> {student.Average:F2}");
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
