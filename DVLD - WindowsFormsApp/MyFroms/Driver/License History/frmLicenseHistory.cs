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



        }

    }
}
