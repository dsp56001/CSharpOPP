using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IDamagable
    {
        int HP
        {
            get;
            set;
        }

        void TakeDamage(int damageAmount);
    }
}
