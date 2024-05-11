
using DVLD___WindowsFormsApp.MyFroms.Application.LocalApplication;
using DVLD___WindowsFormsApp.MyFroms.Application.Test;
using DVLD___WindowsFormsApp.MyFroms.Application.Test.Vision;
using DVLD___WindowsFormsApp.MyFroms.Driver.List_Drivers;
using DVLD___WindowsFormsApp.MyFroms.Login;
using DVLD___WindowsFormsApp.MyFroms.ManageTestTypes;
using DVLD___WindowsFormsApp.MyFroms.Person;
using DVLD___WindowsFormsApp.MyFroms.Uesr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());


            // == test ===
            //Application.Run(new frmVisionTest(35,frmVisionTest.enTestType.VisionTest));
            //Application.Run(new frmListDrivers());
            // Application.Run(new frmManageLocalDrivingApplication());
        }
    }
}
