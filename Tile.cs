using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    abstract class Tile //class for tiles
    {
        public int X //integer for x axis
        {
            get { return X; }
            set { X = value; }
        }

        public int Y //integer for y axis
        {
            get { return Y; }
            set { Y = value; }
        }

        public int SYMBOL //symbols denoting player, enemy, obastacle etc
        {
            get { return SYMBOL; }
        }

        public enum TileType //enum for different tile types
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
        }



        protected Tile(int x, int y, char Symbol)
        {
            Y = y;
            X = x;

        }

        public TileType tiletype
        {
            get { return tiletype; }
            set { tiletype = value; }
        }








    }



}
