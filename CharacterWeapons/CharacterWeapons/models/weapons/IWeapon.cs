using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterWeapoms
{
    interface IWeapon
    {
        string Name { get; set; }
        string Verb { get; set; }
        int Damage { get; set;  }
        string Use(IDamagable target);
    }
}
