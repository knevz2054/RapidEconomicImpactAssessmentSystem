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
    public partial class frmSavingsSummary : Form
    {
        IDataRepository<Respondent> RespondentRepository = new DataRepository<Respondent>();
        IDataRepository<Municipality> MunicipalityRepository = new DataRepository<Municipality>();
        IDataRepository<Barangay> BarangayRepository = new DataRepository<Barangay>();

        List<Respondent> GetRespondents;
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;
        public frmSavingsSummary()
        {
            InitializeComponent();
        }

        public async Task CallLoad()
        {
            GetRespondents = await RespondentRepository.GetAll();
            GetMunicipalities = await MunicipalityRepository.GetAll();
            GetBarangays = await BarangayRepository.GetAll();
        }
        private async void frmSavingsSummary_Load(object sender, EventArgs e)
        {
            await CallLoad();
        }

        private void rbSamar_CheckedChanged(object sender, EventArgs e)
        {
            lblMonthlySavings.Text = ($"{"(Regular Savings)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblRealizeSavings.Text = ($"{"(Able to Save)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblAffectedSavings.Text = ($"{"(Affected Savings)"} {"Respondents:"} {GetRespondents.Count}").ToString();

            lblBarangay_MonthlySavings.Text = "Respondents:";
            lblBarangay_RealizeSavings.Text = "Respondents:";
            lblBarangay_AffectedSavings.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangay_MonthlySavings.DataSource = null;
            dgvBarangay_RealizeSavings.DataSource = null;
            dgvBarangay_AffectedSavings.DataSource = null;

            dgvMunicipality_MonthlySavings.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.RegularMonthlySavings == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.RegularMonthlySavings == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Sometimes = GetRespondents.Count(xx => xx.RegularMonthlySavings == "Sometimes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_RealizeSavings.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Sometimes = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "Sometimes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_AffectedSavings.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.AffectedSavings == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.AffectedSavings == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Sometimes = GetRespondents.Count(xx => xx.AffectedSavings == "Sometimes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Often = GetRespondents.Count(xx => xx.AffectedSavings == "Often" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                AllSpent = GetRespondents.Count(xx => xx.AffectedSavings == "All Spent" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            RespondentGrid();
        }

        private void rb1stDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblMonthlySavings.Text = ($"{"(Regular Savings)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblRealizeSavings.Text = ($"{"(Able to Save)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblAffectedSavings.Text = ($"{"(Affected Savings)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();

            lblBarangay_MonthlySavings.Text = "Respondents:";
            lblBarangay_RealizeSavings.Text = "Respondents:";
            lblBarangay_AffectedSavings.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangay_MonthlySavings.DataSource = null;
            dgvBarangay_RealizeSavings.DataSource = null;
            dgvBarangay_AffectedSavings.DataSource = null;

            dgvMunicipality_MonthlySavings.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.RegularMonthlySavings == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.RegularMonthlySavings == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Sometimes = GetRespondents.Count(xx => xx.RegularMonthlySavings == "Sometimes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_RealizeSavings.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Sometimes = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "Sometimes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_AffectedSavings.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.AffectedSavings == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.AffectedSavings == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Sometimes = GetRespondents.Count(xx => xx.AffectedSavings == "Sometimes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Often = GetRespondents.Count(xx => xx.AffectedSavings == "Often" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                AllSpent = GetRespondents.Count(xx => xx.AffectedSavings == "All Spent" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            RespondentGrid();
        }

        private void rb2ndDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblMonthlySavings.Text = ($"{"(Regular Savings)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblRealizeSavings.Text = ($"{"(Able to Save)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblAffectedSavings.Text = ($"{"(Affected Savings)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();

            lblBarangay_MonthlySavings.Text = "Respondents:";
            lblBarangay_RealizeSavings.Text = "Respondents:";
            lblBarangay_AffectedSavings.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "12ndst District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangay_MonthlySavings.DataSource = null;
            dgvBarangay_RealizeSavings.DataSource = null;
            dgvBarangay_AffectedSavings.DataSource = null;

            dgvMunicipality_MonthlySavings.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.RegularMonthlySavings == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.RegularMonthlySavings == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Sometimes = GetRespondents.Count(xx => xx.RegularMonthlySavings == "Sometimes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_RealizeSavings.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Sometimes = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "Sometimes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_AffectedSavings.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.AffectedSavings == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.AffectedSavings == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Sometimes = GetRespondents.Count(xx => xx.AffectedSavings == "Sometimes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Often = GetRespondents.Count(xx => xx.AffectedSavings == "Often" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                AllSpent = GetRespondents.Count(xx => xx.AffectedSavings == "All Spent" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            RespondentGrid();
        }

        private void cbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBarangay_MonthlySavings.Text = ($"{"(Regular Savings)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();
            lblBarangay_RealizeSavings.Text = ($"{"(Able to Save)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();
            lblBarangay_AffectedSavings.Text = ($"{"(Affected Savings)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();


            dgvBarangay_MonthlySavings.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                MBarangay = x.BarangayName,
                Yes = GetRespondents.Count(xx => xx.RegularMonthlySavings == "Yes" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                No = GetRespondents.Count(xx => xx.RegularMonthlySavings == "No" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Sometimes = GetRespondents.Count(xx => xx.RegularMonthlySavings == "Sometimes" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),

            }).ToList();

            dgvBarangay_RealizeSavings.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Yes = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "Yes" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                No = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "No" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Sometimes = GetRespondents.Count(xx => xx.RealizeMonthlySavings == "Sometimes" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
            }).ToList();

            dgvBarangay_AffectedSavings.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Yes = GetRespondents.Count(xx => xx.AffectedSavings == "Yes" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                No = GetRespondents.Count(xx => xx.AffectedSavings == "No" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Sometimes = GetRespondents.Count(xx => xx.AffectedSavings == "Sometimes" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                Often = GetRespondents.Count(xx => xx.AffectedSavings == "Often" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),
                AllSpent = GetRespondents.Count(xx => xx.AffectedSavings == "All Spent" && xx.Barangay.BarangayName == x.BarangayName && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text),

            }).ToList();

            RespondentGrid();
        }
        public void RespondentGrid()
        {
            dgvMunicipality_MonthlySavings.Columns[1].Width = 130;
            dgvMunicipality_MonthlySavings.Columns[2].Width = 130;
            dgvMunicipality_MonthlySavings.Columns[3].Width = 130;


            dgvMunicipality_RealizeSavings.Columns[1].Width = 130;
            dgvMunicipality_RealizeSavings.Columns[2].Width = 130;
            dgvMunicipality_RealizeSavings.Columns[3].Width = 130;

            dgvMunicipality_AffectedSavings.Columns[1].Width = 111;
            dgvMunicipality_AffectedSavings.Columns[2].Width = 111;
            dgvMunicipality_AffectedSavings.Columns[3].Width = 111;
            dgvMunicipality_AffectedSavings.Columns[4].Width = 111;
            dgvMunicipality_AffectedSavings.Columns[5].HeaderText = "All Spent";
            dgvMunicipality_AffectedSavings.Columns[5].Width = 115;

            if (cbMunicipality.SelectedItem != null)
            {
                dgvBarangay_MonthlySavings.Columns[1].Width = 130;
                dgvBarangay_MonthlySavings.Columns[2].Width = 130;
                dgvBarangay_MonthlySavings.Columns[3].Width = 130;


                dgvBarangay_RealizeSavings.Columns[1].Width = 130;
                dgvBarangay_RealizeSavings.Columns[2].Width = 130;
                dgvBarangay_RealizeSavings.Columns[3].Width = 130;

                dgvBarangay_AffectedSavings.Columns[1].Width = 111;
                dgvBarangay_AffectedSavings.Columns[2].Width = 111;
                dgvBarangay_AffectedSavings.Columns[3].Width = 111;
                dgvBarangay_AffectedSavings.Columns[4].Width = 111;
                dgvBarangay_AffectedSavings.Columns[5].HeaderText = "All Spent";
                dgvBarangay_AffectedSavings.Columns[5].Width = 115;
            }
        }
    }
}
