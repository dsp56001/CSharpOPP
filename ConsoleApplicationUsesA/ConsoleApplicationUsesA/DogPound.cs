using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationUsesA
{
    class DogPound
    {
        List<Dog> dogs;

        public DogPound()
        {
            this.dogs = new List<Dog>();
        }

        public void AddDog(Dog d)
        {
            this.dogs.Add(d);
        }

        public List<Dog> GetDogs()
        {
            return this.dogs;
        }
    }
}
