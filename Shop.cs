using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    class Shop
    {
        public Shop(Character _customer)
        {
            customer = _customer;
            rand = new Random();
            weapons = new Weapon[4];
            weapons[0] = RandomWeapon();
            weapons[1] = RandomWeapon();
            weapons[2] = RandomWeapon();
        }

        private Weapon[] weapons;
        private Character customer;
        private Random rand;


        public Weapon RandomWeapon()
        {
            int randWeapon = rand.Next(1, 5);
            Weapon weapon;
            switch (randWeapon)
            {
                case 1:
                    weapon = new MeleeWeapon(WeaponType.Dagger"D");
                    break;
                case 2:
                    weapon = new MeleeWeapon(WeaponType.LongSword"7");
                    break;
                case 3:
                    weapon = new RangedWeapon(WeaponType.Laser"L");
                    break;
                case 4:
                    weapon = new RangedWeapon(WeaponType.Sniper"S");
                    break;
            }
            return weapon;
        }

        public bool Buy(int num)
        {
            if (customer.Purse >= num)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Purchase(int num)
        {
            customer.Purse -= weapons[num.cost];
            customer.PickUp(weapons[num]);
            weapons[num] = RandomWeapon();
        }

    public string ShowWeapon(int num)
        {
            return ShowWeapon;
        }
    }
}
