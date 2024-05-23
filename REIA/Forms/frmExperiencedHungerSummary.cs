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
    public partial class frmExperiencedHungerSummary : Form
    {
        IDataRepository<Respondent> RespondentRepository = new DataRepository<Respondent>();
        IDataRepository<Municipality> MunicipalityRepository = new DataRepository<Municipality>();
        IDataRepository<Barangay> BarangayRepository = new DataRepository<Barangay>();

        List<Respondent> GetRespondents;
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;

        public frmExperiencedHungerSummary()
        {
            InitializeComponent();
        }

        public async Task CallLoad()
        {
            GetRespondents = await RespondentRepository.GetAll();
            GetMunicipalities = await MunicipalityRepository.GetAll();
            GetBarangays = await BarangayRepository.GetAll();
        }

        private async void frmExperiencedHungerSummary_Load(object sender, EventArgs e)
        {
            await CallLoad();
        }

        private void rbSamar_CheckedChanged(object sender, EventArgs e)
        {
            lblOneDay.Text = ($"{"(Experienced Hunger for One Day)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblTwoDays.Text = ($"{"(Experienced Hunger for Two Days)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblThreeDays.Text = ($"{"(Experienced Hunger for Three Days or More)"} {"Respondents:"} {GetRespondents.Count}").ToString();

            //lblBrgy_EconomicSituation.Text = "Respondents:";
            //lblBrgy_ExperiencedHunger.Text = "Respondents:";
            //lblBrgy_Months.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            //dgvBarangay_EconomicSituation.DataSource = null;
            //dgvBarangay_ExperiencedHunger.DataSource = null;
            //dgvBarangay_Months.DataSource = null;

            dgvMunicipality_OneDay.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_TwoDays.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_ThreeDays.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            RespondentGrid();
        }

        private void rb1stDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblOneDay.Text = ($"{"(Experienced Hunger for One Day)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblTwoDays.Text = ($"{"(Experienced Hunger for Two Days)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblThreeDays.Text = ($"{"(Experienced Hunger for Three Days or More)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();

            //lblBrgy_EconomicSituation.Text = "Respondents:";
            //lblBrgy_ExperiencedHunger.Text = "Respondents:";
            //lblBrgy_Months.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            //dgvBarangay_EconomicSituation.DataSource = null;
            //dgvBarangay_ExperiencedHunger.DataSource = null;
            //dgvBarangay_Months.DataSource = null;

            dgvMunicipality_OneDay.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_TwoDays.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_ThreeDays.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            RespondentGrid();
        }

        private void rb2ndDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblOneDay.Text = ($"{"(Experienced Hunger for One Day)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblTwoDays.Text = ($"{"(Experienced Hunger for Two Days)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblThreeDays.Text = ($"{"(Experienced Hunger for Three Days or More)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();

            //lblBrgy_EconomicSituation.Text = "Respondents:";
            //lblBrgy_ExperiencedHunger.Text = "Respondents:";
            //lblBrgy_Months.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "2nd District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            //dgvBarangay_EconomicSituation.DataSource = null;
            //dgvBarangay_ExperiencedHunger.DataSource = null;
            //dgvBarangay_Months.DataSource = null;

            dgvMunicipality_OneDay.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July == 1 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            dgvMunicipality_TwoDays.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July == 2 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).ToList();

            dgvMunicipality_ThreeDays.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                January = GetRespondents.Count(xx => xx.January >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                February = GetRespondents.Count(xx => xx.February >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                March = GetRespondents.Count(xx => xx.March >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                April = GetRespondents.Count(xx => xx.April >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                May = GetRespondents.Count(xx => xx.March >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                June = GetRespondents.Count(xx => xx.June >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                July = GetRespondents.Count(xx => xx.July >= 3 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                August = GetRespondents.Count(xx => xx.August != 0 && xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),

            }).ToList();

            RespondentGrid();
        }

        public void RespondentGrid()
        {
            dgvMunicipality_OneDay.Columns[1].Width = 55;
            dgvMunicipality_OneDay.Columns[2].Width = 55;
            dgvMunicipality_OneDay.Columns[3].Width = 55;
            dgvMunicipality_OneDay.Columns[4].Width = 55;
            dgvMunicipality_OneDay.Columns[5].Width = 55;
            dgvMunicipality_OneDay.Columns[6].Width = 55;
            dgvMunicipality_OneDay.Columns[7].Width = 55;
            dgvMunicipality_OneDay.Columns[8].Width = 55;

            dgvMunicipality_TwoDays.Columns[1].Width = 55;
            dgvMunicipality_TwoDays.Columns[2].Width = 55;
            dgvMunicipality_TwoDays.Columns[3].Width = 55;
            dgvMunicipality_TwoDays.Columns[4].Width = 55;
            dgvMunicipality_TwoDays.Columns[5].Width = 55;
            dgvMunicipality_TwoDays.Columns[6].Width = 55;
            dgvMunicipality_TwoDays.Columns[7].Width = 55;
            dgvMunicipality_TwoDays.Columns[8].Width = 55;

            dgvMunicipality_ThreeDays.Columns[1].Width = 55;
            dgvMunicipality_ThreeDays.Columns[2].Width = 55;
            dgvMunicipality_ThreeDays.Columns[3].Width = 55;
            dgvMunicipality_ThreeDays.Columns[4].Width = 55;
            dgvMunicipality_ThreeDays.Columns[5].Width = 55;
            dgvMunicipality_ThreeDays.Columns[6].Width = 55;
            dgvMunicipality_ThreeDays.Columns[7].Width = 55;
            dgvMunicipality_ThreeDays.Columns[8].Width = 55;

        }
    }
}
    
