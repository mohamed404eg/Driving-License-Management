namespace DVLD___WindowsFormsApp.MyFroms.Application.LocalApplication
{
    partial class frmViewLocalApplication
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
            this.uCdrivingAndAppInfo1 = new DVLD___WindowsFormsApp.MyFroms.Application.Control.UCdrivingAndAppInfo();
            this.lab_Title = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uCdrivingAndAppInfo1
            // 
            this.uCdrivingAndAppInfo1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.uCdrivingAndAppInfo1.Location = new System.Drawing.Point(12, 71);
            this.uCdrivingAndAppInfo1.Name = "uCdrivingAndAppInfo1";
            this.uCdrivingAndAppInfo1.Size = new System.Drawing.Size(777, 382);
            this.uCdrivingAndAppInfo1.TabIndex = 0;
            this.uCdrivingAndAppInfo1.Load += new System.EventHandler(this.uCdrivingAndAppInfo1_Load);
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.ForeColor = System.Drawing.Color.DarkRed;
            this.lab_Title.Location = new System.Drawing.Point(236, 20);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(328, 31);
            this.lab_Title.TabIndex = 1;
            this.lab_Title.Text = "Show Appleication Details";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = global::DVLD___WindowsFormsApp.Properties.Resources.close;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Close.Location = new System.Drawing.Point(689, 458);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 32);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frmViewLocalApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 493);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lab_Title);
            this.Controls.Add(this.uCdrivingAndAppInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmViewLocalApplication";
            this.Text = "Local Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.UCdrivingAndAppInfo uCdrivingAndAppInfo1;
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Button btn_Close;
    }
}