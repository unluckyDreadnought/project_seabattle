using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ships
{
    public class Ship
    {
        private byte count = 0;
        public Bitmap block = new Bitmap(seabattle.Properties.Resources.battleboat);
        public byte possibleCount = 10;

        public void AddShip(byte c = 1)
        {
            count += c;
        }

        virtual public byte ReducePossibleCount(byte c = 1)
        {
            this.possibleCount -= c;
            return this.possibleCount;
        }

        public byte GetAllShipsCount()
        {
            return count;
        }
    }
}
