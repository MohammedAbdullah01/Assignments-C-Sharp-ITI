using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay5CSharp
{
    internal abstract class Animal
    {
        public string? Name;
        public int Age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public void DieAnimal(Zoo zoo)
        {
            zoo.RemoveAnimal(this);
        }


        public override string ToString()
        {
            return $"\tName Animal => {Name} \n\tAge Animal => {Age}\n";
        }
    }
}
