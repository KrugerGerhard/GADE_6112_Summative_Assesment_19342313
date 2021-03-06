using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{

    public enum TileType //enum for denoting types of tile
    {
        Hero,
        Enemy,
        Gold,
        Weapon,
    }

    public enum movement //enum for movement
    {
        Up,
        Down,
        Left,
        Right,
        NoMovement 
    }
    public enum WeaponType //enum for different weapon types
    {
        Sniper,
        Dagger,
        Laser,
        LongSword
    }

    class GameEngine //class for the game engine
    {
        private Map m = new Map(10, 20, 10, 20, 5); 
        public Map M
        {
            get { return m; }
            set { M = value; }
        }

        public bool PlayerMove(movement move) //boolean for player movement on map
        {
            if (m.Player.returnMove(move) == movement.NoMovement)
            {
                return false;
            }
            else
            {
                Item Playeritem = m.GetItemAtPosition(m.Player.X, M.Player.Y);
                if (Playeritem != null)
                {
                    m.Player.itempickup(Playeritem);
                }
                return true;
            }
        }
        public override string ToString()
        {
            string map = "";
            for (int i = 0; i <  m.Mapwidth; i++)
            {
                for (int j = 0; j < m.Mapheight; j++)
                {
                    map += m.map[i, j].SYMBOL + "";
                }
                map += "\n";
            }
            return map;
        }

        public void UpdateEnemies()
        {
            movement move; 
            m.UpdateVision();
            foreach (Enemy e in m.enemies)
            {
                m.UpdateVision();
                move = (movement)e.returnMove();
                if (e is Goblin)
                {
                    if (e.CheckRange(m.Player))
                    {
                        e.Attack(m.Player);
                    }
                }
             
                m.UpdateMap(); //update movement on map
            }
        }
            public void EnemyAttack() //enemy attack mechanic
            {
                m.UpdateMap();
                foreach (Enemy e in m.enemies)
                {
                if ( e is Goblin)
                {
                    if (e.CheckRange(m.Player))
                    {
                        e.Attack(m.Player);
                    }
                    for (int y = 0; y < m.enemies.Length; y++)
                    {
                        if (m.enemies[y].X != e.X && m.enemies[y].Y !=e.Y)
                        {
                            if (e.CheckRange(m.enemies[y]))
                            {
                                e.Attack(m.enemies[y]);
                            }
                        }
                    }
                }
                
            }
        }
    }
    
}
