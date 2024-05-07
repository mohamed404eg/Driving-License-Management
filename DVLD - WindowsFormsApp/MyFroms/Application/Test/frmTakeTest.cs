using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___BusinessPresentation.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVLD___WindowsFormsApp.MyFroms.Application.Test
{
    public partial class frmTakeTest : Form
    {
        int _TestAppointmentId;
        clsTestAppointments _TestAppointment;

        public frmTakeTest()
        {
            InitializeComponent();
      
        }
        public frmTakeTest(int TestAppointmentId)
        {
            InitializeComponent();
            LoadData(TestAppointmentId);
        }


        void LoadData(int TestAppointmentId)
        {
            _TestAppointmentId = TestAppointmentId;

            // check if the test is
            clsTakeTest TakeTest = clsTakeTest.Find(TestAppointmentId);
            if (TakeTest != null)
            {
                ShowDataIsTaked(TakeTest);
               
            }

            _TestAppointment = clsTestAppointments.Find(TestAppointmentId);

            if (_TestAppointment == null) return ;
            ShowData();
        }




        void ShowDataIsTaked(clsTakeTest TakeTest)
        {
            // off button save
            btn_Save.Enabled = false;


            // Rido button
            RB_Pass.Enabled = false;
            RB_Fail.Enabled = false;

            lab_TestId.Text = TakeTest.TestID.ToString();

            // set result Rido button
            if(TakeTest.TestResult == true)
            {
                RB_Pass.Checked = true;
            }
            else
            {
                RB_Fail .Checked = true;
            }


            // notes
            RTB_Notes.Enabled = false;
            RTB_Notes.Text = TakeTest.Notes;



        }



        void ShowData()
        {

            lab_D_L_App_Id.Text = _TestAppointment.LocalDrivingLicenseApplicationID.ToString();

            //LocalDrivingLicenseApplication
            clsLocalDrivingLicenseApplications clsLocalDriving = clsLocalDrivingLicenseApplications.
                Find(_TestAppointment.LocalDrivingLicenseApplicationID);

            lab_D_Class.Text = clsLicenseClass.Find(clsLocalDriving.LicenseClassID).ClassName;

            lab_Name.Text = clsPeople.Find(clsLocalDriving.ApplicantPersonID).FullName();

            lab_Trial.Text = _TestAppointment.NumberOfTrial().ToString();

            lab_Date.Text = _TestAppointment.AppointmentDate.ToString();


            ShowLogo();
            ShowTitlBox();
        }
        void ShowLogo()
        {
            // Get resources from .resx file.
            ResourceManager resourceManager = new ResourceManager("DVLD___WindowsFormsApp.Resources.RImage", Assembly.GetExecutingAssembly());

            //Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");

            if (_TestAppointment.TestTypeID == 1)
            {

                pB_ImageTest.Image = (Bitmap)resourceManager.GetObject("vision_Test", new CultureInfo("en-US"));
            }
            else if (_TestAppointment.TestTypeID == 2)
            {
                pB_ImageTest.Image = (Bitmap)resourceManager.GetObject("writing__1_", new CultureInfo("en-US"));


            }
            else
            {
                pB_ImageTest.Image = (Bitmap)resourceManager.GetObject("car", new CultureInfo("en-US"));


            }



        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsTakeTest takeTest = new clsTakeTest();

            takeTest.TestAppointmentID = _TestAppointmentId;
            
                takeTest.TestResult = RB_Pass.Checked;
            takeTest.Notes = RTB_Notes.Text;
            //test
            takeTest.CreatedByUserID = 1;

            //            takeTest.CreatedByUserID = CurrentUser.User.UserID;


            Save(takeTest);
        }

        void Save(clsTakeTest takeTest)
        {
            if (MessageBox.Show("Are Sure Save","Save",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (takeTest.Save())
                {
                    MessageBox.Show("Successfully");

                    // update id
                    lab_TestId.Text = takeTest.TestID.ToString();

                    // close input after save
                    CloseAfterSave();
                }
                else
                {
                    MessageBox.Show("Faild");
                }
            }



        }



        void CloseAfterSave()
        {
            RB_Pass.Enabled = false;
            RB_Fail.Enabled = false;

            RTB_Notes.Enabled = false;

            btn_Save.Enabled = false;

        }




        void ShowTitlBox()
        {
            if (_TestAppointment.TestTypeID == 1)
            {

                GB_Detiles.Text = "Vision Test";
            }
            else if (_TestAppointment.TestTypeID == 2)
            {
                GB_Detiles.Text = "Written (Theory) Test";

            }
            else
            {
                GB_Detiles.Text = "Practical (Street) Test";

            }
        }











    }
}
