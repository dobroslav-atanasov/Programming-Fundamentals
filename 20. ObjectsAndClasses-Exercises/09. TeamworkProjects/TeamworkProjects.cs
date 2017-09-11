using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    public class TeamworkProjects
    {
        public static void Main()
        {
            List<Team> teams = new List<Team>();
            int numberOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] inputParts = Console.ReadLine().Split('-').ToArray();
                string creator = inputParts[0];
                string teamName = inputParts[1];
                Team team = new Team()
                {
                    Name = teamName,
                    Creator = creator,
                    Members = new List<string>()
                };
                if (!teams.Select(x => x.Name).Contains(team.Name))
                {
                    if (!teams.Select(x => x.Creator).Contains(team.Creator))
                    {
                        Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                        teams.Add(team);
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] inputParts = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = inputParts[0];
                string teamName = inputParts[1];

                if (!teams.Any(x => x.Name.Contains(teamName)))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Select(x => x.Members).Any(x => x.Contains(user)) || teams.Select(x => x.Creator).Contains(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team exist = teams.First(x => x.Name.Equals(teamName));
                    exist.Members.Add(user);
                }

                input = Console.ReadLine();
            }

            List<Team> teamsWithUsers = teams.Where(x => x.Members.Count > 0).ToList();
            List<Team> teamsWitoutUsers = teams.Where(x => x.Members.Count == 0).ToList();

            foreach (var team in teamsWithUsers.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsWitoutUsers.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
            }
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}
