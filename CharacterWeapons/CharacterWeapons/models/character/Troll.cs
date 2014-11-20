using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterWeapoms
{
    public class Troll : CharacterWeapoms.models.character.Character
    {
        public Troll()
        {
            this.Class = "Troll";
            this.MyWeapon = new WarHammer();
        }
    }
}
