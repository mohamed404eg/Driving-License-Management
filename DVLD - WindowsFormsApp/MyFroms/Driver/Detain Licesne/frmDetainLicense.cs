using DVLD___BusinessPresentation.Driver;
using DVLD___BusinessPresentation.Driver.Detain;
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

namespace DVLD___WindowsFormsApp.MyFroms.Driver.Detain_Licesne
{
    public partial class frmDetainLicense : Form
    {

        int _LicenseID = -1;
        clsLicenses _licenses = null;

      
        clsDetain _Detain = null;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucFindLicense1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucFindLicense1_MyCustomEvent(object sender, uC.UcFindLicense.MyCustomEventArgs e)
        {
            _LicenseID = e.Id;
            AfterEntreLicensId();


        }



        void AfterEntreLicensId()
        {

            if(CheckIfAreadyDetain())
            {
                NotAllowdDetain();
                MessageBox.Show($"Licesne Id {_LicenseID} Is Aready Detain","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

                CreateDetain();
                ShowDetainInfo();
                AllowdDetain();


            }


            if (_LicenseID != -1) {

                lLab_ShowLicenseHistory.Enabled = true;

              

            }

             _licenses = clsLicenses.Find(_LicenseID);
            
        }

        bool CheckIfAreadyDetain()
        {
           return clsDetain.IsAlreadyExistsFindByLicenseID( _LicenseID );
        }

        void NotAllowdDetain()
        {

            btn_Detain.Enabled = false;



        }
        void AllowdDetain()
        {

            btn_Detain.Enabled = true;



        }
        private void lLab_ShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            frmLicenseHistory licenseHistory = new frmLicenseHistory(-1,_licenses.DriverID,false); 
            licenseHistory.ShowDialog();
        }



        void CreateDetain()
        {
            _Detain = new clsDetain();
            _Detain.LicenseID = _LicenseID;
            _Detain.DetainDate = DateTime.Now;
            _Detain.FineFees = 0;
            _Detain.CreatedByUserID = CurrentUser.User.UserID;
            
        }

        void ShowDetainInfo()
        {
            lab_LicenesID.Text = _LicenseID.ToString();

            lab_DetainDate.Text = _Detain.DetainDate.ToShortDateString();
            lab_CreatedBy.Text = CurrentUser.User.UserName;



        }

        private void btn_Detain_Click(object sender, EventArgs e)
        {

            if (_Detain.Save())
            {
                MessageBox.Show($"Successfully Detain License Id {_Detain.LicenseID}", "Save Detain", MessageBoxButtons.OK, MessageBoxIcon.Information);


                CloseTheForm();
                ShowDetainId();

            }




        }


        void CloseTheForm()
        {
            ucFindLicense1.Enabled = false;
            btn_Detain.Enabled = false;
            tB_FineFees.Enabled = false;
        }

        private void tB_FineFees_TextChanged(object sender, EventArgs e)
        {
            if(_Detain  != null && !string.IsNullOrEmpty(tB_FineFees.Text))
            {
                _Detain.FineFees = Convert.ToDecimal(tB_FineFees.Text);
            }

            

        }

        void ShowDetainId()
        {
            lab_DetainID.Text = _Detain.DetainID.ToString();
        }

        private void tB_FineFees_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tB_FineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
       
            if (!char.IsDigit(e.KeyChar ) && e.KeyChar != 8)
            {
                e.Handled = true;

            }




        }
    }
}
