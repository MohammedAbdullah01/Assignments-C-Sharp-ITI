using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay5CSharp
{
    internal class Zoo
    {
        private List<Mammal> mammals = new List<Mammal>();

        private List<Bird> birds = new List<Bird>();


        public ReadOnlyCollection<Mammal> Mammals => mammals.AsReadOnly();
        public ReadOnlyCollection<Bird> Birds => birds.AsReadOnly();
        public ReadOnlyCollection<Animal> Animals => new ReadOnlyCollection<Animal>(mammals.Cast<Animal>().Concat(birds.Cast<Animal>()).ToList());

        public void AddAnimal(Animal animal)
        {

            if (CheckAgeTheAnimal(animal))
            {
                return;
            }

            if (animal is Mammal mammal)
            {
                mammals.Add(mammal);
            }

            else if (animal is Bird bird)
            {
                birds.Add(bird);
            }

        }

        public void RemoveAnimal(Animal animal)
        {
            {
                if(animal is Mammal Mammal)
                {
                    mammals.Remove(Mammal);
                }

                else if (animal is Bird Bird)
                {
                    birds.Remove(Bird);
                }
            }
        }


        public bool CheckAgeTheAnimal(Animal animal)
        {
            return animal.Age > 10;
        }
    }
}
