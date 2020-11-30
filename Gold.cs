using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike_Game
{
     public class Gold : Item
    {
        private Random rand = new Random();

        private int GoldQuantity;
        private int randomx;
        private int randomy;

        public Gold(int randomx, int randomy)
        {
            this.randomx = randomx;
            this.randomy = randomy;
        }

        public Gold(int x, int y, char Symbol) : base (x, y, 'I')
        {
            GoldQuantity = rand.Next(1, 5);
        }

        public int goldquantity 
        {
            get { return GoldQuantity;  }
            set { goldquantity = value;  }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
