namespace DVLD___WindowsFormsApp.MyFroms.Application.LocalApplication
{
    partial class frmNewLocalDrivingApplication
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ucFindPersonDetails1 = new DVLD___WindowsFormsApp.MyFroms.Person.UcFindPersonDetails();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CB_LicenseClass = new System.Windows.Forms.ComboBox();
            this.lab_Create_by = new System.Windows.Forms.Label();
            this.lab_App_Fees = new System.Windows.Forms.Label();
            this.lab_App_Date = new System.Windows.Forms.Label();
            this.lab_App_Id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 394);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ucFindPersonDetails1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(700, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucFindPersonDetails1
            // 
            this.ucFindPersonDetails1.Location = new System.Drawing.Point(35, 24);
            this.ucFindPersonDetails1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucFindPersonDetails1.Name = "ucFindPersonDetails1";
            this.ucFindPersonDetails1.Size = new System.Drawing.Size(610, 319);
            this.ucFindPersonDetails1.TabIndex = 0;
            this.ucFindPersonDetails1.DataBack += new DVLD___WindowsFormsApp.MyFroms.Person.UcFindPersonDetails.DataBackEventHandler(this.ucFindPersonDetails1_DataBack);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CB_LicenseClass);
            this.tabPage2.Controls.Add(this.lab_Create_by);
            this.tabPage2.Controls.Add(this.lab_App_Fees);
            this.tabPage2.Controls.Add(this.lab_App_Date);
            this.tabPage2.Controls.Add(this.lab_App_Id);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appliaction Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CB_LicenseClass
            // 
            this.CB_LicenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_LicenseClass.FormattingEnabled = true;
            this.CB_LicenseClass.Location = new System.Drawing.Point(187, 111);
            this.CB_LicenseClass.Name = "CB_LicenseClass";
            this.CB_LicenseClass.Size = new System.Drawing.Size(249, 28);
            this.CB_LicenseClass.TabIndex = 1;
            // 
            // lab_Create_by
            // 
            this.lab_Create_by.AutoSize = true;
            this.lab_Create_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Create_by.Location = new System.Drawing.Point(183, 178);
            this.lab_Create_by.Name = "lab_Create_by";
            this.lab_Create_by.Size = new System.Drawing.Size(27, 20);
            this.lab_Create_by.TabIndex = 0;
            this.lab_Create_by.Text = "??";
            // 
            // lab_App_Fees
            // 
            this.lab_App_Fees.AutoSize = true;
            this.lab_App_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_App_Fees.Location = new System.Drawing.Point(183, 145);
            this.lab_App_Fees.Name = "lab_App_Fees";
            this.lab_App_Fees.Size = new System.Drawing.Size(27, 20);
            this.lab_App_Fees.TabIndex = 0;
            this.lab_App_Fees.Text = "15";
            // 
            // lab_App_Date
            // 
            this.lab_App_Date.AutoSize = true;
            this.lab_App_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_App_Date.Location = new System.Drawing.Point(183, 77);
            this.lab_App_Date.Name = "lab_App_Date";
            this.lab_App_Date.Size = new System.Drawing.Size(71, 20);
            this.lab_App_Date.TabIndex = 0;
            this.lab_App_Date.Text = "??/??/??";
            // 
            // lab_App_Id
            // 
            this.lab_App_Id.AutoSize = true;
            this.lab_App_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_App_Id.Location = new System.Drawing.Point(194, 40);
            this.lab_App_Id.Name = "lab_App_Id";
            this.lab_App_Id.Size = new System.Drawing.Size(44, 20);
            this.lab_App_Id.TabIndex = 0;
            this.lab_App_Id.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "License Class:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Create By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Application Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Application Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L.Application ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Local Driving License Application";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(607, 496);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(121, 35);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(734, 496);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(121, 35);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmNewLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 533);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmNewLocalDrivingApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving Application";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Person.UcFindPersonDetails ucFindPersonDetails1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_LicenseClass;
        private System.Windows.Forms.Label lab_App_Fees;
        private System.Windows.Forms.Label lab_App_Date;
        private System.Windows.Forms.Label lab_App_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_Create_by;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
    }
}