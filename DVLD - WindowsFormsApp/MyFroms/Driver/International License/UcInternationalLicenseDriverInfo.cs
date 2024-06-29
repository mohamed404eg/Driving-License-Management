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

namespace DVLD___WindowsFormsApp.MyFroms.Driver.International_License
{
    public partial class UcInternationalLicenseDriverInfo : UserControl
    {
        clsInternationalLicenses internationalLicenses = null;
        public UcInternationalLicenseDriverInfo()
        {
            InitializeComponent();
        }

        void FillData(int InternationalLicensesID)
        {
            internationalLicenses = clsInternationalLicenses.Find(InternationalLicensesID);
            if(internationalLicenses != null)
            {
                FillLable();
            }
        }

        void FillLable()
        {
            // fill lable here

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
