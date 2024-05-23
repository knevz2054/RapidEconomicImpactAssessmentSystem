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
    public partial class frmFamilyIncomeSummary : Form
    {
        IDataRepository<Respondent> RespondentRepository = new DataRepository<Respondent>();
        IDataRepository<Municipality> MunicipalityRepository = new DataRepository<Municipality>();
        IDataRepository<Barangay> BarangayRepository = new DataRepository<Barangay>();
        IDataRepository<RespondentSalariesWages> SalariesWages = new DataRepository<RespondentSalariesWages>();
        IDataRepository<RespondentEntrepreneurialActivities> EntrepreneurialActivity = new DataRepository<RespondentEntrepreneurialActivities>();
        IDataRepository<RespondentOtherSources> OtherSources = new DataRepository<RespondentOtherSources>();


        List<Respondent> GetRespondents;
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;
        List<RespondentSalariesWages> GetRespondentSalariesWages;
        List<RespondentEntrepreneurialActivities> GetRespondentEntrepreneurialActivities;
        List<RespondentOtherSources> GetRespondentOtherSources;

        public frmFamilyIncomeSummary()
        {
            InitializeComponent();
        }

        public async Task CallLoad()
        {
            GetRespondents = await RespondentRepository.GetAll();
            GetMunicipalities = await MunicipalityRepository.GetAll();
            GetBarangays = await BarangayRepository.GetAll();
            GetRespondentSalariesWages = await SalariesWages.GetAll();
            GetRespondentEntrepreneurialActivities = await EntrepreneurialActivity.GetAll();
            GetRespondentOtherSources = await OtherSources.GetAll();
        }

        private async void frmFamilyIncomeSummary_Load(object sender, EventArgs e)
        {
            await CallLoad();
        }

        private void rbSamar_CheckedChanged(object sender, EventArgs e)
        {
            lblSources.Text = ($"{"(Sources of Income)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblMainSource.Text = ($"{"(Main Source of Income)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblSubSources.Text = "Respondents:";

            lblBrgySources.Text = "Respondents:";
            lblBrgyMainSource.Text = "Respondents:";
            lblBrgySubSources.Text = "Resp:";

            cbByMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.OrderBy(x => x.MunicipalityName))
                cbByMunicipality.Items.Add(item.MunicipalityName);

            cbIncome.Items.Clear();
            dgvMunicipalitySubSource.DataSource = null;

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);
            dgvBarangaySources.DataSource = null;

            dgvBarangayMainSource.DataSource = null;

            cbMun_SubSource.Items.Clear();
            foreach (var item in GetMunicipalities.OrderBy(x => x.MunicipalityName))
                cbMun_SubSource.Items.Add(item.MunicipalityName);

            cbBrgy_SubSource.Items.Clear();
            cbBrgy_Income.Items.Clear();
            dgvBarangaySubSource.DataSource = null;

            dgvMunicipalitySources.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Salaries_Wages = GetRespondents.Count(xx => xx.SalariesWages == true && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Entrepreneurial_Activities = GetRespondents.Count(xx => xx.EntrepreneurialActivities == true && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Other_Sources = GetRespondents.Count(xx => xx.Otherources == true && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();


            dgvMunicipalityMainSource.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Salaries_Wages = GetRespondents.Count(xx => xx.MainSource == "Salaries / Wages" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Entrepreneurial_Activities = GetRespondents.Count(xx => xx.MainSource == "Entrepreneurial Activity" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Other_Sources = GetRespondents.Count(xx => xx.MainSource == "Other Sources of Income" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();

            RespondentGrid();
        }

        private void rb1stDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblSources.Text = ($"{"(Sources of Income)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblMainSource.Text = ($"{"(Main Source of Income)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblSubSources.Text = "Respondents:";

            lblBrgySources.Text = "Respondents:";
            lblBrgyMainSource.Text = "Respondents:";
            lblBrgySubSources.Text = "Resp:";

            cbByMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                cbByMunicipality.Items.Add(item.MunicipalityName);

            cbIncome.Items.Clear();
            dgvMunicipalitySubSource.DataSource = null;

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);
            dgvBarangaySources.DataSource = null;
            
            dgvBarangayMainSource.DataSource = null;

            cbMun_SubSource.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                cbMun_SubSource.Items.Add(item.MunicipalityName);

            cbBrgy_SubSource.Items.Clear();
            cbBrgy_Income.Items.Clear();
            dgvBarangaySubSource.DataSource = null;

            dgvMunicipalitySources.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Salaries_Wages = GetRespondents.Count(xx => xx.SalariesWages == true && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Entrepreneurial_Activities = GetRespondents.Count(xx => xx.EntrepreneurialActivities == true && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Other_Sources = GetRespondents.Count(xx => xx.Otherources == true && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();


            dgvMunicipalityMainSource.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Salaries_Wages = GetRespondents.Count(xx => xx.MainSource == "Salaries / Wages" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Entrepreneurial_Activities = GetRespondents.Count(xx => xx.MainSource == "Entrepreneurial Activity" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Other_Sources = GetRespondents.Count(xx => xx.MainSource == "Other Sources of Income" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();

            RespondentGrid();
        }

        private void rb2ndDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblSources.Text = ($"{"(Sources of Income)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblMainSource.Text = ($"{"(Main Source of Income)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblSubSources.Text = "Respondents:";

            lblBrgySources.Text = "Respondents:";
            lblBrgyMainSource.Text = "Respondents:";
            lblBrgySubSources.Text = "Resp:";

            cbByMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "2nd District").OrderBy(x => x.MunicipalityName))
                cbByMunicipality.Items.Add(item.MunicipalityName);

            cbIncome.Items.Clear();
            dgvMunicipalitySubSource.DataSource = null;

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "2nd District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangayMainSource.DataSource = null;

            cbMun_SubSource.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "2nd District").OrderBy(x => x.MunicipalityName))
                cbMun_SubSource.Items.Add(item.MunicipalityName);           

            cbBrgy_SubSource.Items.Clear();
            cbBrgy_Income.Items.Clear();
            dgvBarangaySubSource.DataSource = null;

            dgvMunicipalitySources.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Salaries_Wages = GetRespondents.Count(xx => xx.SalariesWages == true && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Entrepreneurial_Activities = GetRespondents.Count(xx => xx.EntrepreneurialActivities == true && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Other_Sources = GetRespondents.Count(xx => xx.Otherources == true && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();


            dgvMunicipalityMainSource.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Salaries_Wages = GetRespondents.Count(xx => xx.MainSource == "Salaries / Wages" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Entrepreneurial_Activities = GetRespondents.Count(xx => xx.MainSource == "Entrepreneurial Activity" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Other_Sources = GetRespondents.Count(xx => xx.MainSource == "Other Sources of Income" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();

            RespondentGrid();
        }

        private void cbByMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSubSources.Text = "Respondents:";
            dgvMunicipalitySubSource.DataSource = null;
            cbIncome.Items.Clear();
            cbIncome.Items.Add("Salaries / Wages");
            cbIncome.Items.Add("Entrpreneurial Activity");
            cbIncome.Items.Add("Other Sources of Income");
        }

        private void cbIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSubSources.Text = ($"{"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbByMunicipality.Text)}").ToString();

            if (cbIncome.SelectedIndex == 0)
            {
                var SalariesWages = GetRespondentSalariesWages.Where(x => x.Respondent.Barangay.Municipality.MunicipalityName == cbByMunicipality.Text).GroupBy(x => x.RespSalaryWage).ToList();
                dgvMunicipalitySubSource.DataSource = SalariesWages.Select(x => new
                {
                    Sources = x.Key,
                    Count = GetRespondentSalariesWages.Count(xx => xx.Respondent.Barangay.Municipality.MunicipalityName == cbByMunicipality.Text && xx.RespSalaryWage == x.Key),
                }).OrderByDescending(x => x.Count).ToList();

                RespondentGrid();
            }

            if (cbIncome.SelectedIndex == 1)
            {
                var Entrepreneurial = GetRespondentEntrepreneurialActivities.Where(x => x.Respondent.Barangay.Municipality.MunicipalityName == cbByMunicipality.Text).GroupBy(x => x.RespEntrepreneurialActivity).ToList();
                dgvMunicipalitySubSource.DataSource = Entrepreneurial.Select(x => new
                {
                    Sources = x.Key,
                    Count = GetRespondentEntrepreneurialActivities.Count(xx => xx.Respondent.Barangay.Municipality.MunicipalityName == cbByMunicipality.Text && xx.RespEntrepreneurialActivity == x.Key),
                }).OrderByDescending(x => x.Count).ToList();

                RespondentGrid();
            }

            if (cbIncome.SelectedIndex == 2)
            {
                var OtherSources = GetRespondentOtherSources.Where(x => x.Respondent.Barangay.Municipality.MunicipalityName == cbByMunicipality.Text).GroupBy(x => x.RespOtherSources).ToList();
                dgvMunicipalitySubSource.DataSource = OtherSources.Select(x => new
                {
                    Sources = x.Key,
                    Count = GetRespondentOtherSources.Count(xx => xx.Respondent.Barangay.Municipality.MunicipalityName == cbByMunicipality.Text && xx.RespOtherSources == x.Key),
                }).OrderByDescending(x => x.Count).ToList();

                RespondentGrid();
            }
        }

        private void cbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBrgySources.Text = ($"{"(Sources of Income)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}");
            dgvBarangaySources.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Salaries_Wages = GetRespondents.Count(xx => xx.SalariesWages == true && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Entrepreneurial_Activities = GetRespondents.Count(xx => xx.EntrepreneurialActivities == true && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Other_Sources = GetRespondents.Count(xx => xx.Otherources == true && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)
            }).OrderBy(x => x.Barangay).ToList();


            lblBrgyMainSource.Text = ($"{"(Main Source of Income)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}");
            dgvBarangayMainSource.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Salaries_Wages = GetRespondents.Count(xx => xx.MainSource == "Salaries / Wages" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Entrepreneurial_Activities = GetRespondents.Count(xx => xx.MainSource == "Entrepreneurial Activity" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Other_Sources = GetRespondents.Count(xx => xx.MainSource == "Other Sources of Income" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
            }).OrderBy(x => x.Barangay).ToList();

            RespondentGrid();
        }

        private void cbMun_SubSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBrgy_SubSource.Items.Clear();
            foreach (var item in GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMun_SubSource.Text))
                cbBrgy_SubSource.Items.Add(item.BarangayName);

            cbBrgy_Income.Items.Clear();
            dgvBarangaySubSource.DataSource = null;
        }

        private void cbBrgy_SubSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblSubSources.Text = "Respondents:";
            dgvBarangaySubSource.DataSource = null;
            cbBrgy_Income.Items.Clear();
            cbBrgy_Income.Items.Add("Salaries / Wages");
            cbBrgy_Income.Items.Add("Entrpreneurial Activity");
            cbBrgy_Income.Items.Add("Other Sources of Income");
        }      

        private void cbBrgy_Income_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBrgySubSources.Text = ($"{"Resp:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMun_SubSource.Text && x.Barangay.BarangayName == cbBrgy_SubSource.Text)}").ToString();

            if (cbBrgy_Income.SelectedIndex == 0)
            {
                var SalariesWages = GetRespondentSalariesWages.Where(x => x.Respondent.Barangay.Municipality.MunicipalityName == cbMun_SubSource.Text && x.Respondent.Barangay.BarangayName == cbBrgy_SubSource.Text).GroupBy(x => x.RespSalaryWage).ToList();
                dgvBarangaySubSource.DataSource = SalariesWages.Select(x => new
                {
                    Sources = x.Key,
                    Count = GetRespondentSalariesWages.Count(xx => xx.Respondent.Barangay.Municipality.MunicipalityName == cbMun_SubSource.Text && xx.Respondent.Barangay.BarangayName == cbBrgy_SubSource.Text && xx.RespSalaryWage == x.Key),
                }).OrderByDescending(x => x.Count).ToList();

                RespondentGrid();
            }

            if (cbBrgy_Income.SelectedIndex == 1)
            {
                var Entrepreneurial = GetRespondentEntrepreneurialActivities.Where(x => x.Respondent.Barangay.Municipality.MunicipalityName == cbMun_SubSource.Text && x.Respondent.Barangay.BarangayName == cbBrgy_SubSource.Text).GroupBy(x => x.RespEntrepreneurialActivity).ToList();
                dgvBarangaySubSource.DataSource = Entrepreneurial.Select(x => new
                {
                    Sources = x.Key,
                    Count = GetRespondentEntrepreneurialActivities.Count(xx => xx.Respondent.Barangay.Municipality.MunicipalityName == cbMun_SubSource.Text && xx.Respondent.Barangay.BarangayName == cbBrgy_SubSource.Text && xx.RespEntrepreneurialActivity == x.Key),
                }).OrderByDescending(x => x.Count).ToList();

                RespondentGrid();
            }

            if (cbBrgy_Income.SelectedIndex == 2)
            {
                var OtherSources = GetRespondentOtherSources.Where(x => x.Respondent.Barangay.Municipality.MunicipalityName == cbMun_SubSource.Text && x.Respondent.Barangay.BarangayName == cbBrgy_SubSource.Text).GroupBy(x => x.RespOtherSources).ToList();
                dgvBarangaySubSource.DataSource = OtherSources.Select(x => new
                {
                    Sources = x.Key,
                    Count = GetRespondentOtherSources.Count(xx => xx.Respondent.Barangay.Municipality.MunicipalityName == cbMun_SubSource.Text && xx.Respondent.Barangay.BarangayName == cbBrgy_SubSource.Text && xx.RespOtherSources == x.Key),
                }).OrderByDescending(x => x.Count).ToList();

                RespondentGrid();
            }
        }

        public void RespondentGrid()
        {
            dgvMunicipalitySources.Columns[1].HeaderText = "Salaries / Wages";
            dgvMunicipalitySources.Columns[1].Width = 115;
            dgvMunicipalitySources.Columns[2].HeaderText = "Entrepreneurial Activities";
            dgvMunicipalitySources.Columns[2].Width = 150;
            dgvMunicipalitySources.Columns[3].HeaderText = "Other Sources of Income";
            dgvMunicipalitySources.Columns[3].Width = 150;

            dgvMunicipalityMainSource.Columns[1].HeaderText = "Salaries/Wages";
            dgvMunicipalityMainSource.Columns[1].Width = 115;
            dgvMunicipalityMainSource.Columns[2].HeaderText = "Entrepreneurial Activities";
            dgvMunicipalityMainSource.Columns[2].Width = 150;
            dgvMunicipalityMainSource.Columns[3].HeaderText = "Other Sources of Income";
            dgvMunicipalityMainSource.Columns[3].Width = 150;

            if (cbIncome.SelectedItem != null)
            {
                dgvMunicipalitySubSource.Columns[0].Width = 500;
                dgvMunicipalitySubSource.Columns[1].Width = 50;
            }

            if (cbMunicipality.SelectedItem != null)
            {
                dgvBarangaySources.Columns[1].HeaderText = "Salaries / Wages";
                dgvBarangaySources.Columns[1].Width = 115;
                dgvBarangaySources.Columns[2].HeaderText = "Entrepreneurial Activities";
                dgvBarangaySources.Columns[2].Width = 150;
                dgvBarangaySources.Columns[3].HeaderText = "Other Sources of Income";
                dgvBarangaySources.Columns[3].Width = 150;

                dgvBarangayMainSource.Columns[1].HeaderText = "Salaries/Wages";
                dgvBarangayMainSource.Columns[1].Width = 115;
                dgvBarangayMainSource.Columns[2].HeaderText = "Entrepreneurial Activities";
                dgvBarangayMainSource.Columns[2].Width = 150;
                dgvBarangayMainSource.Columns[3].HeaderText = "Other Sources of Income";
                dgvBarangayMainSource.Columns[3].Width = 150;
            }
          
            if (cbBrgy_Income.SelectedItem != null)
            {
                dgvBarangaySubSource.Columns[0].Width = 500;
                dgvBarangaySubSource.Columns[1].Width = 50;
            }
        }
    }
}
