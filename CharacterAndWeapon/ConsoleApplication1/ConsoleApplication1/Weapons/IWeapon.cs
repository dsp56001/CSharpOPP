using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IWeapon
    {
        int Damage
        {
            get;
            set;
        }

        string Verb
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        string Use(IDamagable character);
    }
}
