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
    public partial class frmAddEconomicRecommendation : Form
    {
        IDataRepository<EconomicRecommendationList> economicRecommedationList = new DataRepository<EconomicRecommendationList>();
        List<EconomicRecommendationList> GetEconomicRecommendationLists;
        public frmAddEconomicRecommendation()
        {
            InitializeComponent();
        }

        private async void frmAddEconomicRecommendation_Load(object sender, EventArgs e)
        {
            await CallLoad();
            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                EconomicRecommendationList obj = await economicRecommedationList.Get(frmSettings.EconomicRecommendationID);
                txtEconomicRecommendation.Text = obj.ListEconomicRecommendation;
            }
        }
        async Task CallLoad()
        {
            GetEconomicRecommendationLists = await economicRecommedationList.GetAll();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    EconomicRecommendationList obj = new EconomicRecommendationList();
                    obj.ListEconomicRecommendation = txtEconomicRecommendation.Text;
                    await economicRecommedationList.Create(obj);

                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    EconomicRecommendationList obj = await economicRecommedationList.Get(frmSettings.EconomicRecommendationID);
                    obj.ListEconomicRecommendation = txtEconomicRecommendation.Text;
                    await economicRecommedationList.Update(obj);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadEconomicRecommendation();
                    this.Close();
                }
            }
        }

        public bool IsValid()
        {
            if (txtEconomicRecommendation.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Health Economic Recommendation field is required...", "Error!");
                return false;
            }

            else if (GetEconomicRecommendationLists.Count(x => x.ListEconomicRecommendation == txtEconomicRecommendation.Text) > 0)
            {
                MessageBox.Show("Action failed, Health Economic Recommendation is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtEconomicRecommendation.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Economic Crisis Recommendation field is required...", "Error!");
                return false;
            }

            else if (GetEconomicRecommendationLists.Count(x => x.ListEconomicRecommendation == txtEconomicRecommendation.Text && x.ID != frmSettings.EconomicRecommendationID) > 0)
            {
                MessageBox.Show("Action failed, Economic Crisis Recommendation is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        private void frmAddEconomicRecommendation_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }
    }
}
