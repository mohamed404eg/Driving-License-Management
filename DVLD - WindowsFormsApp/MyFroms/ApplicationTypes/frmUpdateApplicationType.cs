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

namespace DVLD___WindowsFormsApp.MyFroms.ApplicationTypes
{
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationTypes applicationTypes;
        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _FullDate(ApplicationTypeID);
        }
        void _FullDate(int ApplicationTypeID)
        {
             applicationTypes = clsApplicationTypes.Find(ApplicationTypeID);

            if (applicationTypes != null)
            {
                lab_ID.Text = applicationTypes.ApplicationTypeId.ToString();
                tB_Title.Text = applicationTypes.ApplicationTypeTitle.ToString();
                tB_Fees.Text = applicationTypes.ApplicationTypeFees.ToString();

            }
            else
            {
                MessageBox.Show("Not Found");
                btn_Save.Enabled = false;
            }

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// update value in Object applicationTypes 
        /// this value of TextBOX
        /// </summary>
        void _UpdateValue()
        {

            applicationTypes.ApplicationTypeTitle = tB_Title.Text;
            applicationTypes.ApplicationTypeFees = Convert.ToDecimal(tB_Fees.Text);

        }

        /// <summary>
        /// check this value Vaild 
        /// </summary>
        /// <returns></returns>
        bool _CheckValue()
        {
            if (string.IsNullOrWhiteSpace(applicationTypes.ApplicationTypeTitle))
            {
                MessageBox.Show("Application Type Title not vaild");
                return false;
            }

            if (int.TryParse(applicationTypes.ApplicationTypeFees.ToString() , out int Fees))
            {
                if(Fees < 0)
                {
                    MessageBox.Show("Application Type Fess not vaild , Plase Enter Fess Upper of 0");
                    return false;

                }

                return true;
              
            }

            return true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            _UpdateValue();

            if (!_CheckValue()) return;

           if (applicationTypes.Save())
            {

                MessageBox.Show("Successfully Save");
            }
            else
            {
                MessageBox.Show("Faild Save");

            }
        }
    }
}
