using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationUsesA
{
    public class Cat
    {

        protected Toy CurrentToy;

        public Cat()
        {
            //NO Init in TOY
            this.CurrentToy = new Toy() { Name = "no toy" };
        }

        public string Play()
        {
           
            
                return string.Format("cat plays with {0}", this.CurrentToy.Name);
            
        }

        public void GiveToy(Toy spralklyball)
        {
            throw new NotImplementedException();
        }
    }
}
