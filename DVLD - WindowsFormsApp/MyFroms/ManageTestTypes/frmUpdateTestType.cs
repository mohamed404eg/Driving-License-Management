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

namespace DVLD___WindowsFormsApp.MyFroms.ManageTestTypes
{
    public partial class frmUpdateTestType : Form
    {
        clsTestTypes testTypes;
        public frmUpdateTestType()
        {
            InitializeComponent();
        }
        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();

            FullData(TestTypeID);

        }


        void FullData(int TestTypeID)
        {
             testTypes = clsTestTypes.Find(TestTypeID);
            if (testTypes != null) {
                lab_Id.Text= testTypes.TestTypeTypeID.ToString();
                tB_Title.Text = testTypes.TestTypeDescription;
                rTB_Description.Text = testTypes.TestTypeDescription;
                tB_Fees.Text = testTypes.TestTypeFees.ToString();
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool CheckDataBeforUpdate()
        {
            if(string.IsNullOrEmpty(tB_Title.Text) || string.IsNullOrWhiteSpace(tB_Title.Text)) {
                MessageBox.Show("Title not vaild");
            return false;
            };

            if (string.IsNullOrEmpty(rTB_Description.Text) || string.IsNullOrWhiteSpace(rTB_Description.Text)) {
                MessageBox.Show("Description not vaild");
                return false;

            }

            if (Convert.ToDecimal(tB_Fees.Text.ToString()) < 0)
            {
        
                MessageBox.Show("Fees not vaild");
                return false;

            }



            /// end check this successfully all condtions
            return true;
        }

        void UpdatetestTypes()
        {


            testTypes.TestTypeDescription = tB_Title.Text;
            testTypes.TestTypeDescription = rTB_Description.Text;
            testTypes.TestTypeFees = Convert.ToDecimal(tB_Fees.Text );

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!CheckDataBeforUpdate())
            {
                MessageBox.Show("Save Failed");
                return;

            }

            // update testTypes befor save
            UpdatetestTypes();

            if (testTypes != null && testTypes.Save())
            {
                MessageBox.Show("Save Successfully");
            }
            else
            {
                MessageBox.Show("Save Failed");
            }
        }
    }
}
