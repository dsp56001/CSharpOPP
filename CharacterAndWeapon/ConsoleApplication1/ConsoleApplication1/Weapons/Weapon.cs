using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Weapon : IWeapon
    {
        protected int damage;
        protected string verb;
        protected string name;
        
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }

        public string Verb
        {
            get
            {
                return this.verb;
            }
            set
            {
                this.verb = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Weapon()
        {

            this.name = "hands";
            this.damage = 0;
            this.verb = "punch";
        }

        public string Use(IDamagable character)
        {
            character.TakeDamage(this.damage);
            return string.Format("{0} damages {1} by {2}", this.name, character, this.damage);
        }
    }
}
