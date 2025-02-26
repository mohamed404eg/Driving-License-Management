﻿using System;
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



        /// <summary>
        ///  Get Index Cell In Row DataGridView
        /// </summary>
        /// <returns>value if successfully otherwise return -1 if not found</returns>
        public static int _GetByIndextCellInRow(DataGridView dgv , int IndexCell)
        {
            object cellValue = null;
            if (dgv.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgv.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                DataGridViewCell firstCellInRow = selectedRow.Cells[IndexCell];
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

        /// <summary>
        ///  Get Index Cell In Row DataGridView
        /// </summary>
        /// <returns>value if successfully otherwise return null  if not found</returns>
        public static string _GetStringByIndextCellInRow(DataGridView dgv, int IndexCell)
        {
            object cellValue = null;
            if (dgv.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgv.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                DataGridViewCell firstCellInRow = selectedRow.Cells[IndexCell];
                cellValue = firstCellInRow.Value;
            }
            if (cellValue != null)
            {
                return (string)cellValue;

            }
            else
            {
                return null;
            }
        }





    }
}
