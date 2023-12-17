using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ships
{
    public class Battleship : Ship
    {
        public byte health = 4;
        public Bitmap bmp = new Bitmap(seabattle.Properties.Resources.battleship);
        public Bitmap rotate = new Bitmap(seabattle.Properties.Resources.battleship_rotate);
        public int controlX = 286;
        public byte possibleCount = 1;

        public Battleship(Ship instance, byte c = 1)
        {
            instance.AddShip(c);
        }

        public override byte ReducePossibleCount(byte c = 1)
        {
            this.possibleCount -= c;
            base.ReducePossibleCount(c);
            return base.ReducePossibleCount(c);
        }
    }
}
