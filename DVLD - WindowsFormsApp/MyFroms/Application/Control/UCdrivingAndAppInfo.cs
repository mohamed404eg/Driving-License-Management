using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___BusinessPresentation.Test;
using DVLD___WindowsFormsApp.MyFroms.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD___WindowsFormsApp.MyFroms.Application.Control
{
    public partial class UCdrivingAndAppInfo : UserControl
    {
        int _LocalDrivingLicenseApplication;
        clsLocalDrivingLicenseApplications _app;
        public UCdrivingAndAppInfo()
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = -1;
                }
        public UCdrivingAndAppInfo(int LocalDrivingLicenseApplication)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplication;
            LoadData();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
       public void LoadData()
        {
            clsLocalDrivingLicenseApplications app = 
                clsLocalDrivingLicenseApplications.Find(_LocalDrivingLicenseApplication);


            if (app != null)
            {
               
              

                lab_D_L_APPID.Text = app.LocalDrivingLicenseApplicationID.ToString();

                lab_ClassOfLicense.Text = clsLicenseClass.Find(app.LicenseClassID).ClassName.ToString();

                // show license
                ShowLicense(app);
              


                // passed Test Count
                PassedTestCount();

                // section Application Basic Info
                ApplicationBasicInfo(app);

            }

            // Save Before Close
            _app = app;
        }

        public void UpdateApplicationID(int LocalDrivingLicenseApplication)
        {
             _LocalDrivingLicenseApplication = LocalDrivingLicenseApplication;
        }


        // just send LocalApplicationID and the fuction load everything
        public void LoadLocalApplication(int LocalApplicationID)
        {
            UpdateApplicationID(LocalApplicationID);
            LoadData();
        }


        void ShowLicense(clsLocalDrivingLicenseApplications app)
        {
            if (app.ApplicationStatus == 3)
            {
                panel_ShowLicense.Enabled = true;
            }
            else
            {
                panel_ShowLicense.Enabled = false;
            }

        }
        void PassedTestCount()
        {
            lab_CountPassedTest.Text = "";

            string StPassed = "";

          StPassed+= clsTestAppointments.TopTestSuccessfullyAchving(_LocalDrivingLicenseApplication).ToString();

            StPassed += "/3";

            lab_CountPassedTest.Text = StPassed;

        }

        void ApplicationBasicInfo(clsLocalDrivingLicenseApplications app)
        {
            //ApplicationID
            lab_AppId.Text = app.ApplicationID.ToString();


            // ApplicationStatus
            ShowApplicationStatus(app);
          
            // PaidFees
            lab_Fees.Text = app.PaidFees.ToString();

            // Application Type Title
            lab_TypeOfApp.Text = clsApplicationTypes.Find(app.ApplicationTypeID).ApplicationTypeTitle;

            // Applicant FullName
            lab__Applicant.Text = clsPeople.Find(app.ApplicantPersonID).FullName();
            
            // Application Date
            lab_Date.Text = app.ApplicationDate.ToString();

            // Last Status Date
            lab_StatusDate.Text = app.LastStatusDate.ToString();

            // Created By UserName
            lab_CreatedBy.Text = clsUser.Find(app.CreatedByUserID).UserName;


        }
        void ShowApplicationStatus(clsLocalDrivingLicenseApplications app)
        {
            // ## Applications Status

            //Applications.ApplicationStatus = 1 THEN 'New'
            //WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'
            //WHEN Applications.ApplicationStatus = 3 THEN 'Completed'
            //END AS Status
            if(app.ApplicationStatus == 1)
            {
            lab_Status.Text = "New";

            }else if(app.ApplicationStatus == 2)
            {
                lab_Status.Text = "Cancelled";

            }
            else if (app.ApplicationStatus == 3)
            {
                lab_Status.Text = "Completed";

            }

        }
        private void lLab_View_Person_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_app != null)
            {

                frmPersonDetails frmPersonDetails = new frmPersonDetails(_app.ApplicantPersonID);
                frmPersonDetails.ShowDialog();

            }
            else
            {
                MessageBox.Show("PersonID Not Avaliable","Alrt",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
