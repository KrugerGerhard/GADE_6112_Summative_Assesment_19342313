using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    class Map
    {
        public int Mapwidth
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }

        public int Mapheight
        {
            get { return mapheight; }
            set { mapheight = value; }
        }

        public int Enemyamount
        {
            get { return enemyamount; }
            set { enemyamount = value; }
        }

        public Hero Player
        {
            get { return player; }
            set { player = value; }
        }

        public Map(int minmapwidth, int maxmapwidth, int minmapheight, int maxmapheight, int enemyamount)
        {
            this.Mapwidth = r.Next(minmapwidth, maxmapwidth);
            this.Mapheight = r.Next(minmapheight, maxmapheight);
            this.Enemyamount = enemyamount;

            map = new Tile[Mapwidth, Mapheight];
            enemies = new Enemy[Enemyamount];


            Tile playerHero = Create(TileType.Hero);
            map[player.X, player.Y] = playerHero;


            UpdateVision();
        }

        public void UpdateVision()
        {
            player.vision[0] = map[player.X - 1, player.Y];
            player.vision[1] = map[player.X, player.Y - 1];
            player.vision[2] = map[player.X + 1, player.Y];
            player.vision[3] = map[player.X, player.Y + 1];


            foreach (Enemy e in enemies)
            {
                e.vision[0] = map[e.X - 1, e.Y];
                e.vision[1] = map[e.X, e.Y - 1];
                e.vision[2] = map[e.X + 1, e.Y];
                e.vision[3] = map[e.X, e.Y + 1];

            }

        }

        public void InitializeMap()
        {
            for (int x = 0; x < mapwidth; x++)
            {
                for (int y = 0; y < mapheight; y++)
                {
                    map[x, y] = new Emptytile(x, y);
                }
            }
            SetObstacles();
        }

        public void UpdateMap()
        {
            InitializeMap();
            map[player.X, player.Y] = player;

            foreach (Enemy e in enemies)
            {
                if (e.IsDead() == false)
                {
                    map[e.X, e.Y] = e;
                }
                                     
            }
        }
        public void SetObstacles()
        {
            for (int x = 0; x < mapwidth; x++)
            {
                for (int y = 0; y < mapheight; y++)
                {
                    if (x == 0 || y == 0 || x == mapwidth - 1 || y == mapheight - 1)
                    {
                        map[x, y] = new Obstacle(x, y);
                    }
                }
            }
        }
        public void Fillmap() //fill map with tiles
        {
            for (int x = 0; x < mapwidth; x++)
            {
                for (int y = 0; y < mapheight; y++)
                {
                    map[x, y] = new Emptytile(x, y);
                }
            }
        }

        public Item GetItemAtPosition(int x, int y)

        {
            return GetItemAtPosition();
        }

        private Item GetItemAtPosition() //item, player, enemy generation
        {
            throw new NotImplementedException();
        }

        public Tile[,] map;
        private Hero player;
        public Enemy[] enemies;
        public Item[] item;

        private int mapwidth;
        private int mapheight;
        private int enemyamount;
        private Random r = new Random();

        //Method

        private Tile Create(TileType tiletype) 
        {
            int randomx = r.Next(0, Mapwidth);
            int randomy = r.Next(0, Mapheight);

            while (map[randomx, randomy] is Obstacle || map[randomx, randomy] is Character)
            {
                randomx = r.Next(0, Mapwidth);
                randomy = r.Next(0, Mapheight);
            }
            if (tiletype == TileType.Hero)
            {
                player = new Hero(randomx, randomy, 100);
                return player;
            }
            else if (tiletype == TileType.Enemy)
            {
                int rand = r.Next(1, 4);
                if (rand == 1)
                {
                    return new Goblin(randomx, randomy, 'G');
                }
                else if (rand == 2)
                {
                    return new Mage(randomx, randomy, 'M');
                }
                else
                {
                    return new Leader(randomx, randomy, player);
                }
            }

            else if (tiletype == TileType.Weapon)
            {
                int rand = r.Next(1, 5);
                if (rand == 1)
                {
                    return new MeleeWeapon(WeaponType.Dagger, "D", randomx, randomy);
                }

                else if (rand == 2)
                {
                    return new MeleeWeapon(WeaponType.LongSword, "7", randomx, randomy);
                }
                else if (rand == 3)
                {
                    return new RangedWeapon(WeaponType.Sniper, "S", randomx, randomy);
                }
                else if (rand == 4)
                {
                    return new RangedWeapon(WeaponType.Laser, "L", randomx, randomy);
                }
                else

                {
                    return new Gold(randomx, randomy);
                }






            }
        }
    }
}
