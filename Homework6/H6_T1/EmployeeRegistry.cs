using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6_T1
{
    public class EmployeeRegistry
    {

        private static List<EmployeeBase> employees = new List<EmployeeBase>();

        public static void AddEmployee(EmployeeBase employee)
        {
            employees.Add(employee);
        }

        public static void ListAllEmployees()
        {
            foreach (EmployeeBase employee in employees)
            {
                Console.WriteLine(employee.GetDetails());
            }
        }

        public static void FindEmployee(string name)
        {
            var flag = true;
            if (!string.IsNullOrEmpty(name))
            {
                name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            }
            else
            {
                Console.WriteLine("You entered a blank name");
            }
            foreach (EmployeeBase employee in employees)
            {
                if (employee.Name == name)
                {
                    flag = false;
                    Console.Write("Your employee " + employee.GetDetails() + "\n");
                }
            }
            if (flag)
            {
                Console.WriteLine("There is no employee with this name");
            }

        }
    }
}
