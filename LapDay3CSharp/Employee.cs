using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay3CSharp
{
    internal class Employee : Person
    {
        public int Nid { get; set; }
        public double Salary { get; set; }


        public Employee(int _nid, double _salary , string _Name , byte _age) : base(_Name,  _age)
        {
            Nid = _nid;
            Salary = _salary;
        }

        public override string ToString()
        {
            return $":\n\tNID: {Nid}\n\tSalary: {Salary}\n\t{base.ToString()}";
        }

        
    }
}
