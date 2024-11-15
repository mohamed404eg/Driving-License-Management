namespace DVLD___WindowsFormsApp.MyFroms.Driver.Detain_Licesne
{
    partial class frmDetainLicense
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
            this.ucFindLicense1 = new DVLD___WindowsFormsApp.MyFroms.Driver.uC.UcFindLicense();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_FineFees = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab_CreatedBy = new System.Windows.Forms.Label();
            this.lab_LicenesID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_FineFees = new System.Windows.Forms.Label();
            this.lab_DetainDate = new System.Windows.Forms.Label();
            this.lab_DetainID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Detain = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lLab_ShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lLab_ShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucFindLicense1
            // 
            this.ucFindLicense1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucFindLicense1.Location = new System.Drawing.Point(12, 41);
            this.ucFindLicense1.Name = "ucFindLicense1";
            this.ucFindLicense1.Size = new System.Drawing.Size(746, 464);
            this.ucFindLicense1.TabIndex = 0;
            this.ucFindLicense1.MyCustomEvent += new System.EventHandler<DVLD___WindowsFormsApp.MyFroms.Driver.uC.UcFindLicense.MyCustomEventArgs>(this.ucFindLicense1_MyCustomEvent);
            this.ucFindLicense1.Load += new System.EventHandler(this.ucFindLicense1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detain Licesne";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_FineFees);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lab_CreatedBy);
            this.groupBox1.Controls.Add(this.lab_LicenesID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lab_FineFees);
            this.groupBox1.Controls.Add(this.lab_DetainDate);
            this.groupBox1.Controls.Add(this.lab_DetainID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tB_FineFees
            // 
            this.tB_FineFees.Location = new System.Drawing.Point(162, 126);
            this.tB_FineFees.Name = "tB_FineFees";
            this.tB_FineFees.Size = new System.Drawing.Size(100, 21);
            this.tB_FineFees.TabIndex = 2;
            this.tB_FineFees.Text = "0";
            this.tB_FineFees.TextChanged += new System.EventHandler(this.tB_FineFees_TextChanged);
            this.tB_FineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_FineFees_KeyPress);
            this.tB_FineFees.MouseEnter += new System.EventHandler(this.tB_FineFees_MouseEnter);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD___WindowsFormsApp.Properties.Resources.user__1_;
            this.pictureBox5.Location = new System.Drawing.Point(497, 76);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD___WindowsFormsApp.Properties.Resources.drivers_license_24;
            this.pictureBox4.Location = new System.Drawing.Point(496, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD___WindowsFormsApp.Properties.Resources.money_24;
            this.pictureBox3.Location = new System.Drawing.Point(118, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD___WindowsFormsApp.Properties.Resources.schedule;
            this.pictureBox2.Location = new System.Drawing.Point(118, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD___WindowsFormsApp.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(118, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lab_CreatedBy
            // 
            this.lab_CreatedBy.AutoSize = true;
            this.lab_CreatedBy.Location = new System.Drawing.Point(544, 79);
            this.lab_CreatedBy.Name = "lab_CreatedBy";
            this.lab_CreatedBy.Size = new System.Drawing.Size(41, 15);
            this.lab_CreatedBy.TabIndex = 0;
            this.lab_CreatedBy.Text = "[????]";
            // 
            // lab_LicenesID
            // 
            this.lab_LicenesID.AutoSize = true;
            this.lab_LicenesID.Location = new System.Drawing.Point(544, 35);
            this.lab_LicenesID.Name = "lab_LicenesID";
            this.lab_LicenesID.Size = new System.Drawing.Size(41, 15);
            this.lab_LicenesID.TabIndex = 0;
            this.lab_LicenesID.Text = "[????]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(411, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Created By:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Licenes ID:";
            // 
            // lab_FineFees
            // 
            this.lab_FineFees.AutoSize = true;
            this.lab_FineFees.Location = new System.Drawing.Point(170, 123);
            this.lab_FineFees.Name = "lab_FineFees";
            this.lab_FineFees.Size = new System.Drawing.Size(0, 15);
            this.lab_FineFees.TabIndex = 0;
            // 
            // lab_DetainDate
            // 
            this.lab_DetainDate.AutoSize = true;
            this.lab_DetainDate.Location = new System.Drawing.Point(170, 85);
            this.lab_DetainDate.Name = "lab_DetainDate";
            this.lab_DetainDate.Size = new System.Drawing.Size(82, 15);
            this.lab_DetainDate.TabIndex = 0;
            this.lab_DetainDate.Text = "[???/???/???]";
            // 
            // lab_DetainID
            // 
            this.lab_DetainID.AutoSize = true;
            this.lab_DetainID.Location = new System.Drawing.Point(170, 35);
            this.lab_DetainID.Name = "lab_DetainID";
            this.lab_DetainID.Size = new System.Drawing.Size(41, 15);
            this.lab_DetainID.TabIndex = 0;
            this.lab_DetainID.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fine Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detain Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detain ID:";
            // 
            // btn_Detain
            // 
            this.btn_Detain.Enabled = false;
            this.btn_Detain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detain.Image = global::DVLD___WindowsFormsApp.Properties.Resources.air_conditioner_24px;
            this.btn_Detain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Detain.Location = new System.Drawing.Point(649, 689);
            this.btn_Detain.Name = "btn_Detain";
            this.btn_Detain.Size = new System.Drawing.Size(106, 35);
            this.btn_Detain.TabIndex = 3;
            this.btn_Detain.Text = "Detain";
            this.btn_Detain.UseVisualStyleBackColor = true;
            this.btn_Detain.Click += new System.EventHandler(this.btn_Detain_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = global::DVLD___WindowsFormsApp.Properties.Resources.air_conditioner_24px;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(521, 689);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(106, 35);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lLab_ShowLicenseHistory
            // 
            this.lLab_ShowLicenseHistory.AutoSize = true;
            this.lLab_ShowLicenseHistory.Enabled = false;
            this.lLab_ShowLicenseHistory.Location = new System.Drawing.Point(9, 700);
            this.lLab_ShowLicenseHistory.Name = "lLab_ShowLicenseHistory";
            this.lLab_ShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.lLab_ShowLicenseHistory.TabIndex = 6;
            this.lLab_ShowLicenseHistory.TabStop = true;
            this.lLab_ShowLicenseHistory.Text = "Show License History";
            this.lLab_ShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLab_ShowLicenseHistory_LinkClicked);
            // 
            // lLab_ShowNewLicenseInfo
            // 
            this.lLab_ShowNewLicenseInfo.AutoSize = true;
            this.lLab_ShowNewLicenseInfo.Enabled = false;
            this.lLab_ShowNewLicenseInfo.Location = new System.Drawing.Point(132, 700);
            this.lLab_ShowNewLicenseInfo.Name = "lLab_ShowNewLicenseInfo";
            this.lLab_ShowNewLicenseInfo.Size = new System.Drawing.Size(0, 13);
            this.lLab_ShowNewLicenseInfo.TabIndex = 7;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 736);
            this.Controls.Add(this.lLab_ShowLicenseHistory);
            this.Controls.Add(this.lLab_ShowNewLicenseInfo);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Detain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucFindLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDetainLicense";
            this.Text = "Detain License";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uC.UcFindLicense ucFindLicense1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_FineFees;
        private System.Windows.Forms.Label lab_DetainDate;
        private System.Windows.Forms.Label lab_DetainID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lab_CreatedBy;
        private System.Windows.Forms.Label lab_LicenesID;
        private System.Windows.Forms.Button btn_Detain;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.LinkLabel lLab_ShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lLab_ShowNewLicenseInfo;
        private System.Windows.Forms.TextBox tB_FineFees;
    }
}