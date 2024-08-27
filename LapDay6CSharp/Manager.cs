using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay6CSharp
{
    internal class Manager : Employee
    {
        public Manager(string name , float salary) : base(name , salary){}
        public static bool FilterManager(Employee employee)
        {
            return employee is Manager;
        }
    }
}
