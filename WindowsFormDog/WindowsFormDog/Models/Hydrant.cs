using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationStaticDob
{
    public class Hydrant 
    {
        public string Color; //the color of the hydrant
        public bool Clean;   //if the hydrant is clean or dirty

        public Hydrant()
        {
            Color = "red";
            Clean = true;
        }

        public override string ToString()
        {
            if (this.Clean == true)
            {
                return ("The " + this.Color + " hydrant is clean.");
            }
            else
            {
                return ("The " + this.Color + " hydrant is not clean.");
            }
        }
    }
}
