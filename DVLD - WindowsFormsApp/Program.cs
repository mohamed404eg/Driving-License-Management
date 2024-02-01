
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
        }
    }
}
