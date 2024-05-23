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
    public partial class frmAddCluster : Form
    {
        IDataRepository<Cluster> repository = new DataRepository<Cluster>();
        List<Cluster> GetClusters;
        public frmAddCluster()
        {
            InitializeComponent();
        }

        private async void frmAddCluster_Load(object sender, EventArgs e)
        {
            await CallLoad();
            if (frmSettings.OnEdit == true)
            {
                this.Text = "Update Info";
                btnAdd.Text = "Update";
                Cluster cluster = await repository.Get(frmSettings.ClusID);
                txtCluster.Text = cluster.ClusterName;
            }
        }

        public async Task CallLoad()
        {
            GetClusters = await repository.GetAll();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Add")
            {
                if (IsValid())
                {
                    Cluster cluster = new Cluster();
                    cluster.ClusterName = txtCluster.Text;
                    await repository.Create(cluster);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadCluster();
                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (IsValidUpdate())
                {
                    Cluster cluster = await repository.Get(frmSettings.ClusID);
                    cluster.ClusterName = txtCluster.Text;
                    await repository.Update(cluster);

                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadCluster();
                    this.Close();
                }
            }
        }

        public bool IsValid()
        {
            if (txtCluster.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Cluster name is required...", "Error!");
                return false;
            }
                      
            else if (GetClusters.Count(x => x.ClusterName == txtCluster.Text) > 0)
            {
                MessageBox.Show("Action failed, Cluster is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        public bool IsValidUpdate()
        {
            if (txtCluster.Text == string.Empty)
            {
                MessageBox.Show("Action failed, Cluster name is required...", "Error!");
                return false;
            }

            else if (GetClusters.Count(x => x.ClusterName == txtCluster.Text && x.ID != frmSettings.ClusID) > 0)
            {
                MessageBox.Show("Action failed, Cluster is already listed...", "Error!");
                return false;
            }

            else return true;
        }

        private void frmAddCluster_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSettings.OnEdit = false;
        }

        private void txtCluster_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
