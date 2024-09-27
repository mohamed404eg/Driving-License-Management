using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___BusinessPresentation.Driver;
using DVLD___WindowsFormsApp.MyFroms.Driver.License_History;
using DVLD___WindowsFormsApp.MyFroms.Driver.ShowLicense;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Driver.Renew_License
{
    public partial class frmRenewLocalLicense : Form
    {
        int _LicenseId = -1;
        clsLicenses _License = null;
        clsLocalDrivingLicenseApplications _NewLocalDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
        clsLicenses _NewLicense = new clsLicenses();

        public frmRenewLocalLicense()
        {
            InitializeComponent();
            FullInitaNewApplicationlData();

        }
        



        private void ucFindLicense1_MyCustomEvent(object sender, uC.UcFindLicense.MyCustomEventArgs e)
        {
            //license id
            //MessageBox.Show(e.Id.ToString());
            _LicenseId = e.Id;
            GetLcense();
            LicenseVild();

        }


        void GetLcense()
        {
            if(this._LicenseId != -1) {

                _License = clsLicenses.Find(_LicenseId);

            }
        }
        void LicenseVild()
        {
            clsLicenses licenses = clsLicenses.Find(this._LicenseId);

            if (licenses != null)
            {
                if(licenses.ExpirationDate > DateTime.Now)
                {
                    MessageBox.Show($"Selected Licesne is not yet expiared , it will exire on: {licenses.ExpirationDate}");
                    EnbuildBtnNotExpirationDate();
                }
                else
                {


                    EnbuildBtnExpirationDate();
                    UpdateApplicationShowAfterGotLicenseId();
                }



            }

        }

        void EnbuildBtnNotExpirationDate()
        {
            lLab_ShowLicenseHistory.Enabled = true;

            // off
            btn_Renew.Enabled = false;
        }

        void EnbuildBtnExpirationDate()
        {
            lLab_ShowLicenseHistory.Enabled = true;
            btn_Renew.Enabled = Enabled;


        }




        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lLab_ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this._License != null)
            {

                frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(-1, _License.DriverID, false);
                frmLicenseHistory.ShowDialog();


            }        }



        void FullInitaNewApplicationlData()
        {
            lab_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            lab_IssueDate .Text= DateTime.Now.ToShortDateString();
            lab_CreatedBy.Text = CurrentUser.User.UserName.ToString();
            lab_ApplicationFees.Text = clsApplicationTypes.Find(2).ApplicationTypeFees.ToString();

        }


        void CopyOldApplicationToNew()
        {
            if (_License != null)
            {
                clsLocalDrivingLicenseApplications OldLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByApplicationID(_License.ApplicationID);


                // copy
                _NewLocalDrivingLicenseApplications.LicenseClassID = OldLocalDrivingLicenseApplications.LicenseClassID;
                _NewLocalDrivingLicenseApplications.ApplicantPersonID = OldLocalDrivingLicenseApplications.ApplicantPersonID;


                // renew Type
                _NewLocalDrivingLicenseApplications.ApplicationTypeID = 2;
                _NewLocalDrivingLicenseApplications.ApplicationDate = DateTime.Now;
                _NewLocalDrivingLicenseApplications.ApplicationStatus = 3;
                _NewLocalDrivingLicenseApplications.LastStatusDate = DateTime.Now;
                _NewLocalDrivingLicenseApplications.CreatedByUserID = CurrentUser.User.UserID;
                

            }
        }


        void AfterRenewed()
        {
            btn_Renew.Enabled = false;
            ucFindLicense1.Enabled = false;
            lLab_ShowNewLicenseInfo.Enabled = true;
        }


        void UpdateApplicationShow()
        {
            lab_RLApplicationID.Text = _NewLocalDrivingLicenseApplications.ApplicationID.ToString();
            lab_RenewedLicenseID.Text = _NewLicense.LicenseID.ToString();
         


        }
        void UpdateApplicationShowAfterGotLicenseId()
        {
            clsLicenseClass licenseClass = clsLicenseClass.Find(_License.LicenseClass);

            lab_LicenseFees.Text = licenseClass.ClassFees.ToString();
            lab_OldLicenseID.Text = _License.LicenseID.ToString();
            lab_TotalFees.Text = (licenseClass.ClassFees + clsApplicationTypes.Find(2).ApplicationTypeFees).ToString();


            lab_ExpirationDate.Text = DateTime.Now.AddYears(licenseClass.DefaultValidityLength).ToShortDateString();
        }



        private void btn_Renew_Click(object sender, EventArgs e)
        {
            CopyOldApplicationToNew();


            if (_NewLocalDrivingLicenseApplications.Save())
            {
                clsLicenseClass LicenseClass =  clsLicenseClass.Find(_License.LicenseClass);

                _NewLicense.ApplicationID = _NewLocalDrivingLicenseApplications.ApplicationID;
                _NewLicense.Notes = richTextBox1.Text;
                _NewLicense.CreatedByUserID = CurrentUser.User.UserID;
                _NewLicense.DriverID = _License.DriverID;
                _NewLicense.IssueDate = DateTime.Now;
                _NewLicense.LicenseClass = _License.LicenseClass;
                _NewLicense.PaidFees = LicenseClass.ClassFees;
                _NewLicense.ExpirationDate= DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
                _NewLicense.IssueReason = 3;




                  // off the old license
                        _License.IsActive = false;

                    if(MessageBox.Show("Are you sure you want to Renew the license","Confirm",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (_NewLicense.Save() && _License.Save() )
                        {

                            MessageBox.Show($"License Renewed Successfully with ID={_NewLicense.LicenseID}","License Issued");
                            AfterRenewed();
                            UpdateApplicationShow();

                      
                       

                        }

                    }
                


            }





        }

        private void lLab_ShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(_NewLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID);
            frmShowLicense.ShowDialog();
        }
    }
}
