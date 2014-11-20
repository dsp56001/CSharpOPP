using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationUsesA
{
    class Dog
    {
        public string Name;
        protected int age;
        public int Weight;
        public string BarkSound;

        public Person Owner;

        public Dog()
        {
            this.Name = "fido";
            this.age = 1;
            this.BarkSound = "woof!";
            this.Weight = 1;
            this.Owner = new Person();
        }

        public string About()
        {
            return string.Format("Hello my name is {0} I'm {1} years old and my bark sounds like {2}",
                this.Name, this.age, this.Bark()); 
        }

        public string Bark()
        {
            return this.BarkSound + " " + this.Owner.Name + " say be quiet";
        }

        public void Relieve(Object o)
        {
            if(o is Hydrant)
                ((Hydrant)o).isClean = false;
            
        }
    }
}
