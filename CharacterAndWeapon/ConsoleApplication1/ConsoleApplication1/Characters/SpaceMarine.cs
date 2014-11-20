using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class SpaceMarine : Character
    {
        public SpaceMarine()
        {
            this.name = "Space Marine";
            this.weapon = new BFG();
        }
    }
}
