using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationinhertiance
{
    public class Dog : Mammal
    {

        public string BarkSound;

        public Dog()
        {
            this.age = 1;
            this.BarkSound = "woof!";
            this.Sound = this.BarkSound;
            this.Name = "fido";
        }

        public virtual string Bark()
        {
            return this.BarkSound;
        }

        
    }
}
