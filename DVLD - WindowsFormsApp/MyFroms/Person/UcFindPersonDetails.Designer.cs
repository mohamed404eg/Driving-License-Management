namespace DVLD___WindowsFormsApp.MyFroms.Person
{
    partial class UcFindPersonDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFindPersonDetails));
            this.tb_FilterBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_FilterBy = new System.Windows.Forms.ComboBox();
            this.gB_Filter = new System.Windows.Forms.GroupBox();
            this.btn_AddNew = new System.Windows.Forms.PictureBox();
            this.btn_Find = new System.Windows.Forms.PictureBox();
            this.ucPersonInfo1 = new DVLD___WindowsFormsApp.MyFroms.Person.UcPersonInfo();
            this.gB_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Find)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_FilterBy
            // 
            this.tb_FilterBy.Location = new System.Drawing.Point(337, 26);
            this.tb_FilterBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_FilterBy.Name = "tb_FilterBy";
            this.tb_FilterBy.Size = new System.Drawing.Size(205, 27);
            this.tb_FilterBy.TabIndex = 13;
            this.tb_FilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_FilterBy_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Find  By:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_FilterBy
            // 
            this.cb_FilterBy.FormattingEnabled = true;
            this.cb_FilterBy.Items.AddRange(new object[] {
            "Person Id",
            "National No."});
            this.cb_FilterBy.Location = new System.Drawing.Point(115, 25);
            this.cb_FilterBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_FilterBy.Name = "cb_FilterBy";
            this.cb_FilterBy.Size = new System.Drawing.Size(196, 28);
            this.cb_FilterBy.TabIndex = 10;
            // 
            // gB_Filter
            // 
            this.gB_Filter.Controls.Add(this.btn_AddNew);
            this.gB_Filter.Controls.Add(this.btn_Find);
            this.gB_Filter.Controls.Add(this.cb_FilterBy);
            this.gB_Filter.Controls.Add(this.tb_FilterBy);
            this.gB_Filter.Controls.Add(this.label5);
            this.gB_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_Filter.Location = new System.Drawing.Point(4, 4);
            this.gB_Filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gB_Filter.Name = "gB_Filter";
            this.gB_Filter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gB_Filter.Size = new System.Drawing.Size(741, 69);
            this.gB_Filter.TabIndex = 14;
            this.gB_Filter.TabStop = false;
            this.gB_Filter.Text = "Filter";
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddNew.Image")));
            this.btn_AddNew.Location = new System.Drawing.Point(632, 23);
            this.btn_AddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(52, 38);
            this.btn_AddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_AddNew.TabIndex = 14;
            this.btn_AddNew.TabStop = false;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Image = ((System.Drawing.Image)(resources.GetObject("btn_Find.Image")));
            this.btn_Find.Location = new System.Drawing.Point(560, 23);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(52, 38);
            this.btn_Find.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Find.TabIndex = 14;
            this.btn_Find.TabStop = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(-1, 80);
            this.ucPersonInfo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.Size = new System.Drawing.Size(831, 313);
            this.ucPersonInfo1.TabIndex = 0;
            // 
            // UcFindPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gB_Filter);
            this.Controls.Add(this.ucPersonInfo1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcFindPersonDetails";
            this.Size = new System.Drawing.Size(859, 393);
            this.gB_Filter.ResumeLayout(false);
            this.gB_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Find)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcPersonInfo ucPersonInfo1;
        private System.Windows.Forms.TextBox tb_FilterBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_FilterBy;
        private System.Windows.Forms.GroupBox gB_Filter;
        private System.Windows.Forms.PictureBox btn_Find;
        private System.Windows.Forms.PictureBox btn_AddNew;
    }
}
