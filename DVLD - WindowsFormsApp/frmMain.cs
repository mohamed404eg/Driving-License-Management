using DVLD___BusinessPresentation;
using DVLD___WindowsFormsApp.MyFroms;
using DVLD___WindowsFormsApp.MyFroms.Login;
using DVLD___WindowsFormsApp.MyFroms.Uesr;
using DVLD___WindowsFormsApp.MyFroms.frmApplicationTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD___WindowsFormsApp.MyFroms.ManageTestTypes;
using DVLD___WindowsFormsApp.MyFroms.Application.LocalApplication;
using DVLD___WindowsFormsApp.MyFroms.Driver.List_Drivers;
using DVLD___WindowsFormsApp.MyFroms.Driver.Renew_License;
using DVLD___WindowsFormsApp.MyFroms.Driver.Replacement;
using DVLD___WindowsFormsApp.MyFroms.Driver.Release_Detain_Licenses;
using DVLD___WindowsFormsApp.MyFroms.Application.Test.Vision;
using DVLD___WindowsFormsApp.MyFroms.Application.International;
using DVLD___WindowsFormsApp.MyFroms.Driver.Detain.Manage_Detain_License;
namespace DVLD___WindowsFormsApp
{

  
    

    public partial class frmMain : Form
    {
        


        public frmMain()
        {
            InitializeComponent();
        }

        private void applToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        frmManagePeople frmManagePeople;
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (frmManagePeople == null || frmManagePeople.IsDisposed)
            {
                frmManagePeople = new frmManagePeople();
                frmManagePeople.MdiParent = this;
                frmManagePeople.FormClosed += FrmManagePeople_FormClosed;
                frmManagePeople.Show();
            }
            else
            {
                frmManagePeople.BringToFront();
            }
            

        }
        private void FrmManagePeople_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmManagePeople = null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();

            CurrentUser.User = null;

