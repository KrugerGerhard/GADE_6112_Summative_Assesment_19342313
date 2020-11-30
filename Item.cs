using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
  public abstract class Item : Tile
    {
        public Item(int x, int y, char Symbol) : base ( x, y, 'I')
        {

        }

        public abstract string ToString();
    }
}
