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

namespace DVLD___WindowsFormsApp.MyFroms.Person
{
    public partial class frmPersonDetails : Form
    {
        int _PersonId;

        void _FullPerson(int PersonId)
        {
            clsPeople Person = clsPeople.Find(PersonId);
            if(Person != null)
            {
                lab_PersonId.Text = Person.PersonID.ToString();
                lab_Name.Text=Person.FirstName.ToString() + " "+ Person.SecondName.ToString()+" " + Person.ThirdName.ToString()+ " " + Person.LastName.ToString();
                lab_NationalNO.Text = Person.NationalNo;
                lab_Gendor .Text = Person.Gendor;
                lab_Email .Text = Person.Email;
                lab_Address .Text = Person.Address;
                lab_DataOfBirth .Text = Person.DateOfBirth.ToShortDateString();
                lab_Phone.Text = Person.Phone;
                lab_Country.Text = Person.NationalityCountry;
                pB_Image.ImageLocation = Person.ImagePath;
               
            }


        }
        public frmPersonDetails(int PersonId)
        {
            InitializeComponent();
            _FullPerson(PersonId);
            _PersonId = PersonId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void lab_EditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdate frmAddUpdate = new frmAddUpdate(_PersonId);
            frmAddUpdate.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddUpdate_FormClosed);
            frmAddUpdate.ShowDialog();


        }

        private void FrmAddUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            _FullPerson(_PersonId);
        }
    }
}
