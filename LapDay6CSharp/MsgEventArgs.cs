using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay6CSharp
{
    internal class MsgEventArgs
    {
        public string? EmployeeName { get; set; }
        public float AmountIncrease { get; set; }
        public float SalaryBeforeIncrease { get; set; }
        public float SalaryAfterIncrease { get; set; }
    }
}
