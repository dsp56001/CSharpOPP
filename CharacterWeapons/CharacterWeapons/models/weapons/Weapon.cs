using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterWeapoms
{
    public abstract class Weapon : IWeapon
    {

        protected int damage;
        protected string name;
        protected string verb;

        public Weapon()
        {
            this.damage = 0;
            this.verb = "use";
            this.name = "not a real weapon";
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

        public string Use(IDamagable target)
        {
            target.TakeDamage(this.damage);
            return string.Format("{0} that {1} take {2} damage",
                this.verb, this.name, this.damage);
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
    }
}
