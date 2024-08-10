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

namespace DVLD___WindowsFormsApp.MyFroms.Driver.International_License
{
    public partial class UcInternationalLicenseDriverInfo : UserControl
    {
        clsInternationalLicenses internationalLicenses = null;
        public UcInternationalLicenseDriverInfo()
        {
            InitializeComponent();
        }

     public   void FillData(int InternationalLicensesID)
        {
            internationalLicenses = clsInternationalLicenses.Find(InternationalLicensesID);
            if(internationalLicenses != null)
            {
                FillLable();
            }
        }

        void FillLable()
        {
            clsDriver driver = clsDriver.Find(internationalLicenses.DriverID);

            clsPeople people = clsPeople.Find(driver.PersonID);

            if (people == null || driver == null) return;


            // fill lable here
            lable_Name.Text = people.FullName();
            label_IntLicenseID.Text = internationalLicenses.InternationalLicenseID.ToString();
            label_LicenseID.Text = internationalLicenses.IssuedUsingLocalLicenseID.ToString();
            label_NationalNo.Text = people.NationalNo.ToString();
            label_Gendor.Text = people.Gendor.ToString();
            label_IssueDate.Text = internationalLicenses.IssueDate.ToShortDateString();
            label_ApplicationID.Text = internationalLicenses.ApplicationID.ToString();
            label_IsActive.Text = internationalLicenses.IsActive.ToString();
            label_DateOfBirth.Text = people.DateOfBirth.ToShortDateString();
            label_DriverID.Text = driver.DriverID.ToString();
            label_ExpirationDate.Text =internationalLicenses.ExpirationDate.ToShortDateString();



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
