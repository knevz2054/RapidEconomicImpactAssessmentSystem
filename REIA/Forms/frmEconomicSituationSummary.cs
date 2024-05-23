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
    public partial class frmEconomicSituationSummary : Form
    {
        IDataRepository<Respondent> RespondentRepository = new DataRepository<Respondent>();
        IDataRepository<Municipality> MunicipalityRepository = new DataRepository<Municipality>();
        IDataRepository<Barangay> BarangayRepository = new DataRepository<Barangay>();


        List<Respondent> GetRespondents;
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;

        public frmEconomicSituationSummary()
        {
            InitializeComponent();
        }

        public async Task CallLoad()
        {
            GetRespondents = await RespondentRepository.GetAll();
            GetMunicipalities = await MunicipalityRepository.GetAll();
            GetBarangays = await BarangayRepository.GetAll();
        }

        private async void frmEconomicSituationSummary_Load(object sender, EventArgs e)
        {
            await CallLoad();
        }

        private void rbSamar_CheckedChanged(object sender, EventArgs e)
        {
            lblEconomicSituation.Text = ($"{"(Economic Situation)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblExperiencedHunger.Text = ($"{"(Experienced Hunger)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblMonths.Text = ($"{"(Months)"} {"Respondents:"} {GetRespondents.Count}").ToString();

            lblBrgy_EconomicSituation.Text = "Respondents:";
            lblBrgy_ExperiencedHunger.Text = "Respondents:";
            lblBrgy_Months.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangay_EconomicSituation.DataSource = null;
            dgvBarangay_ExperiencedHunger.DataSource = null;
            dgvBarangay_Months.DataSource = null;

            dgvMunicipality_EconomicSituation.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Became_Better = GetRespondents.Count(xx => xx.EconomicSituation == "Became Better" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Became_Difficult = GetRespondents.Count(xx => xx.EconomicSituation == "Became Difficult" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                The_Same = GetRespondents.Count(xx => xx.EconomicSituation == "The Same" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_ExperiencedHunger.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.HungerExperience == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.HungerExperience == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_Months.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            //RespondentGrid();
        }

        private void rb1stDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblEconomicSituation.Text = ($"{"(Economic Situation)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblExperiencedHunger.Text = ($"{"(Experienced Hunger)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblMonths.Text = ($"{"(Months)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();

            lblBrgy_EconomicSituation.Text = "Respondents:";
            lblBrgy_ExperiencedHunger.Text = "Respondents:";
            lblBrgy_Months.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangay_EconomicSituation.DataSource = null;
            dgvBarangay_ExperiencedHunger.DataSource = null;
            dgvBarangay_Months.DataSource = null;

            dgvMunicipality_EconomicSituation.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Became_Better = GetRespondents.Count(xx => xx.EconomicSituation == "Became Better" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Became_Difficult = GetRespondents.Count(xx => xx.EconomicSituation == "Became Difficult" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                The_Same = GetRespondents.Count(xx => xx.EconomicSituation == "The Same" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_ExperiencedHunger.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.HungerExperience == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.HungerExperience == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_Months.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();
        }

        private void rb2ndDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblEconomicSituation.Text = ($"{"(Economic Situation)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblExperiencedHunger.Text = ($"{"(Experienced Hunger)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblMonths.Text = ($"{"(Months)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();

            lblBrgy_EconomicSituation.Text = "Respondents:";
            lblBrgy_ExperiencedHunger.Text = "Respondents:";
            lblBrgy_Months.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "2nd District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangay_EconomicSituation.DataSource = null;
            dgvBarangay_ExperiencedHunger.DataSource = null;
            dgvBarangay_Months.DataSource = null;

            dgvMunicipality_EconomicSituation.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Became_Better = GetRespondents.Count(xx => xx.EconomicSituation == "Became Better" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Became_Difficult = GetRespondents.Count(xx => xx.EconomicSituation == "Became Difficult" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                The_Same = GetRespondents.Count(xx => xx.EconomicSituation == "The Same" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_ExperiencedHunger.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Yes = GetRespondents.Count(xx => xx.HungerExperience == "Yes" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                No = GetRespondents.Count(xx => xx.HungerExperience == "No" && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_Months.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();
        }

        private void cbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBrgy_EconomicSituation.Text = ($"{"(Economic Situation)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();
            lblBrgy_ExperiencedHunger.Text = ($"{"(Experienced Hunger)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();
            lblBrgy_Months.Text = ($"{"(Months)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();


            dgvBarangay_EconomicSituation.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Became_Better = GetRespondents.Count(xx => xx.EconomicSituation == "Became Better" && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                Became_Difficult = GetRespondents.Count(xx => xx.EconomicSituation == "Became Difficult" && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                The_Same = GetRespondents.Count(xx => xx.EconomicSituation == "The Same" && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),

            }).ToList();

            dgvBarangay_ExperiencedHunger.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Yes = GetRespondents.Count(xx => xx.HungerExperience == "Yes" && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                No = GetRespondents.Count(xx => xx.HungerExperience == "No" && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
            }).ToList();

            dgvBarangay_Months.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                January = GetRespondents.Count(xx => xx.January != 0 && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                February = GetRespondents.Count(xx => xx.February != 0 && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                March = GetRespondents.Count(xx => xx.March != 0 && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                April = GetRespondents.Count(xx => xx.April != 0 && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                May = GetRespondents.Count(xx => xx.March != 0 && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                June = GetRespondents.Count(xx => xx.June != 0 && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                July = GetRespondents.Count(xx => xx.July != 0 && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == cbMunicipality.Text && xx.Barangay.BarangayName == x.BarangayName),

            }).ToList();
        }
    }
}
