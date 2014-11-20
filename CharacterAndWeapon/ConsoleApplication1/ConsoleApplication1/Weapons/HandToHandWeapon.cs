using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class HandToHandWeapon : Weapon
    {

        public HandToHandWeapon()
        {
            this.verb = "swing";
        }
    }
}
