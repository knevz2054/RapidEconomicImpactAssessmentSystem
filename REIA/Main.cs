using REIA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REIA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmSettings setting = new frmSettings();
            setting.TopLevel = false;
            pnlContent.Controls.Add(setting);
            setting.Dock = DockStyle.Fill;
            setting.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = true;
            btnSummary.Enabled = true;
            btnSettings.Enabled = false;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmSurveyQuestionnaire fsq = new frmSurveyQuestionnaire();
            fsq.TopLevel = false;
            pnlContent.Controls.Add(fsq);
            fsq.Dock = DockStyle.Fill;
            fsq.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = false;
            btnSummary.Enabled = true;
            btnSettings.Enabled = true;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmSummary summary = new frmSummary();
            summary.TopLevel = false;
            pnlContent.Controls.Add(summary);
            summary.Dock = DockStyle.Fill;
            summary.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = true;
            btnSummary.Enabled = false;
            btnSettings.Enabled = true;

        }
    }
}
