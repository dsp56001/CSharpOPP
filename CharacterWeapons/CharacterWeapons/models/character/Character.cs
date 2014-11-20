using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterWeapoms.models.character
{
    public abstract class Character : IDamagable
    {
        protected int hp;

        public int HP
        {
            get { return this.hp; }
            set {  this.hp = value; }
        }
        public string Name { get; set; }
        public string Class { get; set; }

        public Weapon MyWeapon { get; set; }

        public Character()
        {
            this.HP = 100;
            this.Name = "Brian";
            this.Class = "Human";
            this.MyWeapon = new Sword();
        }

        public string Attack(Character otherCharacter)
        {
            string attack = this.MyWeapon.Use(otherCharacter);
            attack += "\n" + otherCharacter.About();
            return attack;
        }

        public string About()
        {
            return string.Format("{0}\t{1}\nHP:{2}",
                this.Name, this.Class, this.HP);
        }

       

        public void TakeDamage(int amountOfDamageToTake)
        {
            this.hp -= amountOfDamageToTake;
        }
    }
}
