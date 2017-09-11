using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10.StudentGroups
{
    public class StudentGroups
    {
        public static void Main()
        {
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string separator = "=>";
                if (input.Contains(separator))
                {
                    string[] parts = input.Trim().Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string townName = parts[0];
                    int seats = int.Parse(parts[1].Split(' ')[0]);
                    Town town = new Town()
                    {
                        Name = townName,
                        Seats = seats,
                        Students = new List<Student>()
                    };
                    towns.Add(town);
                }
                else
                {
                    string[] parts = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string studentName = parts[0].Trim();
                    string studentEmail = parts[1].Trim();
                    string date = parts[2].Trim();
                    DateTime registrationDate = DateTime.ParseExact(date, "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    Student student = new Student()
                    {
                        Name = studentName,
                        Email = studentEmail,
                        RegistrationDate = registrationDate
                    };
                    towns[towns.Count - 1].Students.Add(student);
                }

                input = Console.ReadLine();
            }

            List<Group> groups = new List<Group>();
            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town.Students.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email);

                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.Seats).ToList();
                    students = students.Skip(group.Town.Seats);
                    groups.Add(group);
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {groups.Select(x => x.Town).Distinct().ToList().Count} towns:");

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(x => x.Email).ToList())}");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    public class Town
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Student> Students { get; set; }
    }

    public class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
