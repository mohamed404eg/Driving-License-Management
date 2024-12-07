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
    public partial class frmViewLocalApplication : Form
    {
        public frmViewLocalApplication(int LocalApplicationId)
        {
            InitializeComponent();

            uCdrivingAndAppInfo1.LoadLocalApplication(LocalApplicationId);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uCdrivingAndAppInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
