using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWeek5
{
    
 
    //Dog simple class definition
    public class Dog : Mammal
    {
 	    // the dog's weight
	    public string BarkSound;	// the sound of the dog's bark
 
	    public Dog()
	    {
		    
            BarkSound = "Woof!!!";
            this.age = 1;
	    }
 
	    public virtual string Bark() {
            return this.Sound;
	    }

        public override string About()
        {
            return base.About() + string.Format("I bark Like {0}", this.Bark());
        }
	    
    }
}
