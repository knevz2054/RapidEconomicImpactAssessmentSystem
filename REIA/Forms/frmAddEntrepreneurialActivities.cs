using REIA.Models.Entities.Other;
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
    public partial class frmAddEntrepreneurialActivities : Form
    {
        IDataRepository<EntrepreneurialActivitiesList> entrepreneurialActivitiesList = new DataRepository<EntrepreneurialActivitiesList>();
        List<EntrepreneurialActivitiesList> GetEntrepreneurialActivitiesLists;
        public frmAddEntrepreneurialActivities()
        {
            InitializeComponent();
        }

        private async void frmAddEntrepreneurialActivities_Load(object sender, EventArgs e)
        {
            await CallLoad();

            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                EntrepreneurialActivitiesList obj = await entrepreneurialActivitiesList.Get(frmSettings.SalariesID);
                txtEntrepreneurial.Text = obj.ListEntrepreneurialActivities;
            }
        }

        async Task CallLoad()
        {
            GetEntrepreneurialActivitiesLists = await entrepreneurialActivitiesList.GetAll();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    EntrepreneurialActivitiesList obj = new EntrepreneurialActivitiesList();
                    obj.ListEntrepreneurialActivities = txtEntrepreneurial.Text;
                    await entrepreneurialActivitiesList.Create(obj);

                    frmSurveyQuestionnaire questionnaire = (frmSurveyQuestionnaire)Application.OpenForms["frmSurveyQuestionnaire"];
                    await questionnaire.LoadEntreprenuerial();
                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    EntrepreneurialActivitiesList obj = await entrepreneurialActivitiesList.Get(frmSettings.EntrepreneurialID);
                    obj.ListEntrepreneurialActivities = txtEntrepreneurial.Text;
                    await entrepreneurialActivitiesList.Update(obj);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadEntrepreneurial();
                    this.Close();
                }
            }
        }

        public bool IsValid()
        {
            if (txtEntrepreneurial.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Entrepreneurial Activities field is required...", "Error!");
                return false;
            }

            else if (GetEntrepreneurialActivitiesLists.Count(x => x.ListEntrepreneurialActivities == txtEntrepreneurial.Text) > 0)
            {
                MessageBox.Show("Action failed, Entrepreneurial Activities is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtEntrepreneurial.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Entrepreneurial Activities field is required...", "Error!");
                return false;
            }

            else if (GetEntrepreneurialActivitiesLists.Count(x => x.ListEntrepreneurialActivities == txtEntrepreneurial.Text && x.ID != frmSettings.EntrepreneurialID) > 0)
            {
                MessageBox.Show("Action failed, Entrepreneurial Activities is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        private void frmAddEntrepreneurialActivities_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }
    }
}
