using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LapDay4CSharp
{
    internal abstract class Person
    {
        public string? Name { get; set; }
        public byte Age { get; set; }

        protected Person(string _Name, byte _age)
        {
            Name = _Name;
            Age = _age;
        }

        public override string ToString()
        {
            return $"Name = {Name}\n\tAge = {Age}";
        }

        public static string GetType(object obj)
        {
            return obj.GetType().Name;
        }
    }
}
