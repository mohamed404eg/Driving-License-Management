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

namespace DVLD___WindowsFormsApp.MyFroms.Uesr
{
    public partial class frmManageUsers : Form
    {

        enum enIndexFilterBy
        {
            None ,
            UserId,
            UserName,
            PersonId,
            FullName,
            IsActive
        }
       // enIndexFilterBy _FilterBy;
        public frmManageUsers()
        {
            InitializeComponent();

            // set defeilt value
            cB_Filter.SelectedIndex = (int)enIndexFilterBy.None;

            cB_IsActive.SelectedIndex = 0;
        
        }

    
        void _LoadDateGridByFilterTextBox()
        {
            enIndexFilterBy FilterBy = (enIndexFilterBy)cB_Filter.SelectedIndex;

            if (String.IsNullOrEmpty(tB_FilterBy.Text))
            {
                // when the none value in text box appear all users
                _LoadDateGridAllUsers();
                return;
            }

            if (FilterBy == enIndexFilterBy.UserId)
            {
                if (int.TryParse(tB_FilterBy.Text,out int UserId))
                {

                dGV_Users.DataSource = clsUser.FindByUserIdNonePassword(UserId);
                    return;
                }}

            if (FilterBy == enIndexFilterBy.UserName)
            {
                
                dGV_Users.DataSource = clsUser.FindByUserNameNonePassword(tB_FilterBy.Text);


                return;
            }

            if (FilterBy == enIndexFilterBy.PersonId)
            {
                if (int.TryParse(tB_FilterBy.Text, out int PersonId))
                {

                    dGV_Users.DataSource = clsUser.FindByPersonIdNonePassword(PersonId);
                    return;
                }
            }



            if (FilterBy == enIndexFilterBy.FullName)
            {

                dGV_Users.DataSource = clsUser.FindByFullNameNonePassword(tB_FilterBy.Text);


                return;
            }


        }

        void _LoadDateGridAllUsers()
        {

       
                dGV_Users.DataSource = clsUser.GetAllUsers();

            

        }
        void _LoadDateGridNoneFilter(enIndexFilterBy FilterBy)
        {

            if(FilterBy == enIndexFilterBy.None)
            {
                DataTable dt = clsUser.GetAllUsers();

                dGV_Users.DataSource = dt;

            }
           
        }
        void _ToolInputFilterByVisible(enIndexFilterBy FilterBy)
        {
            if (FilterBy == enIndexFilterBy.None)
            {
                cB_IsActive.Visible = false;
                tB_FilterBy.Visible = false;

            }
            else if (FilterBy == enIndexFilterBy.UserId 
                || FilterBy == enIndexFilterBy.UserName 
                ||  FilterBy == enIndexFilterBy.PersonId
                  || FilterBy == enIndexFilterBy.FullName
                )
            {
                tB_FilterBy.Visible = true;
                cB_IsActive.Visible = false;
            }
            else if (FilterBy == enIndexFilterBy.IsActive)
            {
                cB_IsActive.Visible =true;
                tB_FilterBy.Visible = false;
            }


        }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            enIndexFilterBy FilterBy =(enIndexFilterBy) cB_Filter.SelectedIndex;

            // load data 
            _LoadDateGridNoneFilter(FilterBy);

            _ToolInputFilterByVisible(FilterBy);



        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tB_FilterBy_TextChanged(object sender, EventArgs e)
        {
            _LoadDateGridByFilterTextBox();
        }

        private void tB_FilterBy_KeyDown(object sender, KeyEventArgs e)
        {

         

        }

        private void tB_FilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            enIndexFilterBy FilterBy = (enIndexFilterBy)cB_Filter.SelectedIndex;

            // user id enter only number
            if(FilterBy == enIndexFilterBy.UserId || FilterBy == enIndexFilterBy.PersonId)
            {

            if (!Char.IsDigit(Convert.ToChar(e.KeyChar)) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
            }




        }

        private void cB_IsActive_SelectedIndexChanged(object sender, EventArgs e)

        {

            if(cB_IsActive.SelectedIndex == 0)
            {
                _LoadDateGridAllUsers();

            }else if(cB_IsActive.SelectedIndex == 1)
            {
                dGV_Users.DataSource = clsUser.FindByIsActiveNonePassword(true);

            }
            else
            {
                dGV_Users.DataSource = clsUser.FindByIsActiveNonePassword(false);
            }


        }

        private void dGV_Users_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            NumberOfRows.Text = dGV_Users.RowCount.ToString();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frmAddNewUserAndUpdate frmAddNewUser = new frmAddNewUserAndUpdate();
            frmAddNewUser.FormClosed += FrmAddNewUser_FormClosed;
            frmAddNewUser.ShowDialog();
        }

        private void FrmAddNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _LoadDateGridAllUsers();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUserAndUpdate frmAddNewUser = new frmAddNewUserAndUpdate();
            frmAddNewUser.FormClosed += FrmAddNewUser_FormClosed;
            frmAddNewUser.ShowDialog();
        }
        /// <summary>
        ///  Get first Cell In Row DataGridView
        /// </summary>
        /// <returns>value if successfully otherwise return -1 if not found</returns>
        int _GetfirstCellInRow()
        {
            object cellValue = null;
            if (dGV_Users.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dGV_Users.SelectedCells[0];
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
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserId = _GetfirstCellInRow();
            if (UserId != -1)
            {


                frmUserDetails frmPersonDetails = new frmUserDetails(UserId);

                frmPersonDetails.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Closed);


                frmPersonDetails.ShowDialog();


            }

        }


        private void Frm_Closed(object sender, FormClosedEventArgs e)
        {
            _LoadDateGridAllUsers();
        }

    }
}
