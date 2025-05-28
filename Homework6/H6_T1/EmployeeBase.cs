using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6_T1
{
    public abstract class EmployeeBase
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public EmployeeBase()
        {
            Position = "Unknown";
            Name = "Unknown";
        }
        public EmployeeBase(string position, string name)
        {
            position = "Unknown";
            name = "Unknown";
        }
        public abstract string GetDetails();
 
    }
}
