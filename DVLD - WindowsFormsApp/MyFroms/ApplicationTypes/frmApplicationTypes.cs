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

namespace DVLD___WindowsFormsApp.MyFroms.frmApplicationTypes
{
    public partial class frmApplicationTypes : Form
    {

        public frmApplicationTypes()
        {
            InitializeComponent();
            LoadDatadGV_ApplicationTypes();
        }


        void LoadDatadGV_ApplicationTypes()
        {
            DataTable dt = clsApplicationTypes.GetAll();

            dGV_ApplicationTypes.DataSource = dt;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void dGV_ApplicationTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lab_Records_Number.Text = dGV_ApplicationTypes.RowCount.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        /// <summary>
        ///  Get first Cell In Row DataGridView
        /// </summary>
        /// <returns>value if successfully otherwise return -1 if not found</returns>
        int _GetfirstCellInRow()
        {
            object cellValue = null;
            if (dGV_ApplicationTypes.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dGV_ApplicationTypes.SelectedCells[0];
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
        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = _GetfirstCellInRow();
            if(ApplicationTypeID != -1)
            {
    
                frmUpdateApplicationType.frmUpdateApplicationType UpdateApplicationType = new frmUpdateApplicationType.frmUpdateApplicationType(ApplicationTypeID);
                UpdateApplicationType.FormClosed += UpdateApplicationType_FormClosed;
                UpdateApplicationType.ShowDialog();
            }
        }

        private void UpdateApplicationType_FormClosed(object sender, FormClosedEventArgs e)
        {

            // update screen 
            LoadDatadGV_ApplicationTypes();
        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
