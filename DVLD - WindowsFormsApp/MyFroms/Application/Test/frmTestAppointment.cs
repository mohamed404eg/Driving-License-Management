using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Test;
using DVLD___WindowsFormsApp.MyFroms.Application.Test.Vision;
using DVLD___WindowsFormsApp.MyFroms.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Application.Test
{
    public partial class frmTestAppointment : Form
    {
        int _LocalApplicationID;
    public    enum enTestType
        {
            VisionTest = 1, WrittenTest = 2, PracticalStreetTest = 3
        }

        enTestType _TestType;

        public frmTestAppointment()
        {
            InitializeComponent();
        }
        public frmTestAppointment(int LocalApplicationID , enTestType testType)
        {
            InitializeComponent();
            LoadData(LocalApplicationID , testType);
           
        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uCdrivingAndAppInfo1_Load(object sender, EventArgs e)
        {

        }

        private void frmVisionTest_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clsTestAppointments.haveTestAppointmentsSameStautsOnTestType(_LocalApplicationID,1,false) )
               
            {


                MessageBox.Show("Already Have TestAppointment , Please Take Test Before Create New One");

            } else if(clsTestAppointments.TopTestSuccessfullyAchving(_LocalApplicationID) >= (int)_TestType){

                MessageBox.Show("Already Successfully , Cannot Create New");

            }
            else
            {
            
            frmScheduleTest scheduleTest = new frmScheduleTest(_LocalApplicationID,(int)_TestType);
            scheduleTest.FormClosed += ScheduleTest_FormClosed;
            scheduleTest.ShowDialog();
            }
        }
        void LoadData(int LocalApplicationID , enTestType testType)
        {

            _LocalApplicationID = LocalApplicationID;

            _TestType = testType;




            ShowScreen();

        }
   
        void LoadDgv_Appointments()
        {
            dgv_Appointments.DataSource = clsTestAppointments.FindByLocalDrivingLicenseApplicationIdAndTestTypeID(_LocalApplicationID,(int) _TestType);
        }

        void SendLocalApplicationIDuCdrivingAndAppInfo()
        {
            // send LocalApplicationID to uCdrivingAndAppInfo1
            uCdrivingAndAppInfo1.UpdateApplicationID(_LocalApplicationID);
            uCdrivingAndAppInfo1.LoadData();
        }

        void ShowScreen()
        {
            
            // load datatable to dgv_Appointments
            LoadDgv_Appointments();

            ShowNumberRecords();

            // send LocalApplicationID to uCdrivingAndAppInfo1
            SendLocalApplicationIDuCdrivingAndAppInfo();

            ShowCoustom();
        }
        void ShowCoustom()
        {
            ShowLogo();
            ShowTitle();
            PageTitle();
        }
        void ShowLogo()
        {
            int TestType = (int)_TestType;
            // Get resources from .resx file.
            ResourceManager resourceManager = new ResourceManager("DVLD___WindowsFormsApp.Resources.RImage", Assembly.GetExecutingAssembly());

            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");

            if (TestType == 1)
            {

                PB_Logo.Image = (Bitmap)resourceManager.GetObject("vision_Test", new CultureInfo("en-US"));
            }
            else if (TestType == 2)
            {
                PB_Logo.Image = (Bitmap)resourceManager.GetObject("writing__1_", new CultureInfo("en-US"));


            }
            else
            {
                PB_Logo.Image = (Bitmap)resourceManager.GetObject("car", new CultureInfo("en-US"));


            }

        }
        void ShowTitle()
        {
            lab_Title.Text= lab_Title.Text.Insert(0, FactionTest.TitleBoxTest((int)_TestType)) ;
        }
        void ShowNumberRecords()
        {
            lab_Records .Text = dgv_Appointments.ColumnCount.ToString();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppomentId = Multi._GetfirstCellInRow(dgv_Appointments);

            if (TestAppomentId != -1)
            {
                frmTakeTest frmTake = new frmTakeTest(TestAppomentId);
                frmTake.FormClosed += ScheduleTest_FormClosed;
                frmTake.ShowDialog();

            }

        }

        void PageTitle()
        {

            this.Text = this.Text.Insert(0, FactionTest.TitleBoxTest((int)_TestType));

        
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppomentId = Multi._GetfirstCellInRow(dgv_Appointments);
            if(TestAppomentId != -1)
            {
                frmScheduleTest scheduleTest = new frmScheduleTest(TestAppomentId);
                scheduleTest.FormClosed += ScheduleTest_FormClosed;
                scheduleTest.ShowDialog();
            }

        }

        private void ScheduleTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            // update Load Dgv_Appointments
            LoadDgv_Appointments();
        }
    }
}
