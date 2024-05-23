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
    public partial class frmProfileSummary : Form
    {
        IDataRepository<Respondent> RespondentRepository = new DataRepository<Respondent>();
        IDataRepository<Municipality> MunicipalityRepository = new DataRepository<Municipality>();
        IDataRepository<Barangay> BarangayRepository = new DataRepository<Barangay>();

        List<Respondent> GetRespondents;
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;

        public static string Category;
        public static string MunicipalityName;
        public static string BarangayName;
        public frmProfileSummary()
        {
            InitializeComponent();
        }

        private async void frmSocioEconomicSummary_Load(object sender, EventArgs e)
        {
            await CallLoad();
        }

        public async Task CallLoad()
        {
            GetRespondents = await RespondentRepository.GetAll();
            GetMunicipalities = await MunicipalityRepository.GetAll();
            GetBarangays = await BarangayRepository.GetAll();
        }


        private void rbSamar_CheckedChanged(object sender, EventArgs e)
        {
            dgvBarangay.DataSource = null;
            lblRespondent.Text = ($"{"Respondents:"} {GetRespondents.Count}").ToString();
            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);
            dgvMunicipality.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Respondents = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Male = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Gender == "Male"),
                Female = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Gender == "Female"),
                Single = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Single"),
                Married = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Married"),
                Separated = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Separated"),
                Widowed = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Widowed"),
                Age_18_24 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "18-24 Years Old"),
                Age_25_34 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "25-34 Years Old"),
                Age_35_44 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "35-44 Years Old"),
                Age_45_54 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "45-54 Years Old"),
                Age_55_64 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "55-64 Years Old"),
                Age_65_Above = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "65 and Above Years Old"),
                NoSchooling = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "No Schooling"),
                ElemUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Elementary Undergraduate"),
                ElemGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Elementary Graduate"),
                HighUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "High School Undergraduate"),
                HighGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "High School Graduate"),
                SenUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Senior High Undergraduate"),
                SenGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Senior High Graduate"),
                ColUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "College Undergraduate"),
                ColGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "College Graduate"),
                MasUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Masters Undergraduate"),
                MasGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Masters Graduate"),
                Doctorate = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Doctorate"),
                Vocational = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Vocational"),
                Cert = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Certificate Courses")

            }).OrderBy(x => x.Municipality).ToList();

            RespondentGrid();
        }
        private void rb1stDistrict_CheckedChanged(object sender, EventArgs e)
        {
            dgvBarangay.DataSource = null;
            lblRespondent.Text = ($"{"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);
            dgvMunicipality.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Respondents = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Male = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Gender == "Male"),
                Female = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Gender == "Female"),
                Single = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Single"),
                Married = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Married"),
                Separated = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Separated"),
                Widowed = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Widowed"),
                Age_18_24 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "18-24 Years Old"),
                Age_25_34 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "25-34 Years Old"),
                Age_35_44 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "35-44 Years Old"),
                Age_45_54 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "45-54 Years Old"),
                Age_55_64 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "55-64 Years Old"),
                Age_65_Above = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "65 and Above Years Old"),
                NoSchooling = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "No Schooling"),
                ElemUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Elementary Undergraduate"),
                ElemGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Elementary Graduate"),
                HighUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "High School Undergraduate"),
                HighGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "High School Graduate"),
                SenUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Senior High Undergraduate"),
                SenGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Senior High Graduate"),
                ColUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "College Undergraduate"),
                ColGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "College Graduate"),
                MasUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Masters Undergraduate"),
                MasGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Masters Graduate"),
                Doctorate = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Doctorate"),
                Vocational = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Vocational"),
                Cert = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Certificate Courses")

            }).OrderBy(x => x.Municipality).ToList();

            RespondentGrid();
        }

        private void rb2ndDistrict_CheckedChanged(object sender, EventArgs e)
        {
            dgvBarangay.DataSource = null;
            lblRespondent.Text = ($"{"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "2nd District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);
            dgvMunicipality.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Respondents = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Male = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Gender == "Male"),
                Female = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Gender == "Female"),
                Single = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Single"),
                Married = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Married"),
                Separated = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Separated"),
                Widowed = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.CivilStatus == "Widowed"),
                Age_18_24 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "18-24 Years Old"),
                Age_25_34 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "25-34 Years Old"),
                Age_35_44 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "35-44 Years Old"),
                Age_45_54 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "45-54 Years Old"),
                Age_55_64 = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "55-64 Years Old"),
                Age_65_Above = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.AgeBracket == "65 and Above Years Old"),
                NoSchooling = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "No Schooling"),
                ElemUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Elementary Undergraduate"),
                ElemGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Elementary Graduate"),
                HighUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "High School Undergraduate"),
                HighGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "High School Graduate"),
                SenUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Senior High Undergraduate"),
                SenGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Senior High Graduate"),
                ColUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "College Undergraduate"),
                ColGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "College Graduate"),
                MasUnder = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Masters Undergraduate"),
                MasGrad = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Masters Graduate"),
                Doctorate = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Doctorate"),
                Vocational = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Vocational"),
                Cert = GetRespondents.Count(xx => xx.Barangay.Municipality.MunicipalityName == x.MunicipalityName && xx.Education == "Certificate Courses")

            }).OrderBy(x => x.Municipality).ToList();

            RespondentGrid();
        }

        private void cbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {           
            lblRespondentBarangay.Text = ($"{"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();
            dgvBarangay.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Respondents = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName),
                Male = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Gender == "Male"),
                Female = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Gender == "Female"),
                Single = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.CivilStatus == "Single"),
                Married = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.CivilStatus == "Married"),
                Separated = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.CivilStatus == "Separated"),
                Widowed = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.CivilStatus == "Widowed"),
                Age_18_24 = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.AgeBracket == "18-24 Years Old"),
                Age_25_34 = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.AgeBracket == "25-34 Years Old"),
                Age_35_44 = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.AgeBracket == "35-44 Years Old"),
                Age_45_54 = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.AgeBracket == "45-54 Years Old"),
                Age_55_64 = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.AgeBracket == "55-64 Years Old"),
                Age_65_Above = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.AgeBracket == "65 and Above Years Old"),
                NoSchooling = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "No Schooling"),
                ElemUnder = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "Elementary Undergraduate"),
                ElemGrad = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "Elementary Graduate"),
                HighUnder = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "High School Undergraduate"),
                HighGrad = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "High School Graduate"),
                SenUnder = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "Senior High Undergraduate"),
                SenGrad = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "Senior High Graduate"),
                ColUnder = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "College Undergraduate"),
                ColGrad = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "College Graduate"),
                MasUnder = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "Masters Undergraduate"),
                MasGrad = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "Masters Graduate"),
                Doctorate = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "Doctorate"),
                Vocational = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "Vocational"),
                Cert = GetRespondents.Count(xx => xx.Barangay.BarangayName == x.BarangayName && xx.Education == "Certificate Courses")

            }).OrderBy(x => x.Barangay).ToList();

            RespondentGrid();
        }

        public void RespondentGrid()
        {
            dgvMunicipality.Columns[1].Width = 75;
            dgvMunicipality.Columns[2].Width = 75;
            dgvMunicipality.Columns[3].Width = 50;
            dgvMunicipality.Columns[4].Width = 65;
            dgvMunicipality.Columns[5].Width = 65;
            dgvMunicipality.Columns[6].Width = 65;
            dgvMunicipality.Columns[7].Width = 65;
            dgvMunicipality.Columns[8].Width = 65;
            dgvMunicipality.Columns[9].HeaderText = "18-24";
            dgvMunicipality.Columns[9].Width = 50;
            dgvMunicipality.Columns[10].HeaderText = "25-34";
            dgvMunicipality.Columns[10].Width = 50;
            dgvMunicipality.Columns[11].HeaderText = "35-44";
            dgvMunicipality.Columns[11].Width = 50;
            dgvMunicipality.Columns[12].HeaderText = "34-54";
            dgvMunicipality.Columns[12].Width = 50;
            dgvMunicipality.Columns[13].HeaderText = "55-64";
            dgvMunicipality.Columns[13].Width = 50;
            dgvMunicipality.Columns[14].HeaderText = "65 +";
            dgvMunicipality.Columns[14].Width = 65;
            dgvMunicipality.Columns[15].HeaderText = "No Schooling";
            dgvMunicipality.Columns[15].Width = 100;
            dgvMunicipality.Columns[16].HeaderText = "Elem. Undergrad";
            dgvMunicipality.Columns[16].Width = 115;
            dgvMunicipality.Columns[17].HeaderText = "Elem. Grad";
            dgvMunicipality.Columns[17].Width = 100;
            dgvMunicipality.Columns[18].HeaderText = "HS Undergrad";
            dgvMunicipality.Columns[18].Width = 100;
            dgvMunicipality.Columns[19].HeaderText = "HS Grad";
            dgvMunicipality.Columns[19].Width = 100;
            dgvMunicipality.Columns[20].HeaderText = "SH Undergrad";
            dgvMunicipality.Columns[20].Width = 100;
            dgvMunicipality.Columns[21].HeaderText = "SH Grad";
            dgvMunicipality.Columns[21].Width = 100;
            dgvMunicipality.Columns[22].HeaderText = "Col. Undergrad";
            dgvMunicipality.Columns[22].Width = 110;
            dgvMunicipality.Columns[23].HeaderText = "Col. Grad";
            dgvMunicipality.Columns[23].Width = 100;
            dgvMunicipality.Columns[24].HeaderText = "Masters Undergrad";
            dgvMunicipality.Columns[24].Width = 120;
            dgvMunicipality.Columns[25].HeaderText = "Masters Grad";
            dgvMunicipality.Columns[25].Width = 100;
            dgvMunicipality.Columns[26].HeaderText = "Doctorate";
            dgvMunicipality.Columns[26].Width = 95;
            dgvMunicipality.Columns[27].HeaderText = "Vocational";
            dgvMunicipality.Columns[27].Width = 95;
            dgvMunicipality.Columns[28].HeaderText = "Cert. Courses";
            dgvMunicipality.Columns[28].Width = 100;
        }

        private void dgvMunicipality_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvMunicipality.DataSource != null)
            {
                Category = "Municipality";
                MunicipalityName = dgvMunicipality.CurrentRow.Cells[1].Value.ToString();
                frmRespondentList obj = new frmRespondentList();
                obj.ShowDialog();
            }
           
        }

        private void dgvBarangay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvBarangay.DataSource != null)
            {
                Category = "Barangay";
                BarangayName = dgvBarangay.CurrentRow.Cells[1].Value.ToString();
                frmRespondentList obj = new frmRespondentList();
                obj.ShowDialog();
            }           
        }
    }
}
