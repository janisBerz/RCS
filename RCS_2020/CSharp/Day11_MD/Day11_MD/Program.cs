using System;
using System.Collections.Generic;

namespace Day11_MD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please create a dev team by entering team member details below.");

            Console.Write("How many developers will you need? Amount: ");

            int developerCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            teams.Add(AddTeam(developerCount));
            PrintTeam(teams);

        }

        public static Team AddTeam(int developerCount)
        {
            Console.Write("Team name: ");
            string teamName = Console.ReadLine();

            Manager manager = Team.AddManager();

            List<Programmer> programmer = Team.AddProgrammer(developerCount);

            Team team = new Team(teamName, manager, programmer );
            return team;

        }

        public static void PrintTeam(List<Team> teams)
        {

            foreach (Team team in teams)
            {
                Console.WriteLine();
                Console.WriteLine("--- Printing teams details ---");
                Console.WriteLine($"Team name: {team.TeamName}");
                Console.WriteLine($"Manager: Name - {team.Manager.Name} Age - {team.Manager.Age} Monthly Salary - {team.Manager.MonthlySalary} Experaince - {team.Manager.YearsOfExperiance}");

                foreach (Programmer programmer in team.Programmer)
                {
                    Console.WriteLine($"Programmer: Name - {programmer.Name} Age - {programmer.Age} Monthly Salary - {programmer.MonthlySalary} Experaince - {programmer.Language}");

                }
            }

        }

    }
}
