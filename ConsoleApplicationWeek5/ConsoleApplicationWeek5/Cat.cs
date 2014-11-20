using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWeek5
{
    public class Cat : Mammal
    {

        		// the dog's weight
        public string MeowSound;	// the sound of the dog's bark
 
	    public Cat()
	    {
		    MeowSound = "Woof!!!";
            this.age = 1;
	    }
 
	    public void Meow() { 
		    //put bark code here
	    }
	    
    }
}
