using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    
    abstract class Enemy : Character //class for enemy characters (goblins)
    {
        
       protected Random generator = new Random(); //random generation of enemies 

        public Enemy(int x, int y, int HP, int Damage, char Symbol) : base(x, y,'E')
        {
            this.Hp = HP; //enemy hp value
            this.DAMAGE = Damage; //enemy damage value 
            
        }

        public override string ToString()
        {
            return "(this.GetType().Name at [{x}, {y}] ({Damage} )";
        }
    }
}
