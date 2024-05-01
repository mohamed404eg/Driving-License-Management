using DVLD___BusinessPresentation;
using DVLD___WindowsFormsApp.MyFroms.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___WindowsFormsApp
{

    enum enFilterBy
    {
        None,
PersonId,
NationalNo,
FirstName,
SecondName,
ThirdName,
LastName,
Nationality,
Gendor,
Phone,
Email,
    }
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
            //_UpdateDGV(enFilterBy.None);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // this first item => none
            tb_FilterBy.Visible = (cb_FilterBy.SelectedIndex != (int)enFilterBy.None);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            // select first item => none
            cb_FilterBy.SelectedIndex = (int)enFilterBy.None;
            _UpdateDGV(enFilterBy.None);
        }

        void _UpdateDGV(enFilterBy FilterBy)
        {
            if(tb_FilterBy.Text == "")
            {

             dgv_People.DataSource = clsPeople.GetAllPeople();
              

            }

           else if(FilterBy
                == enFilterBy.None)
            {

             dgv_People.DataSource = clsPeople.GetAllPeople();
            

            }
            else if (FilterBy == enFilterBy.PersonId)
            {
                clsPeople Person = clsPeople.Find(Convert.ToInt32(tb_FilterBy.Text));

                while (dgv_People.Rows.Count > 0)
                {
                    dgv_People.Rows.Remove(dgv_People.Rows[0]);
                }


                BindingSource bindingSource = new BindingSource();
                dgv_People.DataSource = bindingSource;


                if (Person != null)
                {
                    bindingSource.Add(Person);
                   bindingSource.ResetBindings(false);
                }



            }
            else if (FilterBy == enFilterBy.NationalNo)
            {

                clsPeople Person = clsPeople.Find(tb_FilterBy.Text);

                while (dgv_People.Rows.Count > 0)
                {
                    dgv_People.Rows.Remove(dgv_People.Rows[0]);
                }


                BindingSource bindingSource = new BindingSource();
                dgv_People.DataSource = bindingSource;


                if (Person != null)
                {
                    bindingSource.Add(Person);
                    bindingSource.ResetBindings(false);
                }


            }
            else if (FilterBy == enFilterBy.FirstName)
            {
                DataTable dt = clsPeople.FindByFirstName(tb_FilterBy.Text);

                dgv_People.DataSource = dt;

            }
            else if (FilterBy == enFilterBy.SecondName)
            {
                DataTable dt = clsPeople.FindBySecondName(tb_FilterBy.Text);

                dgv_People.DataSource = dt;

            }
            else if (FilterBy == enFilterBy.ThirdName)
            {
                DataTable dt = clsPeople.FindByThirdName(tb_FilterBy.Text);

                dgv_People.DataSource = dt;

            }
            else if (FilterBy == enFilterBy.LastName)
            {
                DataTable dt = clsPeople.FindByLastName(tb_FilterBy.Text);

                dgv_People.DataSource = dt;

            }
            else if (FilterBy == enFilterBy.Nationality)
            {
                DataTable dt = clsPeople.FindByNationalityCountry(tb_FilterBy.Text);

                dgv_People.DataSource = dt;

            }


            else if (FilterBy == enFilterBy.Gendor)
            {
                DataTable dt = clsPeople.FindByGendor(tb_FilterBy.Text);

                dgv_People.DataSource = dt;

            }
            else if (FilterBy == enFilterBy.Phone)
            {
                DataTable dt = clsPeople.FindByPhone(tb_FilterBy.Text);

                dgv_People.DataSource = dt;

            }
            else if (FilterBy == enFilterBy.Email)
            {
                DataTable dt = clsPeople.FindByEmail(tb_FilterBy.Text);

                dgv_People.DataSource = dt;

            }


            // update number rows
            lab_NumberRows.Text = dgv_People.RowCount.ToString();
        }

        /// <summary>
        /// update dgv_People
        /// </summary>
        void _UpdateDGV()
        {

            dgv_People.DataSource = clsPeople.GetAllPeople();
        }
        private void tb_FilterBy_TextChanged(object sender, EventArgs e)
        {
            enFilterBy IndexFilterBy = (enFilterBy)cb_FilterBy.SelectedIndex;


            //MessageBox.ShowCustom(cb_FilterBy.SelectedIndex.ToString());

         
            // send action update
           _UpdateDGV(IndexFilterBy);








            




        }

        private void tb_FilterBy_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void tb_FilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            enFilterBy FilterBy = (enFilterBy)cb_FilterBy.SelectedIndex;




            if (FilterBy == enFilterBy.PersonId) {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // set Handled from my not Handled by text box :)
                    e.Handled = true;

                }



            }



        }


        /// <summary>
        ///  Get first Cell In Row DataGridView
        /// </summary>
        /// <returns>value if successfully otherwise return -1 if not found</returns>
        int _GetfirstCellInRow()
        {
            object cellValue = null;
            if (dgv_People.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgv_People.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                DataGridViewCell firstCellInRow = selectedRow.Cells[0];
                 cellValue = firstCellInRow.Value;
            }
            if (cellValue != null)
            {
                return (int)cellValue;

            }
            else
            {
                return -1;
            }
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PersonId = _GetfirstCellInRow();
            if (PersonId != -1)
            {
               

                frmPersonDetails frmPersonDetails = new frmPersonDetails(PersonId);

                frmPersonDetails.FormClosed += new System.Windows.Forms.FormClosedEventHandler( this.Frm_Closed);


                frmPersonDetails.ShowDialog();

             
            }
          

               


            
        }

        /// <summary>
        /// event after close any from
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Closed(object sender, FormClosedEventArgs e)
        {
            _UpdateDGV();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdate frmAddUpdate = new frmAddUpdate();
            frmAddUpdate.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Closed);
            frmAddUpdate.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddUpdate frmAddUpdate = new frmAddUpdate();
            frmAddUpdate.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Closed);
            frmAddUpdate.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonId = _GetfirstCellInRow();

            if((PersonId != -1) && (clsPeople.DeletePerson(PersonId)))
            {
                MessageBox.Show("Successfully Delete");
            }
            else
            {
                MessageBox.Show("Faild Delete");
            }

            _UpdateDGV();

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implementations");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implementations");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonId = _GetfirstCellInRow();
            frmAddUpdate frmAddUpdate = new frmAddUpdate(PersonId);
            frmAddUpdate.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Closed);
            frmAddUpdate.ShowDialog();
        }
    }
}
