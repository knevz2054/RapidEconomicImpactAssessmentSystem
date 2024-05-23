using REIA.Models.DataContext;
using REIA.Models.Entities;
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
    public partial class frmAddMunicipality : Form
    {
        IDataRepository<Municipality> repository = new DataRepository<Municipality>();
        List<Municipality> GetMunicipalities;
        static string district;
        public frmAddMunicipality()
        {
            InitializeComponent();
        }

        private async void frmAddMunicipality_Load(object sender, EventArgs e)
        {
            await CallLoad();

            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                Municipality municipality = await repository.Get(frmSettings.MunID);
                txtMunicipality.Text = municipality.MunicipalityName;
                if (municipality.District == "1st District")
                    rb_1stDistrict.Checked = true;
                else
                    rb_2ndDistrict.Checked = true;
            }
        }

        public async Task CallLoad()
        {
            GetMunicipalities = await repository.GetAll();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    Municipality municipality = new Municipality();
                    municipality.MunicipalityName = txtMunicipality.Text.Trim();
                    municipality.District = district;
                    await repository.Create(municipality);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadMunicipality();
                    this.Close();
                }
            }
            
            if(btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    Municipality municipality = await repository.Get(frmSettings.MunID);
                    municipality.MunicipalityName = txtMunicipality.Text.Trim();
                    municipality.District = district;
                    await repository.Update(municipality);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadMunicipality();
                    this.Close();
                }
                
            }
        }

        public void rb_District(object sender, EventArgs e)
        {
            district = Controls.OfType<RadioButton>().Where(x => x.Checked).ToList().Select(x => x.Text).SingleOrDefault();
        }
        public bool IsValid()
        {
            if (txtMunicipality.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Municipality name is required...", "Error!");
                return false;
            }

            else if (Controls.OfType<RadioButton>().Count(xx => xx.Checked) == 0)
            {
                MessageBox.Show("Action failed, Select a district...", "Error!");
                return false;
            }
            else if (GetMunicipalities.Count != 0 && GetMunicipalities.Count(x => x.MunicipalityName == txtMunicipality.Text && x.District == district) > 0)
            {
                MessageBox.Show("Action failed, Municipality is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtMunicipality.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Municipality name is required...", "Error!");
                return false;
            }

            else if (Controls.OfType<RadioButton>().Count(xx => xx.Checked) == 0)
            {
                MessageBox.Show("Action failed, Select a district...", "Error!");
                return false;
            }
            else if (GetMunicipalities.Count != 0 && GetMunicipalities.Count(x => x.MunicipalityName == txtMunicipality.Text && x.District == district && x.ID != frmSettings.MunID) > 0)
            {
                MessageBox.Show("Action failed, Municipality is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        private void frmAddMunicipality_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }
    }
}
