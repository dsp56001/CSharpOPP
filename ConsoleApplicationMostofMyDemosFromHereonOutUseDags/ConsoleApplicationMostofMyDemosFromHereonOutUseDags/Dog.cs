using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMostofMyDemosFromHereonOutUseDags
{
    public class Dog
    {
        //Properies
        public string Name;
        public int Age;
        public int Weight;
        public string BarkSound;
        public string Color;

        //Constructor
        public Dog()
        {
            this.Age = 1;
            this.BarkSound = "Arf!";
            this.Name = "fido";
            this.Weight = 2;

        }

        //Methods
        public string Bark()
        {
            return this.BarkSound;
        }

        public void Eat()
        {
            this.Weight++;
        }

        public string About()
        {
            return string.Format("Hello my name is {0} I weight {1} I'm {2} years old. My bark sounds like {3}",
                this.Name, this.Weight, this.Age, this.BarkSound);
        }

        public void WagTail()
        {
            throw new System.NotImplementedException();
        }
    }
}
