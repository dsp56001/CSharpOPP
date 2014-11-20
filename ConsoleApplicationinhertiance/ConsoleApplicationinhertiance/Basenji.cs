using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationinhertiance
{
    public class Basenji : Dog
    {
        public string HowlAndGrowlSound;

        public Basenji()
        {
            this.HowlAndGrowlSound = "basenjis' don't batk they howlm andgrowl";
            this.Sound = this.HowlAndGrowlSound;
        }

        public override string Bark()
        {
            return this.HowlAndGrowlSound;
        }
    }
}
