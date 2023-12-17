using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using ships;

namespace seabattle
{
    public class actions
    {
        Ship ship = new Ship();

        public bool CompareBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            if ((bmp1 == null) != (bmp2 == null)) return false;

            if (bmp1.Width != bmp2.Width) return false;

            if (bmp1.Height != bmp2.Height) return false;

            bool equals = true;
            for (int y = 0; equals && y < bmp1.Height; y++)
            {
                for (int x = 0; x < bmp1.Width; x++)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x,y))
                    {
                        equals = false;
                        break;
                    }
                }
            }
            return equals;
        }

        // rotation: 0 - top-to-bottom, 1 - left-to-right
        public bool PlaceShipBlock(ref DataGridView DGV, int y, int x, byte health, byte rotation = 0)
        {
            byte count = health;
            if (rotation == 0)
            {
                for (int row = x; row < DGV.Columns.Count && count != 0; row++)
                {
                    DGV.Rows[row].Cells[y].Value = ship.block;
                    count--;
                }
                if (count != 0)
                {
                    for (int row = x; row < DGV.Columns.Count && count <= health; row++)
                    {
                        DGV.Rows[row].Cells[y].Value = null;
                        count++;
                    }
                    return false;
                }
            }
            else
            {
                for (int col = y; col < DGV.Rows.Count && count != 0; col++)
                {
                    DGV.Rows[x].Cells[col].Value = ship.block;
                    count--;
                }
                if (count != 0)
                {
                    for (int col = y; col < DGV.Rows.Count && count <= health; col++)
                    {
                        DGV.Rows[x].Cells[col].Value = ship.block;
                        count--;
                    }
                    return false;
                }
            }
            return true;
        }

    }
}
