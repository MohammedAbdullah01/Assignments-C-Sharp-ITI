using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay4CSharp
{
    internal interface IPayable
    {
        decimal Salary { get; set; }

         void ShowPayment();
    }
}
