namespace DVLD___WindowsFormsApp.MyFroms.Uesr
{
    partial class frmAddNewUserAndUpdate
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
            this.labTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersonInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ucFindPersonDetails1 = new DVLD___WindowsFormsApp.MyFroms.Person.UcFindPersonDetails();
            this.tabPage_LoginInfo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cB_IsActive = new System.Windows.Forms.CheckBox();
            this.tB_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.tB_UserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_UserId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.errorProvider_UserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCofirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.PersonInfo.SuspendLayout();
            this.tabPage_LoginInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCofirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.labTitle.Location = new System.Drawing.Point(334, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(425, 69);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Add New User";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonInfo);
            this.tabControl1.Controls.Add(this.tabPage_LoginInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 122);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 619);
            this.tabControl1.TabIndex = 1;
            // 
            // PersonInfo
            // 
            this.PersonInfo.Controls.Add(this.button1);
            this.PersonInfo.Controls.Add(this.ucFindPersonDetails1);
            this.PersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonInfo.Location = new System.Drawing.Point(4, 31);
            this.PersonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PersonInfo.Size = new System.Drawing.Size(1016, 584);
            this.PersonInfo.TabIndex = 0;
            this.PersonInfo.Text = "Personal Info";
            this.PersonInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucFindPersonDetails1
            // 
            this.ucFindPersonDetails1.Location = new System.Drawing.Point(21, 4);
            this.ucFindPersonDetails1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ucFindPersonDetails1.Name = "ucFindPersonDetails1";
            this.ucFindPersonDetails1.Size = new System.Drawing.Size(995, 529);
            this.ucFindPersonDetails1.TabIndex = 0;
            // 
            // tabPage_LoginInfo
            // 
            this.tabPage_LoginInfo.Controls.Add(this.panel1);
            this.tabPage_LoginInfo.Location = new System.Drawing.Point(4, 31);
            this.tabPage_LoginInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_LoginInfo.Name = "tabPage_LoginInfo";
            this.tabPage_LoginInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_LoginInfo.Size = new System.Drawing.Size(1016, 584);
            this.tabPage_LoginInfo.TabIndex = 1;
            this.tabPage_LoginInfo.Text = "LoginInfo";
            this.tabPage_LoginInfo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cB_IsActive);
            this.panel1.Controls.Add(this.tB_ConfirmPassword);
            this.panel1.Controls.Add(this.tB_Password);
            this.panel1.Controls.Add(this.tB_UserName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lab_UserId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(42, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 404);
            this.panel1.TabIndex = 0;
            // 
            // cB_IsActive
            // 
            this.cB_IsActive.AutoSize = true;
            this.cB_IsActive.Checked = true;
            this.cB_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cB_IsActive.Location = new System.Drawing.Point(197, 259);
            this.cB_IsActive.Name = "cB_IsActive";
            this.cB_IsActive.Size = new System.Drawing.Size(99, 26);
            this.cB_IsActive.TabIndex = 3;
            this.cB_IsActive.Text = "Is Active";
            this.cB_IsActive.UseVisualStyleBackColor = true;
            // 
            // tB_ConfirmPassword
            // 
            this.tB_ConfirmPassword.Location = new System.Drawing.Point(197, 196);
            this.tB_ConfirmPassword.Name = "tB_ConfirmPassword";
            this.tB_ConfirmPassword.PasswordChar = '*';
            this.tB_ConfirmPassword.Size = new System.Drawing.Size(166, 28);
            this.tB_ConfirmPassword.TabIndex = 1;
            this.tB_ConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tB_ConfirmPassword_Validating);
            this.tB_ConfirmPassword.Validated += new System.EventHandler(this.tB_ConfirmPassword_Validated);
            // 
            // tB_Password
            // 
            this.tB_Password.Location = new System.Drawing.Point(197, 143);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(166, 28);
            this.tB_Password.TabIndex = 1;
            this.tB_Password.Validating += new System.ComponentModel.CancelEventHandler(this.tB_Password_Validating);
            // 
            // tB_UserName
            // 
            this.tB_UserName.Location = new System.Drawing.Point(197, 74);
            this.tB_UserName.Name = "tB_UserName";
            this.tB_UserName.Size = new System.Drawing.Size(166, 28);
            this.tB_UserName.TabIndex = 1;
            this.tB_UserName.Validating += new System.ComponentModel.CancelEventHandler(this.tB_UserName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "UserName:";
            // 
            // lab_UserId
            // 
            this.lab_UserId.AutoSize = true;
            this.lab_UserId.Location = new System.Drawing.Point(197, 31);
            this.lab_UserId.Name = "lab_UserId";
            this.lab_UserId.Size = new System.Drawing.Size(40, 22);
            this.lab_UserId.TabIndex = 0;
            this.lab_UserId.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserID:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(854, 755);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(148, 42);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(700, 755);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(148, 42);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // errorProvider_UserName
            // 
            this.errorProvider_UserName.ContainerControl = this;
            // 
            // errorProvider_Password
            // 
            this.errorProvider_Password.ContainerControl = this;
            // 
            // errorProviderCofirmPassword
            // 
            this.errorProviderCofirmPassword.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmAddNewUserAndUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 806);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddNewUserAndUpdate";
            this.Text = "AddNewUser";
            this.tabControl1.ResumeLayout(false);
            this.PersonInfo.ResumeLayout(false);
            this.tabPage_LoginInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCofirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonInfo;
        private System.Windows.Forms.TabPage tabPage_LoginInfo;
        private Person.UcFindPersonDetails ucFindPersonDetails1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tB_ConfirmPassword;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.TextBox tB_UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_UserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cB_IsActive;
        private System.Windows.Forms.ErrorProvider errorProvider_UserName;
        private System.Windows.Forms.ErrorProvider errorProvider_Password;
        private System.Windows.Forms.ErrorProvider errorProviderCofirmPassword;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}