using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Applications.LicenseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Application.LocalApplication
{
    public partial class frmNewLocalDrivingApplication : Form
    {
        clsLocalDrivingLicenseApplications LocalApplications;
        int _PersonId = -1;
        public frmNewLocalDrivingApplication()
        {
            LocalApplications  = new clsLocalDrivingLicenseApplications();
            InitializeComponent();
            InitializeDate();
        }
        void InitializeDate()
        {
            lab_App_Date.Text = DateTime.Now.ToShortDateString();

            CB_LicenseClass.DisplayMember = "ClassName";
            CB_LicenseClass.DataSource = clsLicenseClass.GetAll();

            lab_Create_by.Text = CurrentUser.User.UserName.ToString();
        }

        void Clear()
        {
            LocalApplications = new clsLocalDrivingLicenseApplications();
            
        }
        private void ucFindPersonDetails1_DataBack(object sender, int PersonID)
        {
            _PersonId = PersonID;
           


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex  = 1;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        void FillDate()
        {
            // New Local Driving License Service
            LocalApplications.ApplicantPersonID = _PersonId;
            LocalApplications.ApplicationTypeID = 1;
            LocalApplications.CreatedByUserID = CurrentUser.User.UserID;
            LocalApplications.ApplicationStatus = 1;
            LocalApplications.LicenseClassID = (CB_LicenseClass.SelectedIndex + 1);
        }


        bool CheckDate()
        {
            if (LocalApplications.ApplicantPersonID == -1)
            {
                return false;
            }



            return true;
        }

        void Save()
        {
            if (LocalApplications.Save())
            {
                MessageBox.Show("Successfully Save");

                lab_App_Id.Text = LocalApplications.LocalDrivingLicenseApplicationID.ToString();
            }
            else
            {
                MessageBox.Show("Filad Save , perosn Have this LicenseClass or hav Same Applications Same Type");
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FillDate();

           if (!CheckDate() )
            {
                MessageBox.Show("Data Not Complate");
                return;
            }

            Save();

            // clear after new screach
            Clear();
        }

        private void frmNewLocalDrivingApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
