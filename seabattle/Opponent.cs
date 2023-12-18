using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seabattle;
using ships;
using shooting;

namespace bot
{
    public class Opponent
    {
        public Ship fleet = new Ship();
        private Battleboat boats = null;
        private Cruiser cruisers = null;
        private Dreadnought dreadnoughts = null;
        private Battleship battleship = null;

        public OpponentFleet fleetMap = new OpponentFleet();

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
        async public Task PlaceShips()
        {
            while (fleet.possibleCount != 0)
            {
                new_ship:
                byte shipType = (byte)rndm.Next(1, 5);
                byte itHp = 0;

                switch (shipType)
                {
                    case 1:
                        {
                            if (boats.possibleCount != 0)
                            {
                                itHp = boats.health;
                                boats.ReducePossibleCount();
                                break;
                            }
                            else goto new_ship;
                        }
                    case 2:
                        {
                            if (cruisers.possibleCount != 0)
                            {
                                itHp = cruisers.health;
                                cruisers.ReducePossibleCount();
                                break;
                            }
                            else goto new_ship;
                        }
                    case 3:
                        {
                            if (dreadnoughts.possibleCount != 0)
                            {
                                itHp = dreadnoughts.health;
                                dreadnoughts.ReducePossibleCount();
                                break;
                            }
                            else goto new_ship;
                        }
                    case 4:
                        {
                            if (battleship.possibleCount != 0)
                            {
                                itHp = battleship.health;
                                battleship.ReducePossibleCount();
                                break;
                            }
                            else goto new_ship;
                        }
                }

                int xStartPos = rndm.Next(0, 10);
                int yStartPos = rndm.Next(0, 10);
                byte rotate = (byte)rndm.Next(0, 2);
                
                while (!(await Task.Run(() => fleetMap.CanPlaceShipHere(xStartPos, yStartPos, itHp, rotate))))
                {
                    xStartPos = rndm.Next(0, 10);
                    yStartPos = rndm.Next(0, 10);
                }

                await Task.Run(() => fleetMap.Add(fleetMap.Count() + 1, shipType, xStartPos, yStartPos, rotate));
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
                this.Add(key, ship);
            }

            // if there is ship block in this dot, it returns Dictionary key. Else return -1; not right
            // need to check with it on cross of areas
            public bool CanPlaceShipHere(int xPos, int yPos, byte this_health, byte rotate)
            {

                // new version: it did not get any better
                // - - - - - - - - - - - - - - - - - - - - 
                //var ships_in_paste_area = from entries in this
                //                          where entries.Key == - 10
                //                          select entries; 

                //if (rotate == 1)
                //{
                //    ships_in_paste_area = from entries in this
                //                          where
                //                          (
                //                            entries.Value.y >= yPos - 1 &&
                //                            (entries.Value.x >= xPos - 1 && entries.Value.x <= xPos + this_health)
                //                          )
                //                          ||
                //                          (
                //                            entries.Value.y == yPos &&
                //                            (entries.Value.x >= xPos - 1 && entries.Value.x <= xPos + this_health)
                //                          )
                //                          ||
                //                          (
                //                            entries.Value.y == yPos + 1 &&
                //                            (entries.Value.x >= xPos - 1 && entries.Value.x <= xPos + this_health)
                //                          )
                //                          select entries;
                //}
                //else
                //{
                //    ships_in_paste_area = from entries in this
                //                          where
                //                          (
                //                            entries.Value.x >= xPos - 1 &&
                //                            (entries.Value.x >= yPos - 1 && entries.Value.x <= yPos + this_health)
                //                          )
                //                          ||
                //                          (
                //                            entries.Value.y == xPos &&
                //                            (entries.Value.x >= yPos - 1 && entries.Value.x <= yPos + this_health)
                //                          )
                //                          ||
                //                          (
                //                            entries.Value.y == xPos + 1 &&
                //                            (entries.Value.x >= yPos - 1 && entries.Value.x <= yPos + this_health)
                //                          )
                //                          select entries;
                //}
                // - - - - - - - - - - - - - - - - - - - - 


                var ships_in_paste_area = from entries in this
                                          where

                                          //(
                                          ////1
                                          //  (entries.Value.y >= (yPos - 1) && entries.Value.y <= (yPos + 1) &&
                                          //  entries.Value.y >= yPos + 1 && entries.Value.y >= yPos + this_health) &&
                                          //  (entries.Value.x + entries.Value.health - 1 >= (xPos - 1) &&
                                          //  entries.Value.x + entries.Value.health - 1 <= (xPos + this_health))
                                          //)
                                          //||
                                          //(
                                          ////0
                                          //  (entries.Value.y + entries.Value.health - 1 >= (yPos - 1) &&
                                          //  entries.Value.y + entries.Value.health - 1 <= (yPos + this_health)) &&
                                          //  (entries.Value.x >= (xPos - 1) && entries.Value.x <= (xPos + 1))
                                          //)
                                          //||


                                          (
                                            entries.Value.y == yPos + this_health - 1 || entries.Value.y == yPos + this_health &&
                                            (entries.Value.x == xPos - 1 || entries.Value.x == xPos || entries.Value.x == xPos + 1)
                                          )
                                          ||
                                          //
                                          (
                                            (entries.Value.y >= yPos && entries.Value.y + entries.Value.health - 1 <= yPos + this_health) &&
                                            (entries.Value.x == yPos - 1 || entries.Value.x == xPos || entries.Value.x == xPos + 1)
                                          )
                                          ||
                                          //
                                          (
                                            (entries.Value.x >= xPos && entries.Value.x + entries.Value.health - 1 <= xPos + this_health) &&
                                            (entries.Value.y == yPos - 1 || entries.Value.y == yPos || entries.Value.y == yPos + 1)
                                          )
                                          ||
                                          //
                                          (
                                            (entries.Value.x >= xPos - 1 && entries.Value.x <= xPos + this_health) &&
                                            (entries.Value.y == yPos - 1 || entries.Value.y == yPos || entries.Value.y == yPos + 1)
                                          )
                                          //
                                          ||
                                          (
                                            entries.Value.y == yPos &&
                                            (entries.Value.x == xPos - 1 || entries.Value.x == xPos || entries.Value.x == xPos + 1)
                                          )
                                          ||
                                          (
                                            entries.Value.y == yPos - 1 &&
                                            (entries.Value.x == xPos - 1 || entries.Value.x == xPos || entries.Value.x == xPos + 1)
                                          )
                                          ||
                                          (
                                            entries.Value.y == yPos + this_health &&
                                            (entries.Value.x == xPos - 1 || entries.Value.x == xPos || entries.Value.x == xPos + 1)
                                          )
                                          ||
                                          (
                                            entries.Value.x == xPos - 1 &&
                                            (entries.Value.y == yPos - 1 || entries.Value.y == yPos || entries.Value.y == yPos + 1)
                                          )
                                          ||
                                          (
                                            entries.Value.x == xPos &&
                                            (entries.Value.y == yPos - 1 || entries.Value.y == yPos || entries.Value.y == yPos + 1)
                                          )
                                          ||
                                          (
                                            entries.Value.x == xPos + this_health &&
                                            (entries.Value.y == yPos - 1 || entries.Value.y == yPos || entries.Value.y == yPos + 1)
                                          )
                                          select entries;

                if (ships_in_paste_area.Count() == 0 && DoesShipFitIntoBounds(xPos, yPos, this_health, rotate))
                {
                    return true;
                }
                return false;


                //foreach (KeyValuePair<int, ShipInfo> Entry in this)
                //{
                //    bool continued = true;
                //    if (Entry.Value.rotate == 0)
                //    {
                //        for (int y = yPos - 1; continued && y < y + Entry.Value.health; y++)
                //        {
                            
                //            next_line0:
                //            for (int x = xPos - 1; x < x + 1; x++)
                //            {
                //                if (Entry.Value.x != x) continue;
                //                else
                //                {
                                    
                //                }
                //            }
                //        }
                //    }
                //    else
                //    {

                //    }

                //    //
                //    //
                //    if (Entry.Value.x != xPos)
                //    {
                //        continue;
                //    }
                //    else
                //    {
                //        if (Entry.Value.y != yPos)
                //        {
                //            continue;
                //        }
                //        else
                //        {
                //            key = Entry.Key;
                //            break;
                //        }
                //    }
                //}
                //return key;
            }

            public bool DoesShipFitIntoBounds(int xPos, int yPos, byte this_health, byte rotate)
            {
                if (rotate == 1) {
                    if ((xPos >= 0 && xPos <= 9) && (xPos + this_health - 1) >= 0 && (xPos + this_health - 1) <= 9)
                    {
                        if (yPos >= 0 && yPos <= 9) return true;
                    }
                }
                else // rotate -> 0
                {
                    if ((yPos >= 0 && yPos <= 9) && (yPos + this_health - 1) >= 0 && (yPos + this_health - 1) <= 9)
                    {
                        if (xPos >= 0 && xPos <= 9) return true;
                    }
                }
                return false;
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
