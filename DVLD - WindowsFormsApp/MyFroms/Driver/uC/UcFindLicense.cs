using DVLD___BusinessPresentation;
using DVLD___BusinessPresentation.Applications.LicenseClass;
using DVLD___BusinessPresentation.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Driver.uC
{
    public partial class UcFindLicense : UserControl
    {


        public class MyCustomEventArgs : EventArgs
        {
         //   public enum enNotAllowed
         //   {
         //       NotActive,
         //       ExpDate,
         //       Good
         //   }
         //public   enNotAllowed notAllowed { get; }

            public int Id { get; }

            public MyCustomEventArgs(int _Id)
            {
                Id = _Id;
              
            }

        }

        public event EventHandler<MyCustomEventArgs> MyCustomEvent;

        protected virtual void OnMyCustomEvent(MyCustomEventArgs e)
        {
            MyCustomEvent?.Invoke(this, e);
        }

        public UcFindLicense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LienseId = (int.Parse(textBox1.Text));

            clsLicenses licenses = clsLicenses.Find(LienseId);

            if (licenses != null) {

                // licenses.ApplicationID;
                clsLocalDrivingLicenseApplications localDrivingLicenseApplications = clsLocalDrivingLicenseApplications.FindByApplicationID(licenses.ApplicationID);

                if (localDrivingLicenseApplications != null) {
                    // take local appliacttion id
                    ucFindLicensenfo.LoadData(localDrivingLicenseApplications.LocalDrivingLicenseApplicationID);
                    // Raise the custom event when a button is clicked
                    OnMyCustomEvent(new MyCustomEventArgs(int.Parse(textBox1.Text)));

                }



            }
            else
            {
                MessageBox.Show("Not Found licenses");
            }
           



        }

        private void UcFindLicense_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
