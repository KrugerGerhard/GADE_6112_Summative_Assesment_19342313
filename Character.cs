using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    abstract class Character : Tile //
    {

        public Character(int x, int y, char Symbol) : base(x, y, Symbol)
        {
            this.vision = new Tile[4];
        }

        protected int purse;
        protected char symbol;
        protected int HP;
        protected int MAXHP;
        protected int Damage;
        public enum Movement { Nomovement, Up, Down, Left, Right };
        protected Tile[] Vision;


        public int Hp 
        {
            get => HP;
            set => HP = value;

        }

        public int Maxhp 
        {
            get => MAXHP;
            set => MAXHP = value;

        }

        public int DAMAGE 
        {
            get => Damage;
            set => Damage = value;

        }

        public Tile[] vision
        {
            get => Vision;
            set => Vision = value;

        }

        public int Purse
        {
            get { return purse; }
            set { purse = value; }

        }

        public virtual void Attack(Character Target)
        {
            Target.HP -= this.Damage;
        }

        public bool IsDead()
        {
            if(HP <=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool CheckRange (Character Target)
        {
            if (DistanceTo(Target) <=1 && DistanceTo(Target) >= -1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        internal void PickUp(Weapon weapon)
        {
            throw new NotImplementedException();
        }

        private int DistanceTo(Character Target)
        {
            return Math.Abs(Target.X - this.X) + Math.Abs(Target.Y - this.Y);
        }


        public void Move(Movement move)
        {
            if (move == Movement.Up)
            {
                this.Y--;
            }

            if (move == Movement.Down)
            {
                this.Y++;
            }

            if (move == Movement.Right)
            {
                this.X++;
            }

            if (move == Movement.Left)
            {
                this.X--;
            }
        }
        public abstract Movement returnMove(Movement move = 0);

        public abstract override string ToString();
    }
   
}
