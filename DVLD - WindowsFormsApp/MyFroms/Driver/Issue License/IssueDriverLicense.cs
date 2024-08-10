using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___BusinessPresentation.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Driver.Issue_License
{
    public partial class frmIssueDriverLicense : Form
    {
        int _LocalDrivingLicenseApplication;
        public frmIssueDriverLicense()
        {
            InitializeComponent();
        }
        public frmIssueDriverLicense(int LocalDrivingLicenseApplication)
        {
            InitializeComponent();

            LoadData(LocalDrivingLicenseApplication);
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void LoadData(int LocalDrivingLicenseApplication)
        {
            _LocalDrivingLicenseApplication = LocalDrivingLicenseApplication;

            uCdrivingAndAppInfo1.UpdateApplicationID(_LocalDrivingLicenseApplication);
            uCdrivingAndAppInfo1.LoadData();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsLicenses license = new clsLicenses();
            FullLicense(license);

            if (license.Save())
            {
                MessageBox.Show("Licenses Issued Successfully With License ID = " + license.LicenseID, "Successed");
            }
            else
            {
                MessageBox.Show("Faild","Faild",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }


        void FullLicense(clsLicenses license)
        {
            clsLocalDrivingLicenseApplications LocalDrivingApp = clsLocalDrivingLicenseApplications.Find(_LocalDrivingLicenseApplication);
            clsApplications applications = clsApplications.Find(LocalDrivingApp.ApplicationID);

            clsDriver driver = clsDriver.FindByPersonID(applications.ApplicantPersonID);



            if (driver == null) return;

            clsLicenseClass licenseClass = clsLicenseClass.Find(LocalDrivingApp.LicenseClassID);

            //[LicenseID]
            //  ,[ApplicationID]
            //,[DriverID]
            //,[LicenseClass]
            //,[IssueDate]
            //,[ExpirationDate]
            //,[Notes]
            //,[PaidFees]
            //,[IsActive]
            //,[IssueReason]
            //,[CreatedByUserID]

            license.ApplicationID = LocalDrivingApp.ApplicationID;
            
            license.DriverID = driver.DriverID;
            license.LicenseClass = LocalDrivingApp.LicenseClassID;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(licenseClass.DefaultValidityLength);
            license.Notes = RB_Notes.Text;
            license.PaidFees = licenseClass.ClassFees;
            license.IsActive = true;
            license.IssueReason = 1;

          //  license.CreatedByUserID = CurrentUser.User.UserID;

            // test
            license.CreatedByUserID = 1;

           


        }
    }
}
