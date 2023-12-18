using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace shooting
{
    public class Shoot
    {
        public Bitmap miss = seabattle.Properties.Resources.shoot;

        public void Fire(ref DataGridView DGV, int x, int y, ref ShootDict dictionary, int res = 0)
        {
            DGV.Rows[y].Cells[x].Value = miss;
            dictionary.Add(dictionary.Count, x, y, res);
        }
    }

    //  result:
    //    0: hit
    //    1: miss
    public struct UserShoots
    {
        public int x;
        public int y;
        public int result;
    }

    public class ShootDict : Dictionary<int, UserShoots>
    {
        public void Add(int key, int xPos, int yPos, int result)
        {
            UserShoots userShoots;
            userShoots.x = xPos;
            userShoots.y = yPos;
            userShoots.result = result;
            this.Add(key, userShoots);
        }

        public bool IsDone(int xPos, int yPos)
        {
            bool result = false;
            foreach (KeyValuePair<int, UserShoots> Entry in this)
            {
                if (Entry.Value.x != xPos)
                {
                    result = false;
                    continue;
                }
                else
                {
                    if (Entry.Value.y != yPos)
                    {
                        result = false;
                        continue;
                    }
                    else
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
