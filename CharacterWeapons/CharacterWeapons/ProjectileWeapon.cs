using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterWeapoms
{
    public abstract class ProjectileWeapon : Weapon
    {
        public ProjectileWeapon()
        {
            this.verb = "shoot";
        }
    }
}
