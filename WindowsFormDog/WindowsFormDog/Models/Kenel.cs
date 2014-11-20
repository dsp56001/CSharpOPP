using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationStaticDob
{
    class Kenel  
    {
        List<Dog> dogs;

        public Kenel()
        {
            dogs = new List<Dog>();
        }

        public void AddDog(Dog d)
        {
            dogs.Add(d);
        }

        
        public string BarkAllDogs()
        {
            string barks = string.Empty;
            foreach (Dog d in this.dogs)
            {
                barks += d.Bark();
            }
            return barks;
        }
    }
}
