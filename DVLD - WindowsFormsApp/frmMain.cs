using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void applToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        frmManagePeople frmManagePeople;
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (frmManagePeople == null || frmManagePeople.IsDisposed)
            {
                frmManagePeople = new frmManagePeople();
                frmManagePeople.MdiParent = this;
                frmManagePeople.FormClosed += FrmManagePeople_FormClosed;
                frmManagePeople.Show();
            }
            else
            {
                frmManagePeople.BringToFront();
            }
            

        }
        private void FrmManagePeople_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmManagePeople = null;
        }



    }
}
