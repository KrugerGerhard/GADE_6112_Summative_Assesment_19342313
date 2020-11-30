using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
    class Emptytile : Tile //class created to simulate an empty tile
    {
        public Emptytile(int x, int y) : base(x, y, ' ' )
        {

        }

    }
}
