using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }
        public string Creator { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] userTeam = Console.ReadLine().Split('-').ToArray();
                List<string> membersList = new List<string>();
                Team team = new Team();
                team.Name = userTeam[1];
                team.Creator = userTeam[0];
                team.Members = membersList;
                if (!teams.Select(a => a.Name).Contains(team.Name))
                {
                    if (!teams.Select(a => a.Creator).Contains(team.Creator))
                    {
                        teams.Add(team);
                        Console.WriteLine("Team {0} has been created by {1}!",
                            userTeam[1],
                            userTeam[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} cannot create another team!", team.Creator);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} was already created!", team.Name);
                }
            }

            string teamRegistration = Console.ReadLine();

            while (!teamRegistration.Equals("end of assignment"))
            {
                var input = teamRegistration.Split(new char[] { '-', '>' }).ToArray();
                string newUser = input[0];
                string teamName = input[2];
                if (!teams.Select(x => x.Name).Contains(teamName))
                {
                    Console.WriteLine("Team {0} does not exist!", teamName);
                }
                else if (teams.Select(a => a.Members).Any(a => a.Contains(newUser))
                    || teams.Select(x => x.Creator).Contains(newUser))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!",
                        newUser,
                        teamName);
                }
                else
                {
                    int teamToJoinIndex = teams.FindIndex(x => x.Name == teamName);
                    teams[teamToJoinIndex].Members.Add(newUser);
                }

                teamRegistration = Console.ReadLine();
            }

            var teamsToDisband = teams.OrderBy(x => x.Name).Where(x => x.Members.Count == 0);
            var fullTeams = teams.
            OrderByDescending(x => x.Members.Count).
            ThenBy(x => x.Name).
            Where(x => x.Members.Count > 0);

            foreach (var team in fullTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsToDisband)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
