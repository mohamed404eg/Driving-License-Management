using DVLD___BusinessPresentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.ManageTestTypes
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
            LoadDGV_ManageTestTypes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {

        }


        void LoadDGV_ManageTestTypes()
        {
            dGV_ManageTestTypes.DataSource = clsTestTypes.GetAllTestTypes();
        }

        private void dGV_ManageTestTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lab_Records.Text = dGV_ManageTestTypes.RowCount.ToString();
        }

        /// <summary>
        ///  Get first Cell In Row DataGridView
        /// </summary>
        /// <returns>value if successfully otherwise return -1 if not found</returns>
        int _GetfirstCellInRow()
        {
            object cellValue = null;
            if (dGV_ManageTestTypes.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dGV_ManageTestTypes.SelectedCells[0];
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
        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iD = _GetfirstCellInRow();

            if(iD != -1)
            {
                frmUpdateTestType UpdateTestType = new frmUpdateTestType(iD);
                UpdateTestType.FormClosed += UpdateTestType_FormClosed;
                UpdateTestType.ShowDialog();
            }
        }

        private void UpdateTestType_FormClosed(object sender, FormClosedEventArgs e)
        {


            //Update Grid View 
            LoadDGV_ManageTestTypes();
        }
    }
}
