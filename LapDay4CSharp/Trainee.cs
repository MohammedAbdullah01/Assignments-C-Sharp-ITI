using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LapDay4CSharp
{
    internal class Trainee : Person, IPayable, IComparer<Trainee> , ICloneable
    {
        public int Nid { get; set; }
        public string? IntakeNumber { get; set; }

        public decimal Salary { get; set; }

        public Trainee(int _nid, string _IntakeNumber, string _name, byte _age, decimal _salary) : base(_name, _age)
        {
            Nid = _nid;
            IntakeNumber = _IntakeNumber;
            Salary = _salary;
        }


        public override string ToString()
        {
            return $":\n\tNID: {Nid}\n\tIntakeNumber: {IntakeNumber}\n\t{base.ToString()} Salary: {Salary}";
        }

        public void ShowPayment()
        {
            Console.WriteLine($"Trainee Salary: {Salary}");
        }

        // Implement the Clone method Interface (ICloneable) 
        public object Clone()
        {
            return new Trainee(this.Nid, this.IntakeNumber?? string.Empty, base.Name ?? string.Empty, base.Age, this.Salary);
        }

        public int Compare(Trainee? obj1 , Trainee? obj2)
        {
            if (obj1 == null || obj2 == null)
            {
                throw new ArgumentNullException();
            }

           return obj1.Age.CompareTo(obj2.Age);
        }
    }


}
