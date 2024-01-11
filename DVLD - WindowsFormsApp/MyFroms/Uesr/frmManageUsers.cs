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
        }


        
        void _LoadDateGrid(enIndexFilterBy FilterBy)
        {

            if(FilterBy == enIndexFilterBy.None)
            {
                dGV_Users.DataSource = clsUser.GetAllUsers();

            }
            else if(FilterBy == enIndexFilterBy.UserId)
            {
                dGV_Users.DataSource = clsUser.FindByUserIdNonePassword(Convert.ToInt32(tB_FilterBy.Text));

            }


        }
        void _ToolInputFilterBy(enIndexFilterBy FilterBy)
        {
            if (FilterBy == enIndexFilterBy.None)
            {
                cB_IsActive.Visible = false;
                tB_FilterBy.Visible = false;

            }
            else if (FilterBy == enIndexFilterBy.UserId)
            {
                tB_FilterBy.Visible = true;

            }

        }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            enIndexFilterBy FilterBy =(enIndexFilterBy) cB_Filter.SelectedIndex;

            // load data 
            _LoadDateGrid(FilterBy);

            _ToolInputFilterBy(FilterBy);



        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
