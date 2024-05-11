using DVLD___BusinessPresentation.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Driver.List_Drivers
{
    public partial class frmListDrivers : Form
    {
        public frmListDrivers()
        {
            InitializeComponent();
            LoadData();
        }


        void LoadData()
        {
            DGV_Drivers.DataSource = clsDriver.GetAll();

            lab_Records.Text = DGV_Drivers.RowCount.ToString();

            CB_FilterBy.SelectedIndex = 0;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void DGV_Drivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
