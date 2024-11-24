using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Driver;
using DVLD___BusinessPresentation.Driver.Detain;
using DVLD___WindowsFormsApp.MyFroms.Driver.License_History;
using DVLD___WindowsFormsApp.MyFroms.Driver.ShowLicense;
using DVLD___WindowsFormsApp.MyFroms.Driver.uC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD___WindowsFormsApp.MyFroms.Driver.Release_Detain_Licenses
{
    public partial class frmReleaseDetainLicenses : Form
    {

        int _LicesneId = -1;
        clsDetain _detain;
        clsApplicationTypes _applicationTypes = clsApplicationTypes.Find(5);

        clsApplications _ReleaseApplication = null;

        public frmReleaseDetainLicenses()
        {
            InitializeComponent();
        }
        public frmReleaseDetainLicenses(int LicenseId)
        {
            InitializeComponent();

         //   ucFindLicense1.Enabled = false;
            ucFindLicense1.LoadLienseId(LicenseId);
            ucFindLicense1_MyCustomEvent(LicenseId);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucFindLicense1_Load(object sender, EventArgs e)
        {

        }

        private void ucFindLicense1_MyCustomEvent(object sender, uC.UcFindLicense.MyCustomEventArgs e)
        {
            _LicesneId = e.Id;

            if(_LicesneId != -1)
            {
            CehckAfterFoundLicense();

            }
            else
            {
                NotFoundLicens();
            }


        }

        private void ucFindLicense1_MyCustomEvent(int LicenseId)
        {
            _LicesneId = LicenseId;

            if (_LicesneId != -1)
            {
                CehckAfterFoundLicense();

            }
            else
            {
                NotFoundLicens();
            }


        }

        void CehckAfterFoundLicense()
        {

             _detain = clsDetain.FindDetainIDByLienseId(_LicesneId);
            
            if (_detain == null || _detain.IsReleased == true)
            {
                // Licensd Not Detain

                LicenseNotDetain();


            }
            else { 
            LicenseDetain();
            
            }





        }

        void LicenseNotDetain()
        {

            MessageBox.Show($"Licesn id : {_LicesneId} is not Detain");


            lL_ShowLicenseHistory.Enabled = true;
            lL_ShowLicenseInfo.Enabled = true;
            btn_Release.Enabled = false;
        }

      
        void NotFoundLicens()
        {
            lL_ShowLicenseHistory.Enabled = false;
            lL_ShowLicenseInfo.Enabled = false;
            btn_Release.Enabled = false;

        }




        void LicenseDetain()
        {
            // button Release Enabled
            btn_Release.Enabled = true;

            ShowDetainInfo();
            EnabledBtnHistoryAndInfo();



        }

        void EnabledBtnHistoryAndInfo()
        {
            lL_ShowLicenseHistory.Enabled = true;
            lL_ShowLicenseInfo.Enabled = true;
        }

        void ShowDetainInfo()
        {

            lab_DerainID.Text = _detain.DetainID.ToString();

            lab_DetainDate.Text = _detain.DetainDate.ToLongDateString();
            ShowApplicationFees();

            lab_TotalFees.Text = (_applicationTypes.ApplicationTypeFees + _detain.FineFees).ToString();

            lab_LicenseID.Text = _detain.LicenseID.ToString();

            lab_CreatedBy.Text = CurrentUser.User.UserName;

            lab_FineFees.Text = _detain.FineFees.ToString();




        }


        void ShowApplicationFees()
        {

            lab_ApplicationFees.Text = _applicationTypes.ApplicationTypeFees.ToString();




        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lab_ApplicationFees_Click(object sender, EventArgs e)
        {

        }

        private void lab_DetainDate_Click(object sender, EventArgs e)
        {

        }

        private void lab_DerainID_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)



        {

            if (MessageBox.Show($"Are You Sure Release License Id {_LicesneId} ?" ,"Sure!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != DialogResult.OK) return;



            clsDriver driver = clsDriver.FindByLicenseID(_LicesneId);

            if (driver == null) return;

            _ReleaseApplication = new clsApplications();

            _ReleaseApplication.ApplicantPersonID = driver.PersonID;
            _ReleaseApplication.ApplicationDate = DateTime.Now;
            _ReleaseApplication.ApplicationTypeID = _applicationTypes.ApplicationTypeId;
            _ReleaseApplication.ApplicationStatus = 3; 
            _ReleaseApplication.LastStatusDate = DateTime.Now;
            _ReleaseApplication.PaidFees = _applicationTypes.ApplicationTypeFees;
            _ReleaseApplication.CreatedByUserID = CurrentUser.User.UserID;


            if (_ReleaseApplication.Save())
            {


                _detain.IsReleased = true;
                _detain.ReleaseDate = DateTime.Now;
                _detain.ReleasedByUserID = CurrentUser.User.UserID;
                _detain.ReleaseApplicationID = _ReleaseApplication.ApplicationID;

                if (_detain.Save())
                {
                    MessageBox.Show($"Detain Licesne Release Successfully","Info",MessageBoxButtons.OK);

                    CloseForm();

                    ShowAplicationId(_ReleaseApplication.ApplicationID);

                }
                else
                {
                    MessageBox.Show($"Detain Licesne Release Faild", "Info", MessageBoxButtons.OK);
                }

                

            }
            else
            {
                MessageBox.Show("Error ReleaseApplication");
            }







        }

        void ShowAplicationId(int ApplicationId)
        {
            lab_ApplicationID.Text = ApplicationId.ToString();

        }
        void CloseForm()
        {
            btn_Release.Enabled = false;
            ucFindLicense1.Enabled = false;
        }
        private void lL_ShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            clsLocalDrivingLicenseApplications localDrivingLicenseApplication = clsLocalDrivingLicenseApplications.FindByApplicationID(clsLicenses.Find(_LicesneId).ApplicationID);

            if (localDrivingLicenseApplication != null)
            {

            frmShowLicense showLicense = new frmShowLicense(localDrivingLicenseApplication.LocalDrivingLicenseApplicationID);
                
                showLicense.ShowDialog();
            
            
            }
        }

        private void lL_ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            clsDriver driver = clsDriver.FindByLicenseID(_LicesneId);
            if (driver != null)
            {
                frmLicenseHistory licenseHistory = new frmLicenseHistory(-1, driver.DriverID, false);
                licenseHistory.ShowDialog();
            }
        }
    }
}
