namespace DVLD___WindowsFormsApp.MyFroms.Uesr
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_Users = new System.Windows.Forms.DataGridView();
            this.btn_AddNew = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cB_Filter = new System.Windows.Forms.ComboBox();
            this.tB_FilterBy = new System.Windows.Forms.TextBox();
            this.cB_IsActive = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(750, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Users";
            // 
            // dGV_Users
            // 
            this.dGV_Users.AllowUserToAddRows = false;
            this.dGV_Users.AllowUserToDeleteRows = false;
            this.dGV_Users.AllowUserToOrderColumns = true;
            this.dGV_Users.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Users.Location = new System.Drawing.Point(0, 304);
            this.dGV_Users.Name = "dGV_Users";
            this.dGV_Users.ReadOnly = true;
            this.dGV_Users.RowHeadersWidth = 51;
            this.dGV_Users.RowTemplate.Height = 24;
            this.dGV_Users.Size = new System.Drawing.Size(1773, 555);
            this.dGV_Users.TabIndex = 2;
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNew.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.Image")));
            this.btn_AddNew.Location = new System.Drawing.Point(1686, 205);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(87, 75);
            this.btn_AddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AddNew.TabIndex = 3;
            this.btn_AddNew.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cB_Filter
            // 
            this.cB_Filter.FormattingEnabled = true;
            this.cB_Filter.Items.AddRange(new object[] {
            "None",
            "User Id",
            "UserName",
            "Person Id",
            "Fill Name ",
            "Is Active"});
            this.cB_Filter.Location = new System.Drawing.Point(139, 261);
            this.cB_Filter.Name = "cB_Filter";
            this.cB_Filter.Size = new System.Drawing.Size(222, 24);
            this.cB_Filter.TabIndex = 5;
            this.cB_Filter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tB_FilterBy
            // 
            this.tB_FilterBy.Location = new System.Drawing.Point(367, 261);
            this.tB_FilterBy.Name = "tB_FilterBy";
            this.tB_FilterBy.Size = new System.Drawing.Size(279, 22);
            this.tB_FilterBy.TabIndex = 6;
            this.tB_FilterBy.Visible = false;
            // 
            // cB_IsActive
            // 
            this.cB_IsActive.FormattingEnabled = true;
            this.cB_IsActive.Location = new System.Drawing.Point(367, 262);
            this.cB_IsActive.Name = "cB_IsActive";
            this.cB_IsActive.Size = new System.Drawing.Size(279, 24);
            this.cB_IsActive.TabIndex = 7;
            this.cB_IsActive.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(776, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 865);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "# Records";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 869);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "??";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Location = new System.Drawing.Point(1662, 865);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 29);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 906);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_FilterBy);
            this.Controls.Add(this.cB_Filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.dGV_Users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cB_IsActive);
            this.Name = "frmManageUsers";
            this.Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_Users;
        private System.Windows.Forms.PictureBox btn_AddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cB_Filter;
        private System.Windows.Forms.TextBox tB_FilterBy;
        private System.Windows.Forms.ComboBox cB_IsActive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Close;
    }
}