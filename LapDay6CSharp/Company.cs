using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay6CSharp
{
    delegate bool EmployeeFilterDelegate(Employee employee);
    internal class Company
    {
        public string? Name { get; private set; }
        public float Budget { get; private set; }
        private  List<Employee> employees { get; set; }

        public IReadOnlyList<Employee> Employees => employees != null 
            ?  
            employees.AsReadOnly() 
            : 
            new List<Employee>().AsReadOnly();

        public Company(string name , float  budget , List<Employee> employees)
        {
            Name = name;
            Budget = budget;
            this.employees = employees;

            SubscribeToSalaryIncrease();
        }


        public void Notify(object obj , MsgEventArgs data)
        {
            if (Budget < data.AmountIncrease)
            {
                Console.WriteLine("Insufficient budget for salary increase.");
                return;
            }

            Budget -= data.AmountIncrease;
            Console.WriteLine(
                $"The budget was reduced after the increase in the employee's salary :\n" +
                $"EmployeeName : {data.EmployeeName}\n" +
                $"Salary before increase : {data.SalaryBeforeIncrease}\n" +
                $"Salary After increase : {data.SalaryAfterIncrease}\n" +
                $"Amount Increase : {data.AmountIncrease}\n" +
                $"The company's budget after increasing the employee's salary : {Budget}\n");
        }

        private void SubscribeToSalaryIncrease()
        {
            foreach (var employee in employees)
            {
                employee.OnSalaryIncreased += Notify;
            }
        }


        public List<Employee> FilterEmployees(EmployeeFilterDelegate empFilter)
        {
            List<Employee> filteredEmployees = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (empFilter(employee))
                {
                    filteredEmployees.Add(employee);
                }
                
            }
            return filteredEmployees;
        }

    }
}
