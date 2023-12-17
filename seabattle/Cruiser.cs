using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    public class Cruiser : Ship
    {
        public byte health = 2;
        public Bitmap bmp = new Bitmap(seabattle.Properties.Resources.cruiser);
        public Bitmap rotate = new Bitmap(seabattle.Properties.Resources.cruiser_rotate);
        public int controlX = 69;
        public byte possibleCount = 3;

        public Cruiser(Ship instance, byte c = 1)
        {
            instance.AddShip(c);
        }

        public override byte ReducePossibleCount(byte c = 1)
        {
            this.possibleCount -= c;
            return base.ReducePossibleCount(c);
        }
    }
}
