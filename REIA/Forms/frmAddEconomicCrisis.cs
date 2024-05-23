using REIA.Models.Entities.Lists;
using REIA.Services.Repository;
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
    public partial class frmAddEconomicCrisis : Form
    {
        IDataRepository<EconomicCrisisList> economicCrisisList = new DataRepository<EconomicCrisisList>();
        List<EconomicCrisisList> GetEconomicCrisisLists;
        public frmAddEconomicCrisis()
        {
            InitializeComponent();
        }

        private async void frmAddEconomicCrisis_Load(object sender, EventArgs e)
        {
            await CallLoad();
            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                EconomicCrisisList obj = await economicCrisisList.Get(frmSettings.EcomicCrisisID);
                txtEconomicCrisis.Text = obj.ListEconomicCrisis;
            }
        }
        async Task CallLoad()
        {
            GetEconomicCrisisLists = await economicCrisisList.GetAll();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    EconomicCrisisList obj = new EconomicCrisisList();
                    obj.ListEconomicCrisis = txtEconomicCrisis.Text;
                    await economicCrisisList.Create(obj);

                    frmSurveyQuestionnaire questionnaire = (frmSurveyQuestionnaire)Application.OpenForms["frmSurveyQuestionnaire"];
                    questionnaire.LoadEconomicCrisis();
                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    EconomicCrisisList obj = await economicCrisisList.Get(frmSettings.EcomicCrisisID);
                    obj.ListEconomicCrisis = txtEconomicCrisis.Text;
                    await economicCrisisList.Update(obj);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadEconomicCrisis();
                    this.Close();
                }
            }
        }

        public bool IsValid()
        {
            if (txtEconomicCrisis.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Economic Crisis field is required...", "Error!");
                return false;
            }

            else if (GetEconomicCrisisLists.Count(x => x.ListEconomicCrisis == txtEconomicCrisis.Text) > 0)
            {
                MessageBox.Show("Action failed, Economic Crisis is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtEconomicCrisis.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Economic Crisis field is required...", "Error!");
                return false;
            }

            else if (GetEconomicCrisisLists.Count(x => x.ListEconomicCrisis == txtEconomicCrisis.Text && x.ID != frmSettings.EcomicCrisisID) > 0)
            {
                MessageBox.Show("Action failed, Economic is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        private void frmAddEconomicCrisis_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }
    }
}
