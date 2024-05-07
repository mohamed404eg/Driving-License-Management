namespace DVLD___WindowsFormsApp.MyFroms.Application.Test
{
    partial class frmTestAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestAppointment));
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.lab_Title = new System.Windows.Forms.Label();
            this.dgv_Appointments = new System.Windows.Forms.DataGridView();
            this.cM_Appointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_Records = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.uCdrivingAndAppInfo1 = new DVLD___WindowsFormsApp.MyFroms.Application.Control.UCdrivingAndAppInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).BeginInit();
            this.cM_Appointments.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Logo
            // 
            this.PB_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PB_Logo.Image")));
            this.PB_Logo.Location = new System.Drawing.Point(341, 3);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(90, 55);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Logo.TabIndex = 0;
            this.PB_Logo.TabStop = false;
            this.PB_Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lab_Title
            // 
            this.lab_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.Location = new System.Drawing.Point(217, 73);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(370, 25);
            this.lab_Title.TabIndex = 1;
            this.lab_Title.Text = " Appointments";
            this.lab_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_Appointments
            // 
            this.dgv_Appointments.AllowUserToAddRows = false;
            this.dgv_Appointments.AllowUserToDeleteRows = false;
            this.dgv_Appointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointments.ContextMenuStrip = this.cM_Appointments;
            this.dgv_Appointments.Location = new System.Drawing.Point(12, 533);
            this.dgv_Appointments.Name = "dgv_Appointments";
            this.dgv_Appointments.ReadOnly = true;
            this.dgv_Appointments.Size = new System.Drawing.Size(757, 148);
            this.dgv_Appointments.TabIndex = 3;
            // 
            // cM_Appointments
            // 
            this.cM_Appointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cM_Appointments.Name = "cM_Appointments";
            this.cM_Appointments.Size = new System.Drawing.Size(121, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeTestToolStripMenuItem.Image")));
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(723, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 34);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Appointments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 712);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Records:";
            // 
            // lab_Records
            // 
            this.lab_Records.AutoSize = true;
            this.lab_Records.Location = new System.Drawing.Point(67, 712);
            this.lab_Records.Name = "lab_Records";
            this.lab_Records.Size = new System.Drawing.Size(19, 13);
            this.lab_Records.TabIndex = 6;
            this.lab_Records.Text = "??";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(664, 705);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(105, 27);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // uCdrivingAndAppInfo1
            // 
            this.uCdrivingAndAppInfo1.Location = new System.Drawing.Point(1, 101);
            this.uCdrivingAndAppInfo1.Name = "uCdrivingAndAppInfo1";
            this.uCdrivingAndAppInfo1.Size = new System.Drawing.Size(781, 395);
            this.uCdrivingAndAppInfo1.TabIndex = 2;
            this.uCdrivingAndAppInfo1.Load += new System.EventHandler(this.uCdrivingAndAppInfo1_Load);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.PB_Logo);
            this.panel1.Controls.Add(this.lab_Title);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 103);
            this.panel1.TabIndex = 8;
            // 
            // frmTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lab_Records);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Appointments);
            this.Controls.Add(this.uCdrivingAndAppInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTestAppointment";
            this.Text = " Appointments";
            this.Load += new System.EventHandler(this.frmVisionTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).EndInit();
            this.cM_Appointments.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Label lab_Title;
        private Control.UCdrivingAndAppInfo uCdrivingAndAppInfo1;
        private System.Windows.Forms.DataGridView dgv_Appointments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_Records;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ContextMenuStrip cM_Appointments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}