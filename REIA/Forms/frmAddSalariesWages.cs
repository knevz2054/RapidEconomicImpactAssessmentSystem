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
    public partial class frmAddSalariesWages : Form
    {
        IDataRepository<SalariesWagesList> salariesWagesList = new DataRepository<SalariesWagesList>();
        List<SalariesWagesList> GetSalariesWagesLists;
        public frmAddSalariesWages()
        {
            InitializeComponent();
        }

        private async void frmAddSalariesWages_Load(object sender, EventArgs e)
        {
            await CallLoad();

            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                SalariesWagesList obj = await salariesWagesList.Get(frmSettings.SalariesID);
                txtSalariesWages.Text = obj.ListSalariesWages;
            }
        }
        async Task CallLoad()
        {
            GetSalariesWagesLists = await salariesWagesList.GetAll();
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    SalariesWagesList obj = new SalariesWagesList();
                    obj.ListSalariesWages = txtSalariesWages.Text;
                    await salariesWagesList.Create(obj);

                    frmSurveyQuestionnaire questionnaire = (frmSurveyQuestionnaire)Application.OpenForms["frmSurveyQuestionnaire"];
                    await questionnaire.LoadSalariesWages();
                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    SalariesWagesList obj = await salariesWagesList.Get(frmSettings.SalariesID);
                    obj.ListSalariesWages = txtSalariesWages.Text;
                    await salariesWagesList.Update(obj);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadSalariesWages();
                    this.Close();
                }
            }
        }

        public bool IsValid()
        {
            if (txtSalariesWages.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Salaries and Wages field is required...", "Error!");
                return false;
            }

            else if (GetSalariesWagesLists.Count(x => x.ListSalariesWages == txtSalariesWages.Text) > 0)
            {
                MessageBox.Show("Action failed, Salaries and Wages is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtSalariesWages.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Salaries and Wages field is required...", "Error!");
                return false;
            }

            else if (GetSalariesWagesLists.Count(x => x.ListSalariesWages == txtSalariesWages.Text && x.ID != frmSettings.SalariesID) > 0)
            {
                MessageBox.Show("Action failed, Salaries and Wages is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        private void frmAddSalariesWages_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }
    }
}
