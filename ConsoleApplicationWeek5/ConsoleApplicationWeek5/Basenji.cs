using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationWeek5
{
    public class Basenji : Dog
    {
        public override string Bark()
        {
            return "Basenji's don't bark the howl and growl";
        }

        public override string About()
        {
            return base.About().Replace("Bark", "Howl and Growl") ;
        }
    }
}
