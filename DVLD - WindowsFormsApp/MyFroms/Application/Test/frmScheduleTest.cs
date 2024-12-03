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
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace DVLD___WindowsFormsApp.MyFroms.Application.Test.Vision
{
    public partial class frmScheduleTest : Form
    {
        int _LocalAppId;
        
        clsTestAppointments _tA;
        clsApplications _RetakeTestApplication;
        enum enMode
        {
            New,Update , IsLocked
               
        }
        enMode _Mode;

        // load TestAppointment from db
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

        void SetData(int LocalAppId, int TestType)
        {
            _tA = new clsTestAppointments();
            _LocalAppId = LocalAppId;
            _tA.TestTypeID = TestType;
            _Mode = enMode.New;

            _tA.LocalDrivingLicenseApplicationID = _LocalAppId;

            //_tA.CreatedByUserID = CurrentUser.User.UserID;
            // for test
            _tA.CreatedByUserID = 1;

        }
        public void LoadData(int LocalAppId, int TestType)
        {
            // set initl data
            SetData(LocalAppId,TestType);

            // show header logo
            ShowCustom();

            // set miniumum Date
            MiniDate();

            clsLocalDrivingLicenseApplications LDLApp = clsLocalDrivingLicenseApplications.Find(_LocalAppId);

            if(LDLApp != null )
            {
                ShowData(LDLApp);


            }
            // set fees on _tA
            SetFees(LDLApp);
            // set fees on screen
            
            ShowRetakeTest();



        }

        void ShowData(clsLocalDrivingLicenseApplications LDLApp)
        {
            lab_D_L_App_ID.Text = LDLApp.ApplicationID.ToString();
            labe_Dclass.Text = clsLicenseClass.Find(LDLApp.LicenseClassID).ClassName;
            lab_Trial.Text = clsTestAppointments.NumberOfTrial(LDLApp.LocalDrivingLicenseApplicationID,
                LDLApp.ApplicationTypeID).ToString();
            lab_Name.Text = clsPeople.Find(LDLApp.ApplicantPersonID).FullName();

        }
      
        void SetFees(clsLocalDrivingLicenseApplications LDLApp)
        {
            _tA.PaidFees += clsTestTypes.Find(_tA.TestTypeID).TestTypeFees;

            ShowFees(LDLApp);

            if (_tA.RetakeTest())
            {
                _tA.PaidFees += 5;
            }
        }
        void ShowLogo()
        {
            // Get resources from .resx file.
            ResourceManager resourceManager = new ResourceManager("DVLD___WindowsFormsApp.Resources.RImage", Assembly.GetExecutingAssembly());

            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
       
                if (_tA.TestTypeID == 1)
                {

                pB_Logo.Image =(Bitmap) resourceManager.GetObject("vision_Test", new CultureInfo("en-US"));
                }
                else if (_tA.TestTypeID == 2)
                {
                pB_Logo.Image = (Bitmap)resourceManager.GetObject("writing__1_", new CultureInfo("en-US"));


            }
            else
                {
                pB_Logo.Image = (Bitmap)resourceManager.GetObject("car", new CultureInfo("en-US"));
                

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
            lab_Fees.Text = _tA.PaidFees.ToString(("0.00"));
        }

         

        void ShowRetakeTest()
        {

            if (_tA.RetakeTest())
            {

                FeesRetake();

                // show RetakeTestApplicationID
                lab_R_Test_Id.Text = _tA.RetakeTestApplicationID.ToString();



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
            lab_TotalFees.Text = _tA.PaidFees.ToString(("0.00"));

        }
        void SetDateInAppointments()
        {
         
            _tA.AppointmentDate = DTP_Date.Value;
           

          



        }


        bool Full_RetakeTestApplication()
        {
            clsLocalDrivingLicenseApplications localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.Find(_LocalAppId);

          if(localDrivingLicenseApplications == null ) return false;

            _RetakeTestApplication = new clsApplications();

            _RetakeTestApplication.ApplicantPersonID = localDrivingLicenseApplications.ApplicantPersonID;
            _RetakeTestApplication.ApplicationDate = DateTime.Now;
            _RetakeTestApplication.ApplicationTypeID = 7; //Retake Test
            _RetakeTestApplication.ApplicationStatus = 3; // end
            _RetakeTestApplication.LastStatusDate = DateTime.Now;
            _RetakeTestApplication.PaidFees = clsApplicationTypes.Find(7).ApplicationTypeFees;
            _RetakeTestApplication.CreatedByUserID = CurrentUser.User.UserID;


            return _RetakeTestApplication.Save();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case enMode.New:
                    // load data to object
                    SetDateInAppointments(); 
                    break;

                case enMode.Update:

                    UpdateAppointments();
                    break;
            }
            

             
            void UddateRetakeTestApplicationIdInScreen()

            {
                lab_R_Test_Id.Text = _RetakeTestApplication.ApplicationID.ToString();




            }
          if (MessageBox.Show("Are sure Save","Save",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (_tA.RetakeTest())

                {

                  if(Full_RetakeTestApplication())
                    {
                        _tA.RetakeTestApplicationID = _RetakeTestApplication.ApplicationID;

                        UddateRetakeTestApplicationIdInScreen();
                    }
                    else
                    {
                        MessageBox.Show("error in function : Full_RetakeTestApplication() ");
                        return;
                    }
                }




                 if (_tA.Save()){

                    MessageBox.Show("Successfully Save");
                    IsIsLocked();

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

            ShowRetakeTest();

            lab_R_Test_Id.Text = _tA.TestAppointmentID.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
