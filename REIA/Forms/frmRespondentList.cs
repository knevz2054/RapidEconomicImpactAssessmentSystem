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
    public partial class frmRespondentList : Form
    {
        IDataRepository<Respondent> RespondentRepository = new DataRepository<Respondent>();
        IDataRepository<Municipality> MunicipalityRepository = new DataRepository<Municipality>();
        IDataRepository<Barangay> BarangayRepository = new DataRepository<Barangay>();
        IDataRepository<Survey> SurveyRepository = new DataRepository<Survey>();


        List<Respondent> GetRespondents;
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;
        List<Survey> GetSurveys;
        public frmRespondentList()
        {
            InitializeComponent();
        }

        public async Task CallLoad()
        {
            GetRespondents = await RespondentRepository.GetAll();
            GetMunicipalities = await MunicipalityRepository.GetAll();
            GetBarangays = await BarangayRepository.GetAll();
            GetSurveys = await SurveyRepository.GetAll();
        }

        private async void frmRespondentList_Load(object sender, EventArgs e)
        {
            await CallLoad();
           
            if (frmProfileSummary.Category == "Municipality")
            {
                lblObject.Text = ($"{"Respondents:"} {GetSurveys.Count(x => x.Respondent.Barangay.Municipality.MunicipalityName == frmProfileSummary.MunicipalityName)}").ToString();
                dgvList.DataSource = GetSurveys.Where(x => x.Respondent.Barangay.Municipality.MunicipalityName == frmProfileSummary.MunicipalityName).Select(x => new
                {
                    Fullname = x.Respondent.Fullname == string.Empty ? "Not Specified" : x.Respondent.Fullname,
                    RespondentCode = x.RespondentCode,
                    Gender = x.Respondent.Gender,
                    Status = x.Respondent.CivilStatus,
                    Age = x.Respondent.AgeBracket,
                    Education = x.Respondent.Education,
                    MainIncome = x.Respondent.MainSource,
                    HouseholdMember = x.Respondent.NumberHouseholdMembers
                }).OrderByDescending(x => x.HouseholdMember).ToList();
            }

            if (frmProfileSummary.Category == "Barangay")
            {
                lblObject.Text = ($"{"Respondents:"} {GetSurveys.Count(x => x.Respondent.Barangay.BarangayName == frmProfileSummary.BarangayName)}").ToString();
                dgvList.DataSource = GetSurveys.Where(x => x.Respondent.Barangay.BarangayName == frmProfileSummary.BarangayName).Select(x => new
                {
                    Fullname = x.Respondent.Fullname == string.Empty ? "Not Specified" : x.Respondent.Fullname,
                    espondentCode = x.RespondentCode,
                    Gender = x.Respondent.Gender,
                    Status = x.Respondent.CivilStatus,
                    Age = x.Respondent.AgeBracket,
                    Education = x.Respondent.Education,
                    MainIncome = x.Respondent.MainSource,
                    HouseholdMember = x.Respondent.NumberHouseholdMembers
                }).OrderByDescending(x => x.HouseholdMember).ToList();
            }
        }
    }
}
