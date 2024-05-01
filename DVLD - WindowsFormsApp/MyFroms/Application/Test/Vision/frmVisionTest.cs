using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Application.Test
{
    public partial class frmVisionTest : Form
    {
        public frmVisionTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uCdrivingAndAppInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmVisionTest_Load(object sender, EventArgs e)
        {
            uCdrivingAndAppInfo1.UpdateApplicationID(35);
            uCdrivingAndAppInfo1.LoadData();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
