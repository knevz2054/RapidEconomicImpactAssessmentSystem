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
    public partial class frmAddOtherSources : Form
    {
        IDataRepository<OtherSourcesList> otherSourcesList = new DataRepository<OtherSourcesList>();
        List<OtherSourcesList> GetOtherSourcesLists;

        public frmAddOtherSources()
        {
            InitializeComponent();
        }

        private async void frmAddOtherSources_Load(object sender, EventArgs e)
        {
            await CallLoad();

            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                OtherSourcesList obj = await otherSourcesList.Get(frmSettings.OtherSourcesID);
                txtOtherSources.Text = obj.ListOtherSources;
            }
        }

        async Task CallLoad()
        {
            GetOtherSourcesLists = await otherSourcesList.GetAll();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    OtherSourcesList obj = new OtherSourcesList();
                    obj.ListOtherSources = txtOtherSources.Text;
                    await otherSourcesList.Create(obj);

                    frmSurveyQuestionnaire questionnaire = (frmSurveyQuestionnaire)Application.OpenForms["frmSurveyQuestionnaire"];
                    await questionnaire.LoadOtherSources();
                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    OtherSourcesList obj = await otherSourcesList.Get(frmSettings.OtherSourcesID);
                    obj.ListOtherSources = txtOtherSources.Text;
                    await otherSourcesList.Update(obj);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadOtherSources();
                    this.Close();
                }
            }
        }

        public bool IsValid()
        {
            if (txtOtherSources.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Other Sources field is required...", "Error!");
                return false;
            }

            else if (GetOtherSourcesLists.Count(x => x.ListOtherSources == txtOtherSources.Text) > 0)
            {
                MessageBox.Show("Action failed, Other Sources is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtOtherSources.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Other Sources field is required...", "Error!");
                return false;
            }

            else if (GetOtherSourcesLists.Count(x => x.ListOtherSources == txtOtherSources.Text && x.ID != frmSettings.OtherSourcesID) > 0)
            {
                MessageBox.Show("Action failed, Other Sources is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        private void frmAddOtherSources_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }
    }
}
