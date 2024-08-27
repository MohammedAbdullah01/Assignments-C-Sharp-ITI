using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay2CSharp
{
    internal struct Employee
    {
        string Name;
        decimal Salary;
        public Role Role { get; private set; }


        public Employee(string name , decimal salary , Role role)
        {
            Name = name;
            Salary = salary;
            Role = role;
            
        }

        public void Display()
        {
            Console.WriteLine($"Information The Employee: \nName :\t{Name}\nSalary :\t{Salary}\nPermissions :\t{Role}\n");
        }

        public void AssignRole(Role role)
        {
            Role ^= role;
        }

        public bool HasRole(Role role)
        {
            if((Role & role) == role)
            {
                return true;
            }
            return false;
        }

    }
}
