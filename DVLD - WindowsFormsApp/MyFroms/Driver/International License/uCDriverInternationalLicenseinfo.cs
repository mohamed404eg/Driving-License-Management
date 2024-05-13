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

namespace DVLD___WindowsFormsApp.MyFroms.Driver.International_License
{
    public partial class UcDriverInternationalLicenseinfo : UserControl
    {
        int _LocalAppId;
        public UcDriverInternationalLicenseinfo()
        {
            InitializeComponent();
          
        }
        public UcDriverInternationalLicenseinfo(int LocalAppId)
        {
            InitializeComponent();
            LoadData(LocalAppId);
        }



       public void LoadData(int LocalAppId)
        {
            _LocalAppId = LocalAppId;

            ShowData();

        }

        void ShowData()
        {
            clsLocalDrivingLicenseApplications localDrivingLicenseApplications
                = clsLocalDrivingLicenseApplications.Find(_LocalAppId);

            clsLicenseClass licenseClass = clsLicenseClass.Find(localDrivingLicenseApplications.LicenseClassID);

            clsPeople people = clsPeople.Find(localDrivingLicenseApplications.ApplicantPersonID);

            clsLicenses licenses = clsLicenses.FindByApplicationID(localDrivingLicenseApplications.ApplicationID);
            



                lab_Class.Text = licenseClass.ClassName;

           
                lab_Name.Text = people.FullName();

            lab_LicenseId.Text = licenses.LicenseID.ToString();

            lab_NationalNo.Text = people.NationalNo;

            lab_Gendor.Text = people.Gendor;

            lab_IssueDate.Text = licenses.IssueDate.ToShortDateString();

            lab_IssueReason.Text = IssueReason.GetIssueReasonName(licenses.IssueReason);

            lab_Notes.Text = licenses.Notes;

            lab_IsActive.Text = (licenses.IsActive ? "Yes" : "No");

            lab_DateOfBirth.Text = people.DateOfBirth.ToShortDateString();

            lab_DriverId.Text = licenses.DriverID.ToString();

            lab_ExpirationDate.Text = licenses.ExpirationDate.ToShortDateString();

            lab_IsDetained.Text = (licenses.IsActive ? "Yes" : "No");

            if (!string.IsNullOrWhiteSpace(people.ImagePath))
            {

            PB_ImagePerson.ImageLocation = people.ImagePath;
            }



        }


    }
}
