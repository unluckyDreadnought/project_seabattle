using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    public class Dreadnought : Ship
    {
        public byte health = 3;
        public Bitmap bmp = new Bitmap(seabattle.Properties.Resources.dreadnought);
        public Bitmap rotate = new Bitmap(seabattle.Properties.Resources.dreadnought_rotate);
        public int controlX = 162;
        public byte possibleCount = 2;

        public Dreadnought(Ship instance, byte c = 1)
        {
            instance.AddShip(c);
        }
    }
}
