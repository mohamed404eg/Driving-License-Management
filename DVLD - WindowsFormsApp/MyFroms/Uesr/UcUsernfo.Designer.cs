namespace DVLD___WindowsFormsApp.MyFroms.Uesr
{
    partial class UcUsernfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cB_IsActive = new System.Windows.Forms.CheckBox();
            this.lab_UserName = new System.Windows.Forms.Label();
            this.lab_UserId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPersonInfo1 = new DVLD___WindowsFormsApp.MyFroms.Person.UcPersonInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cB_IsActive);
            this.groupBox1.Controls.Add(this.lab_UserName);
            this.groupBox1.Controls.Add(this.lab_UserId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // cB_IsActive
            // 
            this.cB_IsActive.AutoSize = true;
            this.cB_IsActive.Enabled = false;
            this.cB_IsActive.Location = new System.Drawing.Point(514, 43);
            this.cB_IsActive.Name = "cB_IsActive";
            this.cB_IsActive.Size = new System.Drawing.Size(79, 20);
            this.cB_IsActive.TabIndex = 1;
            this.cB_IsActive.Text = "Is Active";
            this.cB_IsActive.UseVisualStyleBackColor = true;
            // 
            // lab_UserName
            // 
            this.lab_UserName.AutoSize = true;
            this.lab_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_UserName.Location = new System.Drawing.Point(343, 41);
            this.lab_UserName.Name = "lab_UserName";
            this.lab_UserName.Size = new System.Drawing.Size(36, 20);
            this.lab_UserName.TabIndex = 0;
            this.lab_UserName.Text = "???";
            // 
            // lab_UserId
            // 
            this.lab_UserId.AutoSize = true;
            this.lab_UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_UserId.Location = new System.Drawing.Point(86, 41);
            this.lab_UserId.Name = "lab_UserId";
            this.lab_UserId.Size = new System.Drawing.Size(36, 20);
            this.lab_UserId.TabIndex = 0;
            this.lab_UserId.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserId:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(3, 0);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.Size = new System.Drawing.Size(790, 319);
            this.ucPersonInfo1.TabIndex = 0;
            this.ucPersonInfo1.Load += new System.EventHandler(this.ucPersonInfo1_Load);
            // 
            // UcUsernfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucPersonInfo1);
            this.Name = "UcUsernfo";
            this.Size = new System.Drawing.Size(796, 420);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Person.UcPersonInfo ucPersonInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cB_IsActive;
        private System.Windows.Forms.Label lab_UserName;
        private System.Windows.Forms.Label lab_UserId;
    }
}
