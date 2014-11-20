using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationWeek5
{
    public class Mammal
    {
        public string Name;		// the dog's name
        protected int age;			// the dog's age
        public int Weight;
        public string Sound;
        public bool givesBirthToLiveYoung;
        public bool hasHair;

        public Mammal()
        {
            this.givesBirthToLiveYoung = true;
            this.hasHair = true;
        }

        public void Eat()
        {
            //put eat code here 
        }

        public void HappyBirthday()
        {
            this.age++;
        }

        public virtual string About()
        {
            return string.Format("Hello my name is {0} and I'm {1} i Sounds like {2}",
                this.Name, this.age, this.Sound);
        }
    }


}
