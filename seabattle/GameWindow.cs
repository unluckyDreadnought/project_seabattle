using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ships;

namespace seabattle
{
    public partial class GameWindow : Form
    {
        // ships
        Ship ships = new Ship();
        Battleship btlship1 = null;
        Dreadnought dreadno1 = null;
        //  Dreadnought dreadno2 = null;
        Cruiser cruiser1 = null;
        //  Cruiser cruiser2 = null;
        //  Cruiser cruiser3 = null;
        Battleboat boat1 = null;
        //  Battleboat boat2 = null;
        //  Battleboat boat3 = null;
        //  Battleboat boat4 = null;


        bool dragging = false;
        int xPos = 0, yPos = 0;
        Control captured = null;
        byte rotate = 1;

        // 0: row, 1: col
        int[] cellOverMouse = { 0, 0 };

        public GameWindow()
        {            
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            gamecontrols field = new gamecontrols();
            field.CreateBattleField(ref user_field);
            field.CreateBattleField(ref attack_field);

            int Y = 387;

            boat1 = new Battleboat(ships, 4);
            pictureBox1.Image = boat1.bmp;
            pictureBox1.Location = new Point(boat1.controlX, Y);
            boat_n.Text = boat1.possibleCount.ToString();

            cruiser1 = new Cruiser(ships, 3);
            pictureBox2.Image = cruiser1.rotate;
            pictureBox2.Location = new Point(cruiser1.controlX, Y);
            cruiser_n.Text = cruiser1.possibleCount.ToString();

            dreadno1 = new Dreadnought(ships, 2);
            pictureBox3.Image = dreadno1.rotate;
            pictureBox3.Location = new Point(dreadno1.controlX, Y);
            dreadno_n.Text = dreadno1.possibleCount.ToString();

            btlship1 = new Battleship(ships);
            pictureBox4.Image = btlship1.rotate;
            pictureBox4.Location = new Point(btlship1.controlX, Y);
            btlship_n.Text = btlship1.possibleCount.ToString();
        }

        // picture 1
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                captured = sender as Control;
                dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (boat1.possibleCount != 0)
            {
                Control ctrl = sender as Control;
                if (captured == null)
                {
                    captured = ctrl;
                }
                else if (captured == ctrl)
                {
                    if (dragging && ctrl != null)
                    {
                        ctrl.Location = new Point(ctrl.Left + e.X - xPos, ctrl.Top + e.Y - yPos);
                    }
                    ctrl.Visible = true;
                }
            }
        }

