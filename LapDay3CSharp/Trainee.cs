using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LapDay3CSharp
{
    internal class Trainee : Person
    {
        public int Nid { get; set; }
        public string? IntakeNumber { get; set; }

        public Trainee(int _nid ,string _IntakeNumber , string _name , byte _age) : base(_name, _age)
        {    
            Nid = _nid;
            IntakeNumber = _IntakeNumber;
        }


        public override string ToString()
        {
            return $":\n\tNID: {Nid}\n\tSalary: {IntakeNumber}\n\t{base.ToString()}";
        }

        
    }
}
