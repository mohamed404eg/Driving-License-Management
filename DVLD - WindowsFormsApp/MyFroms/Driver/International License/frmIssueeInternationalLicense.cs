using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Driver;
using DVLD___BusinessPresentation.Driver.InternationalLicenses;
using DVLD___WindowsFormsApp.MyFroms.Driver.License_History;
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

namespace DVLD___WindowsFormsApp.MyFroms.Driver.International_License
{
    public partial class frmIssueeInternationalLicense : Form
    {
        int _LicenseId;
        clsInternationalLicenses InternationalLicenses = null;

        public frmIssueeInternationalLicense()
        {
            InitializeComponent();
        }


        // firt fuction call after click button find license
        private void ucFindLicense1_MyCustomEvent(object sender, uC.UcFindLicense.MyCustomEventArgs e)
        {
            _LicenseId = e.Id;
           
            CheckVildLocalLicense();
           
        }

        void CheckVildLocalLicense()
        {
            clsLicenses licenses = clsLicenses.Find(_LicenseId);

         
            if (!licenses.IsActive)
            {
                MessageBox.Show("Local License is Not Active");
                btn_Issue.Enabled = false;
                LL_ShowLicenseHistory.Enabled = false;
                return;
            }
         

            if (licenses.ExpirationDate < DateTime.Now)
            {
                MessageBox.Show($"Local License is Expiration Date in: {licenses.ExpirationDate}");
                btn_Issue.Enabled = false;
                LL_ShowLicenseHistory.Enabled = false;
                return;
            }
           


             btn_Issue.Enabled = true;
            LL_ShowLicenseHistory.Enabled = true;
            InternationalLicenses = new clsInternationalLicenses(); // new info
            FillInternationalLicenses();
            ShowApplicationInfo();
        }


        void ShowApplicationInfo()
        {
           

            lab_Application_Date.Text = InternationalLicenses.IssueDate.ToShortDateString();
            lab_IssueDate.Text = InternationalLicenses.IssueDate.ToShortDateString();
            lab_Fees.Text = clsApplicationTypes.Find(6).ApplicationTypeFees.ToString(); // New International License fees
            lab_Local_License_ID.Text = InternationalLicenses.IssuedUsingLocalLicenseID.ToString();
            lab_ExpirationDate.Text = InternationalLicenses.ExpirationDate.ToShortDateString();
            lab_CreatedBy.Text = InternationalLicenses.CreatedByUserID.ToString();

        }


        void FillInternationalLicenses()
        {
            clsLicenses licenses  = clsLicenses.Find(_LicenseId);

            if(licenses != null)
            {
                InternationalLicenses.DriverID = licenses.DriverID;
                InternationalLicenses.IssuedUsingLocalLicenseID = licenses.LicenseID;
                InternationalLicenses.IssueDate = DateTime.Now;
                InternationalLicenses.ExpirationDate = DateTime.Now.AddYears(1);
                InternationalLicenses.CreatedByUserID = CurrentUser.User.UserID;
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucFindLicense1_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Issue_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you suer you want issue this License ?","Confirm",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (InternationalLicenses.Save())
                {
                    MessageBox.Show($"Successfully Created with License Id {InternationalLicenses.InternationalLicenseID}");
                    FillRemaingShowApplicationInfo();
                    btnAfterIssue();
                }
                else
                {
                    if(InternationalLicenses.ReasonRejected == clsInternationalLicenses.enstatusRejected.IsHave)
                    {
                         MessageBox.Show($"Faild Created Reason -> you Have License");
                    }
                }


            }
        }

        void FillRemaingShowApplicationInfo()
        {
            lab_I_L_Application_ID.Text = InternationalLicenses.ApplicationID.ToString();
            lab_I_L_License_ID.Text = InternationalLicenses.InternationalLicenseID.ToString();

        }

        void btnAfterIssue()
        {
            btn_Issue.Enabled = false;
            ucFindLicense1.Enabled = false;
            LL_ShowLicenseInfo.Enabled = true;

        }
        private void LL_ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsLicenses licenses = clsLicenses.Find(_LicenseId);

            if (licenses != null) {
            clsLocalDrivingLicenseApplications localDrivingLicenseApplications=
                    clsLocalDrivingLicenseApplications.FindByApplicationID(licenses.ApplicationID);

                if (localDrivingLicenseApplications != null)
                {

                   frmLicenseHistory frmLicenseHistory = 
                        new frmLicenseHistory(localDrivingLicenseApplications.LocalDrivingLicenseApplicationID);

                    frmLicenseHistory.ShowDialog();
                }


                    }


        }

        private void LL_ShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frmInternationalLicenseInfo = new frmInternationalLicenseInfo(InternationalLicenses.InternationalLicenseID);
          

            frmInternationalLicenseInfo.ShowDialog();


        }
    }
}
