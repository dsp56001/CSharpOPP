using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class ShotGun : ProjectileWeapon
    {
        public ShotGun()
        {
            this.damage = 10;
            this.name = "Shot Gun";
        }
    }
}
