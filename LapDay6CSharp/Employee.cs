
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay6CSharp
{
    internal class Employee
    {
        public event Action<object , MsgEventArgs>? OnSalaryIncreased;
        public string Name { get; private set; }
        public float Salary { get; private set; }

        public Employee(string name , float salary)
        {
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(float amount)
        {
            float SalaryAfterIncrease =  Salary + amount;

                OnSalaryIncreased?.Invoke(this , 
                    new MsgEventArgs 
                    { 
                        EmployeeName = Name , 
                        SalaryBeforeIncrease = Salary  ,
                        SalaryAfterIncrease = SalaryAfterIncrease,
                        AmountIncrease = amount
                    });
            Salary = SalaryAfterIncrease;
        }
    }
}
