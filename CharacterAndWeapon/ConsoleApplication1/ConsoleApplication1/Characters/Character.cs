using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Character : ICharacter, IDamagable
    {
        protected string name;
        protected IWeapon weapon;
        protected int hp;
        
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

        public IWeapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public Character()
        {
            this.hp = 10;
            this.Weapon = new Sword();
        }

        public string Attack(IDamagable otherCharacter)
        {
            otherCharacter.TakeDamage(this.weapon.Damage);
            string otherName = "something";
            if(otherCharacter is ICharacter)
            {
                otherName = ((ICharacter)otherCharacter).Name;
            }
            return string.Format("{0} {1} {2} at {3}", this.name, this.weapon.Verb, this.weapon.Name,
                otherName);
        }

        public int HP
        {
            get
            {
                return this.hp;
            }
            set
            {
                this.hp = value;
            }
        }

        public void TakeDamage(int damageAmount)
        {
            this.hp -= damageAmount;
        }
    }
}
