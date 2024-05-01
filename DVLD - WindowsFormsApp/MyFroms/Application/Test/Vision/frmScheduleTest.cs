using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___BusinessPresentation.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD___WindowsFormsApp.MyFroms.Application.Test.Vision
{
    public partial class frmScheduleTest : Form
    {
        int _LocalAppId;
        
        clsTestAppointments _tA;

        enum enMode
        {
            New,Update , IsLocked

        }
        enMode _Mode;

        public frmScheduleTest(int TestAppointmentId)
        {
            InitializeComponent();
            LoadDataUpdate( TestAppointmentId);

        }

        public frmScheduleTest()
        {
            InitializeComponent();
        }

        public frmScheduleTest(int LocalAppId, int TestType)
        {
            InitializeComponent();
          
            LoadData(LocalAppId,TestType);
        }

        public void LoadData(int LocalAppId, int TestType)
        {
            _tA = new clsTestAppointments();
            _LocalAppId = LocalAppId;
            _tA.TestTypeID = TestType;
            _Mode = enMode.New;

            // show header logo
            ShowCustom();

            // set miniumum Date
            MiniDate();

            clsLocalDrivingLicenseApplications LDLApp = clsLocalDrivingLicenseApplications.Find(_LocalAppId);

            if(LDLApp != null )
            {
                lab_D_L_App_ID.Text = LDLApp.ApplicationID.ToString();
                labe_Dclass.Text = clsLicenseClass.Find(LDLApp.LicenseClassID).ClassName;
                lab_Trial.Text = clsTestAppointments.NumberOfTrial(LDLApp.LocalDrivingLicenseApplicationID,
                    LDLApp.ApplicationTypeID).ToString();
                 
                
            }
            // set fees on screen
            ShowFees(LDLApp);
            ShowRetakeTest(LDLApp);



        }

      
        void ShowLogo()
        {
              const string resxFile = @".\frmScheduleTest.resx";
            // Get resources from .resx file.
            using (ResXResourceSet resxSet = new ResXResourceSet(resxFile))
            {
                if (_tA.TestTypeID == 1)
                {
                 
                    pB_Logo.Image = (Bitmap)resxSet.GetObject("shared-vision (1)", true);
                }else if (_tA.TestTypeID == 2)
                {
                    pB_Logo.Image = (Bitmap)resxSet.GetObject("writing", true);

                }
                else
                {
                    pB_Logo.Image = (Bitmap)resxSet.GetObject("vehicles", true);

                }

            }

        }

        void ShowCustom()
        {
            ShowLogo();
            ShowTitlBox();
        }

        void ShowTitlBox()
        {
            if (_tA.TestTypeID == 1)
            {

                groupBox1.Text = "Vision Test";
            }
            else if (_tA.TestTypeID == 2)
            {
                groupBox1.Text = "Written (Theory) Test";

            }
            else
            {
                groupBox1.Text = "Practical (Street) Test";

            }
        }

        void MiniDate()
        {
            DTP_Date.MinDate = DateTime.Now;
        }

        void ShowFees(clsLocalDrivingLicenseApplications LDLApp)
        {
            // fees of Test TestAppointment (diif of fees of application) by type of the test not type application
            lab_Fees.Text = clsTestTypes.Find(_tA.TestTypeID).ToString();
        }

         

        void ShowRetakeTest(clsLocalDrivingLicenseApplications LDLApp)
        {
            bool isRetake =  clsTestAppointments.haveTestAppointmentsSameStautsOnTestType(LDLApp.LocalDrivingLicenseApplicationID, _tA.TestTypeID, false);

            if (isRetake)
            {

                FeesRetake();




            }
            else
            {
                GB_RetakeTest.Enabled = false;
            }


        }

        void FeesRetake()
        {
            GB_RetakeTest.Enabled = true;

            // set fees of retake
            lab_R_Fees.Text = "5";

           
            // _tA.PaidFees += 5; paidfess fees update auto in class

            // update fees on screen
            lab_TotalFees.Text += (Convert.ToInt32(lab_Fees.Text) + 5).ToString();

        }
        void SetDataInAppointments()
        {
            _tA.LocalDrivingLicenseApplicationID = _LocalAppId;
            _tA.AppointmentDate = DTP_Date.Value;
            _tA.PaidFees += clsTestTypes.Find(_tA.TestTypeID).TestTypeFees;

            //_tA.CreatedByUserID = CurrentUser.User.UserID;
            // for test
            _tA.CreatedByUserID = 1;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case enMode.New:
                    // load data to object
                    SetDataInAppointments(); 
                    break;

                case enMode.Update:

                    UpdateAppointments();
                    break;
            }
            

          if (MessageBox.Show("Are sure Save","Save",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (_tA.Save())
                {
                    MessageBox.Show("Successfully Save");
                }
                else
                {
                    MessageBox.Show("Filad Save");
                }
            }


        }

        void UpdateAppointments()
        {
            _tA.AppointmentDate = DTP_Date.Value;
        }

        void IsIsLocked()
        {
            groupBox1.Enabled = false;
            btn_Save.Enabled = false;

            // show text lab_IsLocked
            lab_IsLocked.Visible = true;
        }

        void LoadDataUpdate(int TestAppointmentId)
        {
            _tA = clsTestAppointments.Find(TestAppointmentId);

            // show
            ShowCustom();

            if (_tA.IsLocked)
            {
                IsIsLocked();

            }
            else
            {

            _Mode = enMode.Update;

            }

            // load Appointments
            ShowDataUpdate();


        }

        void ShowDataUpdate()
        {
            clsLocalDrivingLicenseApplications LocalDriving = clsLocalDrivingLicenseApplications.Find(
                    _tA.LocalDrivingLicenseApplicationID);

            lab_D_L_App_ID.Text = _tA._LocalDrivingLicenseApplicationID.ToString();

            labe_Dclass.Text = clsLicenseClass.Find(LocalDriving.LicenseClassID).ClassName;

            lab_Name.Text = clsPeople.Find(LocalDriving.ApplicantPersonID).FullName();

            lab_Trial.Text = clsTestAppointments.NumberOfTrial(LocalDriving.LocalDrivingLicenseApplicationID,
                  LocalDriving.ApplicationTypeID).ToString();

            DTP_Date.Value = _tA.AppointmentDate;

            lab_Fees.Text = _tA.PaidFees.ToString();

            ShowRetakeTest(LocalDriving);

            lab_R_Test_Id.Text = _tA.TestAppointmentID.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
