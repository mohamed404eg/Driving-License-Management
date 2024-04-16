namespace DVLD___WindowsFormsApp.MyFroms.Application.LocalApplication
{
    partial class frmManageLocalDrivingApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalDrivingApplication));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.btn_New = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.COBX_Filter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labRecords = new System.Windows.Forms.Label();
            this.tB_FilterBy = new System.Windows.Forms.TextBox();
            this.CB_Status = new System.Windows.Forms.ComboBox();
            this.cMS_AllApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDrivingLiceseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.cMS_AllApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Local Driving Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(597, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 78);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AllowUserToOrderColumns = true;
            this.dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.ContextMenuStrip = this.cMS_AllApplication;
            this.dGV.Location = new System.Drawing.Point(12, 186);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.Size = new System.Drawing.Size(1237, 393);
            this.dGV.TabIndex = 2;
            this.dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.Image")));
            this.btn_New.Location = new System.Drawing.Point(1174, 105);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 75);
            this.btn_New.TabIndex = 3;
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By :";
            // 
            // COBX_Filter
            // 
            this.COBX_Filter.FormattingEnabled = true;
            this.COBX_Filter.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID (Applications Id)",
            "National No.",
            "Full Name",
            "Status"});
            this.COBX_Filter.Location = new System.Drawing.Point(72, 157);
            this.COBX_Filter.Name = "COBX_Filter";
            this.COBX_Filter.Size = new System.Drawing.Size(140, 21);
            this.COBX_Filter.TabIndex = 5;
            this.COBX_Filter.SelectedIndexChanged += new System.EventHandler(this.COBX_Filter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "# Records:";
            // 
            // labRecords
            // 
            this.labRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labRecords.AutoSize = true;
            this.labRecords.Location = new System.Drawing.Point(69, 591);
            this.labRecords.Name = "labRecords";
            this.labRecords.Size = new System.Drawing.Size(25, 13);
            this.labRecords.TabIndex = 6;
            this.labRecords.Text = "???";
            // 
            // tB_FilterBy
            // 
            this.tB_FilterBy.Location = new System.Drawing.Point(218, 157);
            this.tB_FilterBy.Name = "tB_FilterBy";
            this.tB_FilterBy.Size = new System.Drawing.Size(191, 20);
            this.tB_FilterBy.TabIndex = 7;
            this.tB_FilterBy.TextChanged += new System.EventHandler(this.tB_FilterBy_TextChanged);
            // 
            // CB_Status
            // 
            this.CB_Status.FormattingEnabled = true;
            this.CB_Status.Items.AddRange(new object[] {
            "New",
            "Cancelled",
            "Completed"});
            this.CB_Status.Location = new System.Drawing.Point(218, 156);
            this.CB_Status.Name = "CB_Status";
            this.CB_Status.Size = new System.Drawing.Size(191, 21);
            this.CB_Status.TabIndex = 8;
            this.CB_Status.SelectedIndexChanged += new System.EventHandler(this.CB_Status_SelectedIndexChanged);
            // 
            // cMS_AllApplication
            // 
            this.cMS_AllApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMS_AllApplication.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cMS_AllApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.sechduleTaskToolStripMenuItem,
            this.issuToolStripMenuItem,
            this.eDrivingLiceseFirstTimeToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cMS_AllApplication.Name = "cMS_AllApplication";
            this.cMS_AllApplication.Size = new System.Drawing.Size(327, 330);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.showToolStripMenuItem.Text = "show appleication details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelApplicationToolStripMenuItem.Image")));
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // sechduleTaskToolStripMenuItem
            // 
            this.sechduleTaskToolStripMenuItem.Name = "sechduleTaskToolStripMenuItem";
            this.sechduleTaskToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.sechduleTaskToolStripMenuItem.Text = "Sechdule Task";
            // 
            // issuToolStripMenuItem
            // 
            this.issuToolStripMenuItem.Name = "issuToolStripMenuItem";
            this.issuToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.issuToolStripMenuItem.Text = "Issue e Driving Licese (First Time)";
            // 
            // eDrivingLiceseFirstTimeToolStripMenuItem
            // 
            this.eDrivingLiceseFirstTimeToolStripMenuItem.Name = "eDrivingLiceseFirstTimeToolStripMenuItem";
            this.eDrivingLiceseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.eDrivingLiceseFirstTimeToolStripMenuItem.Text = "Show License";
            this.eDrivingLiceseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.eDrivingLiceseFirstTimeToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // frmManageLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 613);
            this.Controls.Add(this.labRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.COBX_Filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Status);
            this.Controls.Add(this.tB_FilterBy);
            this.Name = "frmManageLocalDrivingApplication";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmManageLocalDrivingApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.cMS_AllApplication.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COBX_Filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labRecords;
        private System.Windows.Forms.TextBox tB_FilterBy;
        private System.Windows.Forms.ComboBox CB_Status;
        private System.Windows.Forms.ContextMenuStrip cMS_AllApplication;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDrivingLiceseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}