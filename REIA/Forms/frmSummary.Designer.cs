namespace REIA.Forms
{
    partial class frmSummary
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSituation = new System.Windows.Forms.Button();
            this.btnExpenditure = new System.Windows.Forms.Button();
            this.btnSavings = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnSources = new System.Windows.Forms.Button();
            this.pnlSummaryContent = new System.Windows.Forms.Panel();
            this.btnHunger = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.btnHunger, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSituation, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExpenditure, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSavings, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIncome, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProfile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSources, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1533, 42);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSituation
            // 
            this.btnSituation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSituation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSituation.Location = new System.Drawing.Point(854, 4);
            this.btnSituation.Name = "btnSituation";
            this.btnSituation.Size = new System.Drawing.Size(163, 34);
            this.btnSituation.TabIndex = 5;
            this.btnSituation.Text = "Economic Situation";
            this.btnSituation.UseVisualStyleBackColor = true;
            this.btnSituation.Click += new System.EventHandler(this.btnSituation_Click);
            // 
            // btnExpenditure
            // 
            this.btnExpenditure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExpenditure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenditure.Location = new System.Drawing.Point(684, 4);
            this.btnExpenditure.Name = "btnExpenditure";
            this.btnExpenditure.Size = new System.Drawing.Size(163, 34);
            this.btnExpenditure.TabIndex = 4;
            this.btnExpenditure.Text = "EXPENDITURES";
            this.btnExpenditure.UseVisualStyleBackColor = true;
            this.btnExpenditure.Click += new System.EventHandler(this.btnExpenditure_Click);
            // 
            // btnSavings
            // 
            this.btnSavings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavings.Location = new System.Drawing.Point(514, 4);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(163, 34);
            this.btnSavings.TabIndex = 3;
            this.btnSavings.Text = "Savings";
            this.btnSavings.UseVisualStyleBackColor = true;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Location = new System.Drawing.Point(344, 4);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(163, 34);
            this.btnIncome.TabIndex = 2;
            this.btnIncome.Text = "Status of Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(4, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(163, 34);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnSources
            // 
            this.btnSources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSources.Location = new System.Drawing.Point(174, 4);
            this.btnSources.Name = "btnSources";
            this.btnSources.Size = new System.Drawing.Size(163, 34);
            this.btnSources.TabIndex = 1;
            this.btnSources.Text = "Source of Income";
            this.btnSources.UseVisualStyleBackColor = true;
            this.btnSources.Click += new System.EventHandler(this.btnSources_Click);
            // 
            // pnlSummaryContent
            // 
            this.pnlSummaryContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummaryContent.Location = new System.Drawing.Point(0, 42);
            this.pnlSummaryContent.Name = "pnlSummaryContent";
            this.pnlSummaryContent.Size = new System.Drawing.Size(1533, 816);
            this.pnlSummaryContent.TabIndex = 2;
            // 
            // btnHunger
            // 
            this.btnHunger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHunger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHunger.Location = new System.Drawing.Point(1024, 4);
            this.btnHunger.Name = "btnHunger";
            this.btnHunger.Size = new System.Drawing.Size(163, 34);
            this.btnHunger.TabIndex = 6;
            this.btnHunger.Text = "Experienced Hunger";
            this.btnHunger.UseVisualStyleBackColor = true;
            this.btnHunger.Click += new System.EventHandler(this.btnHunger_Click);
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 858);
            this.Controls.Add(this.pnlSummaryContent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSummary";
            this.Text = "frmSummary";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlSummaryContent;
        private System.Windows.Forms.Button btnSources;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnExpenditure;
        private System.Windows.Forms.Button btnSituation;
        private System.Windows.Forms.Button btnHunger;
    }
}