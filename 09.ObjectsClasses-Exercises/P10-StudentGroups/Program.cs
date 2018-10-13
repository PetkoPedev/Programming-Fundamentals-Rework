using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P10_StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = ReadTownsAndStudents();
            List<Group> groups = DistributeStudentsIntoGroups(towns);
        }

        static List<Town> ReadTownsAndStudents()
        {
            List<Town> towns = new List<Town>();

            string inputLine = Console.ReadLine();
            while (inputLine != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    Town town = new Town();
                    string[] tokens = inputLine.Split("=>");
                    string townName = tokens[0].Trim();
                    int seats = int.Parse(tokens[1].Trim().Split(' ')[0]);
                    town.Students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    Student student = new Student();
                    Town town = new Town();
                    string[] tokens = inputLine.Split('|');
                    string name = tokens[0].Trim();
                    string email = tokens[1].Trim();
                    DateTime date = DateTime.ParseExact(tokens[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    student.Name = name;
                    student.Email = email;
                    student.RegistrationDate = date;

                    town.Students.Add(student);
                }

                inputLine = Console.ReadLine();
            }
            return towns;
        } 

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns)
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);
                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }
            return groups;
        }
    }
}
