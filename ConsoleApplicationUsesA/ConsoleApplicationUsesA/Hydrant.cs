using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationUsesA
{
    class Hydrant
    {
        public string Color;
        public bool isClean;

        public Hydrant()
        {
            this.Color = "purple";
            this.isClean = true;
        }

        public override string ToString()
        {

            if (this.isClean == true)
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
