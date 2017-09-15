using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OrderByAge
{
    public class OrderByAge
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] parts = input.Split(' ').ToArray();
                Person person = new Person
                {
                    Name = parts[0],
                    ID = parts[1],
                    Age = int.Parse(parts[2])
                };
                people.Add(person);
                input = Console.ReadLine();
            }

            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
