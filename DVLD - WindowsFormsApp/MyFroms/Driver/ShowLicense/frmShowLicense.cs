using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Driver.ShowLicense
{
    public partial class frmShowLicense : Form
    {
        int _LocalAppId;
        public frmShowLicense()
        {
            InitializeComponent();
        }
        public frmShowLicense(int LocalAppId)
        {
            InitializeComponent();

            LoadData(LocalAppId);
        }

        void LoadData(int LocalAppId)
        {
            _LocalAppId = LocalAppId;
            
            uCDriverLicenseInfo1.LoadData(LocalAppId);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uCDriverLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