        // picture 2
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                captured = sender as Control;
                dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (cruiser1.possibleCount != 0)
            {
                Control ctrl = sender as Control;
                if (captured == null)
                {
                    captured = ctrl;
                }
                else if (captured == ctrl)
                {
                    if (dragging && ctrl != null)
                    {
                        ctrl.Location = new Point(ctrl.Left + e.X - xPos, ctrl.Top + e.Y - yPos);
                    }
                    ctrl.Visible = true;
                }
            }
        }

        // picture 3
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                captured = sender as Control;
                dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dreadno1.possibleCount != 0)
            {
                Control ctrl = sender as Control;
                if (captured == null)
                {
                    captured = ctrl;
                }
                else if (captured == ctrl)
                {
                    if (dragging && ctrl != null)
                    {
                        ctrl.Location = new Point(ctrl.Left + e.X - xPos, ctrl.Top + e.Y - yPos);
                    }
                    ctrl.Visible = true;
                }
            }
        }

        // picture 4
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                captured = sender as Control;
                dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (btlship1.possibleCount != 0)
            {
                Control ctrl = sender as Control;
                if (captured == null)
                {
                    captured = ctrl;
                }
                else if (captured == ctrl)
                {
                    if (dragging && ctrl != null)
                    {
                        ctrl.Location = new Point(ctrl.Left + e.X - xPos, ctrl.Top + e.Y - yPos);
                    }
                    ctrl.Visible = true;
                }
            }
        }


        private void user_field_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            cellOverMouse[0] = e.RowIndex;
            cellOverMouse[1] = e.ColumnIndex;
        }

        private void user_field_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dragging && captured != null)
            {
                Bitmap bmp = new Bitmap((captured as PictureBox).Image);
                actions act = new actions();

                if (act.CompareBitmaps(bmp, boat1.bmp))
                {
                    if (!act.IsShipsCrossed(ref user_field, e.ColumnIndex, e.RowIndex, boat1.health, rotate))
                    {
                        if (boat1.possibleCount != 0)
                        {
                            try
                            {
                                user_field.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = bmp;

                                ships.possibleCount = boat1.ReducePossibleCount();
                                boat_n.Text = boat1.possibleCount.ToString();
                            }
                            catch (ArgumentOutOfRangeException ex)
                            {
                                MessageBox.Show("Невозможно поместить корабль здесь ввиду нехватки места. Попробуйте ещё раз.",
                                    "Капитан, у нас проблемы!", MessageBoxButtons.OK);
                            }

                            captured.Location = new Point(boat1.controlX, 387);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно поместить корабль здесь ввиду пересечения с другими кораблями.\n" +
                            "Измените клетку размещения.", "Капитан, у нас проблемы", MessageBoxButtons.OK);
                    }
                }
                else if (act.CompareBitmaps(bmp, cruiser1.bmp) || act.CompareBitmaps(bmp, cruiser1.rotate))
                {
                    if (!act.IsShipsCrossed(ref user_field, e.ColumnIndex, e.RowIndex, cruiser1.health, rotate)) {
                        if (cruiser1.possibleCount != 0)
                        {
                            if (!act.PlaceShipBlock(ref user_field, e.ColumnIndex, e.RowIndex, cruiser1.health, rotate))
                            {
                                MessageBox.Show("Невозможно поместить корабль здесь ввиду нехватки места. Попробуйте ещё раз.",
                                    "Капитан, у нас проблемы!", MessageBoxButtons.OK);
                            }
                            else
                            {
                                ships.possibleCount = cruiser1.ReducePossibleCount();
                                cruiser_n.Text = cruiser1.possibleCount.ToString();
                            }
                            (captured as PictureBox).Image = cruiser1.rotate;
                            captured.Size = new Size(62, 32);
                            captured.Location = new Point(cruiser1.controlX, 387);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно поместить корабль здесь ввиду пересечения с другими кораблями.\n" +
                            "Измените клетку размещения.", "Капитан, у нас проблемы", MessageBoxButtons.OK);
                        (captured as PictureBox).Image = cruiser1.rotate;
                        captured.Size = new Size(62, 32);
                        captured.Location = new Point(cruiser1.controlX, 387);
                    }
                }
                else if (act.CompareBitmaps(bmp, dreadno1.bmp) || act.CompareBitmaps(bmp, dreadno1.rotate))
                {
                    if (!act.IsShipsCrossed(ref user_field, e.ColumnIndex, e.RowIndex, dreadno1.health, rotate))
                    {
                        if (dreadno1.possibleCount != 0)
                        {
                            if (!act.PlaceShipBlock(ref user_field, e.ColumnIndex, e.RowIndex, dreadno1.health, rotate))
                            {
                                MessageBox.Show("Невозможно поместить корабль здесь ввиду нехватки места. Попробуйте ещё раз.",
                                    "Капитан, у нас проблемы!", MessageBoxButtons.OK);
                            }
                            else
                            {
                                ships.possibleCount = dreadno1.ReducePossibleCount();
                                dreadno_n.Text = dreadno1.possibleCount.ToString();
                            }
                            (captured as PictureBox).Image = dreadno1.rotate;
                            captured.Size = new Size(92, 32);
                            captured.Location = new Point(dreadno1.controlX, 387);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно поместить корабль здесь ввиду пересечения с другими кораблями.\n" +
                            "Измените клетку размещения.", "Капитан, у нас проблемы", MessageBoxButtons.OK);
                        (captured as PictureBox).Image = dreadno1.rotate;
                        captured.Size = new Size(92, 32);
                        captured.Location = new Point(dreadno1.controlX, 387);
                    }
                }
                else if (act.CompareBitmaps(bmp, btlship1.bmp) || act.CompareBitmaps(bmp, btlship1.rotate))
                {
                    if (!act.IsShipsCrossed(ref user_field, e.ColumnIndex, e.RowIndex, btlship1.health, rotate))
                    {
                        if (btlship1.possibleCount != 0)
                        {
                            if (!act.PlaceShipBlock(ref user_field, e.ColumnIndex, e.RowIndex, btlship1.health, rotate))
                            {
                                MessageBox.Show("Невозможно поместить корабль здесь ввиду нехватки места. Попробуйте ещё раз.",
                                    "Капитан, у нас проблемы!", MessageBoxButtons.OK);
                            }
                            else
                            {
                                ships.possibleCount = btlship1.ReducePossibleCount();
                                btlship_n.Text = btlship1.possibleCount.ToString();
                            }
                            (captured as PictureBox).Image = btlship1.rotate;
                            captured.Size = new Size(122, 32);
                            captured.Location = new Point(btlship1.controlX, 387);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно поместить корабль здесь ввиду пересечения с другими кораблями.\n" +
                            "Измените клетку размещения.", "Капитан, у нас проблемы", MessageBoxButtons.OK);
                        (captured as PictureBox).Image = btlship1.rotate;
                        captured.Size = new Size(122, 32);
                        captured.Location = new Point(btlship1.controlX, 387);
                    }
                }
                
                ships.GetPossibleToSetCount();
                //user_field.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = bmp;
                rotate = 1;
                captured = null;
                dragging = false;
            }
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt && e.Modifiers == Keys.R && dragging && captured != null)
            {
                RotateShip(captured);
            }

            if (e.KeyCode == Keys.Escape && dragging && captured != null)
            {
                FreeTheCapturedObj();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RotateShip(captured);
        }

        //Dictionary<PictureBox, string> dict = new Dictionary<PictureBox, string>();

        //public void FillListImg()
        //{
        //    string path = ".\\..\\..\\images\\";
        //    dict.Add(pictureBox1, path + "battleboat.png");
        //    dict.Add(pictureBox2, path + "cruiser.png");
        //    dict.Add(pictureBox3, path + "dreadnought.png");
        //}

        public void FreeTheCapturedObj()
        {
            Bitmap bmp = new Bitmap((captured as PictureBox).Image);
            actions act = new actions();

            if (act.CompareBitmaps(bmp, boat1.bmp))
            {
                captured.Location = new Point(boat1.controlX, 387);
            }
            else if (act.CompareBitmaps(bmp, cruiser1.bmp) || act.CompareBitmaps(bmp, cruiser1.rotate))
            {
                captured.Location = new Point(cruiser1.controlX, 387);
                (captured as PictureBox).Image = cruiser1.rotate;
                captured.Size = new Size(62, 32);
            }
            else if (act.CompareBitmaps(bmp, dreadno1.bmp) || act.CompareBitmaps(bmp, dreadno1.rotate))
            {
                captured.Location = new Point(dreadno1.controlX, 387);
                (captured as PictureBox).Image = dreadno1.rotate;
                captured.Size = new Size(92, 32);
            }
            else if (act.CompareBitmaps(bmp, btlship1.bmp) || act.CompareBitmaps(bmp, btlship1.rotate))
            {
                captured.Location = new Point(btlship1.controlX, 387);
                (captured as PictureBox).Image = btlship1.rotate;
                captured.Size = new Size(122, 32);
            }

            captured = null;
            dragging = false;
        }

        public void RotateShip(Control picture)
        {
            if (picture != null && dragging != false)
            {
                Bitmap old = new Bitmap((picture as PictureBox).Image);
                actions act = new actions();

                if (act.CompareBitmaps(old, cruiser1.bmp))
                {
                    (picture as PictureBox).Image = cruiser1.rotate;
                    picture.Size = new Size(62, 32);
                    rotate = 1;
                }
                else if (act.CompareBitmaps(old, cruiser1.rotate))
                {
                    (picture as PictureBox).Image = cruiser1.bmp;
                    picture.Size = new Size(32, 62);
                    rotate = 0;
                }
                else if (act.CompareBitmaps(old, dreadno1.bmp))
                {
                    (picture as PictureBox).Image = dreadno1.rotate;
                    picture.Size = new Size(92, 32);
                    rotate = 1;
                }
                else if (act.CompareBitmaps(old, dreadno1.rotate))
                {
                    (picture as PictureBox).Image = dreadno1.bmp;
                    picture.Size = new Size(32, 92);
                    rotate = 0;
                }
                else if (act.CompareBitmaps(old, btlship1.bmp))
                {
                    (picture as PictureBox).Image = btlship1.rotate;
                    picture.Size = new Size(122, 32);
                    rotate = 1;
                }
                else if (act.CompareBitmaps(old, btlship1.rotate))
                {
                    (picture as PictureBox).Image = btlship1.bmp;
                    picture.Size = new Size(32, 122);
                    rotate = 0;
                }
            }
            else
            {
                MessageBox.Show("Выберете корабль для поворота", "Капитан, у нас проблемы", MessageBoxButtons.OK);
            }
        }
        
    }

    
}
