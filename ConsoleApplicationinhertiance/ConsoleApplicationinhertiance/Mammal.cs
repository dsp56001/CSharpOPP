using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationinhertiance
{
    public class Mammal
    {
        public string Name;
        protected int age;
        public string Sound;

        public Mammal()
        {
            this.Name = "a mammal";
            this.age = 1;
            this.Sound = "noisey!!";
        }

        public virtual string Sing()
        {
            return this.Sound;
        }

        public virtual string About()
        {
            return string.Format("Hello My name is {0} I'm {1} years old and my song sounds like {2}",
                this.Name, this.age, this.Sing());
        }
    }
}
