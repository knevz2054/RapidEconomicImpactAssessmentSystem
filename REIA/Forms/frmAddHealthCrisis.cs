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
    public partial class frmAddHealthCrisis : Form
    {
        IDataRepository<HealtCrisisList> healthCrisisList = new DataRepository<HealtCrisisList>();
        List<HealtCrisisList> GetHealtCrisisLists;
        public frmAddHealthCrisis()
        {
            InitializeComponent();
        }

        private async void frmAddHealthCrisis_Load(object sender, EventArgs e)
        {
            await CallLoad();
            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                HealtCrisisList obj = await healthCrisisList.Get(frmSettings.HealthCrisisID);
                txtHealthCrisis.Text = obj.ListHealthCrisis;
            }
        }

        async Task CallLoad()
        {
            GetHealtCrisisLists = await healthCrisisList.GetAll();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    HealtCrisisList obj = new HealtCrisisList();
                    obj.ListHealthCrisis = txtHealthCrisis.Text;
                    await healthCrisisList.Create(obj);

                    frmSurveyQuestionnaire questionnaire = (frmSurveyQuestionnaire)Application.OpenForms["frmSurveyQuestionnaire"];
                    questionnaire.LoadHealthCrisis();
                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    HealtCrisisList obj = await healthCrisisList.Get(frmSettings.HealthCrisisID);
                    obj.ListHealthCrisis = txtHealthCrisis.Text;
                    await healthCrisisList.Update(obj);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadHealthCrisis();
                    this.Close();
                }
            }
        }

        public bool IsValid()
        {
            if (txtHealthCrisis.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Health Crisis field is required...", "Error!");
                return false;
            }

            else if (GetHealtCrisisLists.Count(x => x.ListHealthCrisis == txtHealthCrisis.Text) > 0)
            {
                MessageBox.Show("Action failed, Health Crisis is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtHealthCrisis.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Health Crisis field is required...", "Error!");
                return false;
            }

            else if (GetHealtCrisisLists.Count(x => x.ListHealthCrisis == txtHealthCrisis.Text && x.ID != frmSettings.HealthCrisisID) > 0)
            {
                MessageBox.Show("Action failed, Health Crisis is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        private void frmAddHealthCrisis_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }

    }
}
