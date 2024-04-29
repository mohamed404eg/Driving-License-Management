using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Test;
using DVLD___WindowsFormsApp.MyFroms.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD___WindowsFormsApp.MyFroms.Application.LocalApplication
{
    public partial class frmManageLocalDrivingApplication : Form
    {
        enum enFilterBy
        {
            None,
L_D_L_AppID,
NationalNo,
FullName,
Status

    }
        enFilterBy _FilterByIndex;
        public frmManageLocalDrivingApplication()
        {
            InitializeComponent();
            InitializeData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageLocalDrivingApplication_Load(object sender, EventArgs e)
        {

        }


        void InitializeData()
        {
            // dGV
            RestGridView();

            //Records
            labRecords.Text = dGV.RowCount.ToString(); ;

            // ComboBox
            COBX_Filter.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingApplication frmNewApp = new frmNewLocalDrivingApplication();
            frmNewApp.FormClosed += FrmNewApp_FormClosed;
            frmNewApp.ShowDialog();
        }

        private void FrmNewApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            // update screen
            InitializeData();
        }

        private void COBX_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterByIndex = (enFilterBy)COBX_Filter.SelectedIndex;

            // when Filter type change
            ChangeDataGrid();

            if (_FilterByIndex == enFilterBy.None)
            {
                tB_FilterBy.Visible = false;
                CB_Status.Visible = false;
                return;
            }
            else if( _FilterByIndex == enFilterBy.FullName 
                || _FilterByIndex == enFilterBy.L_D_L_AppID || _FilterByIndex == enFilterBy.NationalNo)
            {
                tB_FilterBy.Visible = true;
                CB_Status.Visible = false;
                return;
            }

            else if (_FilterByIndex == enFilterBy.Status)
            {

                CB_Status.Visible = true;
                tB_FilterBy.Visible = false;

                // selecet default
                CB_Status.SelectedIndex = 0;

                return;
            }


           
        }

        private void tB_FilterBy_TextChanged(object sender, EventArgs e)
        {

            // when text change 
            ChangeDataGrid();



        }


        void ChangeDataGrid()
        {
//            None = 0
//L.D.L.AppID(Applications Id) =1
//National No. =2
//Full Name=3
//Status=4

            if(_FilterByIndex == enFilterBy.None){
                        // dGV
                        dGV.DataSource = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications_View();
                return;
            }

            if (!string.IsNullOrEmpty(tB_FilterBy.Text)  ){
                switch (_FilterByIndex)
                {



                    case enFilterBy.L_D_L_AppID:
                        dGV.DataSource = clsLocalDrivingLicenseApplications.Find_DataTable(Convert.ToInt32(tB_FilterBy.Text));
                        break;

                    case enFilterBy.NationalNo:
                        dGV.DataSource = clsLocalDrivingLicenseApplications.FindByNationalNo(tB_FilterBy.Text);
                        break;

                    case enFilterBy.FullName:
                        dGV.DataSource = clsLocalDrivingLicenseApplications.FindByFullName(tB_FilterBy.Text);
                        break;

                   

                }

                return;
            }






            // dGV if not case successfully
            RestGridView();
        }


        void RestGridView()
        {
            // dGV
            dGV.DataSource = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications_View();

        }

        private void CB_Status_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (!string.IsNullOrEmpty(CB_Status.Text))
            {
                switch (_FilterByIndex)
                {

                    case enFilterBy.Status:
                        dGV.DataSource = clsLocalDrivingLicenseApplications.FindByStatus(CB_Status.Text);
                        break;

                }
                return;
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eDrivingLiceseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationId = Multi._GetfirstCellInRow(dGV);
            if(ApplicationId != -1)
            {
                if(MessageBox.Show("Are sure Cancel Applaction", "Cancel Applicaion",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (clsLocalDrivingLicenseApplications.ChangeStatus(2, ApplicationId))
                    {
                        MessageBox.Show("successfully", "successfully",MessageBoxButtons.OK);
                        RestGridView();
                    }
                    else
                    {
                        MessageBox.Show("Filad", "Filad", MessageBoxButtons.OK);
                    }


                }
            }

        }

        void _SheduleCheckAvailable()
        {
            int ApplicationId = Multi._GetfirstCellInRow(dGV);

            if(ApplicationId != -1)
            {

                int TopTestSuccessfullyAchving = clsTestAppointments.TopTestSuccessfullyAchving(ApplicationId);
                
                if(TopTestSuccessfullyAchving >= 3)
                {
                    sechduleTaskToolStripMenuItem.Enabled = false;
                }
                else
                {
                    sechduleTaskToolStripMenuItem.Enabled = true;

                }


                if(TopTestSuccessfullyAchving == 0)
                {
                    // scheduleVisionTest
                    scheduleVisionTestToolStripMenuItem.Enabled = true;

                    // end else false
                    scheduleWritenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;

                }

               else if (TopTestSuccessfullyAchving == 1)
                {
                    // scheduleWritenTest
                    scheduleWritenTestToolStripMenuItem.Enabled = true;

                    // end else false
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;

                }

                else if(TopTestSuccessfullyAchving == 2)
                {
                    //  scheduleStreetTest
                    scheduleStreetTestToolStripMenuItem.Enabled = true;

                    // end else false
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWritenTestToolStripMenuItem.Enabled = false;

                }


            }

        }
        private void cMS_AllApplication_Opening(object sender, CancelEventArgs e)
        {
            // 
            _SheduleCheckAvailable();

        }
    }
}
