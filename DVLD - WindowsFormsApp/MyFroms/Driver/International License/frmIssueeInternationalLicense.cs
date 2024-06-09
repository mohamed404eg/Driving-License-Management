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
    public partial class frmIssueeInternationalLicense : Form
    {
        int _LicenseId;
        public frmIssueeInternationalLicense()
        {
            InitializeComponent();
        }

        private void ucFindLicense1_MyCustomEvent(object sender, uC.UcFindLicense.MyCustomEventArgs e)
        {
            _LicenseId = e.Id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
