using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay4CSharp
{
    internal class Employee : Person , IPayable , IComparable<Employee>
    {
        public int Nid { get; set; }
        public decimal Salary { get; set; }


        public Employee(int _nid, decimal _salary , string _Name , byte _age) : base(_Name,  _age)
        {
            Nid = _nid;
            Salary = _salary;
        }

        public override string ToString()
        {
            return $":\n\tNID: {Nid}\n\tSalary: {Salary}\n\t{base.ToString()}";
        }

        public void ShowPayment()
        {
             Console.WriteLine($"Employee Salary: {Salary}");
        }

        public int CompareTo(Employee? other)
        {
            if (other == null || Name == null) throw new ArgumentNullException("Arguments cannot be null");

            return Name.CompareTo(other.Name);
        }
    }
}
