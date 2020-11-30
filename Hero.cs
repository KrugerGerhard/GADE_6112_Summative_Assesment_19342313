using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    class Hero : Character //class for hero character (player)
    {
        Movement Heromove;

            public Hero (int x, int y, int HP) : base(x, y ,'H')
        {
            
            this.Hp = HP;
            this.Maxhp = MAXHP;
            Damage = 2;
            base.purse = 0;
        }

        public override Movement returnMovement(Movement move) //hero movement
        {
            if (move == Movement.Up)
            {
                Heromove = Movement.Up;
            }

            else if (move == Movement.Down)
            {
                Heromove = Movement.Down;
            }

            else if (move == Movement.Right)
            {
                Heromove = Movement.Right;
            }

            else if (move == Movement.Left)
            {
                Heromove = Movement.Left;
            }

            else if (move == Movement.Nomovement)
            {
                Heromove = Movement.Nomovement;
            }

            return Heromove;
        }

        internal void itempickup(Item playeritem) //hero item pick up 
        {
            throw new NotImplementedException();
        }

        internal movement returnMovement(movement move)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Player Stats:\n HP: {HP}/{MAXHP}\n Damage: {Damage}\n [{X}, {Y}]";
        }
    }

    
}
