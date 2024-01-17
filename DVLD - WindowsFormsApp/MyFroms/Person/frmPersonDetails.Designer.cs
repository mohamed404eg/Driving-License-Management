
namespace DVLD___WindowsFormsApp.MyFroms.Person
{
    partial class frmPersonDetails
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
            this.lab_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ucPersonInfo1 = new DVLD___WindowsFormsApp.MyFroms.Person.UcPersonInfo();
            this.SuspendLayout();
            // 
            // lab_Title
            // 
            this.lab_Title.AutoSize = true;
            this.lab_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Title.ForeColor = System.Drawing.Color.Brown;
            this.lab_Title.Location = new System.Drawing.Point(266, 24);
            this.lab_Title.Name = "lab_Title";
            this.lab_Title.Size = new System.Drawing.Size(280, 46);
            this.lab_Title.TabIndex = 1;
            this.lab_Title.Text = "Person Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 477);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 44;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(2, 75);
            this.ucPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.Size = new System.Drawing.Size(791, 395);
            this.ucPersonInfo1.TabIndex = 45;
            this.ucPersonInfo1.Load += new System.EventHandler(this.ucPersonInfo1_Load);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(795, 525);
            this.Controls.Add(this.ucPersonInfo1);
            this.Controls.Add(this.lab_Title);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(811, 564);
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_Title;
        private System.Windows.Forms.Button button1;
        private UcPersonInfo ucPersonInfo1;
    }
}