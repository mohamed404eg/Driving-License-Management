using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Driver;
using DVLD___BusinessPresentation.Driver.Detain;
using DVLD___WindowsFormsApp.MyFroms.Driver.Detain_Licesne;
using DVLD___WindowsFormsApp.MyFroms.Driver.License_History;
using DVLD___WindowsFormsApp.MyFroms.Driver.Release_Detain_Licenses;
using DVLD___WindowsFormsApp.MyFroms.Driver.ShowLicense;
using DVLD___WindowsFormsApp.MyFroms.Functions;
using DVLD___WindowsFormsApp.MyFroms.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Driver.Detain.Manage_Detain_License
{
    public partial class frmManageDetainLicenses : Form
    {
        enum enFilterBySelectedIndex
        {
            None,
            DetainID,
            IsReleased,
            NationalNo,
            FullName,
            ReleaseApplicationID

        }

        enFilterBySelectedIndex filterBySelectedIndex = enFilterBySelectedIndex.None;
        public frmManageDetainLicenses()
        {
            InitializeComponent();
            LoadData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        void LoadData()
        {
            cB_FilterBy.SelectedIndex = 0;
            dG_ManageDetain.DataSource = clsDetain.GetAll();
        }


      
        private void cB_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (cB_FilterBy.SelectedIndex) {

                case (int)enFilterBySelectedIndex.None:
                    filterBySelectedIndex = enFilterBySelectedIndex.None;
                    BySelectedIndexNone();
                    break;

                case (int)enFilterBySelectedIndex.DetainID:
                    filterBySelectedIndex = enFilterBySelectedIndex.DetainID;
                    SelectedIndexDetainID();
                    break;

                case (int)enFilterBySelectedIndex.IsReleased:
                    filterBySelectedIndex = enFilterBySelectedIndex.IsReleased;
                    SelectedIndexIsReleased();
                    break;

                case (int)enFilterBySelectedIndex.NationalNo:
                    filterBySelectedIndex = enFilterBySelectedIndex.NationalNo;
                    SelectedIndexNationalNo();
                    break;
                case (int)enFilterBySelectedIndex.FullName:
                    filterBySelectedIndex = enFilterBySelectedIndex.FullName;
                    SelectedIndexFullName();
                    break;
                case (int)enFilterBySelectedIndex.ReleaseApplicationID:
                    filterBySelectedIndex = enFilterBySelectedIndex.ReleaseApplicationID;
                    SelectedIndexReleaseApplicationID();
                    break;
            
            }


        }






        void BySelectedIndexNone()
        {
            dG_ManageDetain.DataSource = clsDetain.GetAll();

            rB_IsReleaseVisible();
            tB_FilterByVisible();

        }

        void SelectedIndexIsReleased()
        {
            rB_IsReleaseVisible(true,true);
            tB_FilterByVisible();
        }

        void SelectedIndexDetainID()
        {
            tB_FilterByVisible(true);
            rB_IsReleaseVisible();

        }
        void SelectedIndexNationalNo()
        {
            tB_FilterByVisible(true);
            rB_IsReleaseVisible();

        }

        void SelectedIndexFullName()
        {
            tB_FilterByVisible(true);
            rB_IsReleaseVisible();

        }

        void SelectedIndexReleaseApplicationID()
        {
            tB_FilterByVisible(true);
            rB_IsReleaseVisible();

        }

        void tB_FilterByVisible(bool isVisible = false)
        {
            tB_FilterBy.Visible = isVisible;
        }

        void rB_IsReleaseVisible(bool OneisVisible = false, bool SecondisVisible = false)
        {
            rB_IsReleasedTrue.Visible = OneisVisible;

            rB_IsReleaseNo.Visible = SecondisVisible;

        }


        void TextBoxIsNullOrEmpty()
        {
            dG_ManageDetain.DataSource = clsDetain.GetAll();


        }
        private void tB_FilterBy_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tB_FilterBy.Text))
            {
                TextBoxIsNullOrEmpty();

                return;

            }

            switch (filterBySelectedIndex)
            {

                case enFilterBySelectedIndex.DetainID:

                    dG_ManageDetain.DataSource = clsDetain.FindByDetainIdDataTable(int.Parse(tB_FilterBy.Text));

                    break;


                case enFilterBySelectedIndex.NationalNo:
                    dG_ManageDetain.DataSource = clsDetain.FindByNationalNoDataTable(tB_FilterBy.Text);

                    break;
                case enFilterBySelectedIndex.FullName:
                    dG_ManageDetain.DataSource = clsDetain.FindByFullNameDataTable(tB_FilterBy.Text);
                    break;
                case enFilterBySelectedIndex.ReleaseApplicationID:

                    dG_ManageDetain.DataSource = clsDetain.FindByReleaseApplicationIdDataTable(int.Parse(tB_FilterBy.Text));

                    break;



            }


        }

        private void rB_IsReleasedTrue_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton.Checked){

                dG_ManageDetain.DataSource = clsDetain.FindByIsReleaseDataTable(true);
                
            }



        }

        private void rB_IsReleaseNo_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton.Checked)
            {

                dG_ManageDetain.DataSource = clsDetain.FindByIsReleaseDataTable(false);

            }
        }










        void lab_RecordsUpdate()
        {
            lab_Records.Text = dG_ManageDetain.RowCount.ToString();
        }

        private void dG_ManageDetain_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void dG_ManageDetain_DataSourceChanged(object sender, EventArgs e)
        {
            lab_RecordsUpdate();
        }

        private void btn_Release_Click(object sender, EventArgs e)
        {
            frmReleaseDetainLicenses releaseDetainLicenses = new frmReleaseDetainLicenses();
            
            releaseDetainLicenses.ShowDialog();

        }

        private void btn_Detain_Click(object sender, EventArgs e)
        {
            frmDetainLicense detainLicense = new frmDetainLicense();

            detainLicense.ShowDialog();


        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string NationalNo = Multi._GetStringByIndextCellInRow(dG_ManageDetain, 6);

            if(NationalNo != null)
            {
                clsPeople people = clsPeople.Find(NationalNo);
                if(people != null)
                {
                frmPersonDetails personDetails = new frmPersonDetails(people.PersonID);
                personDetails.ShowDialog();
                
                     }



            }

        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseId = Multi._GetByIndextCellInRow(dG_ManageDetain, 1);

            if(LicenseId != -1)
            {
               

                frmShowLicense showLicense = new frmShowLicense(LicenseId,frmShowLicense.enSlected.IsLicenseId);

                showLicense.ShowDialog();

                
            
            }
        }

        private void showPersonLicesneHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseId = Multi._GetByIndextCellInRow(dG_ManageDetain, 1);

            clsLicenses licenses = clsLicenses.Find(LicenseId);
            if(licenses != null)
            {

            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(-1, licenses.DriverID,false);
                frmLicenseHistory.ShowDialog();

            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LicenseId = Multi._GetByIndextCellInRow(dG_ManageDetain, 1);

            bool isdetain = clsDetain.IsAlreadyExistsFindByLicenseID(LicenseId);
            // if true so is not Released
            if(isdetain)
            {
                releaseDateinedLicenseToolStripMenuItem.Enabled = true;
            }
            else
            {
                releaseDateinedLicenseToolStripMenuItem.Enabled = false;
            }


        }

        private void releaseDateinedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LicenseId = Multi._GetByIndextCellInRow(dG_ManageDetain, 1);

            frmReleaseDetainLicenses frmReleaseDetain = new frmReleaseDetainLicenses(LicenseId);

            frmReleaseDetain.ShowDialog();

        }

        /// end
    } }







 

