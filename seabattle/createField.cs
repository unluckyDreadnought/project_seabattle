using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seabattle
{
    public class gamecontrols
    {
        
        
        public void CreateBattleField(ref DataGridView field)
        {
            string ABC = "АБВГДЕЖЗИК";
            field.ColumnCount = 10;
            field.RowCount = 10;
            
            for (byte cntr = 0; cntr < 10; cntr++)
            {
                field.Columns[cntr].Width = 32;
                field.Rows[cntr].Height = 32;
            }

            //  this.dataGridViewImageColumn1.DefaultCellStyle.NullValue = null;
            for (byte cntr = 0; cntr < field.Columns.Count; cntr++)
            {
                field.Columns[cntr].DefaultCellStyle.NullValue = null;
            }
        }

        
    }
}
