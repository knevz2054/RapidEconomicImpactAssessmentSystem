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
    public partial class frmAddReason : Form
    {
        IDataRepository<ReasonList> reasonList = new DataRepository<ReasonList>();
        List<ReasonList> GetReasonLists;
        public frmAddReason()
        {
            InitializeComponent();
        }

        private async void frmAddReason_Load(object sender, EventArgs e)
        {
            await CallLoad();

            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                ReasonList obj = await reasonList.Get(frmSettings.ReasonID);
                txtReason.Text = obj.ListReason;
            }
        }

        async Task CallLoad()
        {
            GetReasonLists = await reasonList.GetAll();
        }

        public bool IsValid()
        {
            if (txtReason.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Reason field is required...", "Error!");
                return false;
            }

            else if (GetReasonLists.Count(x => x.ListReason == txtReason.Text) > 0)
            {
                MessageBox.Show("Action failed, Reason is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtReason.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Reason field is required...", "Error!");
                return false;
            }

            else if (GetReasonLists.Count(x => x.ListReason == txtReason.Text && x.ID != frmSettings.ReasonID) > 0)
            {
                MessageBox.Show("Action failed, Reason is already listed...", "Error!");
                return false;
            }

            else return true;
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    ReasonList obj = new ReasonList();
                    obj.ListReason = txtReason.Text;
                    await reasonList.Create(obj);

                    frmSurveyQuestionnaire questionnaire = (frmSurveyQuestionnaire)Application.OpenForms["frmSurveyQuestionnaire"];
                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    ReasonList obj = await reasonList.Get(frmSettings.ReasonID);
                    obj.ListReason = txtReason.Text;
                    await reasonList.Update(obj);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadReason();
                    this.Close();
                }
            }
        }

        private void frmAddReason_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }
    }
}
