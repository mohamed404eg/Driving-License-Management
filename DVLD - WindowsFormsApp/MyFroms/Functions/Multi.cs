using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Functions
{
    internal class Multi
    {


        /// <summary>
        ///  Get first Cell In Row DataGridView
        /// </summary>
        /// <returns>value if successfully otherwise return -1 if not found</returns>
      public static  int _GetfirstCellInRow(DataGridView dgv )
        {
            object cellValue = null;
            if (dgv.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgv.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                DataGridViewCell firstCellInRow = selectedRow.Cells[0];
                cellValue = firstCellInRow.Value;
            }
            if (cellValue != null)
            {
                return (int)cellValue;

            }
            else
            {
                return -1;
            }
        }






    }
}
