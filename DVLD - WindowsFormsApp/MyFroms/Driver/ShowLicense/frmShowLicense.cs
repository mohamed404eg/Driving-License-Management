using DVLD___BusinessPresentation;
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

namespace DVLD___WindowsFormsApp.MyFroms.Driver.ShowLicense
{
    public partial class frmShowLicense : Form
    {
        int _LocalAppId;
        public frmShowLicense()
        {
            InitializeComponent();
        }

        public enum enSlected
        {
            LocalAppId,

            IsLicenseId
        }
        public frmShowLicense(int Id , enSlected slected = enSlected.LocalAppId)
        {
            InitializeComponent();

            if(slected == enSlected.LocalAppId)
            {
            LoadData(Id);
                    
            }else if(slected == enSlected.IsLicenseId)
            {

                IsLicenseId( Id);
            }
            
        }
      
        void IsLicenseId(int LicenseId)
        {
            clsLicenses licenses = clsLicenses.Find(LicenseId);
            if (licenses != null)
            {
               
                clsLocalDrivingLicenseApplications localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByApplicationID (licenses.ApplicationID);



                if(localDrivingLicenseApplications != null)
                {
                      LoadData(localDrivingLicenseApplications.LocalDrivingLicenseApplicationID);
                    
                }


            }
        }

        void LoadData(int LocalAppId)
        {
            _LocalAppId = LocalAppId;
            
            uCDriverLicenseInfo1.LoadData(LocalAppId);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uCDriverLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
