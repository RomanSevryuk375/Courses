using System;
using System.Globalization;

namespace H6_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager1 = new Manager();
            var manager2 = new Manager(1000, "software technician", "Roman", "junior");
            var worker1 = new Worker();
            var worker2 = new Worker(1000, "software technician", "Ivan", "1st class");
            EmployeeRegistry.AddEmployee(manager1);
            EmployeeRegistry.AddEmployee(manager2);
            EmployeeRegistry.AddEmployee(worker1);
            EmployeeRegistry.AddEmployee(worker2);
            Console.WriteLine("ALL EMPLOYEES:");
            EmployeeRegistry.ListAllEmployees();
            Console.WriteLine("YOUR EMPLOYEES:");
            EmployeeRegistry.FindEmployee("mike");
            var project = new Manager.Project();
            project.Deadline = DateTime.Now;
            project.ProjectName = "first project";
            manager1.AssignedProject = project;
            manager1.AssignedProject.DisplayProjectInfo();
            var project1 = new Manager.Project();
            project1.Deadline = DateTime.Now;
            project1.ProjectName = "second project";
            manager2.AssignedProject = project1;
            manager2.AssignedProject.DisplayProjectInfo();
            while (true)
            {
                Console.WriteLine("If you want to add \n worker - enter 1 \n manager - enter 2 \n want to stop - enter 3 or nothing");
                var userChoise = Console.ReadLine();
                if (userChoise == "")
                {
                    Console.WriteLine("Nothing entered means stop");
                    break;
                }
                else if (userChoise == "3")
                {
                    break;
                }
                else if (userChoise == "2")
                {
                    Console.WriteLine("If you want to add project to your manager - enter 1, else enter nothing or 2");
                    var userProjectChoise = Console.ReadLine();
                    if (userProjectChoise == "2" || userProjectChoise == "")
                    {
                        EmployeeRegistry.AddEmployee(AddManager());
                    }
                    else if (userProjectChoise == "1")
                    {
                        var inputManager = AddManager();
                        var inputProject = AddProject();
                        inputManager.AssignedProject = inputProject;
                        EmployeeRegistry.AddEmployee(inputManager);
                    }
                    else
                    {
                        Console.WriteLine("You should enter only 1/2/nothing");
                    }
                }
                else if (userChoise == "1")
                {
                    EmployeeRegistry.AddEmployee(AddWorker());
                }
                else
                {
                    Console.WriteLine("You should enter only 1/2/3/nothing");
                }
            }
            Console.WriteLine("What is the employee's name");
            var employeeName = Console.ReadLine();
            Console.WriteLine("ALL EMPLOYEES:");
            EmployeeRegistry.ListAllEmployees();
            Console.WriteLine("YOUR EMPLOYEES:");
            EmployeeRegistry.FindEmployee(employeeName);
        }

        static Manager AddManager()
        {
            Console.WriteLine("Enter the manager's name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the manager's position");
            var position = Console.ReadLine();
            Console.WriteLine("Enter the manager's qalification");
            var qalification = Console.ReadLine();
            Console.WriteLine("Enter the manager's salary");
            var inputSalary = Console.ReadLine();
            var salary = 0;
            if (!string.IsNullOrEmpty(inputSalary))
            {
                salary = int.Parse(inputSalary);
            }
            return new Manager(salary, qalification, name, position);
        }

        static Worker AddWorker()
        {
            Console.WriteLine("Enter the worker's name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the worker's position");
            var position = Console.ReadLine();
            Console.WriteLine("Enter the worker's qalification");
            var qalification = Console.ReadLine();
            Console.WriteLine("Enter the worker's salary");
            var inputSalary = Console.ReadLine();
            var salary = 0;
            if (!string.IsNullOrEmpty(inputSalary))
            {
                salary = int.Parse(inputSalary);
            }
            return new Worker(salary, qalification, name, position);
        }

        static Manager.Project AddProject()
        {
            Console.WriteLine("Enter the project's deadline as year-month-day");
            var inputDeadline = Console.ReadLine();
            DateTime deadline = DateTime.ParseExact(inputDeadline, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the project's name");
            var projectName = Console.ReadLine();
            return new Manager.Project(projectName, deadline);
        }
    }
}

