using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface ICharacter
    {
        string Name
        {
            get;
            set;
        }

        IWeapon Weapon
        {
            get;
            set;
        }

        string Attack(IDamagable otherCharacter);
    }
}
