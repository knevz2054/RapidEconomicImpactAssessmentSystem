using REIA.Models.Entities;
using REIA.Models.Entities.Lists;
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
    public partial class frmSettings : Form
    {
        IDataRepository<Municipality> rep_Municipality = new DataRepository<Municipality>();
        IDataRepository<Barangay> rep_Barangay = new DataRepository<Barangay>();
        IDataRepository<Cluster> rep_Cluster = new DataRepository<Cluster>();
        IDataRepository<SalariesWagesList> salariesWagesList = new DataRepository<SalariesWagesList>();
        IDataRepository<EntrepreneurialActivitiesList> entrepreneurialActivitiesList = new DataRepository<EntrepreneurialActivitiesList>();
        IDataRepository<OtherSourcesList> otherSourcesList = new DataRepository<OtherSourcesList>();
        IDataRepository<ReasonList> reasonList = new DataRepository<ReasonList>();
        IDataRepository<HealtCrisisList> healthCrisisList = new DataRepository<HealtCrisisList>();
        IDataRepository<HealthRecommendationList> healthCrisisRecommendationList = new DataRepository<HealthRecommendationList>();
        IDataRepository<EconomicCrisisList> economicCrisisList = new DataRepository<EconomicCrisisList>();
        IDataRepository<EconomicRecommendationList> economicCrisisRecommendationList = new DataRepository<EconomicRecommendationList>();
        IDataRepository<Survey> Surveys = new DataRepository<Survey>();

        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;
        List<Cluster> GetClusters;
        List<SalariesWagesList> GetSalariesWagesLists;
        List<EntrepreneurialActivitiesList> GetEntrepreneurialActivitiesLists;
        List<OtherSourcesList> GetOtherSourcesLists;
        List<ReasonList> GetReasonLists;
        List<HealtCrisisList> GetHealtCrisisLists;
        List<HealthRecommendationList> GetHealthRecommendationLists;
        List<EconomicCrisisList> GetEconomicCrisisLists;
        List<EconomicRecommendationList> GetEconomicRecommendationLists;
        List<Survey> GetSurveys;

        public static int MunID;
        public static int BrgyID;
        public static int ClusID;
        public static int SalariesID;
        public static int EntrepreneurialID;
        public static int OtherSourcesID;
        public static int ReasonID;
        public static int HealthCrisisID;
        public static int HealthRecommendationID;
        public static int EcomicCrisisID;
        public static int EconomicRecommendationID;
        public static int SurveyID;
        public static int RespondentID;

        public static bool OnEdit;
        public frmSettings()
        {
            InitializeComponent();
        }

        private async void frmSettings_Load(object sender, EventArgs e)
        {
            await LoadMunicipality();
            await LoadBarangay();
            await LoadCluster();
            await LoadSalariesWages();
            await LoadEntrepreneurial();
            await LoadOtherSources();
            await LoadReason();
            await LoadHealthCrisis();
            await LoadHealthRecommendation();
            await LoadEconomicCrisis();
            await LoadEconomicRecommendation();
            await LoadSurveys();
        }

        public async Task LoadMunicipality()
        {
            GetMunicipalities = await rep_Municipality.GetAll();
            dgvMunicipality.DataSource = GetMunicipalities.Select(x => new
            {
                ID = x.ID,
                Municipality = x.MunicipalityName,
                District = x.District
            }).OrderBy(x => x.Municipality).ThenBy(x => x.District).ToList();
        }

        public async Task LoadBarangay()
        {

            GetBarangays = await rep_Barangay.GetAll();
            dgvBarangay.DataSource = GetBarangays.Select(x => new
            {
                ID = x.ID,
                Barangay = x.BarangayName,
                Municipality = x.Municipality.MunicipalityName,
                District = x.Municipality.District,
                Cluster = x.BarangayCluster
            }).OrderBy(x => x.Municipality).ThenBy(x => x.District).ThenBy(x => x.Barangay).ToList();
        }

        public async Task LoadCluster()
        {

            GetClusters = await rep_Cluster.GetAll();
            dgvCluster.DataSource = GetClusters.Select(x => new
            {
                ID = x.ID,
                Cluster = x.ClusterName
            }).OrderBy(x => x.Cluster).ToList();
        }

        public async Task LoadSalariesWages()
        {
            GetSalariesWagesLists = await salariesWagesList.GetAll();
            dgvSalariesWages.DataSource = GetSalariesWagesLists.Select(x => new
            {
                ID = x.ID,
                Salary_Type = x.ListSalariesWages
            }).OrderBy(x => x.Salary_Type).ToList();
        }

        public async Task LoadEntrepreneurial()
        {
            GetEntrepreneurialActivitiesLists = await entrepreneurialActivitiesList.GetAll();
            dgvEntrepreneurial.DataSource = GetEntrepreneurialActivitiesLists.Select(x => new
            {
                ID = x.ID,
                Activity_Type = x.ListEntrepreneurialActivities
            }).OrderBy(x => x.Activity_Type).ToList();
        }

        public async Task LoadOtherSources()
        {
            GetOtherSourcesLists = await otherSourcesList.GetAll();
            dgvOtherSources.DataSource = GetOtherSourcesLists.Select(x => new
            {
                ID = x.ID,
                Other_Sources = x.ListOtherSources
            }).OrderBy(x => x.Other_Sources).ToList();
        }

        public async Task LoadReason()
        {
            GetReasonLists = await reasonList.GetAll();
            dgvReason.DataSource = GetReasonLists.Select(x => new
            {
                ID = x.ID,
                Reason = x.ListReason
            }).OrderBy(x => x.Reason).ToList();
        }
        public async Task LoadHealthCrisis()
        {
            GetHealtCrisisLists = await healthCrisisList.GetAll();
            dgvHealthCrisis.DataSource = GetHealtCrisisLists.Select(x => new
            {
                ID = x.ID,
                Health_Crisis = x.ListHealthCrisis
            }).OrderBy(x => x.Health_Crisis).ToList();
        }
        public async Task LoadHealthRecommendation()
        {
            GetHealthRecommendationLists = await healthCrisisRecommendationList.GetAll();
            dgvHealthRecommendation.DataSource = GetHealthRecommendationLists.Select(x => new
            {
                ID = x.ID,
                Recommendation = x.ListHealthRecommendation
            }).OrderBy(x => x.Recommendation).ToList();
        }

        public async Task LoadEconomicCrisis()
        {
            GetEconomicCrisisLists = await economicCrisisList.GetAll();
            dgvEconomicCrisis.DataSource = GetEconomicCrisisLists.Select(x => new
            {
                ID = x.ID,
                Economic_Crisis = x.ListEconomicCrisis
            }).OrderBy(x => x.Economic_Crisis).ToList();
        }

        public async Task LoadEconomicRecommendation()
        {
            GetEconomicRecommendationLists = await economicCrisisRecommendationList.GetAll();
            dgvEconomicRecommendation.DataSource = GetEconomicRecommendationLists.Select(x => new
            {
                ID = x.ID,
                Recommendation = x.ListEconomicRecommendation
            }).OrderBy(x => x.Recommendation).ToList();
        }
        public async Task LoadSurveys()
        {
            GetSurveys = await Surveys.GetAll();
            dgvSurvey.DataSource = GetSurveys.Select(x => new
            {
                ID = x.ID,
                RespondentCode = x.RespondentCode,
                EnumeratorCode = x.EnumeratorsCode,
                RespondentID = x.RespondentID,
                DateSurveyd = x.DateSurveyed,
                District = x.Respondent.Barangay.Municipality.District,
                Municipality = x.Respondent.Barangay.Municipality.MunicipalityName,
                Barangay = x.Respondent.Barangay.BarangayName
            }).OrderByDescending(x => x.DateSurveyd).ThenBy(x => x.ID).ToList();
        }

        private void btnCreateMunicipality_Click(object sender, EventArgs e)
        {
            frmAddMunicipality fam = new frmAddMunicipality();
            fam.ShowDialog();
        }

        private async void dgvMunicipality_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMunicipality.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                MunID = int.Parse(dgvMunicipality.CurrentRow.Cells[2].Value.ToString());

                frmAddMunicipality fam = new frmAddMunicipality();
                fam.ShowDialog();
            }

            if (dgvMunicipality.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                MunID = int.Parse(dgvMunicipality.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Municipality?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    if (GetBarangays.Count(x => x.MunID == MunID) > 0)
                    {
                        MessageBox.Show("Deletion failed, Municipality has barangay...", "Error!");
                        return;
                    }
                    else
                    {
                        await rep_Municipality.Delete(MunID);
                        await LoadMunicipality();
                    }
                }
            }
        }

        private void dgvBarangay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBarangay.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                BrgyID = int.Parse(dgvBarangay.CurrentRow.Cells[2].Value.ToString());

                frmAddBarangay fad = new frmAddBarangay();
                fad.ShowDialog();
            }
        }

        private void btnCreateBarangay_Click(object sender, EventArgs e)
        {
            frmAddBarangay fab = new frmAddBarangay();
            fab.ShowDialog();
        }

        private void btnCreateCluster_Click(object sender, EventArgs e)
        {
            frmAddCluster fac = new frmAddCluster();
            fac.ShowDialog();
        }

        private async void dgvCluster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCluster.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                ClusID = int.Parse(dgvCluster.CurrentRow.Cells[2].Value.ToString());

                frmAddCluster fac = new frmAddCluster();
                fac.ShowDialog();
            }

            if (dgvCluster.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                ClusID = int.Parse(dgvMunicipality.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Cluster?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    await rep_Cluster.Delete(ClusID);
                    await LoadCluster();
                }
            }
        }

        private async void dgvSalariesWages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSalariesWages.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                SalariesID = int.Parse(dgvSalariesWages.CurrentRow.Cells[2].Value.ToString());

                frmAddSalariesWages obj = new frmAddSalariesWages();
                obj.ShowDialog();
            }

            if (dgvSalariesWages.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                SalariesID = int.Parse(dgvSalariesWages.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Salaries/Wages?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    await salariesWagesList.Delete(SalariesID);
                    await LoadSalariesWages();
                }
            }
        }

        private async void dgvEntrepreneurial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntrepreneurial.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                EntrepreneurialID = int.Parse(dgvEntrepreneurial.CurrentRow.Cells[2].Value.ToString());

                frmAddEntrepreneurialActivities obj = new frmAddEntrepreneurialActivities();
                obj.ShowDialog();
            }

            if (dgvEntrepreneurial.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                EntrepreneurialID = int.Parse(dgvEntrepreneurial.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Entrepreneurial Activity?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    await entrepreneurialActivitiesList.Delete(EntrepreneurialID);
                    await LoadEntrepreneurial();
                }
            }
        }

        private async void dgvOtherSources_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOtherSources.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                OtherSourcesID = int.Parse(dgvOtherSources.CurrentRow.Cells[2].Value.ToString());

                frmAddOtherSources obj = new frmAddOtherSources();
                obj.ShowDialog();
            }

            if (dgvOtherSources.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                OtherSourcesID = int.Parse(dgvOtherSources.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Other Sources?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    await otherSourcesList.Delete(OtherSourcesID);
                    await LoadOtherSources();
                }
            }
        }

        private async void dgvReason_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReason.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                ReasonID = int.Parse(dgvReason.CurrentRow.Cells[2].Value.ToString());

                frmAddReason obj = new frmAddReason();
                obj.ShowDialog();
            }

            if (dgvReason.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                ReasonID = int.Parse(dgvReason.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Reason?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    await reasonList.Delete(ReasonID);
                    await LoadReason();
                }
            }
        }

        private async void dgvHealthCrisis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHealthCrisis.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                HealthCrisisID = int.Parse(dgvHealthCrisis.CurrentRow.Cells[2].Value.ToString());

                frmAddHealthCrisis obj = new frmAddHealthCrisis();
                obj.ShowDialog();
            }

            if (dgvHealthCrisis.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                HealthCrisisID = int.Parse(dgvHealthCrisis.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Health Crisis?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    await healthCrisisList.Delete(HealthCrisisID);
                    await LoadHealthCrisis();
                }
            }
        }

        private async void dgvHealthRecommendation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHealthRecommendation.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                HealthRecommendationID = int.Parse(dgvHealthRecommendation.CurrentRow.Cells[2].Value.ToString());

                frmAddHealthRecommendation obj = new frmAddHealthRecommendation();
                obj.ShowDialog();
            }

            if (dgvHealthRecommendation.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                HealthRecommendationID = int.Parse(dgvHealthRecommendation.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Health Recommendation?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    await healthCrisisRecommendationList.Delete(HealthRecommendationID);
                    await LoadHealthRecommendation();
                }
            }
        }

        private async void dgvEconomicCrisis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEconomicCrisis.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                EcomicCrisisID = int.Parse(dgvEconomicCrisis.CurrentRow.Cells[2].Value.ToString());

                frmAddEconomicCrisis obj = new frmAddEconomicCrisis();
                obj.ShowDialog();
            }

            if (dgvEconomicCrisis.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                EcomicCrisisID = int.Parse(dgvEconomicCrisis.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Economic Crisis?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    await economicCrisisList.Delete(EcomicCrisisID);
                    await LoadEconomicCrisis();
                }
            }
        }

        private async void dgvEconomicRecommendation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEconomicRecommendation.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                OnEdit = true;
                EconomicRecommendationID = int.Parse(dgvEconomicRecommendation.CurrentRow.Cells[2].Value.ToString());

                frmAddHealthRecommendation obj = new frmAddHealthRecommendation();
                obj.ShowDialog();
            }

            if (dgvEconomicRecommendation.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                EconomicRecommendationID = int.Parse(dgvEconomicRecommendation.CurrentRow.Cells[2].Value.ToString());

                DialogResult dr = MessageBox.Show("Are you sure to delete selected Economic Recommendation?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    await economicCrisisRecommendationList.Delete(EconomicRecommendationID);
                    await LoadEconomicRecommendation();
                }
            }
        }

        private void dgvSurvey_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSurvey.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
               SurveyID  = int.Parse(dgvSurvey.CurrentRow.Cells[1].Value.ToString());
               RespondentID = int.Parse(dgvSurvey.CurrentRow.Cells[4].Value.ToString());
                DialogResult dr = MessageBox.Show("Are you sure to delete selected Survey?", "Warning!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    frmVerificationDelete obj = new frmVerificationDelete();
                    obj.ShowDialog();
                }
            }
        }
    }
}
