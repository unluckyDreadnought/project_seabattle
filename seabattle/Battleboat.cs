using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    public class Battleboat : Ship
    {
        private Ship parent = null; 
        public byte health = 1;
        public Bitmap bmp = new Bitmap(seabattle.Properties.Resources.battleboat);
        public int controlX = 12;
        public byte possibleCount = 4;

        public Battleboat(Ship instance, byte c = 1)
        {
            parent = instance;
            instance.AddShip(c);
        }

        public override byte ReducePossibleCount(byte c = 1)
        {
            this.possibleCount -= c;
            parent.possibleCount -= c;
            return base.ReducePossibleCount(c);
        }
    }
}
