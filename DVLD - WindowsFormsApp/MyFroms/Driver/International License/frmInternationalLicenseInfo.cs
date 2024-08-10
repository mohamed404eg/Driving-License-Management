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
    public partial class frmInternationalLicenseInfo : Form
    {

         int _InternationalLicensesID = -1;
        public frmInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public frmInternationalLicenseInfo(int InternationalLicensesID)
        {
            InitializeComponent();
            _InternationalLicensesID=InternationalLicensesID;
            FullNewData(InternationalLicensesID);
        }

      public  void FullNewData(int InternationalLicensesID)
        {
            ucInternationalLicenseDriverInfo1.FillData(InternationalLicensesID);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
