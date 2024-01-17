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

namespace DVLD___WindowsFormsApp.MyFroms.Uesr
{
    public partial class frmAddNewUserAndUpdate : Form
    {
        int _PersionId = -1;
        int _UserId = -1;
        enum enMode
        {Add 
                ,Update
            
        }
        enMode Mode;

        public frmAddNewUserAndUpdate()
        {
            InitializeComponent();
            ucFindPersonDetails1.DataBack  +=_DataBack;
            Mode = enMode.Add;
        }
        public frmAddNewUserAndUpdate(int PersionId , int UserId)
        {
            InitializeComponent();
        
            // Update
            Mode = enMode.Update;
            _PersionId = PersionId;
            _UserId = UserId;
            FullDate();
            _UpdateUi();
        }


        void _UpdateUi()
        {
            labTitle.Text = "Update User";
        }

        void FullDateUser()
        {
            clsUser User = clsUser.Find(_UserId);
            if(User != null)
            {
                lab_UserId.Text = User.UserID.ToString();
                tB_UserName .Text = User.UserName.ToString();
                tB_Password.Text = User.Password.ToString();
                tB_ConfirmPassword.Text = User.Password.ToString();
                cB_IsActive.Checked = User.IsActive;
            }
        }
        void FullDate()
        {
            ucFindPersonDetails1.ShowDetails(this, _PersionId);

            FullDateUser();
        }

        void _DataBack(object sender , int PersonId)
        {
            if (clsUser.IsExist(PersonId))
            {

            MessageBox.Show("this Person Alrady Has User");

            }

            _PersionId = PersonId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage_LoginInfo;
            tB_UserName.Focus();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tB_UserName_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(tB_UserName.Text) || string.IsNullOrWhiteSpace(tB_UserName.Text))
            {
                errorProvider_UserName.SetError(tB_UserName, "UserName is Required");

            }
            else
            {
                errorProvider_UserName.Clear();
            }
        }

        private void tB_Password_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tB_Password.Text) || string.IsNullOrWhiteSpace(tB_Password.Text))
            {
                errorProvider_Password.SetError(tB_Password, "Password is Required");

            }
            else
            {
                errorProvider_Password.Clear();
                _CheckConfirmEquail();
            }

        }

        bool _CheckConfirmEquail()
        {

            if (tB_Password.Text != tB_ConfirmPassword.Text)
            {
                errorProviderCofirmPassword.SetError(tB_ConfirmPassword, "Confirm Password not equail Password");

                return false;
            }
            else
            {
                errorProviderCofirmPassword.Clear();
                return true;
            }

        }
        private void tB_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tB_ConfirmPassword.Text) || string.IsNullOrWhiteSpace(tB_ConfirmPassword.Text))
            {
                errorProviderCofirmPassword.SetError(tB_ConfirmPassword, "Confirm Password is Required");

            }
            else
            {
                errorProviderCofirmPassword.Clear();
            }

            _CheckConfirmEquail();
        }

        private void tB_ConfirmPassword_Validated(object sender, EventArgs e)
        {
         }


        bool _DataOk()
        {
            // check if Selected Person 
            if (_PersionId == -1)
            {
                MessageBox.Show("Persion Not Selected, Please Selected Person Before Save");
                return false;
            }

            // check if this Person has User Already
            if (clsUser.IsExist(_PersionId))
            {

                MessageBox.Show("this Person Already Has User");
                return false;
            }


            if (clsUser.IsExist(tB_UserName.Text))
            {
                MessageBox.Show("UserName Exist Please Change");
                return false;
            }

            if (!_CheckConfirmEquail())
            {
                MessageBox.Show("Password and Confirm Not Equail");
                return false;

            }



            return true;
        }
        string GetFullName()
        {
            string FullName = "";
            clsPeople Persion = clsPeople.Find(_PersionId);
            if(Persion != null)
            {

                FullName += Persion.FirstName;
                FullName += " " + Persion.SecondName ;
                FullName += " " + Persion.ThirdName ;
                FullName += " " + Persion.LastName;
            }
            return FullName;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Add)
            {
            if (!_DataOk())
            {
                return;
            }


            clsUser User = new clsUser();
            User.PersonID = _PersionId;
            User.UserName = tB_UserName.Text;
            User.Password = tB_Password.Text;
            User.IsActive = cB_IsActive.Checked;

            if (User.Save())
            {
                MessageBox.Show("Successfully Save");
                lab_UserId.Text = User.UserID.ToString();
            }
            else
            {
                MessageBox.Show("Faild Save");

            }
        }




        }
    }
}
