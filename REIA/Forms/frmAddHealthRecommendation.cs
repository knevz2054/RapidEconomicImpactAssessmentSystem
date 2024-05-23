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
    public partial class frmAddHealthRecommendation : Form
    {
        IDataRepository<HealthRecommendationList> healthRecommedationList = new DataRepository<HealthRecommendationList>();
        List<HealthRecommendationList> GetHealthRecommendationLists;
        public frmAddHealthRecommendation()
        {
            InitializeComponent();
        }

        private async void frmAddHealthRecommendation_Load(object sender, EventArgs e)
        {
            await CallLoad();
            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                HealthRecommendationList obj = await healthRecommedationList.Get(frmSettings.HealthRecommendationID);
                txtHealthRecommendation.Text = obj.ListHealthRecommendation;
            }
        }
        async Task CallLoad()
        {
            GetHealthRecommendationLists = await healthRecommedationList.GetAll();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    HealthRecommendationList obj = new HealthRecommendationList();
                    obj.ListHealthRecommendation = txtHealthRecommendation.Text;
                    await healthRecommedationList.Create(obj);

                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    HealthRecommendationList obj = await healthRecommedationList.Get(frmSettings.HealthRecommendationID);
                    obj.ListHealthRecommendation = txtHealthRecommendation.Text;
                    await healthRecommedationList.Update(obj);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadHealthRecommendation();
                    this.Close();
                }
            }
        }

        public bool IsValid()
        {
            if (txtHealthRecommendation.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Health Crisis Recommendation field is required...", "Error!");
                return false;
            }

            else if (GetHealthRecommendationLists.Count(x => x.ListHealthRecommendation == txtHealthRecommendation.Text) > 0)
            {
                MessageBox.Show("Action failed, Health Crisis Recommendation is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtHealthRecommendation.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Health Crisis Recommendation field is required...", "Error!");
                return false;
            }

            else if (GetHealthRecommendationLists.Count(x => x.ListHealthRecommendation == txtHealthRecommendation.Text && x.ID != frmSettings.HealthRecommendationID) > 0)
            {
                MessageBox.Show("Action failed, Health Crisis Recommendation is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        private void frmAddHealthRecommendation_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }
    }
}
