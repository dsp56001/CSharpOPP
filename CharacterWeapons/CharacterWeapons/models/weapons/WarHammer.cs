using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterWeapoms
{
    class WarHammer : HandToHandWeapon
    {
        public WarHammer()
        {
            this.name = "War Hammer";
            this.verb = "swing";
            this.damage = 12;
        }
    }
}
