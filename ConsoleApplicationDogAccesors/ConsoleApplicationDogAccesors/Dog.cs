using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Dog
    {
        protected string name; //Private instance data member
        public int Age { get; set; }
        public int Weight { get; set; }

        public Dog()
        {
            this.name = "fido";
        }



        public string Name
        {
            get
            {
                //Do other stuff
                return this.name;
            }
            set
            {
                //take age ++
                this.name = value;
            }
        }

        

        public void About()
        {
            throw new System.NotImplementedException();
        }

        public int BarkSound
        {
            get;

            set;

        }

        public void Eat()
        {
            this.Weight++;
        }

        public void Poop()
        {
            this.Weight--;
        }

        
    }
}
