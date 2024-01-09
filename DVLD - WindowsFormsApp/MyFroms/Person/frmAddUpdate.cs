using DVLD___BusinessPresentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace DVLD___WindowsFormsApp.MyFroms.Person
{
    public partial class frmAddUpdate : Form
    {
        enum enMode
        {
            Add,
            Update
        }
        enMode Mode;
        clsPeople _Person;
        public frmAddUpdate()
        {
            InitializeComponent();
            frmAddUpdate_Load();
            Mode = enMode.Add;
        }


        void _LoadData(int PersonId)
        {
            _Person = clsPeople.Find(PersonId);
            if (_Person != null)
            {
              
              


                // fill
                lab_PrsonId.Text = _Person.PersonID.ToString();




                tB_FirstName.Text = _Person.FirstName.ToString();
                tB_Second.Text = _Person.SecondName;

                tB_Third.Text = _Person.ThirdName;

                tB_Last.Text = _Person.LastName;


           tB_NationalNo.Text = _Person.NationalNo;

                dTP_DateOfBirth.Value = _Person.DateOfBirth;

                if (_Person.Gendor == "Male"){
                    rdb_GendorMale.Checked = true;

                }
                else
                {
                    rdb_GendorFemale.Checked = true;
                }

                tB_Phone.Text = _Person.Phone;

                tB_Email.Text = _Person.Email;


                cb_Counties.SelectedIndex = cb_Counties.FindString(_Person.NationalityCountry);

                rtb_Address.Text = _Person.Address;
                OFD_Image.FileName = _Person.ImagePath;

                pB_Image.ImageLocation = OFD_Image.FileName;

                if (_Person.ImagePath != "")
                {
                    lab_RemoveImage.Visible = true;
                }


            }


            _ChnageAfterAdd(PersonId);
            tB_NationalNo.Enabled = false;

        }
        public frmAddUpdate(int PersonId)
        {
            InitializeComponent();
            frmAddUpdate_Load();
            Mode = enMode.Update;
      
            _LoadData(PersonId);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void _LoadCountries()
        {
            DataTable dataTable= clsCountries.GetCountries();

            foreach (DataRow item in dataTable.Rows)
            {
                cb_Counties.Items.Add(item["CountryName"]);
            }
        }

        private void frmAddUpdate_Load()
        {

            _LoadCountries();

            dTP_DateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void OFD_Image_FileOk(object sender, CancelEventArgs e)
        {
            pB_Image.ImageLocation = OFD_Image.FileName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OFD_Image.ShowDialog();
            if(OFD_Image.FileName != "")
            {
                lab_RemoveImage.Visible = true;
            }
        }

         bool _DataOk()
        {

            if (String.IsNullOrEmpty(tB_FirstName.Text))
            {
                errorProvider1.SetError(tB_FirstName, "First Name is Required");


                return false;

            }
            else
            {
                errorProvider1.Clear();

            }

            if (String.IsNullOrEmpty(tB_Second.Text))
            {
                errorProvider1.SetError(tB_Second, "Second Name is Required");


                return false;

            }
            else
            {
                errorProvider1.Clear();

            }
        
            if (String.IsNullOrEmpty(tB_Last.Text))
            {
                errorProvider1.SetError(tB_Last, "Last Name is Required");


                return false;

            }
            else
            {
                errorProvider1.Clear();

            }

            if (String.IsNullOrEmpty(tB_NationalNo.Text))
            {
                errorProvider1.SetError(tB_NationalNo, "National No is Required");


                return false;

            }
            else
            {
                errorProvider1.Clear();

            }



            if (!(rdb_GendorMale.Checked || rdb_GendorFemale.Checked))
            {
                errorProvider1.SetError(rdb_GendorMale, "Gendor  is Required");

                errorProvider1.SetError(rdb_GendorFemale, "Gendor  is Required");
                return false;

            }
            else
            {
                errorProvider1.Clear();

            }

            if (String.IsNullOrEmpty(tB_Phone.Text))
            {
                errorProvider1.SetError(tB_Phone, "Phone  is Required");

                return false;

            }
            else
            {
                errorProvider1.Clear();

            }





            if (cb_Counties.SelectedIndex == -1)
            {
                errorProvider1.SetError(cb_Counties, "Country  is Required");

                return false;

            }
            else
            {
                errorProvider1.Clear();

            }



            if (String.IsNullOrEmpty(rtb_Address.Text))
            {
                errorProvider1.SetError(rtb_Address, "Address  is Required");

                return false;

            }
            else
            {
                errorProvider1.Clear();

            }






            // most this last check
            if (!String.IsNullOrEmpty(tB_Email.Text))
            {
                string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

                Regex regex = new Regex(pattern);

                if(!regex.IsMatch(tB_Email.Text))
                {

                errorProvider1.SetError(tB_Email, "Email is invalid.");
                return false;

                }
                else
                {
                    errorProvider1.Clear();
                }



            }
            else
            {
                errorProvider1.Clear();

            }




            return true;
        }


        void _ChnageAfterAdd(int PersonId)
        {
            lab_PrsonId.Text = PersonId.ToString();
            lab_Title.Text = "Update Person";


        }



        bool _SaveCopyFile(OpenFileDialog FileName ,ref string FileNameCopy ) {

            if (FileName.FileName == "") return false;
            FileNameCopy = "P:/DVLD - Driving License Management/Temp/";

            FileNameCopy += Guid.NewGuid().ToString();
            FileNameCopy += Path.GetExtension(FileName.FileName);

            try
            {


                File.Copy(FileName.FileName, FileNameCopy,false);


                return true;


            }catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());

                return false;
            }

        
        
        
        }
        void _RemoveFile(string FileName)
        {
            if (FileName == "") return;
            File.Delete(FileName);
        }
        private void button2_Click(object sender, EventArgs e)
        {







            if (!_DataOk()) return;


            // copy of image before send && change url

            string FileName = "";
            if (_SaveCopyFile(OFD_Image,ref FileName))
            {
                OFD_Image.FileName = FileName;
            }





                //cheak data befor send 

                if (Mode == enMode.Add)
            {

                //add new
                _Person = new clsPeople();

                // fill value

                _Person.FirstName = tB_FirstName.Text;
                _Person.SecondName = tB_Second.Text;
                _Person.ThirdName = tB_Third.Text;
                _Person.LastName = tB_Last.Text;
                _Person.NationalNo = tB_NationalNo.Text;
                _Person.DateOfBirth = dTP_DateOfBirth.Value;
                _Person.Email = tB_Email.Text;
                if (rdb_GendorMale.Checked)
                {
                    _Person.Gendor = "Male";

                }
                else
                {
                    _Person.Gendor = "Female";
                }
                _Person.Phone = tB_Phone.Text;
                _Person.NationalityCountry = cb_Counties.Text;

                _Person.Address = rtb_Address.Text;
                _Person.ImagePath = OFD_Image.FileName;





                if (_Person.Save())
                {
                    MessageBox.Show("Add Successfully");
                    Mode = enMode.Update;
                    _ChnageAfterAdd(_Person.PersonID);

                }
                else
                {
                    MessageBox.Show("Add Faild");

                }


            }

            else
            {
                // udpate


                //update value
                _Person.FirstName = tB_FirstName.Text;
                _Person.SecondName = tB_Second.Text;
                _Person.ThirdName = tB_Third.Text;
                _Person.LastName = tB_Last.Text;
                _Person.NationalNo = tB_NationalNo.Text;
                _Person.DateOfBirth = dTP_DateOfBirth.Value;
                _Person.Email = tB_Email.Text;
                if (rdb_GendorMale.Checked)
                {
                    _Person.Gendor = "Male";

                }
                else
                {
                    _Person.Gendor = "Female";
                }
                _Person.Phone = tB_Phone.Text;
                _Person.NationalityCountry = cb_Counties.Text;

                _Person.Address = rtb_Address.Text;
                _Person.ImagePath = OFD_Image.FileName;
                
                if (_Person.Save())
                {
                    MessageBox.Show("Update Successfully");

                }
                else
                {
                    MessageBox.Show("Update Faild");

                }
            }



           
             


               




                }
            

    

    private void tB_NationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPeople.Find(tB_NationalNo.Text) != null)
            {
                errorProvider1.SetError(tB_NationalNo, "National No Already exist");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _RemoveFile(pB_Image.ImageLocation);
            OFD_Image.Reset();
            pB_Image.ImageLocation = "";
            lab_RemoveImage.Visible = false;

        }
    }
}
