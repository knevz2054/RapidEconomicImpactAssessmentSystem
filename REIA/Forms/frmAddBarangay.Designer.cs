namespace REIA.Forms
{
    partial class frmAddBarangay
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
            this.rb_2ndDistrict = new System.Windows.Forms.RadioButton();
            this.rb_1stDistrict = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBarangay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMunicipality = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.cbCluster = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rb_2ndDistrict
            // 
            this.rb_2ndDistrict.AutoSize = true;
            this.rb_2ndDistrict.Location = new System.Drawing.Point(226, 76);
            this.rb_2ndDistrict.Name = "rb_2ndDistrict";
            this.rb_2ndDistrict.Size = new System.Drawing.Size(78, 17);
            this.rb_2ndDistrict.TabIndex = 12;
            this.rb_2ndDistrict.Text = "2nd District";
            this.rb_2ndDistrict.UseVisualStyleBackColor = true;
            this.rb_2ndDistrict.CheckedChanged += new System.EventHandler(this.Select_District);
            // 
            // rb_1stDistrict
            // 
            this.rb_1stDistrict.AutoSize = true;
            this.rb_1stDistrict.Location = new System.Drawing.Point(106, 76);
            this.rb_1stDistrict.Name = "rb_1stDistrict";
            this.rb_1stDistrict.Size = new System.Drawing.Size(74, 17);
            this.rb_1stDistrict.TabIndex = 11;
            this.rb_1stDistrict.Text = "1st District";
            this.rb_1stDistrict.UseVisualStyleBackColor = true;
            this.rb_1stDistrict.CheckedChanged += new System.EventHandler(this.Select_District);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(148, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBarangay
            // 
            this.txtBarangay.Location = new System.Drawing.Point(106, 50);
            this.txtBarangay.Name = "txtBarangay";
            this.txtBarangay.Size = new System.Drawing.Size(198, 20);
            this.txtBarangay.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Barangay";
            // 
            // cbMunicipality
            // 
            this.cbMunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMunicipality.FormattingEnabled = true;
            this.cbMunicipality.Location = new System.Drawing.Point(106, 114);
            this.cbMunicipality.Name = "cbMunicipality";
            this.cbMunicipality.Size = new System.Drawing.Size(198, 21);
            this.cbMunicipality.TabIndex = 13;
            this.cbMunicipality.SelectedIndexChanged += new System.EventHandler(this.cbMunicipality_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(103, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Municipality";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lable.Location = new System.Drawing.Point(103, 138);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(55, 15);
            this.lable.TabIndex = 16;
            this.lable.Text = "Cluster";
            // 
            // cbCluster
            // 
            this.cbCluster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCluster.FormattingEnabled = true;
            this.cbCluster.Location = new System.Drawing.Point(106, 156);
            this.cbCluster.Name = "cbCluster";
            this.cbCluster.Size = new System.Drawing.Size(198, 21);
            this.cbCluster.TabIndex = 15;
            // 
            // frmAddBarangay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 260);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.cbCluster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMunicipality);
            this.Controls.Add(this.rb_2ndDistrict);
            this.Controls.Add(this.rb_1stDistrict);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBarangay);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddBarangay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Barangay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddBarangay_FormClosed);
            this.Load += new System.EventHandler(this.frmAddBarangay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_2ndDistrict;
        private System.Windows.Forms.RadioButton rb_1stDistrict;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBarangay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMunicipality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox cbCluster;
    }
}