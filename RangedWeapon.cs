using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    class RangedWeapon : Weapon
    {

        public RangedWeapon(WeaponType type, string v, int x, int y) : base(x, y)
        {

            if (type == WeaponType.Sniper)
            {
                base.Damage = 4;
                base.range = 2;
                base.Durability = 4;
                base.Cost = 6;
            }

            if (type == WeaponType.Laser)
            {
                base.Damage = 5;
                base.range = 3;
                base.Durability = 3;
                base.Cost = 7;
            }
        }

        public RangedWeapon(WeaponType laser, string v)
        {
            this.laser = laser;
            this.v = v;
        }

        public WeaponType weaponType;
        private WeaponType laser;
        private string v;

        public override string ToString()
        {
            return "Ranged weapon at " + X + Y + "Deals: " + Damage;
        }

    }

        
    }
