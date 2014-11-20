using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterWeapoms
{
    public interface IDamagable
    {
        int HP
        {
            get;
            set;
        }

        void TakeDamage(int amountOfDamageToTake);
    }
}
