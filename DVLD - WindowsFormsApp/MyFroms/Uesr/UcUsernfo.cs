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
  
    public partial class UcUsernfo : UserControl
    {
      
        clsUser User = null;
        public UcUsernfo()
        {
            InitializeComponent();
           
        }
        
        void _FullLable(clsUser User)
        {
            lab_UserId.Text = User.UserID.ToString();
            lab_UserName.Text = User.UserName.ToString();
            cB_IsActive.Checked = User.IsActive;
        }
      public  void _FullUser(int UserId)
        {
            User = clsUser.Find(UserId);
            if (User != null)
            {
                ucPersonInfo1.FullPerson(User.PersonID);

                _FullLable(User);

            }
        }
        private void ucPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
