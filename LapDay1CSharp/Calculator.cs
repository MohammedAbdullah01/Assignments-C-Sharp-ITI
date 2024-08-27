using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay1CSharp
{
    internal class Calculator
    {
        public static decimal Add(decimal num1 , decimal num2)
        {
            return num1 + num2;
        }

        public static decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public static decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }


        public static decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
    }
}
