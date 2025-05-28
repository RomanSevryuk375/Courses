using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H6_T1
{
    internal class Worker : EmployeeBase
    {
        private int _salary;

        public string Qualification { get; set; }

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

        public Worker() : base()
        {
            Qualification = "Unknown";
            Salary = 0;
        }

        public Worker(int salary, string qualification, string name, string position) : base(name, position)
        {
            Salary = salary;
            Qualification = qualification;
            Name = name;
            Position = position;
        }
        public override string GetDetails()
        {
            return $"Name: {Name} Position: {Position} Sallary: {Salary} Qualification: {Qualification}";
        }
    }
}
