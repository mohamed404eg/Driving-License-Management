using DVLD___BusinessPresentation;
using DVLD___WindowsFormsApp.MyFroms.Coustom_Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp.MyFroms.Person
{
    public partial class UcPersonInfo : UserControl
    {
        int _PersonId = -1;
        public UcPersonInfo()
        {
            InitializeComponent();
        }
        public UcPersonInfo(int PersonId)
        {
            InitializeComponent();
            _PersonId = PersonId;
            FullPerson(_PersonId);
        }

        // call to load Data and send PersonId
        public void FullPerson(int PersonId)
        {
            _PersonId = PersonId;

            clsPeople Person = clsPeople.Find(PersonId);
            if (Person != null)
            {
                lab_PersonId.Text = Person.PersonID.ToString();
                lab_Name.Text = Person.FirstName.ToString() + " " + Person.SecondName.ToString() + " " + Person.ThirdName.ToString() + " " + Person.LastName.ToString();
                lab_NationalNO.Text = Person.NationalNo;
                lab_Gendor.Text = Person.Gendor;
                lab_Email.Text = Person.Email;
                lab_Address.Text = Person.Address;
                lab_DataOfBirth.Text = Person.DateOfBirth.ToShortDateString();
                lab_Phone.Text = Person.Phone;
                lab_Country.Text = Person.NationalityCountry;
                pB_Image.ImageLocation = Person.ImagePath;

            }


        }
        private void lab_EditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_PersonId == -1)
            {
                return;
            }
            frmAddUpdate frmAddUpdate = new frmAddUpdate(_PersonId);
            frmAddUpdate.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddUpdate_FormClosed);
            frmAddUpdate.ShowDialog();


        }
        private void FrmAddUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {

            FullPerson(_PersonId);
        }

      
    }
}
