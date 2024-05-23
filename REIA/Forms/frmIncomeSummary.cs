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
    public partial class frmIncomeSummary : Form
    {
        IDataRepository<Respondent> RespondentRepository = new DataRepository<Respondent>();
        IDataRepository<Municipality> MunicipalityRepository = new DataRepository<Municipality>();
        IDataRepository<Barangay> BarangayRepository = new DataRepository<Barangay>();

        List<Respondent> GetRespondents;
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;

        public frmIncomeSummary()
        {
            InitializeComponent();
        }

        public async Task CallLoad()
        {
            GetRespondents = await RespondentRepository.GetAll();
            GetMunicipalities = await MunicipalityRepository.GetAll();
            GetBarangays = await BarangayRepository.GetAll();
        }

        private async void frmIncomeSummary_Load(object sender, EventArgs e)
        {
            await CallLoad();
        }

        private void rbSamar_CheckedChanged(object sender, EventArgs e)
        {
            lblIncome_Before.Text = ($"{"(Income Before)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblIncome_Status.Text = ($"{"(Income Changes)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblIncome_Now.Text = ($"{"(Income Now)"} {"Respondents:"} {GetRespondents.Count}").ToString();

            lblBarangay_IncomeBefore.Text = "Respondents:";
            lblBarangay_IncomeStatus.Text = "Respondents:";
            lblBarangay_IncomeNow.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangay_IncomeBefore.DataSource = null;
            dgvBarangay_IncomeStatus.DataSource = null;
            dgvBarangay_IncomeNow.DataSource = null;

            dgvMunicipality_IncomeBefore.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Below_7840 = GetRespondents.Count(xx => xx.IncomeBefore == "Below 7,840" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _7841_11300 = GetRespondents.Count(xx => xx.IncomeBefore == "7,841 - 11,300" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _12000_21000 = GetRespondents.Count(xx => xx.IncomeBefore == "12,000 - 21,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _22000_120000 = GetRespondents.Count(xx => xx.IncomeBefore == "22,000 - 120,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Above_121000 = GetRespondents.Count(xx => xx.IncomeBefore == "Above 121,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_IncomeStatus.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Increase = GetRespondents.Count(xx => xx.IncomeChanges == "Increase" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Decrease = GetRespondents.Count(xx => xx.IncomeChanges == "Decrease" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Remained = GetRespondents.Count(xx => xx.IncomeChanges == "The Same" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_IncomeNow.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Below_7840 = GetRespondents.Count(xx => xx.IncomeNow == "Below 7,840" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _7841_11300 = GetRespondents.Count(xx => xx.IncomeNow == "7,841 - 11,300" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _12000_21000 = GetRespondents.Count(xx => xx.IncomeNow == "12,000 - 21,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _22000_120000 = GetRespondents.Count(xx => xx.IncomeNow == "22,000 - 120,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Above_121000 = GetRespondents.Count(xx => xx.IncomeNow == "Above 121,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            RespondentGrid();
        }

        private void rb1stDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblIncome_Before.Text = ($"{"(Income Before)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblIncome_Status.Text = ($"{"(Income Changes)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblIncome_Now.Text = ($"{"(Income Now)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();

            lblBarangay_IncomeBefore.Text = "Respondents:";
            lblBarangay_IncomeStatus.Text = "Respondents:";
            lblBarangay_IncomeNow.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangay_IncomeBefore.DataSource = null;
            dgvBarangay_IncomeStatus.DataSource = null;
            dgvBarangay_IncomeNow.DataSource = null;

            dgvMunicipality_IncomeBefore.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Below_7840 = GetRespondents.Count(xx => xx.IncomeBefore == "Below 7,840" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _7841_11300 = GetRespondents.Count(xx => xx.IncomeBefore == "7,841 - 11,300" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _12000_21000 = GetRespondents.Count(xx => xx.IncomeBefore == "12,000 - 21,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _22000_120000 = GetRespondents.Count(xx => xx.IncomeBefore == "22,000 - 120,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Above_121000 = GetRespondents.Count(xx => xx.IncomeBefore == "Above 121,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_IncomeStatus.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Increase = GetRespondents.Count(xx => xx.IncomeChanges == "Increase" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Decrease = GetRespondents.Count(xx => xx.IncomeChanges == "Decrease" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Remained = GetRespondents.Count(xx => xx.IncomeChanges == "The Same" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_IncomeNow.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Below_7840 = GetRespondents.Count(xx => xx.IncomeNow == "Below 7,840" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _7841_11300 = GetRespondents.Count(xx => xx.IncomeNow == "7,841 - 11,300" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _12000_21000 = GetRespondents.Count(xx => xx.IncomeNow == "12,000 - 21,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _22000_120000 = GetRespondents.Count(xx => xx.IncomeNow == "22,000 - 120,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Above_121000 = GetRespondents.Count(xx => xx.IncomeNow == "Above 121,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            RespondentGrid();
        }

        private void rb2ndDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblIncome_Before.Text = ($"{"(Income Before)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblIncome_Status.Text = ($"{"(Income Changes)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblIncome_Now.Text = ($"{"(Income Now)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();

            lblBarangay_IncomeBefore.Text = "Respondents:";
            lblBarangay_IncomeStatus.Text = "Respondents:";
            lblBarangay_IncomeNow.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "2nd District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangay_IncomeBefore.DataSource = null;
            dgvBarangay_IncomeStatus.DataSource = null;
            dgvBarangay_IncomeNow.DataSource = null;

            dgvMunicipality_IncomeBefore.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Below_7840 = GetRespondents.Count(xx => xx.IncomeBefore == "Below 7,840" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _7841_11300 = GetRespondents.Count(xx => xx.IncomeBefore == "7,841 - 11,300" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _12000_21000 = GetRespondents.Count(xx => xx.IncomeBefore == "12,000 - 21,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _22000_120000 = GetRespondents.Count(xx => xx.IncomeBefore == "22,000 - 120,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Above_121000 = GetRespondents.Count(xx => xx.IncomeBefore == "Above 121,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_IncomeStatus.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Increase = GetRespondents.Count(xx => xx.IncomeChanges == "Increase" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Decrease = GetRespondents.Count(xx => xx.IncomeChanges == "Decrease" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Remained = GetRespondents.Count(xx => xx.IncomeChanges == "The Same" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_IncomeNow.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Below_7840 = GetRespondents.Count(xx => xx.IncomeNow == "Below 7,840" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _7841_11300 = GetRespondents.Count(xx => xx.IncomeNow == "7,841 - 11,300" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _12000_21000 = GetRespondents.Count(xx => xx.IncomeNow == "12,000 - 21,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                _22000_120000 = GetRespondents.Count(xx => xx.IncomeNow == "22,000 - 120,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Above_121000 = GetRespondents.Count(xx => xx.IncomeNow == "Above 121,000" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            RespondentGrid();
        }

        public void RespondentGrid()
        {
            dgvMunicipality_IncomeBefore.Columns[1].HeaderText = "Below 7,840";
            dgvMunicipality_IncomeBefore.Columns[1].Width = 100;
            dgvMunicipality_IncomeBefore.Columns[2].HeaderText = "7,841 - 11,300";
            dgvMunicipality_IncomeBefore.Columns[2].Width = 112;
            dgvMunicipality_IncomeBefore.Columns[3].HeaderText = "12,000 - 21,000";
            dgvMunicipality_IncomeBefore.Columns[3].Width = 112;
            dgvMunicipality_IncomeBefore.Columns[4].HeaderText = "22,000 - 120,000";
            dgvMunicipality_IncomeBefore.Columns[4].Width = 112;
            dgvMunicipality_IncomeBefore.Columns[5].HeaderText = "Above 121,000";
            dgvMunicipality_IncomeBefore.Columns[5].Width = 112;


            dgvMunicipality_IncomeStatus.Columns[1].Width = 84;
            dgvMunicipality_IncomeStatus.Columns[2].Width = 84;
            dgvMunicipality_IncomeStatus.Columns[3].Width = 84;

            dgvMunicipality_IncomeNow.Columns[1].HeaderText = "Below 7,840";
            dgvMunicipality_IncomeNow.Columns[1].Width = 100;
            dgvMunicipality_IncomeNow.Columns[2].HeaderText = "7,841 - 11,300";
            dgvMunicipality_IncomeNow.Columns[2].Width = 112;
            dgvMunicipality_IncomeNow.Columns[3].HeaderText = "12,000 - 21,000";
            dgvMunicipality_IncomeNow.Columns[3].Width = 112;
            dgvMunicipality_IncomeNow.Columns[4].HeaderText = "22,000 - 120,000";
            dgvMunicipality_IncomeNow.Columns[4].Width = 112;
            dgvMunicipality_IncomeNow.Columns[5].HeaderText = "Above 121,000";
            dgvMunicipality_IncomeNow.Columns[5].Width = 112;

            if(cbMunicipality.SelectedItem != null)
            {
                dgvBarangay_IncomeBefore.Columns[1].HeaderText = "Below 7,840";
                dgvBarangay_IncomeBefore.Columns[1].Width = 100;
                dgvBarangay_IncomeBefore.Columns[2].HeaderText = "7,841 - 11,300";
                dgvBarangay_IncomeBefore.Columns[2].Width = 112;
                dgvBarangay_IncomeBefore.Columns[3].HeaderText = "12,000 - 21,000";
                dgvBarangay_IncomeBefore.Columns[3].Width = 112;
                dgvBarangay_IncomeBefore.Columns[4].HeaderText = "22,000 - 120,000";
                dgvBarangay_IncomeBefore.Columns[4].Width = 112;
                dgvBarangay_IncomeBefore.Columns[5].HeaderText = "Above 121,000";
                dgvBarangay_IncomeBefore.Columns[5].Width = 112;


                dgvBarangay_IncomeStatus.Columns[1].Width = 84;
                dgvBarangay_IncomeStatus.Columns[2].Width = 84;
                dgvBarangay_IncomeStatus.Columns[3].Width = 84;

                dgvBarangay_IncomeNow.Columns[1].HeaderText = "Below 7,840";
                dgvBarangay_IncomeNow.Columns[1].Width = 100;
                dgvBarangay_IncomeNow.Columns[2].HeaderText = "7,841 - 11,300";
                dgvBarangay_IncomeNow.Columns[2].Width = 112;
                dgvBarangay_IncomeNow.Columns[3].HeaderText = "12,000 - 21,000";
                dgvBarangay_IncomeNow.Columns[3].Width = 112;
                dgvBarangay_IncomeNow.Columns[4].HeaderText = "22,000 - 120,000";
                dgvBarangay_IncomeNow.Columns[4].Width = 112;
                dgvBarangay_IncomeNow.Columns[5].HeaderText = "Above 121,000";
                dgvBarangay_IncomeNow.Columns[5].Width = 112;
            }
        }

        private void cbMunicipality_IncomeBefore_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBarangay_IncomeBefore.Text = ($"{"(Income Before)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();
            lblBarangay_IncomeStatus.Text = ($"{"(Income Changes)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();
            lblBarangay_IncomeNow.Text = ($"{"(Income Now)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();
                       

            dgvBarangay_IncomeBefore.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Below_7840 = GetRespondents.Count(xx => xx.IncomeBefore == "Below 7,840" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                _7841_11300 = GetRespondents.Count(xx => xx.IncomeBefore == "7,841 - 11,300" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                _12000_21000 = GetRespondents.Count(xx => xx.IncomeBefore == "12,000 - 21,000" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                _22000_120000 = GetRespondents.Count(xx => xx.IncomeBefore == "22,000 - 120,000" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Above_121000 = GetRespondents.Count(xx => xx.IncomeBefore == "Above 121,000" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),

            }).OrderBy(x => x.Barangay).ToList();

            dgvBarangay_IncomeStatus.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Increase = GetRespondents.Count(xx => xx.IncomeChanges == "Increase" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Decrease = GetRespondents.Count(xx => xx.IncomeChanges == "Decrease" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Remained = GetRespondents.Count(xx => xx.IncomeChanges == "The Same" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
            }).OrderBy(x => x.Barangay).ToList();

            dgvBarangay_IncomeNow.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Below_7840 = GetRespondents.Count(xx => xx.IncomeNow == "Below 7,840" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                _7841_11300 = GetRespondents.Count(xx => xx.IncomeNow == "7,841 - 11,300" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                _12000_21000 = GetRespondents.Count(xx => xx.IncomeNow == "12,000 - 21,000" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                _22000_120000 = GetRespondents.Count(xx => xx.IncomeNow == "22,000 - 120,000" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Above_121000 = GetRespondents.Count(xx => xx.IncomeNow == "Above 121,000" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),

            }).OrderBy(x => x.Barangay).ToList();

            RespondentGrid();
        }

    }
}
