using System;
using System.Collections.Generic;
using System.Text;

namespace Day11_MD
{
    class Team
    {
        public string TeamName { get; set; }
        public Manager Manager { get; set; }
        public List<Programmer> Programmer { get; set; }
        //public ProgrammerDatabase ProgrammerDatabase { get; set; }

        public Team(string teamName, Manager manager, List<Programmer> programmer)
        {
            this.TeamName = teamName;
            this.Manager = manager;
            this.Programmer = programmer;

        }

        public static Manager AddManager()
        {
            Console.WriteLine();
            Console.WriteLine("--- Manager details ---");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Salary: ");
            double monthlySalary = int.Parse(Console.ReadLine());

            Console.Write("Experiance: ");
            int yearsOfExperiance = int.Parse(Console.ReadLine());

            Manager manager = new Manager(name, age, monthlySalary, yearsOfExperiance);

            return manager;
        }

        public static List<Programmer> AddProgrammer(int count)
        {
            List<Programmer> programmers = new List<Programmer>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("--- Programmer details ---");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Salary: ");
                double monthlySalary = int.Parse(Console.ReadLine());

                Console.Write("Language: ");
                string language = Console.ReadLine();
                programmers.Add(new Programmer(name, age, monthlySalary, language));
            }

            return programmers;
        }
    }
}
