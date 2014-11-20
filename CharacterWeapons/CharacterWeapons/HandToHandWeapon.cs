using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterWeapoms
{
    public abstract class HandToHandWeapon : Weapon
    {
        public HandToHandWeapon()
        {
            this.verb = "swing";
        }
    }
}
