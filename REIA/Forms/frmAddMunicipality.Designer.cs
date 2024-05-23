namespace REIA.Forms
{
    partial class frmAddMunicipality
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMunicipality = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_1stDistrict = new System.Windows.Forms.RadioButton();
            this.rb_2ndDistrict = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(151, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMunicipality
            // 
            this.txtMunicipality.Location = new System.Drawing.Point(109, 80);
            this.txtMunicipality.Name = "txtMunicipality";
            this.txtMunicipality.Size = new System.Drawing.Size(198, 20);
            this.txtMunicipality.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(106, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Municipality";
            // 
            // rb_1stDistrict
            // 
            this.rb_1stDistrict.AutoSize = true;
            this.rb_1stDistrict.Location = new System.Drawing.Point(109, 106);
            this.rb_1stDistrict.Name = "rb_1stDistrict";
            this.rb_1stDistrict.Size = new System.Drawing.Size(74, 17);
            this.rb_1stDistrict.TabIndex = 6;
            this.rb_1stDistrict.Text = "1st District";
            this.rb_1stDistrict.UseVisualStyleBackColor = true;
            this.rb_1stDistrict.CheckedChanged += new System.EventHandler(this.rb_District);
            // 
            // rb_2ndDistrict
            // 
            this.rb_2ndDistrict.AutoSize = true;
            this.rb_2ndDistrict.Location = new System.Drawing.Point(229, 106);
            this.rb_2ndDistrict.Name = "rb_2ndDistrict";
            this.rb_2ndDistrict.Size = new System.Drawing.Size(78, 17);
            this.rb_2ndDistrict.TabIndex = 7;
            this.rb_2ndDistrict.Text = "2nd District";
            this.rb_2ndDistrict.UseVisualStyleBackColor = true;
            this.rb_2ndDistrict.CheckedChanged += new System.EventHandler(this.rb_District);
            // 
            // frmAddMunicipality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 227);
            this.Controls.Add(this.rb_2ndDistrict);
            this.Controls.Add(this.rb_1stDistrict);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMunicipality);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddMunicipality";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Municipality";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddMunicipality_FormClosed);
            this.Load += new System.EventHandler(this.frmAddMunicipality_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMunicipality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_1stDistrict;
        private System.Windows.Forms.RadioButton rb_2ndDistrict;
    }
}