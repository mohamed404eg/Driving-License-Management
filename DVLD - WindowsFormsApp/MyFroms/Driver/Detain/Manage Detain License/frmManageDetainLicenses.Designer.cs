namespace DVLD___WindowsFormsApp.MyFroms.Driver.Detain.Manage_Detain_License
{
    partial class frmManageDetainLicenses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_FilterBy = new System.Windows.Forms.ComboBox();
            this.dG_ManageDetain = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_Records = new System.Windows.Forms.Label();
            this.btn_Release = new System.Windows.Forms.Button();
            this.btn_Detain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tB_FilterBy = new System.Windows.Forms.TextBox();
            this.rB_IsReleasedTrue = new System.Windows.Forms.RadioButton();
            this.rB_IsReleaseNo = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicesneHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDateinedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dG_ManageDetain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(358, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cB_FilterBy
            // 
            this.cB_FilterBy.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No.",
            "Full Name",
            "Release Application ID"});
            this.cB_FilterBy.FormattingEnabled = true;
            this.cB_FilterBy.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No.",
            "Full Name",
            "Release Application ID"});
            this.cB_FilterBy.Location = new System.Drawing.Point(79, 247);
            this.cB_FilterBy.Name = "cB_FilterBy";
            this.cB_FilterBy.Size = new System.Drawing.Size(157, 21);
            this.cB_FilterBy.TabIndex = 3;
            this.cB_FilterBy.SelectedIndexChanged += new System.EventHandler(this.cB_FilterBy_SelectedIndexChanged);
            // 
            // dG_ManageDetain
            // 
            this.dG_ManageDetain.AllowUserToAddRows = false;
            this.dG_ManageDetain.AllowUserToDeleteRows = false;
            this.dG_ManageDetain.AllowUserToOrderColumns = true;
            this.dG_ManageDetain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dG_ManageDetain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dG_ManageDetain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_ManageDetain.ContextMenuStrip = this.contextMenuStrip1;
            this.dG_ManageDetain.Location = new System.Drawing.Point(29, 270);
            this.dG_ManageDetain.Name = "dG_ManageDetain";
            this.dG_ManageDetain.ReadOnly = true;
            this.dG_ManageDetain.Size = new System.Drawing.Size(1080, 333);
            this.dG_ManageDetain.TabIndex = 4;
            this.dG_ManageDetain.DataSourceChanged += new System.EventHandler(this.dG_ManageDetain_DataSourceChanged);
            this.dG_ManageDetain.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dG_ManageDetain_CellValueNeeded);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = global::DVLD___WindowsFormsApp.Properties.Resources.cancel;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(1012, 609);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(97, 35);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "# Records:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lab_Records
            // 
            this.lab_Records.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lab_Records.AutoSize = true;
            this.lab_Records.Location = new System.Drawing.Point(92, 621);
            this.lab_Records.Name = "lab_Records";
            this.lab_Records.Size = new System.Drawing.Size(25, 13);
            this.lab_Records.TabIndex = 6;
            this.lab_Records.Text = "???";
            // 
            // btn_Release
            // 
            this.btn_Release.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Release.Image = global::DVLD___WindowsFormsApp.Properties.Resources.Release_64px;
            this.btn_Release.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Release.Location = new System.Drawing.Point(949, 192);
            this.btn_Release.Name = "btn_Release";
            this.btn_Release.Size = new System.Drawing.Size(77, 72);
            this.btn_Release.TabIndex = 5;
            this.btn_Release.UseVisualStyleBackColor = true;
            this.btn_Release.Click += new System.EventHandler(this.btn_Release_Click);
            // 
            // btn_Detain
            // 
            this.btn_Detain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Detain.Image = global::DVLD___WindowsFormsApp.Properties.Resources.banned_64px;
            this.btn_Detain.Location = new System.Drawing.Point(1032, 192);
            this.btn_Detain.Name = "btn_Detain";
            this.btn_Detain.Size = new System.Drawing.Size(77, 72);
            this.btn_Detain.TabIndex = 5;
            this.btn_Detain.UseVisualStyleBackColor = true;
            this.btn_Detain.Click += new System.EventHandler(this.btn_Detain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DVLD___WindowsFormsApp.Properties.Resources.drivers_license_128;
            this.pictureBox1.Location = new System.Drawing.Point(477, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tB_FilterBy
            // 
            this.tB_FilterBy.Location = new System.Drawing.Point(242, 247);
            this.tB_FilterBy.Name = "tB_FilterBy";
            this.tB_FilterBy.Size = new System.Drawing.Size(235, 20);
            this.tB_FilterBy.TabIndex = 7;
            this.tB_FilterBy.Visible = false;
            this.tB_FilterBy.TextChanged += new System.EventHandler(this.tB_FilterBy_TextChanged);
            // 
            // rB_IsReleasedTrue
            // 
            this.rB_IsReleasedTrue.AutoSize = true;
            this.rB_IsReleasedTrue.Location = new System.Drawing.Point(264, 247);
            this.rB_IsReleasedTrue.Name = "rB_IsReleasedTrue";
            this.rB_IsReleasedTrue.Size = new System.Drawing.Size(43, 17);
            this.rB_IsReleasedTrue.TabIndex = 8;
            this.rB_IsReleasedTrue.TabStop = true;
            this.rB_IsReleasedTrue.Text = "Yes";
            this.rB_IsReleasedTrue.UseVisualStyleBackColor = true;
            this.rB_IsReleasedTrue.Visible = false;
            this.rB_IsReleasedTrue.CheckedChanged += new System.EventHandler(this.rB_IsReleasedTrue_CheckedChanged);
            // 
            // rB_IsReleaseNo
            // 
            this.rB_IsReleaseNo.AutoSize = true;
            this.rB_IsReleaseNo.Location = new System.Drawing.Point(364, 247);
            this.rB_IsReleaseNo.Name = "rB_IsReleaseNo";
            this.rB_IsReleaseNo.Size = new System.Drawing.Size(39, 17);
            this.rB_IsReleaseNo.TabIndex = 8;
            this.rB_IsReleaseNo.TabStop = true;
            this.rB_IsReleaseNo.Text = "No";
            this.rB_IsReleaseNo.UseVisualStyleBackColor = true;
            this.rB_IsReleaseNo.Visible = false;
            this.rB_IsReleaseNo.CheckedChanged += new System.EventHandler(this.rB_IsReleaseNo_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 25);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicesneHistoryToolStripMenuItem,
            this.releaseDateinedLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(304, 154);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD___WindowsFormsApp.Properties.Resources.lDrivings_64;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD___WindowsFormsApp.Properties.Resources.drivers_license;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicesneHistoryToolStripMenuItem
            // 
            this.showPersonLicesneHistoryToolStripMenuItem.Image = global::DVLD___WindowsFormsApp.Properties.Resources.passport_24;
            this.showPersonLicesneHistoryToolStripMenuItem.Name = "showPersonLicesneHistoryToolStripMenuItem";
            this.showPersonLicesneHistoryToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.showPersonLicesneHistoryToolStripMenuItem.Text = "Show Person Licesne History";
            this.showPersonLicesneHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicesneHistoryToolStripMenuItem_Click);
            // 
            // releaseDateinedLicenseToolStripMenuItem
            // 
            this.releaseDateinedLicenseToolStripMenuItem.Enabled = false;
            this.releaseDateinedLicenseToolStripMenuItem.Image = global::DVLD___WindowsFormsApp.Properties.Resources.Release_24px;
            this.releaseDateinedLicenseToolStripMenuItem.Name = "releaseDateinedLicenseToolStripMenuItem";
            this.releaseDateinedLicenseToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.releaseDateinedLicenseToolStripMenuItem.Text = "Release Dateined License";
            this.releaseDateinedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDateinedLicenseToolStripMenuItem_Click);
            // 
            // frmManageDetainLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 651);
            this.Controls.Add(this.rB_IsReleaseNo);
            this.Controls.Add(this.rB_IsReleasedTrue);
            this.Controls.Add(this.tB_FilterBy);
            this.Controls.Add(this.lab_Records);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Release);
            this.Controls.Add(this.btn_Detain);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dG_ManageDetain);
            this.Controls.Add(this.cB_FilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmManageDetainLicenses";
            this.Text = "Manage Detain Licenses";
            ((System.ComponentModel.ISupportInitialize)(this.dG_ManageDetain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_FilterBy;
        private System.Windows.Forms.DataGridView dG_ManageDetain;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_Records;
        private System.Windows.Forms.Button btn_Detain;
        private System.Windows.Forms.Button btn_Release;
        private System.Windows.Forms.TextBox tB_FilterBy;
        private System.Windows.Forms.RadioButton rB_IsReleasedTrue;
        private System.Windows.Forms.RadioButton rB_IsReleaseNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicesneHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDateinedLicenseToolStripMenuItem;
    }
}