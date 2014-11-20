using CharacterWeapoms.models.character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterWeapoms
{
    public class SpaceMarine : Character
    {
        public SpaceMarine()
        {
            this.MyWeapon = new BFG();
            this.Class = "Space Marine";
        }
    }
}
