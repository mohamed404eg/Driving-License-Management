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
using System.IO;
using Microsoft.Win32;
using DVLD___WindowsFormsApp.MyFroms.Application.LocalApplication;
namespace DVLD___WindowsFormsApp.MyFroms.Login
{
    public partial class frmLogin : Form
    {
       

        void _LoadValueRegistry()
        {
            string savedPassword = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\DVLD", "Password", null);
            string savedUsername = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\DVLD", "Username", null);

            if(savedUsername != null)
            {
                tB_UserName.Text = savedUsername;
                cB_RememberMe.Checked = true;
            }
            if (savedPassword != null)
            {
                tB_Pass.Text = savedPassword;
            }
        }
        public frmLogin()
        {
            InitializeComponent();
            btn_close.FlatAppearance.MouseOverBackColor = btn_close.BackColor;

            // load value of Registry
            _LoadValueRegistry();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
          
           
        }

        private void btn_close_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {


            CurrentUser.User = clsUser.Find(tB_UserName.Text, tB_Pass.Text);


            if(CurrentUser.User != null )
            {

                MessageBox.Show("Successfully");

                // and User Is Active
                if(CurrentUser.User.IsActive == true)
                {
                    // show next form

                    //frmMain frmMain = new frmMain();
                    //frmMain.Show();
                    //this.Hide();



                    // Test

                    frmManageLocalDrivingApplication ManageLocalDrivingApplication = new frmManageLocalDrivingApplication();
                    ManageLocalDrivingApplication.Show();
                    this.Hide();


                }
                else
                {

                     MessageBox.Show("User Is Not Active");

                }


            }
            else
            {
                MessageBox.Show("Faild");

            }

            _RememberMe();
        }

        void _RememberMe()
        {
            if (cB_RememberMe.Checked)
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\DVLD");

                key.SetValue("Username", tB_UserName.Text);
                key.SetValue("Password", tB_Pass.Text);
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\DVLD");

                try
                {
                key.DeleteValue("Username");

                key.DeleteValue("Password");
                }catch(Exception ex)
                {

                }
            }
        }

        private void cB_RememberMe_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
