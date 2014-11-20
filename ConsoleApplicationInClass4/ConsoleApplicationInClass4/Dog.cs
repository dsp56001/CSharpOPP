using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInClass4
{
    public class Dog
    {
        //Fields AKA Properties
        public string Name;
        public int Age;
        public int Weight;
        public string BarkSound;

        //Constructor
        public Dog() : this("fido")
        {
            
        }

        public Dog(string dogName)
        {
            this.Name = dogName;
            this.Age = 1;
            this.BarkSound = "Woof!";
            this.Weight = 7;
        }

        //Methods
        public string Bark()
        {
            
            return string.Format("{0} bark sounds like {1}",
                this.Name, this.BarkSound);
        }

        

        public void Eat()
        {
            this.Weight++;
        }

        public void Eat(int HowMuch)
        {
            for (int i = 0; i < HowMuch; i++)
            {
                this.Eat();
            }
        }

        public string About()
        {
            string about = string.Empty;
            about += string.Format("Hello My name is {0} and I'm {1} years old I weigh {2} lbs",
                this.Name, this.Age, this.Weight);
            about += "\n" + this.Bark();
            return about;
        }
    }
}
