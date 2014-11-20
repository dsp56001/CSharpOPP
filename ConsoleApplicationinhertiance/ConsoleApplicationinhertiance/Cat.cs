using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationinhertiance
{
    public class Cat : Mammal
    {
        public string MeowSound;

        public Cat()
        {
            this.Name = "punkin";
            this.age = 1;
            this.MeowSound = "meow!!";

        }

        public override string Sing()
        {
            return this.Meow();
        }

        public override string About()
        {
            return base.About();
        }
        public string Meow()
        {
            return this.MeowSound;
        }
    }
}
