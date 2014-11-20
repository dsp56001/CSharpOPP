using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationStaticDob
{
    public class Dog
    {
        private static int dogCount;
        
        protected int age;
        public string BarkSound;
        private string Name;
        protected int barkCount;
        public Person Owner;
    
        public Dog()
        {
            this.Owner = new Person();

            this.BarkSound = "Woof!";
            Dog.dogCount++;
        }

        public void ChangeOwner(Person p)
        {
            this.Owner = p;
        }
    
        public string About()
        {
            return string.Format("Hello my name is {0} and my Bark Sounds like {1} I have barked {2} times. My owners name is {3}",
                this.Name, this.Bark(), this.barkCount, this.Owner.Name);
        }

        public string Bark()
        {
            this.barkCount++;
            return this.BarkSound;
        }

        public void Relieve(Hydrant h)
        {
            h.Clean = false;
        }

        public void Die()
        {
            this.BarkSound = string.Empty;
            Dog.dogCount--;
        }

        public static int GetDogCount()
        {
            return Dog.dogCount;
        }
    }
}
