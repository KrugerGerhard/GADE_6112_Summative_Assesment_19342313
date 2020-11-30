using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    class MeleeWeapon : Weapon
    {
        public MeleeWeapon(WeaponType type, string v, int x, int y) : base (x, y)
        {
            if (type == WeaponType.Dagger)
            {
                base.Damage = 4;
                base.Durability = 10;
                base.Cost = 3;
            }

            if (type == WeaponType.LongSword)
            {
                base.Damage = 4;
                base.Durability = 6;
                base.Cost = 5;
            }
        }

        public MeleeWeapon(WeaponType dagger,string v)
        {
            this.dagger = dagger;
            this.v = v;
        }

        public WeaponType weaponType;
        private WeaponType dagger;
        private string v;

        public override string ToString()
        {
            return "Melee weapon at " + X + Y + "Deals: " + Damage;
        }
    }
}
