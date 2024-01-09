namespace DVLD___WindowsFormsApp.MyFroms.Person
{
    partial class frmAddUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdate));
            this.lab_Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_PrsonId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_NationalNo = new System.Windows.Forms.TextBox();
            this.tB_Second = new System.Windows.Forms.TextBox();
            this.tB_Third = new System.Windows.Forms.TextBox();
            this.tB_Last = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dTP_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.rdb_GendorMale = new System.Windows.Forms.RadioButton();
            this.rdb_GendorFemale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_Email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_Counties = new System.Windows.Forms.ComboBox();
            this.rtb_Address = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pB_Image = new System.Windows.Forms.PictureBox();
            this.tB_FirstName = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tB_Phone = new System.Windows.Forms.TextBox();
            this.OFD_Image = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lab_RemoveImage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Title
            // 
            this.lab_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.ForeColor = System.Drawing.Color.DarkRed;
            this.lab_Title.Location = new System.Drawing.Point(258, 49);
            this.lab_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(217, 31);
            this.lab_Title.TabIndex = 0;
            this.lab_Title.Text = "Add New Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person ID :";
            // 
            // lab_PrsonId
            // 
            this.lab_PrsonId.AutoSize = true;
            this.lab_PrsonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PrsonId.Location = new System.Drawing.Point(104, 95);
            this.lab_PrsonId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_PrsonId.Name = "lab_PrsonId";
            this.lab_PrsonId.Size = new System.Drawing.Size(35, 20);
            this.lab_PrsonId.TabIndex = 3;
            this.lab_PrsonId.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "National No:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gendor:*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 355);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Address:*";
            // 
            // tB_NationalNo
            // 
            this.tB_NationalNo.Location = new System.Drawing.Point(146, 231);
            this.tB_NationalNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_NationalNo.Name = "tB_NationalNo";
            this.tB_NationalNo.Size = new System.Drawing.Size(134, 20);
            this.tB_NationalNo.TabIndex = 5;
            this.tB_NationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tB_NationalNo_Validating);
            // 
            // tB_Second
            // 
            this.tB_Second.Location = new System.Drawing.Point(259, 188);
            this.tB_Second.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_Second.Name = "tB_Second";
            this.tB_Second.Size = new System.Drawing.Size(134, 20);
            this.tB_Second.TabIndex = 2;
            // 
            // tB_Third
            // 
            this.tB_Third.Location = new System.Drawing.Point(417, 188);
            this.tB_Third.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_Third.Name = "tB_Third";
            this.tB_Third.Size = new System.Drawing.Size(134, 20);
            this.tB_Third.TabIndex = 3;
            // 
            // tB_Last
            // 
            this.tB_Last.Location = new System.Drawing.Point(574, 191);
            this.tB_Last.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_Last.Name = "tB_Last";
            this.tB_Last.Size = new System.Drawing.Size(134, 20);
            this.tB_Last.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 225);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Date Of Birth:*";
            // 
            // dTP_DateOfBirth
            // 
            this.dTP_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP_DateOfBirth.Location = new System.Drawing.Point(460, 231);
            this.dTP_DateOfBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_DateOfBirth.Name = "dTP_DateOfBirth";
            this.dTP_DateOfBirth.Size = new System.Drawing.Size(149, 20);
            this.dTP_DateOfBirth.TabIndex = 6;
            // 
            // rdb_GendorMale
            // 
            this.rdb_GendorMale.AutoSize = true;
            this.rdb_GendorMale.Location = new System.Drawing.Point(108, 276);
            this.rdb_GendorMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_GendorMale.Name = "rdb_GendorMale";
            this.rdb_GendorMale.Size = new System.Drawing.Size(48, 17);
            this.rdb_GendorMale.TabIndex = 7;
            this.rdb_GendorMale.TabStop = true;
            this.rdb_GendorMale.Text = "Male";
            this.rdb_GendorMale.UseVisualStyleBackColor = true;
            // 
            // rdb_GendorFemale
            // 
            this.rdb_GendorFemale.AutoSize = true;
            this.rdb_GendorFemale.Location = new System.Drawing.Point(175, 276);
            this.rdb_GendorFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_GendorFemale.Name = "rdb_GendorFemale";
            this.rdb_GendorFemale.Size = new System.Drawing.Size(59, 17);
            this.rdb_GendorFemale.TabIndex = 8;
            this.rdb_GendorFemale.TabStop = true;
            this.rdb_GendorFemale.Text = "Female";
            this.rdb_GendorFemale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(356, 270);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Phone:*";
            // 
            // tB_Email
            // 
            this.tB_Email.Location = new System.Drawing.Point(99, 317);
            this.tB_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_Email.Name = "tB_Email";
            this.tB_Email.Size = new System.Drawing.Size(134, 20);
            this.tB_Email.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 311);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "Country:*";
            // 
            // cb_Counties
            // 
            this.cb_Counties.FormattingEnabled = true;
            this.cb_Counties.Location = new System.Drawing.Point(455, 315);
            this.cb_Counties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Counties.Name = "cb_Counties";
            this.cb_Counties.Size = new System.Drawing.Size(153, 21);
            this.cb_Counties.TabIndex = 11;
            // 
            // rtb_Address
            // 
            this.rtb_Address.Location = new System.Drawing.Point(121, 366);
            this.rtb_Address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtb_Address.Name = "rtb_Address";
            this.rtb_Address.Size = new System.Drawing.Size(486, 78);
            this.rtb_Address.TabIndex = 13;
            this.rtb_Address.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 476);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 476);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pB_Image
            // 
            this.pB_Image.InitialImage = ((System.Drawing.Image)(resources.GetObject("pB_Image.InitialImage")));
            this.pB_Image.Location = new System.Drawing.Point(640, 247);
            this.pB_Image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pB_Image.Name = "pB_Image";
            this.pB_Image.Size = new System.Drawing.Size(136, 170);
            this.pB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Image.TabIndex = 11;
            this.pB_Image.TabStop = false;
            // 
            // tB_FirstName
            // 
            this.tB_FirstName.Location = new System.Drawing.Point(106, 185);
            this.tB_FirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_FirstName.Name = "tB_FirstName";
            this.tB_FirstName.Size = new System.Drawing.Size(134, 20);
            this.tB_FirstName.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(663, 424);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 20);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Set Image";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(154, 158);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "First*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(298, 158);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Second*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(456, 158);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Third";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(608, 158);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Last*";
            // 
            // tB_Phone
            // 
            this.tB_Phone.Location = new System.Drawing.Point(455, 275);
            this.tB_Phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tB_Phone.Name = "tB_Phone";
            this.tB_Phone.Size = new System.Drawing.Size(152, 20);
            this.tB_Phone.TabIndex = 9;
            // 
            // OFD_Image
            // 
            this.OFD_Image.Filter = "Image|*.jpg;*.jpeg;*.png;";
            this.OFD_Image.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_Image_FileOk);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lab_RemoveImage
            // 
            this.lab_RemoveImage.AutoSize = true;
            this.lab_RemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_RemoveImage.Location = new System.Drawing.Point(663, 225);
            this.lab_RemoveImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_RemoveImage.Name = "lab_RemoveImage";
            this.lab_RemoveImage.Size = new System.Drawing.Size(68, 20);
            this.lab_RemoveImage.TabIndex = 12;
            this.lab_RemoveImage.TabStop = true;
            this.lab_RemoveImage.Text = "Remove";
            this.lab_RemoveImage.Visible = false;
            this.lab_RemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 543);
            this.Controls.Add(this.lab_RemoveImage);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pB_Image);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_Address);
            this.Controls.Add(this.cb_Counties);
            this.Controls.Add(this.rdb_GendorFemale);
            this.Controls.Add(this.rdb_GendorMale);
            this.Controls.Add(this.dTP_DateOfBirth);
            this.Controls.Add(this.tB_Email);
            this.Controls.Add(this.tB_Last);
            this.Controls.Add(this.tB_Phone);
            this.Controls.Add(this.tB_Third);
            this.Controls.Add(this.tB_FirstName);
            this.Controls.Add(this.tB_Second);
            this.Controls.Add(this.tB_NationalNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_PrsonId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(813, 582);
            this.MinimumSize = new System.Drawing.Size(813, 582);
            this.Name = "frmAddUpdate";
            this.Text = "frmAddUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_PrsonId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_NationalNo;
        private System.Windows.Forms.TextBox tB_Second;
        private System.Windows.Forms.TextBox tB_Third;
        private System.Windows.Forms.TextBox tB_Last;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dTP_DateOfBirth;
        private System.Windows.Forms.RadioButton rdb_GendorMale;
        private System.Windows.Forms.RadioButton rdb_GendorFemale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_Email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_Counties;
        private System.Windows.Forms.RichTextBox rtb_Address;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pB_Image;
        private System.Windows.Forms.TextBox tB_FirstName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tB_Phone;
        private System.Windows.Forms.OpenFileDialog OFD_Image;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel lab_RemoveImage;
    }
}