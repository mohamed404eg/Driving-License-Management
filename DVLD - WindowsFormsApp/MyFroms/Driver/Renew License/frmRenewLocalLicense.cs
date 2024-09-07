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
        public frmRenewLocalLicense()
        {
            InitializeComponent();
        }

        private void ucFindLicense1_MyCustomEvent(object sender, uC.UcFindLicense.MyCustomEventArgs e)
        {
            //license id MessageBox.Show(e.Id.ToString());




        }
    }
}
