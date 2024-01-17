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
    public partial class UcFindPersonDetails : UserControl
    { 
        // Declare a delegate
        // if send Persion Id equal -1 then Person Not add
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;


        enum enFilterBy
        {
            PersonId,
            NationalNo,
           
        }


        void RestCb_FilterBy()
        {
            cb_FilterBy.SelectedIndex = (int)enFilterBy.PersonId;
        }
        public UcFindPersonDetails()
        {
            InitializeComponent();
            // select first item => PersonId
            RestCb_FilterBy();
        }

        void _Find()
        {
            enFilterBy FilterBy = (enFilterBy)cb_FilterBy.SelectedIndex;
            clsPeople Person = null;


             if (FilterBy == enFilterBy.PersonId)
            {
                 Person = clsPeople.Find(Convert.ToInt32(tb_FilterBy.Text));


            }
            else if (FilterBy == enFilterBy.NationalNo)
            {

                 Person = clsPeople.Find(tb_FilterBy.Text);
            }
         
      

            if (Person != null)
            {
                ucPersonInfo1._FullPerson(Person.PersonID);
                
                if(DataBack != null)
                {

                    DataBack.Invoke(this, Person.PersonID);
                }
            }
            else
            {
                MessageBox.Show("Not Found :)");
            }

        }


        /// <summary>
        /// this function active show details mode
        /// </summary>
        public void ShowDetails(object sender,int PersonId)
        {
            // full date this PeriosnId
            DataBackAddNewPersion( sender,  PersonId);


            // disabled button
            gB_Filter.Enabled = false;

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {

            _Find();

        }

        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdate frmAddUpdate = new frmAddUpdate();
            frmAddUpdate.DataBack += DataBackAddNewPersion;
            frmAddUpdate.ShowDialog();

        }


        private void DataBackAddNewPersion(object sender, int PersonId)
        {
            tb_FilterBy.Text = Convert.ToString(PersonId);

            // select first item => PersonId
            // if User Select Another Rest TO  Periosn Becose add Persion Id  
            RestCb_FilterBy();

            _Find();
          

        }

        private void tb_FilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            enFilterBy FilterBy = (enFilterBy)cb_FilterBy.SelectedIndex;

            // PersonId  enter only number
            if (FilterBy == enFilterBy.PersonId )
            {

                if (!Char.IsDigit(Convert.ToChar(e.KeyChar)) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;

                }
            }
        }
    }
}
