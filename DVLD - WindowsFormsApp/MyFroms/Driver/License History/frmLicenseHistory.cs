using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Driver;
using DVLD___BusinessPresentation.Driver.InternationalLicenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Driver.License_History
{
    public partial class frmLicenseHistory : Form
    {
        int _LocalAppId;
        public frmLicenseHistory()
        {
            InitializeComponent();
        }

        public frmLicenseHistory(int LocalAppId)
        {
            InitializeComponent();
            _LocalAppId = LocalAppId;
            LoadData();
        }

        void LoadData()
        {
            clsLocalDrivingLicenseApplications localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.Find(_LocalAppId);
            if(localDrivingLicenseApplications != null) { 
            ucPersonInfo1.FullPerson(localDrivingLicenseApplications.ApplicantPersonID);
            }

            clsDriver driver = clsDriver.FindByPersonID(localDrivingLicenseApplications.ApplicantPersonID);
            if(driver != null)
            {

                // load Data Grid View 
                // Local

                DGV_LicenseLocal.DataSource = clsLicenses.FindByDriverIDShort(driver.DriverID);



                // number of record
                lab_Recored_Local.Text = DGV_LicenseLocal.RowCount.ToString();

                // international
                DGV_LicenseInternational.DataSource = clsInternationalLicenses.FindByDriverID(driver.DriverID);
                // number of record

                lab_Records_International.Text = DGV_LicenseInternational.RowCount.ToString();





            }
        }

        private void Local_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lab_Records_International_Click(object sender, EventArgs e)
        {

        }

        private void lab_Recored_Local_Click(object sender, EventArgs e)
        {

        }
    }
}