            frmLogin frmLogin = new frmLogin();
            frmLogin.Show   ();
        }

        frmManageUsers ManageUsers;
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManageUsers == null || ManageUsers.IsDisposed)
            {
                 ManageUsers = new frmManageUsers();
                ManageUsers.MdiParent = this;
                ManageUsers.FormClosed += FrmManagePeople_FormClosed1; ;
                ManageUsers.Show();
            }
            else
            {
                frmManagePeople.BringToFront();
            }

        }

        private void FrmManagePeople_FormClosed1(object sender, FormClosedEventArgs e)
        {
            ManageUsers = null;
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentUser.User == null) return;

            int UserId = CurrentUser.User.UserID;
            if (UserId != -1)
            {


                frmUserDetails frmPersonDetails = new frmUserDetails(UserId);
                frmPersonDetails.ShowDialog();


            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (CurrentUser.User == null) return;

            int UserId = CurrentUser.User.UserID;
            int PersonId = CurrentUser.User.PersonID;

            if (UserId != -1 && PersonId != -1)
            {


                frmAddNewUserAndUpdate frmAddNewUserAndUpdate = new frmAddNewUserAndUpdate(PersonId, UserId);

           
                frmAddNewUserAndUpdate.ShowDialog();


            }
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        frmApplicationTypes applicationTypes;
        private void manageAplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (applicationTypes == null || applicationTypes.IsDisposed)
            {
                applicationTypes = new frmApplicationTypes();
                applicationTypes.MdiParent = this;
                applicationTypes.FormClosed += ApplicationTypes_FormClosed;
                applicationTypes.Show();
            }
            else
            {
                applicationTypes.BringToFront();
            }
        }

        private void ApplicationTypes_FormClosed(object sender, FormClosedEventArgs e)
        {
            applicationTypes = null;
        }

        frmManageTestTypes frmManageTest; 
        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManageTest == null || frmManageTest.IsDisposed)
            {
                frmManageTest = new frmManageTestTypes();
                frmManageTest.MdiParent = this;
                frmManageTest.FormClosed += FrmManageTest_FormClosed; ;
                frmManageTest.Show();
            }
            else
            {
                applicationTypes.BringToFront();
            }
        }

        private void FrmManageTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            applicationTypes = null;
        }



        /// <summary>
        /// Add New Local Driving Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        frmNewLocalDrivingApplication newLocalDrivingApplication;
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newLocalDrivingApplication == null || newLocalDrivingApplication.IsDisposed)
            {
                newLocalDrivingApplication = new frmNewLocalDrivingApplication();
                newLocalDrivingApplication.MdiParent = this;
                newLocalDrivingApplication.FormClosed += NewLocalDrivingApplication_FormClosed;
                newLocalDrivingApplication.Show();
            }
            else
            {
                newLocalDrivingApplication.BringToFront();
            }

        }

        private void NewLocalDrivingApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            newLocalDrivingApplication = null;
        }


        frmManageLocalDrivingApplication frmManageLocalDrivingApplication;
        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmManageLocalDrivingApplication == null || frmManageLocalDrivingApplication.IsDisposed)
            {
                frmManageLocalDrivingApplication = new frmManageLocalDrivingApplication();
                frmManageLocalDrivingApplication.MdiParent = this;
                frmManageLocalDrivingApplication.FormClosed += NewLocalDrivingApplication_FormClosed;
                frmManageLocalDrivingApplication.Show();
            }
            else
            {
                frmManageLocalDrivingApplication.BringToFront();
            }

        }

        frmListDrivers frmListDrivers;
        private void drivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListDrivers == null || frmListDrivers.IsDisposed)
            {
                frmListDrivers = new frmListDrivers();
                frmListDrivers.MdiParent = this;
                frmListDrivers.FormClosed += NewLocalDrivingApplication_FormClosed;
                frmListDrivers.Show();
            }
            else
            {
                frmListDrivers.BringToFront();
            }
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        frmRenewLocalLicense _frmRenewLocalLicense;
        private void rrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_frmRenewLocalLicense == null || _frmRenewLocalLicense.IsDisposed)
            {

             _frmRenewLocalLicense = new frmRenewLocalLicense();
            _frmRenewLocalLicense.FormClosed += _frmRenewLocalLicense_FormClosed;
            _frmRenewLocalLicense.MdiParent = this;
            _frmRenewLocalLicense.Show();

            }
            else
            {
                _frmRenewLocalLicense.BringToFront();
            }


        }

        private void _frmRenewLocalLicense_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmRenewLocalLicense = null;
        }


        frmReplacment _frmReplacment;
        private void replacmentForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(_frmReplacment == null  || _frmReplacment.IsDisposed)
            {
                _frmReplacment = new frmReplacment();
                _frmReplacment.MdiParent = this;
                _frmReplacment.FormClosed += _frmReplacment_FormClosed;
                _frmReplacment.Show();


            }
            else
            {
                _frmReplacment.BringToFront();
            }

        }

        private void _frmReplacment_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmReplacment = null; 
        }


        frmReleaseDetainLicenses _frmReleaseDetainLicenses;
        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(_frmReleaseDetainLicenses == null || _frmReleaseDetainLicenses.IsDisposed)
            {
                _frmReleaseDetainLicenses = new frmReleaseDetainLicenses();
                _frmReleaseDetainLicenses.MdiParent= this;
                _frmReleaseDetainLicenses.FormClosed += _frmReleaseDetainLicenses_FormClosed;
                _frmReleaseDetainLicenses.Show();


            }
            else
            {
                _frmReleaseDetainLicenses.BringToFront();
            }



        }

        private void _frmReleaseDetainLicenses_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmReleaseDetainLicenses= null;
        }



        frmManageLocalDrivingApplication _RetakeTesst;
        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_RetakeTesst == null || _RetakeTesst.IsDisposed)
            {

            _RetakeTesst = new frmManageLocalDrivingApplication();
            _RetakeTesst .MdiParent= this;
            _RetakeTesst.FormClosed += _RetakeTesst_FormClosed;
            _RetakeTesst.Show();
            }
            else
            {
                _RetakeTesst.BringToFront();
            }




        }

        private void _RetakeTesst_FormClosed(object sender, FormClosedEventArgs e)
        {
           _RetakeTesst = null;
        }



        frmManageInternationalDrivingApplication _frmManageInternationalDrivingApplication;
        private void internationlLicneseAppliactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_frmManageInternationalDrivingApplication == null || _frmManageInternationalDrivingApplication.IsDisposed)
            {
                _frmManageInternationalDrivingApplication = new frmManageInternationalDrivingApplication();
                _frmManageInternationalDrivingApplication .MdiParent= this;
                _frmManageInternationalDrivingApplication.FormClosed += _frmManageInternationalDrivingApplication_FormClosed;
                _frmManageInternationalDrivingApplication.Show();
            }
            else
            {
                _frmManageInternationalDrivingApplication.BringToFront();
            }



        }

        private void _frmManageInternationalDrivingApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
         _frmManageInternationalDrivingApplication=null;
        }


       
        frmManageDetainLicenses _frmManageDetainLicenses;
        private void manageDetaineToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  if()

        }
    }
}
