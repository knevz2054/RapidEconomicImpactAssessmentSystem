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
    public partial class frmExpenditureSummary : Form
    {
        IDataRepository<Respondent> RespondentRepository = new DataRepository<Respondent>();
        IDataRepository<Municipality> MunicipalityRepository = new DataRepository<Municipality>();
        IDataRepository<Barangay> BarangayRepository = new DataRepository<Barangay>();
        IDataRepository<RespondentGoods> GoodsRepository = new DataRepository<RespondentGoods>();
        IDataRepository<RespondentServices> ServicesRepository = new DataRepository<RespondentServices>();


        List<Respondent> GetRespondents;
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;
        List<RespondentGoods> GetRespondentGoods;
        List<RespondentServices> GetRespondentServices;
        public frmExpenditureSummary()
        {
            InitializeComponent();
        }

        public async Task CallLoad()
        {
            GetRespondents = await RespondentRepository.GetAll();
            GetMunicipalities = await MunicipalityRepository.GetAll();
            GetBarangays = await BarangayRepository.GetAll();
            GetRespondentGoods = await GoodsRepository.GetAll();
            GetRespondentServices = await ServicesRepository.GetAll();
        }

        private async  void frmExpenditureSummary_Load(object sender, EventArgs e)
        {
            await CallLoad();
        }

        private void rbSamar_CheckedChanged(object sender, EventArgs e)
        {
            lblGoods.Text = ($"{"(Goods)"} {"Respondents:"} {GetRespondents.Count}").ToString();
            lblServices.Text = ($"{"(Services)"} {"Respondents:"} {GetRespondents.Count}").ToString();

            lblBarangay_Goods.Text = "Respondents:";
            lblBarangay_Services.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangayGoods.DataSource = null;
            dgvBarangayServices.DataSource = null;

            dgvMunicipalityGoods.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Food = GetRespondentGoods.Count(xx => xx.RespGoods == "Food and Non-Alcoholic Beverages" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Alcoholic = GetRespondentGoods.Count(xx => xx.RespGoods == "Alcoholic Beverages and Tobacco" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Clothing = GetRespondentGoods.Count(xx => xx.RespGoods == "Clothing and Footwear" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Housing = GetRespondentGoods.Count(xx => xx.RespGoods == "Housing, Water, Electricity, Gas and Other Fuels" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();


            dgvMunicipalityServices.DataSource = GetMunicipalities.Select(x => new
            {
                Municipality = x.MunicipalityName,
                Health = GetRespondentServices.Count(xx => xx.RespServices == "Health" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Transport = GetRespondentServices.Count(xx => xx.RespServices == "Transport" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Communication = GetRespondentServices.Count(xx => xx.RespServices == "Communication" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Culture = GetRespondentServices.Count(xx => xx.RespServices == "Recreation and Culture" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Education = GetRespondentServices.Count(xx => xx.RespServices == "Education" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Miscellaneous = GetRespondentServices.Count(xx => xx.RespServices == "Miscellaneous Goods and Services" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();

            RespondentGrid();
        }

        private void rb1stDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblGoods.Text = ($"{"(Goods)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();
            lblServices.Text = ($"{"(Services)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "1st District")}").ToString();

            lblBarangay_Goods.Text = "Respondents:";
            lblBarangay_Services.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangayGoods.DataSource = null;
            dgvBarangayServices.DataSource = null;

            dgvMunicipalityGoods.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Food = GetRespondentGoods.Count(xx => xx.RespGoods == "Food and Non-Alcoholic Beverages" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Alcoholic = GetRespondentGoods.Count(xx => xx.RespGoods == "Alcoholic Beverages and Tobacco" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Clothing = GetRespondentGoods.Count(xx => xx.RespGoods == "Clothing and Footwear" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Housing = GetRespondentGoods.Count(xx => xx.RespGoods == "Housing, Water, Electricity, Gas and Other Fuels" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();


            dgvMunicipalityServices.DataSource = GetMunicipalities.Where(x => x.District == "1st District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Health = GetRespondentServices.Count(xx => xx.RespServices == "Health" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Transport = GetRespondentServices.Count(xx => xx.RespServices == "Transport" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Communication = GetRespondentServices.Count(xx => xx.RespServices == "Communication" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Culture = GetRespondentServices.Count(xx => xx.RespServices == "Recreation and Culture" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Education = GetRespondentServices.Count(xx => xx.RespServices == "Education" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Miscellaneous = GetRespondentServices.Count(xx => xx.RespServices == "Miscellaneous Goods and Services" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();

            RespondentGrid();
        }

        private void rb2ndDistrict_CheckedChanged(object sender, EventArgs e)
        {
            lblGoods.Text = ($"{"(Goods)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();
            lblServices.Text = ($"{"(Services)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.District == "2nd District")}").ToString();

            lblBarangay_Goods.Text = "Respondents:";
            lblBarangay_Services.Text = "Respondents:";

            cbMunicipality.Items.Clear();
            foreach (var item in GetMunicipalities.Where(x => x.District == "2nd District").OrderBy(x => x.MunicipalityName))
                cbMunicipality.Items.Add(item.MunicipalityName);

            dgvBarangayGoods.DataSource = null;
            dgvBarangayServices.DataSource = null;

            dgvMunicipalityGoods.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Food = GetRespondentGoods.Count(xx => xx.RespGoods == "Food and Non-Alcoholic Beverages" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Alcoholic = GetRespondentGoods.Count(xx => xx.RespGoods == "Alcoholic Beverages and Tobacco" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Clothing = GetRespondentGoods.Count(xx => xx.RespGoods == "Clothing and Footwear" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Housing = GetRespondentGoods.Count(xx => xx.RespGoods == "Housing, Water, Electricity, Gas and Other Fuels" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();


            dgvMunicipalityServices.DataSource = GetMunicipalities.Where(x => x.District == "2nd District").Select(x => new
            {
                Municipality = x.MunicipalityName,
                Health = GetRespondentServices.Count(xx => xx.RespServices == "Health" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Transport = GetRespondentServices.Count(xx => xx.RespServices == "Transport" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Communication = GetRespondentServices.Count(xx => xx.RespServices == "Communication" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Culture = GetRespondentServices.Count(xx => xx.RespServices == "Recreation and Culture" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Education = GetRespondentServices.Count(xx => xx.RespServices == "Education" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
                Miscellaneous = GetRespondentServices.Count(xx => xx.RespServices == "Miscellaneous Goods and Services" && xx.Respondent.Barangay.Municipality.MunicipalityName == x.MunicipalityName),
            }).OrderBy(x => x.Municipality).ToList();

            RespondentGrid();
        }

        private void cbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGoods.Text = ($"{"(Goods)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();
            lblServices.Text = ($"{"(Services)"} {"Respondents:"} {GetRespondents.Count(x => x.Barangay.Municipality.MunicipalityName == cbMunicipality.Text)}").ToString();

            dgvBarangayGoods.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Food = GetRespondentGoods.Count(xx => xx.RespGoods == "Food and Non-Alcoholic Beverages" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
                Alcoholic = GetRespondentGoods.Count(xx => xx.RespGoods == "Alcoholic Beverages and Tobacco" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
                Clothing = GetRespondentGoods.Count(xx => xx.RespGoods == "Clothing and Footwear" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
                Housing = GetRespondentGoods.Count(xx => xx.RespGoods == "Housing, Water, Electricity, Gas and Other Fuels" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
            }).OrderBy(x => x.Barangay).ToList();


            dgvBarangayServices.DataSource = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).Select(x => new
            {
                Barangay = x.BarangayName,
                Health = GetRespondentServices.Count(xx => xx.RespServices == "Health" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
                Transport = GetRespondentServices.Count(xx => xx.RespServices == "Transport" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
                Communication = GetRespondentServices.Count(xx => xx.RespServices == "Communication" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
                Culture = GetRespondentServices.Count(xx => xx.RespServices == "Recreation and Culture" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
                Education = GetRespondentServices.Count(xx => xx.RespServices == "Education" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
                Miscellaneous = GetRespondentServices.Count(xx => xx.RespServices == "Miscellaneous Goods and Services" && xx.Respondent.Barangay.BarangayName == x.BarangayName && xx.Respondent.Barangay.Municipality.MunicipalityName == x.Municipality.MunicipalityName),
            }).OrderBy(x => x.Barangay).ToList();

            RespondentGrid();
        }

        public void RespondentGrid()
        {
            dgvMunicipalityGoods.Columns[1].HeaderText = "Food & Non-Alcoholic Beverages";
            dgvMunicipalityGoods.Columns[1].Width = 188;
            dgvMunicipalityGoods.Columns[2].HeaderText = "Alcoholic Beverages & Tobacco";
            dgvMunicipalityGoods.Columns[2].Width = 186;
            dgvMunicipalityGoods.Columns[3].HeaderText = "Clothing & Footwear";
            dgvMunicipalityGoods.Columns[3].Width = 124;
            dgvMunicipalityGoods.Columns[4].HeaderText = "Housing, Water, Electricity, Gas & Other Fuels";
            dgvMunicipalityGoods.Columns[4].Width = 246;

            dgvMunicipalityServices.Columns[1].Width = 93;
            dgvMunicipalityServices.Columns[2].Width = 93;
            dgvMunicipalityServices.Columns[3].Width = 93;
            dgvMunicipalityServices.Columns[4].HeaderText = "Recreation & Culture";
            dgvMunicipalityServices.Columns[4].Width = 150;
            dgvMunicipalityServices.Columns[5].Width = 93;
            dgvMunicipalityServices.Columns[6].HeaderText = "Miscellaneous Goods & Services";
            dgvMunicipalityServices.Columns[6].Width = 190;

            if (cbMunicipality.SelectedItem != null)
            {
                dgvBarangayGoods.Columns[1].HeaderText = "Food & Non-Alcoholic Beverages";
                dgvBarangayGoods.Columns[1].Width = 188;
                dgvBarangayGoods.Columns[2].HeaderText = "Alcoholic Beverages & Tobacco";
                dgvBarangayGoods.Columns[2].Width = 186;
                dgvBarangayGoods.Columns[3].HeaderText = "Clothing & Footwear";
                dgvBarangayGoods.Columns[3].Width = 124;
                dgvBarangayGoods.Columns[4].HeaderText = "Housing, Water, Electricity, Gas & Other Fuels";
                dgvBarangayGoods.Columns[4].Width = 246;

                dgvBarangayServices.Columns[1].Width = 93;
                dgvBarangayServices.Columns[2].Width = 93;
                dgvBarangayServices.Columns[3].Width = 93;
                dgvBarangayServices.Columns[4].HeaderText = "Recreation & Culture";
                dgvBarangayServices.Columns[4].Width = 150;
                dgvBarangayServices.Columns[5].Width = 93;
                dgvBarangayServices.Columns[6].HeaderText = "Miscellaneous Goods & Services";
                dgvBarangayServices.Columns[6].Width = 190;
            }
        }
    }
}
