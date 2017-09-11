using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.MentorGroup
{
    public class MentorGroup
    {
        public static void Main()
        {            
            List<Student> students = new List<Student>();
            string firstInput = Console.ReadLine();
            while (!firstInput.Equals("end of dates"))
            {
                string[] inputParts = firstInput.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = inputParts[0];
                List<DateTime> dates = inputParts.Skip(1).Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InstalledUICulture)).ToList();
                if (students.Any(x => x.Name.Equals(name)))
                {
                    Student exist = students.First(x => x.Name.Equals(name));
                    exist.Dates.AddRange(dates);
                }
                else
                {
                    Student student = new Student
                    {
                        Name = name,
                        Dates = dates,
                        Comments = new List<string>()
                    };
                    students.Add(student);
                }

                firstInput = Console.ReadLine();
            }
            string secondInput = Console.ReadLine();
            while (!secondInput.Equals("end of comments"))
            {
                string[] inputParts = secondInput.Split('-').ToArray();
                string name = inputParts[0];
                string comment = inputParts[1];
                if (students.Any(x => x.Name == name))
                {
                    Student exist = students.First(x => x.Name.Equals(name));
                    exist.Comments.Add(comment);
                }

                secondInput = Console.ReadLine();
            }

            foreach (var student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine("Comments:");
                if (student.Comments.Count != 0)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                Console.WriteLine("Dates attended:");
                if (student.Dates.Count != 0)
                {
                    foreach (var date in student.Dates.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {date:dd/MM/yyyy}");
                    }
                }
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
