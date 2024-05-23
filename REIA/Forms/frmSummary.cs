using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REIA.Forms
{
    public partial class frmSummary : Form
    {
        public frmSummary()
        {
            InitializeComponent();
        }
              
        private void btnProfile_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main" && x.Name != "frmSummary").ToList().ForEach(x => x.Close());
            frmProfileSummary obj = new frmProfileSummary();
            obj.TopLevel = false;
            pnlSummaryContent.Controls.Add(obj);
            obj.Dock = DockStyle.Fill;
            obj.Show();

            btnProfile.Enabled = false;
            btnSources.Enabled = true;
            btnIncome.Enabled = true;
            btnSavings.Enabled = true;
            btnExpenditure.Enabled = true;
            btnSituation.Enabled = true;
        }

        private void btnSources_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main" && x.Name != "frmSummary").ToList().ForEach(x => x.Close());
            frmFamilyIncomeSummary obj = new frmFamilyIncomeSummary();
            obj.TopLevel = false;
            pnlSummaryContent.Controls.Add(obj);
            obj.Dock = DockStyle.Fill;
            obj.Show();

            btnProfile.Enabled = true;
            btnSources.Enabled = false;
            btnIncome.Enabled = true;
            btnSavings.Enabled = true;
            btnExpenditure.Enabled = true;
            btnSituation.Enabled = true;
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main" && x.Name != "frmSummary").ToList().ForEach(x => x.Close());
            frmIncomeSummary obj = new frmIncomeSummary();
            obj.TopLevel = false;
            pnlSummaryContent.Controls.Add(obj);
            obj.Dock = DockStyle.Fill;
            obj.Show();

            btnProfile.Enabled = true;
            btnSources.Enabled = true;
            btnIncome.Enabled = false;
            btnSavings.Enabled = true;
            btnExpenditure.Enabled = true;
            btnSituation.Enabled = true;
            btnHunger.Enabled = true;
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main" && x.Name != "frmSummary").ToList().ForEach(x => x.Close());
            frmSavingsSummary obj = new frmSavingsSummary();
            obj.TopLevel = false;
            pnlSummaryContent.Controls.Add(obj);
            obj.Dock = DockStyle.Fill;
            obj.Show();

            btnProfile.Enabled = true;
            btnSources.Enabled = true;
            btnIncome.Enabled = true;
            btnSavings.Enabled = false;
            btnExpenditure.Enabled = true;
            btnSituation.Enabled = true;
            btnHunger.Enabled = true;
        }

        private void btnExpenditure_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main" && x.Name != "frmSummary").ToList().ForEach(x => x.Close());
            frmExpenditureSummary obj = new frmExpenditureSummary();
            obj.TopLevel = false;
            pnlSummaryContent.Controls.Add(obj);
            obj.Dock = DockStyle.Fill;
            obj.Show();

            btnProfile.Enabled = true;
            btnSources.Enabled = true;
            btnIncome.Enabled = true;
            btnSavings.Enabled = true;
            btnExpenditure.Enabled = false;
            btnSituation.Enabled = true;
            btnHunger.Enabled = true;
        }

        private void btnSituation_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main" && x.Name != "frmSummary").ToList().ForEach(x => x.Close());
            frmEconomicSituationSummary obj = new frmEconomicSituationSummary();
            obj.TopLevel = false;
            pnlSummaryContent.Controls.Add(obj);
            obj.Dock = DockStyle.Fill;
            obj.Show();

            btnProfile.Enabled = true;
            btnSources.Enabled = true;
            btnIncome.Enabled = true;
            btnSavings.Enabled = true;
            btnExpenditure.Enabled = true;
            btnSituation.Enabled = false;
            btnHunger.Enabled = true;
        }

        private void btnHunger_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main" && x.Name != "frmSummary").ToList().ForEach(x => x.Close());
            frmExperiencedHungerSummary obj = new frmExperiencedHungerSummary();
            obj.TopLevel = false;
            pnlSummaryContent.Controls.Add(obj);
            obj.Dock = DockStyle.Fill;
            obj.Show();

            btnProfile.Enabled = true;
            btnSources.Enabled = true;
            btnIncome.Enabled = true;
            btnSavings.Enabled = true;
            btnExpenditure.Enabled = true;
            btnSituation.Enabled = true;
            btnHunger.Enabled = false;
        }
    }
}
