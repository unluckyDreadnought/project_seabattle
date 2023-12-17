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
        public bool PlaceShipBlock(ref DataGridView DGV, int x, int y, byte health, byte rotation = 0)
        {
            byte count = health;
            try
            {
                if (rotation == 0)
                {
                    for (int row = y; row < DGV.Columns.Count && count != 0; row++)
                    {
                        DGV.Rows[row].Cells[x].Value = ship.block;
                        count--;
                    }
                    if (count != 0)
                    {
                        for (int row = y; row < DGV.Columns.Count && count <= health; row++)
                        {
                            DGV.Rows[row].Cells[x].Value = null;
                            count++;
                        }
                        return false;
                    }
                }
                else
                {
                    for (int col = x; col < DGV.Rows.Count && count != 0; col++)
                    {
                        DGV.Rows[y].Cells[col].Value = ship.block;
                        count--;
                    }
                    if (count != 0)
                    {
                        for (int col = x; col < DGV.Rows.Count && count <= health; col++)
                        {
                            DGV.Rows[y].Cells[col].Value = ship.block;
                            count--;
                        }
                        return false;
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return false;
            }
            return true;
        }

        public bool IsShipsCrossed(ref DataGridView DGV, int x, int y, byte health, byte rotation)
        {
            bool continued = true;
            if (rotation == 0)
            {
                for (int v = y - 1; continued && v <= y + health; v++)
                {
                    next_line0:
                    for (int h = x - 1; h <= x + 1; h++)
                    {
                        next_cell0:
                        try
                        {
                            if (DGV.Rows[v].Cells[h].Value == null) continue;
                            else
                            {
                                continued = false;
                                break;
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            if (v < 0)
                            {
                                v++;
                                goto next_line0;
                            }
                            else if (h < 0)
                            {
                                h++;
                                goto next_cell0;
                            }
                        }
                    }
                }
            }
            else
            {
                for (int v = y - 1; v <= y + 1; v++)
                {
                    next_line1:
                    for (int h = x - 1; continued && h <= x + health; h++)
                    {
                    next_cell1:
                        try
                        {
                            if (DGV.Rows[v].Cells[h].Value == null) continue;
                            else
                            {
                                continued = false;
                                break;
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            if (v < 0)
                            {
                                v++;
                                goto next_line1;
                            }
                            else if (h < 0)
                            {
                                h++;
                                goto next_cell1;
                            }
                        }
                    }
                }
            }
            return !continued;
        }
    }
}
