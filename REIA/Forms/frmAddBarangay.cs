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
using System.Xml;

namespace REIA.Forms
{
    public partial class frmAddBarangay : Form
    {
        IDataRepository<Barangay> rep_Barangay = new DataRepository<Barangay>();
        IDataRepository<Municipality> rep_Municipality = new DataRepository<Municipality>();
        IDataRepository<Cluster> rep_Cluster = new DataRepository<Cluster>();
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;
        List<Cluster> GetClusters;
        static int MunID;
        static string district;
        public frmAddBarangay()
        {
            InitializeComponent();
        }

        private async void frmAddBarangay_Load(object sender, EventArgs e)
        {
            await CallLoad();
            foreach (var item in GetClusters)
                cbCluster.Items.Add(item.ClusterName);
            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                Barangay barangay = await rep_Barangay.Get(frmSettings.BrgyID);
                txtBarangay.Text = barangay.BarangayName;
               
                if (barangay.Municipality.District == "1st District")
                    rb_1stDistrict.Checked = true;
                else
                    rb_2ndDistrict.Checked = true;

                cbMunicipality.Text = barangay.Municipality.MunicipalityName;
                cbCluster.Text = barangay.BarangayCluster;
                
            }
        }

        private void Select_District(object sender, EventArgs e)
        {
            district = Controls.OfType<RadioButton>().Where(x => x.Checked).ToList().Select(x => x.Text).SingleOrDefault();
            if (rb_1stDistrict.Checked)
            {
                cbMunicipality.Items.Clear();
                foreach (var item in GetMunicipalities.Where(x => x.District == district))
                    cbMunicipality.Items.Add(item.MunicipalityName);
            }

            if (rb_2ndDistrict.Checked)
            {
                cbMunicipality.Items.Clear();
                foreach (var item in GetMunicipalities.Where(x => x.District == district))
                    cbMunicipality.Items.Add(item.MunicipalityName);
            }

        }

        public async Task CallLoad()
        {
            GetMunicipalities = await rep_Municipality.GetAll();
            GetBarangays = await rep_Barangay.GetAll();
            GetClusters = await rep_Cluster.GetAll();
        }

        private void cbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            MunID = GetMunicipalities.Where(x => x.MunicipalityName == cbMunicipality.Text && x.District == district).Select(x => x.ID).SingleOrDefault(); 
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    Barangay barangay = new Barangay();
                    barangay.BarangayName = txtBarangay.Text;
                    barangay.MunID = MunID;
                    barangay.BarangayCluster = cbCluster.Text;
                    await rep_Barangay.Create(barangay);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadBarangay();
                    this.Close();
                }
            }

            if(btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    Barangay barangay = await rep_Barangay.Get(frmSettings.BrgyID);
                    barangay.BarangayName = txtBarangay.Text;
                    barangay.MunID = MunID;
                    barangay.BarangayCluster = cbCluster.Text;
                    await rep_Barangay.Update(barangay);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadBarangay();
                    this.Close();
                }
            }
        }

        public bool IsValid()
        {
            if (txtBarangay.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Barangay name is required...", "Error!");
                return false;
            }

            if(cbMunicipality.SelectedItem == null)
            {
                MessageBox.Show("Action failed, Select municipality...", "Error!");
                return false;
            }

            if (GetBarangays.Count(x => x.MunID == MunID && x.BarangayName == txtBarangay.Text) > 0)
            {
                MessageBox.Show("Action failed, Barangay already listed...", "Error!");
                return false;
            }
            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtBarangay.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Barangay name is required...", "Error!");
                return false;
            }

            if (cbMunicipality.SelectedItem == null)
            {
                MessageBox.Show("Action failed, Select municipality...", "Error!");
                return false;
            }

            if (GetBarangays.Count(x => x.MunID == MunID && x.BarangayName == txtBarangay.Text && x.ID != frmSettings.BrgyID) > 0)
            {
                MessageBox.Show("Action failed, Barangay already listed...", "Error!");
                return false;
            }
            else return true;
        }

        private void frmAddBarangay_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }
    }
}
