using CharacterWeapoms.models.character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterWeapoms
{
    public class Knight : Character
    {
        public Knight()
        {
            this.Class = "Knight";
            this.MyWeapon = new Sword();
        }
    }
}
