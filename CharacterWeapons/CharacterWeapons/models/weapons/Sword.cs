using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterWeapoms
{
    class Sword : HandToHandWeapon
    {
        public Sword()
        {
            this.name = "sword";
            this.verb = "swing";
            this.damage = 7;
        }
    }
}
