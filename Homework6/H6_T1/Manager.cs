using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6_T1
{
    public class Manager : EmployeeBase
    {
        private int _salary;

        public string Qualification { get; set; }

        public Project AssignedProject { get; set; }

        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Salary cannot be negative");
                    _salary = 0;
                }
                else
                {
                    _salary = value;
                }
            }
        }

        public Manager() : base()
        {
            Qualification = "Unknown";
            Salary = 0;
        }

        public Manager(int salary, string qualification, string name, string position) : base(name, position)
        {
            Salary = salary;
            Qualification = qualification;
            Name = name;
            Position = position;
        }

        public Manager(int salary, string qualification, string name, string position, Project project) : this(salary, qualification, name, position)
        {
            AssignedProject = project;
        }

        public override string GetDetails()
        {
            return $"Name: {Name} Position: {Position} Sallary: {Salary} Qualification: {Qualification}";
        }

        public void AssignProject(string projectName, DateTime deadline)
        {
            AssignedProject = new Project(projectName, deadline);
        }

        public class Project
        {
            public string ProjectName;

            public DateTime Deadline;

            public Project()
            {
               
            }

            public Project(string projectName, DateTime deadline)
            {
                ProjectName = projectName;
                Deadline = deadline;
            }

            public void DisplayProjectInfo()
            {
                Console.WriteLine($"Project name - {ProjectName}, deadline - {Deadline}");
            }
        }
    }
}

