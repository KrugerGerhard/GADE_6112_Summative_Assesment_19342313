using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
  public abstract class Item : Tile //item class for tile
    {
        public Item(int x, int y, char Symbol) : base ( x, y, 'I') //spawn location
        {

        }

        public abstract string ToString();
    }
}
