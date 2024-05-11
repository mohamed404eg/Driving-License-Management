namespace DVLD___WindowsFormsApp.MyFroms.Driver.License_History
{
    partial class frmLicenseHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Local = new System.Windows.Forms.TabPage();
            this.International = new System.Windows.Forms.TabPage();
            this.DGV_LicenseLocal = new System.Windows.Forms.DataGridView();
            this.DGV_LicenseInternational = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_Recored_Local = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_Records_International = new System.Windows.Forms.Label();
            this.ucPersonInfo1 = new DVLD___WindowsFormsApp.MyFroms.Person.UcPersonInfo();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Local.SuspendLayout();
            this.International.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LicenseLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LicenseInternational)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "License History";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 71);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD___WindowsFormsApp.Properties.Resources.clock_512;
            this.pictureBox1.Location = new System.Drawing.Point(27, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 346);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver License";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Local);
            this.tabControl1.Controls.Add(this.International);
            this.tabControl1.Location = new System.Drawing.Point(6, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 323);
            this.tabControl1.TabIndex = 0;
            // 
            // Local
            // 
            this.Local.Controls.Add(this.label5);
            this.Local.Controls.Add(this.lab_Recored_Local);
            this.Local.Controls.Add(this.label2);
            this.Local.Controls.Add(this.DGV_LicenseLocal);
            this.Local.Location = new System.Drawing.Point(4, 27);
            this.Local.Name = "Local";
            this.Local.Padding = new System.Windows.Forms.Padding(3);
            this.Local.Size = new System.Drawing.Size(897, 292);
            this.Local.TabIndex = 0;
            this.Local.Text = "Local";
            this.Local.UseVisualStyleBackColor = true;
            this.Local.Click += new System.EventHandler(this.Local_Click);
            // 
            // International
            // 
            this.International.Controls.Add(this.label4);
            this.International.Controls.Add(this.lab_Records_International);
            this.International.Controls.Add(this.label3);
            this.International.Controls.Add(this.DGV_LicenseInternational);
            this.International.Location = new System.Drawing.Point(4, 27);
            this.International.Name = "International";
            this.International.Padding = new System.Windows.Forms.Padding(3);
            this.International.Size = new System.Drawing.Size(897, 292);
            this.International.TabIndex = 1;
            this.International.Text = "International";
            this.International.UseVisualStyleBackColor = true;
            // 
            // DGV_LicenseLocal
            // 
            this.DGV_LicenseLocal.AllowUserToAddRows = false;
            this.DGV_LicenseLocal.AllowUserToDeleteRows = false;
            this.DGV_LicenseLocal.AllowUserToOrderColumns = true;
            this.DGV_LicenseLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_LicenseLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LicenseLocal.Location = new System.Drawing.Point(6, 31);
            this.DGV_LicenseLocal.Name = "DGV_LicenseLocal";
            this.DGV_LicenseLocal.ReadOnly = true;
            this.DGV_LicenseLocal.Size = new System.Drawing.Size(888, 205);
            this.DGV_LicenseLocal.TabIndex = 0;
            // 
            // DGV_LicenseInternational
            // 
            this.DGV_LicenseInternational.AllowUserToAddRows = false;
            this.DGV_LicenseInternational.AllowUserToDeleteRows = false;
            this.DGV_LicenseInternational.AllowUserToOrderColumns = true;
            this.DGV_LicenseInternational.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_LicenseInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LicenseInternational.Location = new System.Drawing.Point(9, 27);
            this.DGV_LicenseInternational.Name = "DGV_LicenseInternational";
            this.DGV_LicenseInternational.ReadOnly = true;
            this.DGV_LicenseInternational.Size = new System.Drawing.Size(886, 212);
            this.DGV_LicenseInternational.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(832, 769);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(106, 38);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local Licesne History :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "International Licesne History :";
            // 
            // lab_Recored_Local
            // 
            this.lab_Recored_Local.AutoSize = true;
            this.lab_Recored_Local.Location = new System.Drawing.Point(83, 258);
            this.lab_Recored_Local.Name = "lab_Recored_Local";
            this.lab_Recored_Local.Size = new System.Drawing.Size(32, 18);
            this.lab_Recored_Local.TabIndex = 2;
            this.lab_Recored_Local.Text = "???";
            this.lab_Recored_Local.Click += new System.EventHandler(this.lab_Recored_Local_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "# Records:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "# Records:";
            // 
            // lab_Records_International
            // 
            this.lab_Records_International.AutoSize = true;
            this.lab_Records_International.Location = new System.Drawing.Point(93, 260);
            this.lab_Records_International.Name = "lab_Records_International";
            this.lab_Records_International.Size = new System.Drawing.Size(32, 18);
            this.lab_Records_International.TabIndex = 4;
            this.lab_Records_International.Text = "???";
            this.lab_Records_International.Click += new System.EventHandler(this.lab_Records_International_Click);
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(330, 105);
            this.ucPersonInfo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.Size = new System.Drawing.Size(584, 254);
            this.ucPersonInfo1.TabIndex = 4;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 819);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucPersonInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicenseHistory";
            this.Text = "License History";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Local.ResumeLayout(false);
            this.Local.PerformLayout();
            this.International.ResumeLayout(false);
            this.International.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LicenseLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LicenseInternational)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Person.UcPersonInfo ucPersonInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Local;
        private System.Windows.Forms.TabPage International;
        private System.Windows.Forms.DataGridView DGV_LicenseLocal;
        private System.Windows.Forms.DataGridView DGV_LicenseInternational;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_Recored_Local;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_Records_International;
    }
}