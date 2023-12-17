
namespace seabattle
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.user_field = new System.Windows.Forms.DataGridView();
            this.c0 = new System.Windows.Forms.DataGridViewImageColumn();
            this.c1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.c2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.c3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.c4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.c5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.c6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.c7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.c8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.c9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.list = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.boat_n = new System.Windows.Forms.Label();
            this.cruiser_n = new System.Windows.Forms.Label();
            this.dreadno_n = new System.Windows.Forms.Label();
            this.btlship_n = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.user_field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ships";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_field
            // 
            this.user_field.AllowDrop = true;
            this.user_field.AllowUserToAddRows = false;
            this.user_field.AllowUserToDeleteRows = false;
            this.user_field.AllowUserToResizeRows = false;
            this.user_field.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_field.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.user_field.ColumnHeadersHeight = 30;
            this.user_field.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.user_field.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c0,
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6,
            this.c7,
            this.c8,
            this.c9});
            this.user_field.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.user_field.Location = new System.Drawing.Point(461, 2);
            this.user_field.MultiSelect = false;
            this.user_field.Name = "user_field";
            this.user_field.ReadOnly = true;
            this.user_field.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.user_field.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.user_field.RowHeadersWidth = 30;
            this.user_field.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_field.ShowCellErrors = false;
            this.user_field.ShowCellToolTips = false;
            this.user_field.ShowEditingIcon = false;
            this.user_field.ShowRowErrors = false;
            this.user_field.Size = new System.Drawing.Size(350, 350);
            this.user_field.TabIndex = 0;
            this.user_field.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.user_field_CellMouseClick);
            this.user_field.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_field_CellMouseEnter);
            // 
            // c0
            // 
            this.c0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c0.Frozen = true;
            this.c0.HeaderText = "1";
            this.c0.MinimumWidth = 8;
            this.c0.Name = "c0";
            this.c0.ReadOnly = true;
            this.c0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c0.Width = 30;
            // 
            // c1
            // 
            this.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c1.Frozen = true;
            this.c1.HeaderText = "2";
            this.c1.MinimumWidth = 8;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c1.Width = 30;
            // 
            // c2
            // 
            this.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c2.Frozen = true;
            this.c2.HeaderText = "3";
            this.c2.MinimumWidth = 8;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c2.Width = 30;
            // 
            // c3
            // 
            this.c3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c3.Frozen = true;
            this.c3.HeaderText = "4";
            this.c3.MinimumWidth = 8;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c3.Width = 30;
            // 
            // c4
            // 
            this.c4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c4.Frozen = true;
            this.c4.HeaderText = "5";
            this.c4.MinimumWidth = 8;
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            this.c4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c4.Width = 30;
            // 
            // c5
            // 
            this.c5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c5.Frozen = true;
            this.c5.HeaderText = "6";
            this.c5.MinimumWidth = 8;
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            this.c5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c5.Width = 30;
            // 
            // c6
            // 
            this.c6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c6.Frozen = true;
            this.c6.HeaderText = "7";
            this.c6.MinimumWidth = 8;
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            this.c6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c6.Width = 30;
            // 
            // c7
            // 
            this.c7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c7.Frozen = true;
            this.c7.HeaderText = "8";
            this.c7.MinimumWidth = 8;
            this.c7.Name = "c7";
            this.c7.ReadOnly = true;
            this.c7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c7.Width = 30;
            // 
            // c8
            // 
            this.c8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c8.Frozen = true;
            this.c8.HeaderText = "9";
            this.c8.MinimumWidth = 8;
            this.c8.Name = "c8";
            this.c8.ReadOnly = true;
            this.c8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c8.Width = 30;
            // 
            // c9
            // 
            this.c9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.c9.Frozen = true;
            this.c9.HeaderText = "10";
            this.c9.MinimumWidth = 8;
            this.c9.Name = "c9";
            this.c9.ReadOnly = true;
            this.c9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.c9.Width = 30;
            // 
            // list
            // 
            this.list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("list.ImageStream")));
            this.list.TransparentColor = System.Drawing.Color.Transparent;
            this.list.Images.SetKeyName(0, "battleboat.png");
            this.list.Images.SetKeyName(1, "cruiser.png");
            this.list.Images.SetKeyName(2, "dreadnought.png");
            this.list.Images.SetKeyName(3, "battleship.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(69, 387);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 32);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(286, 387);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(122, 32);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(12, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(162, 387);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 32);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // button1
            // 
            this.button1.Image = global::seabattle.Properties.Resources.rotate;
            this.button1.Location = new System.Drawing.Point(398, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boat_n
            // 
            this.boat_n.AutoSize = true;
            this.boat_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boat_n.Location = new System.Drawing.Point(27, 422);
            this.boat_n.Name = "boat_n";
            this.boat_n.Size = new System.Drawing.Size(29, 16);
            this.boat_n.TabIndex = 11;
            this.boat_n.Text = "<n>";
            // 
            // cruiser_n
            // 
            this.cruiser_n.AutoSize = true;
            this.cruiser_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cruiser_n.Location = new System.Drawing.Point(118, 422);
            this.cruiser_n.Name = "cruiser_n";
            this.cruiser_n.Size = new System.Drawing.Size(29, 16);
            this.cruiser_n.TabIndex = 12;
            this.cruiser_n.Text = "<n>";
            // 
            // dreadno_n
            // 
            this.dreadno_n.AutoSize = true;
            this.dreadno_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dreadno_n.Location = new System.Drawing.Point(238, 422);
            this.dreadno_n.Name = "dreadno_n";
            this.dreadno_n.Size = new System.Drawing.Size(29, 16);
            this.dreadno_n.TabIndex = 13;
            this.dreadno_n.Text = "<n>";
            // 
            // btlship_n
            // 
            this.btlship_n.AutoSize = true;
            this.btlship_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btlship_n.Location = new System.Drawing.Point(395, 422);
            this.btlship_n.Name = "btlship_n";
            this.btlship_n.Size = new System.Drawing.Size(29, 16);
            this.btlship_n.TabIndex = 14;
            this.btlship_n.Text = "<n>";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.btlship_n);
            this.Controls.Add(this.dreadno_n);
            this.Controls.Add(this.cruiser_n);
            this.Controls.Add(this.boat_n);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_field);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.KeyPreview = true;
            this.Name = "GameWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.user_field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView user_field;
        private System.Windows.Forms.ImageList list;
        private System.Windows.Forms.DataGridViewImageColumn c0;
        private System.Windows.Forms.DataGridViewImageColumn c1;
        private System.Windows.Forms.DataGridViewImageColumn c2;
        private System.Windows.Forms.DataGridViewImageColumn c3;
        private System.Windows.Forms.DataGridViewImageColumn c4;
        private System.Windows.Forms.DataGridViewImageColumn c5;
        private System.Windows.Forms.DataGridViewImageColumn c6;
        private System.Windows.Forms.DataGridViewImageColumn c7;
        private System.Windows.Forms.DataGridViewImageColumn c8;
        private System.Windows.Forms.DataGridViewImageColumn c9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label boat_n;
        private System.Windows.Forms.Label cruiser_n;
        private System.Windows.Forms.Label dreadno_n;
        private System.Windows.Forms.Label btlship_n;
    }
}

