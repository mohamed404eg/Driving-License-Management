using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Driver;
using DVLD___BusinessPresentation.Driver.InternationalLicenses;
using DVLD___WindowsFormsApp.MyFroms.Driver.International_License;
using DVLD___WindowsFormsApp.MyFroms.Functions;
using DVLD___WindowsFormsApp.MyFroms.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Application.International
{
    public partial class frmManageInternationalDrivingApplication : Form
    {
        public frmManageInternationalDrivingApplication()
        {
            InitializeComponent();
            FullGridView();
            SetDefiltFilterNone();
            SetNumberRecords();
        }


        void FullGridView()
        {
            dataGridView1.DataSource = clsInternationalLicenses.GetAll();
        }
        void RestFullGridView()
        {
            FullGridView();
        }
        void SetDefiltFilterNone()
        {
            comboBox1.SelectedIndex = 0;
            FullGridView();
            SetNumberRecords();
          

        }
        void SetNumberRecords()
        {
            lab_CountRecords.Text = dataGridView1.RowCount.ToString();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frmIssueeInternationalLicense frmIssueeInternationalLicense = new frmIssueeInternationalLicense();
            frmIssueeInternationalLicense.FormClosed += FrmIssueeInternationalLicense_FormClosed;
            frmIssueeInternationalLicense.ShowDialog();

        }


        private void FrmIssueeInternationalLicense_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetDefiltFilterNone();
        

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {

                TbFiterValue.Enabled = true;





            }
            else
            {
                TbFiterValue.Enabled = false;
                RestFullGridView();
                TbFiterValue.Text = string.Empty;
            }
        }

        private void TbFiterValue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TbFiterValue.Text, out int InternationalLicenseID))
            {

                dataGridView1.DataSource = clsInternationalLicenses.FindRdataTable(InternationalLicenseID);
            }
            if (string.IsNullOrEmpty(TbFiterValue.Text))
            {
                RestFullGridView();

            }
        }

        private void showPersonLicenseHistorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showPersonDerailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverId = Multi._GetByIndextCellInRow(dataGridView1, 2);
            if (DriverId != -1)
            {
                clsDriver driver = clsDriver.Find(DriverId);
                if (driver != null)
                {
                    frmPersonDetails frmPersonDetails = new frmPersonDetails(driver.PersonID);
                    frmPersonDetails.ShowDialog();


                }


                // MessageBox.Show(Multi._GetByIndextCellInRow(dataGridView1, 2).ToString());

            }
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
