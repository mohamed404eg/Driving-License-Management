using DVLD___BusinessPresentation.Driver;
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
using System.Security.Cryptography;
using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___WindowsFormsApp.MyFroms.Driver.ShowLicense;
using DVLD___WindowsFormsApp.MyFroms.Driver.License_History;
namespace DVLD___WindowsFormsApp.MyFroms.Driver.Replacement
{
    public partial class frmReplacment : Form
    {
        int _OldLicenseId = -1;
        clsLicenses _OldLicense = null;
        clsLocalDrivingLicenseApplications _NewLocalDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
        clsLicenses _NewLicense = new clsLicenses();


        public frmReplacment()
        {
            InitializeComponent();
            ShowInitData();
        }

        void ShowInitData()
        {
            lab_AppliationFees.Text = clsApplicationTypes.Find(5).ApplicationTypeFees.ToString();
            lab_CreatedBy.Text = CurrentUser.User.UserName.ToString();
            lab_AppliationDate.Text = DateTime.Now.ToShortDateString();
        }
        private void frmReplacment_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // affect aftetr boutton Checked Change
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Damaged.Checked)
            {
                lab_AppliationFees.Text = clsApplicationTypes.Find(5).ApplicationTypeFees.ToString();
                ChangeLayoutDamagedOrLost(1);



            }
            else
            {
                lab_AppliationFees.Text = clsApplicationTypes.Find(4).ApplicationTypeFees.ToString();
                ChangeLayoutDamagedOrLost(2);
            }

        }

        /// <summary>
        /// Damaged  = 1, Lost  = 2
        /// </summary>
        /// <param name="Order"></param>
        void ChangeLayoutDamagedOrLost(int Order)
        {
            string Text = "Replacement for Damaged Licenses";

            if (Order == 1)
            {
                Text = "Replacement for Damaged Licenses";
     
            }
            else
            {
                Text = "Replacement for Lost Licenses";
              
            }

            lab_Title.Text = Text;
            this.Text = Text;

        }

        private void ucFindLicense1_MyCustomEvent(object sender, uC.UcFindLicense.MyCustomEventArgs e)
        {
            if(e.Id != -1)
            {
                //  MessageBox.Show(e.Id.ToString());
                IsFoundLicnse(e.Id);
            }
            else
            {
                MessageBox.Show("Not Found");
            }



        }


        void IsFoundLicnse(int OldLicnse)
        {
            _OldLicenseId = OldLicnse;

            _OldLicense = clsLicenses.Find(OldLicnse);

            if (_OldLicense == null) return;
            IsNotActive();
        }



        void IsNotActive()
        {
            if(_OldLicense.IsActive == false)
            {
                MessageBox.Show("Licnse Is Not Active");
                ActionAfterNotActive();

            }
            else
            {
                // good Licnse
                ActionAfterCheckLicnseIsGood();
            }

        }



        void ActionAfterNotActive()
        {
            btn_Issue.Enabled = false;

        }



        void ActionAfterCheckLicnseIsGood()
        {
            //    MessageBox.Show("Good License");

            ShowNewInfoAfterFoundLicense();
            EnabledIssueBtn();

        }

        void EnabledIssueBtn()
        {
            btn_Issue.Enabled = true;
        }

        void ShowNewInfoAfterFoundLicense()
        {
            lab_OldLicneseID.Text = _OldLicenseId.ToString() ;
        }
        void CopyOldApplicationToNew()
        {
            
      

                clsLocalDrivingLicenseApplications OldLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByApplicationID(_OldLicense.ApplicationID);


                // copy
                _NewLocalDrivingLicenseApplications.LicenseClassID = OldLocalDrivingLicenseApplications.LicenseClassID;
                _NewLocalDrivingLicenseApplications.ApplicantPersonID = OldLocalDrivingLicenseApplications.ApplicantPersonID;


                // renew Type
                _NewLocalDrivingLicenseApplications.ApplicationTypeID = GetApplicationTypeID();
                _NewLocalDrivingLicenseApplications.ApplicationDate = DateTime.Now;
                _NewLocalDrivingLicenseApplications.ApplicationStatus = 3;
                _NewLocalDrivingLicenseApplications.LastStatusDate = DateTime.Now;
                _NewLocalDrivingLicenseApplications.CreatedByUserID = CurrentUser.User.UserID;


            // set isReplacement is true
            _NewLocalDrivingLicenseApplications.isReplacement = true;

        }

        int GetApplicationTypeID()
        {
            if (rBtn_Damaged.Checked)
            {
                return 4; // for a damaged license.
            }
            else
            {
                return 3; // for a lost license .
            }

        }


        private void btn_Issue_Click(object sender, EventArgs e)
        {
            CopyOldApplicationToNew();



            if (_NewLocalDrivingLicenseApplications.Save())
            {
                clsLicenseClass LicenseClass = clsLicenseClass.Find(_OldLicense.LicenseClass);

                _NewLicense.ApplicationID = _NewLocalDrivingLicenseApplications.ApplicationID;
                _NewLicense.Notes = _OldLicense.Notes;
                _NewLicense.CreatedByUserID = CurrentUser.User.UserID;
                _NewLicense.DriverID = _OldLicense.DriverID;
                _NewLicense.IssueDate = DateTime.Now;
                _NewLicense.LicenseClass = _OldLicense.LicenseClass;
                _NewLicense.PaidFees = LicenseClass.ClassFees;
                _NewLicense.ExpirationDate = _OldLicense.ExpirationDate;
                _NewLicense.IssueReason =(byte)( GetApplicationTypeID() +  1);




                // off the old license
                _OldLicense.IsActive = false;


                if (MessageBox.Show($"Are you sure you want to {((GetApplicationTypeID() == 4) ? "issue a replacement for a damaged license" : "replacement for a lost license")  } the license", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_NewLicense.Save() && _OldLicense.Save())
                    {

                        MessageBox.Show($"License Replacement Successfully with ID={_NewLicense.LicenseID}", "License Issued");
                        AfterRenewed();
                        UpdateApplicationShow();




                    }

                }



            }






        }

        void AfterRenewed()
        {
            btn_Issue.Enabled = false;
            ucFindLicense1.Enabled = false;
            gB_Replacement.Enabled = false;

            // true
            lLab_ShowNewLicenseInfo.Enabled = true;
            lLab_ShowLicenseHistory.Enabled = true;
        }


        void UpdateApplicationShow()
        {
            lab_L_R_ApplicationID.Text = _NewLocalDrivingLicenseApplications.ApplicationID.ToString();
            lab_ReplacedLicenseID.Text = _NewLicense.LicenseID.ToString();



        }

        private void lLab_ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(-1, _NewLicense.DriverID, false);
            frmLicenseHistory.ShowDialog();

        }

        private void lLab_ShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frmShowLicense = new frmShowLicense(_NewLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID);
            frmShowLicense.ShowDialog();
        }
    }
}
