using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ships;
using shooting;

namespace seabattle
{
    public class Opponent
    {
        public Ship fleet = new Ship();
        private Battleboat boats = null;
        private Cruiser cruisers = null;
        private Dreadnought dreadnoughts = null;
        private Battleship battleship = null;

        private OpponentFleet fleetMap = new OpponentFleet();

        Random rndm = new Random();

        public Opponent()
        {
            boats = new Battleboat(fleet, 4);
            cruisers = new Cruiser(fleet, 3);
            dreadnoughts = new Dreadnought(fleet, 2);
            battleship = new Battleship(fleet, 1);
        }

        // 0;0         9;0
        // 0;9         9;9
        public void PlaceShips()
        {
            while (fleet.possibleCount != 0)
            {
                int shipType = rndm.Next(1, 5);
                int xStartPos = rndm.Next(0, 10);
                int yStartPos = rndm.Next(0, 10);
                while (fleetMap.IsHereShip(xStartPos, yStartPos) != -1)
                {
                    xStartPos = rndm.Next(0, 10);
                    yStartPos = rndm.Next(0, 10);
                }

                switch (shipType)
                {
                    case 1:
                        {

                            break;
                        }
                }
            }
        }

        public class OpponentFleet : Dictionary<int, ShipInfo>
        {
            public void Add(int key, byte type, int x, int y, byte rotation)
            {
                ShipInfo ship = new ShipInfo();
                ship.type = type;
                ship.health = type;
                ship.x = x;
                ship.y = y;
                ship.rotate = rotation;
            }

            // if there is ship block in this dot, it returns Dictionary key. Else return -1; not right
            // need to check with it on cross of areas
            public int IsHereShip(int xPos, int yPos)
            {
                int key = -1;
                foreach (KeyValuePair<int, ShipInfo> Entry in this)
                {
                    bool continued = true;
                    if (Entry.Value.rotate == 0)
                    {
                        for (int y = yPos - 1; continued && y < y + Entry.Value.health; y++)
                        {
                            
                            next_line0:
                            for (int x = xPos - 1; x < x + 1; x++)
                            {
                                if (Entry.Value.x != x) continue;
                                else
                                {
                                    
                                }
                            }
                        }
                    }
                    else
                    {

                    }

                    //
                    //
                    if (Entry.Value.x != xPos)
                    {
                        continue;
                    }
                    else
                    {
                        if (Entry.Value.y != yPos)
                        {
                            continue;
                        }
                        else
                        {
                            key = Entry.Key;
                            break;
                        }
                    }
                }
                return key;
            }

            public void DamageShip(int key, int x, int y /* , DataGridView fog_field, Ship instance */)
            {
                this[key].health -= 1;
                // fog_field.Rows[this[key].y].Cells[this[key].x].Value = instance.hitted;
            }

            public void ChangeNonDamageBlockPosition(int key, DataGridView fog_field, Ship instance)
            {
                if (this[key].rotate == 1)
                {
                    for (int col = this[key].x; col < col + this[key].health; col++)
                    {
                        if (fog_field.Rows[this[key].y].Cells[col].Value != instance.hitted)
                        {
                            this[key].x = col;
                            break;
                        }
                    }
                }
                else
                {
                    for (int row = this[key].y; row < row + this[key].health; row++)
                    {
                        if (fog_field.Rows[row].Cells[this[key].x].Value != instance.hitted)
                        {
                            this[key].y = row;
                            break;
                        }
                    }
                }

            }
        }
    }

    // types
    // 1 - boat, 2 - cruiser, 3 - dreadnought / destroyer, 4 - battleship 
    public class ShipInfo
    {
        public byte type = 0;
        public byte health = 0;
        public int x = 0;
        public int y = 0;
        public byte rotate = 0;
    }
}
