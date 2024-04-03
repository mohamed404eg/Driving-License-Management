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

namespace DVLD___WindowsFormsApp.MyFroms.Application.LocalApplication
{
    public partial class frmManageLocalDrivingApplication : Form
    {
        public frmManageLocalDrivingApplication()
        {
            InitializeComponent();
            InitializeData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageLocalDrivingApplication_Load(object sender, EventArgs e)
        {

        }


        void InitializeData()
        {
            // dGV
            dGV.DataSource = clsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications_View();

            //Records
            labRecords.Text = dGV.RowCount.ToString(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingApplication frmNewApp = new frmNewLocalDrivingApplication();
            frmNewApp.FormClosed += FrmNewApp_FormClosed;
            frmNewApp.ShowDialog();
        }

        private void FrmNewApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            // update screen
            InitializeData();
        }
    }
}
