namespace DVLD___WindowsFormsApp.MyFroms.Driver.uC
{
    partial class UcFindLicense
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
            this.Gb_FilterBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucFindLicensenfo = new DVLD___WindowsFormsApp.MyFroms.Driver.ShowLicense.uCDriverLicensenfo();
            this.Gb_FilterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_FilterBox
            // 
            this.Gb_FilterBox.Controls.Add(this.button1);
            this.Gb_FilterBox.Controls.Add(this.textBox1);
            this.Gb_FilterBox.Controls.Add(this.label1);
            this.Gb_FilterBox.Location = new System.Drawing.Point(3, 3);
            this.Gb_FilterBox.Name = "Gb_FilterBox";
            this.Gb_FilterBox.Size = new System.Drawing.Size(484, 76);
            this.Gb_FilterBox.TabIndex = 0;
            this.Gb_FilterBox.TabStop = false;
            this.Gb_FilterBox.Text = "Filter";
            this.Gb_FilterBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Image = global::DVLD___WindowsFormsApp.Properties.Resources.find_32;
            this.button1.Location = new System.Drawing.Point(398, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 42);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LicenseID:";
            // 
            // ucFindLicensenfo
            // 
            this.ucFindLicensenfo.Location = new System.Drawing.Point(0, 85);
            this.ucFindLicensenfo.Name = "ucFindLicensenfo";
            this.ucFindLicensenfo.Size = new System.Drawing.Size(744, 384);
            this.ucFindLicensenfo.TabIndex = 1;
            this.ucFindLicensenfo.Load += new System.EventHandler(this.ucFindLicensenfo_Load);
            // 
            // UcFindLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucFindLicensenfo);
            this.Controls.Add(this.Gb_FilterBox);
            this.Name = "UcFindLicense";
            this.Size = new System.Drawing.Size(744, 464);
            this.Load += new System.EventHandler(this.UcFindLicense_Load);
            this.Gb_FilterBox.ResumeLayout(false);
            this.Gb_FilterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_FilterBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private ShowLicense.uCDriverLicensenfo ucFindLicensenfo;
    }
}
