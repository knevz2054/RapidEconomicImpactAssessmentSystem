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
    public partial class frmSurveyQuestionnaire : Form
    {
        IDataRepository<EconomicCrisisList> economicCrisisList = new DataRepository<EconomicCrisisList>();
        IDataRepository<EconomicRecommendationList> economicRecommendationList = new DataRepository<EconomicRecommendationList>();
        IDataRepository<EntrepreneurialActivitiesList> entrepreneurialActivitiesList = new DataRepository<EntrepreneurialActivitiesList>();
        IDataRepository<GoodsList> goodsList = new DataRepository<GoodsList>();
        IDataRepository<HealtCrisisList> healthCrisisList = new DataRepository<HealtCrisisList>();
        IDataRepository<HealthRecommendationList> healthRecommendationList = new DataRepository<HealthRecommendationList>();
        IDataRepository<OtherSourcesList> otherSourcesList = new DataRepository<OtherSourcesList>();
        IDataRepository<ReasonList> reasonList = new DataRepository<ReasonList>();
        IDataRepository<SalariesWagesList> salariesWagesList = new DataRepository<SalariesWagesList>();
        IDataRepository<ServicesList> servicesList = new DataRepository<ServicesList>();
        IDataRepository<Municipality> dataMunicipality = new DataRepository<Municipality>();
        IDataRepository<Barangay> dataBarangay = new DataRepository<Barangay>();

        IDataRepository<AlcoholicBeverages> alcoholicBeverages = new DataRepository<AlcoholicBeverages>();
        IDataRepository<AllowanceOfStudent> allowanceOfStudent = new DataRepository<AllowanceOfStudent>();
        IDataRepository<BreadsAndCereals> breadsAndCereals = new DataRepository<BreadsAndCereals>();
        IDataRepository<Clothing> Clothings = new DataRepository<Clothing>();
        IDataRepository<Education> Educations = new DataRepository<Education>();
        IDataRepository<ElectricityGasFuels> electricityGasFuel = new DataRepository<ElectricityGasFuels>();
        IDataRepository<FishAndSeafood> fishAndSeafood = new DataRepository<FishAndSeafood>();
        IDataRepository<Footwear> Footwears = new DataRepository<Footwear>();
        IDataRepository<FoodProduct> foodProduct = new DataRepository<FoodProduct>();
        IDataRepository<Fruit> Fruit = new DataRepository<Fruit>();
        IDataRepository<Housing> Housings = new DataRepository<Housing>();
        IDataRepository<InpatientMedicalServices> inpatientMedicalServices = new DataRepository<InpatientMedicalServices>();
        IDataRepository<Insurance> Insurances = new DataRepository<Insurance>();
        IDataRepository<Meat> Meats = new DataRepository<Meat>();
        IDataRepository<MedicalProducts> medicalProducts = new DataRepository<MedicalProducts>();
        IDataRepository<MilkCheeseEggs> milkCheeseEggs = new DataRepository<MilkCheeseEggs>();
        IDataRepository<MineralwaterSoftdrinkJuice> mineralWaterSoftdrinks = new DataRepository<MineralwaterSoftdrinkJuice>();
        IDataRepository<NewspaperBookStationary> newspaperBookStationary = new DataRepository<NewspaperBookStationary>();
        IDataRepository<NonAlcoholicBeverages> nonAlcoholicBeverages = new DataRepository<NonAlcoholicBeverages>();
        IDataRepository<OilsAndFats> oilsAndFats = new DataRepository<OilsAndFats>();
        IDataRepository<OtherEducationalExpense> otherEducationalExpense = new DataRepository<OtherEducationalExpense>();
        IDataRepository<OutpatientMedicalServices> outpatientMedicalServices = new DataRepository<OutpatientMedicalServices>();
        IDataRepository<PersonalCare> personalCare = new DataRepository<PersonalCare>();
        IDataRepository<PersonalEffect> personalEffect = new DataRepository<PersonalEffect>();
        IDataRepository<PersonalTransport> personalTransport = new DataRepository<PersonalTransport>();
        IDataRepository<PostalServices> postalServices = new DataRepository<PostalServices>();
        IDataRepository<RecreationalItemsEquipment> recreationalItemsEquipment = new DataRepository<RecreationalItemsEquipment>();
        IDataRepository<RecreationAndCulture> recreationAndculture = new DataRepository<RecreationAndCulture>();
        IDataRepository<Respondent> Respondent = new DataRepository<Respondent>();
        IDataRepository<RespondentEconomicCrisis> respondentEconomicCrisis = new DataRepository<RespondentEconomicCrisis>();
        IDataRepository<RespondentEntrepreneurialActivities> respondentEntrepreneurialActivities = new DataRepository<RespondentEntrepreneurialActivities>();
        IDataRepository<RespondentGoods> respondentGoods = new DataRepository<RespondentGoods>();
        IDataRepository<RespondentHealthCrisis> respondentHealthCrisis = new DataRepository<RespondentHealthCrisis>();
        IDataRepository<RespondentOtherSources> respondentOtherSources = new DataRepository<RespondentOtherSources>();
        IDataRepository<RespondentSalariesWages> respondentSalariesWages = new DataRepository<RespondentSalariesWages>();
        IDataRepository<RespondentServices> respondentServices = new DataRepository<RespondentServices>();
        IDataRepository<SugarJamHoneyChocolateConfectionary> sugarJamHoney = new DataRepository<SugarJamHoneyChocolateConfectionary>();
        IDataRepository<Survey> Survey = new DataRepository<Survey>();
        IDataRepository<TelephoneTelefaxServices> telephoneTelefaxes = new DataRepository<TelephoneTelefaxServices>();
        IDataRepository<Tobacco> Tobaccos = new DataRepository<Tobacco>();
        IDataRepository<TransportServices> transportServices = new DataRepository<TransportServices>();
        IDataRepository<TuitionFee> tuitionFee = new DataRepository<TuitionFee>();
        IDataRepository<Vegetable> Vegetable = new DataRepository<Vegetable>();
        IDataRepository<WatersupplyMiscellaneous> waterSupplyMisc = new DataRepository<WatersupplyMiscellaneous>();



        List<EconomicCrisisList> GetEconomicCrisisLists;
        List<EconomicRecommendationList> GetEconomicRecommendationLists;
        List<EntrepreneurialActivitiesList> GetEntrepreneurialActivitiesLists;
        List<GoodsList> GetGoodsLists;
        List<HealtCrisisList> GetHealtCrisisLists;
        List<HealthRecommendationList> GetHealthRecommendationLists;
        List<OtherSourcesList> GetOtherSourcesLists;
        List<ReasonList> GetReasonLists;
        List<SalariesWagesList> GetSalariesWagesLists;
        List<ServicesList> GetServicesLists;
        List<Municipality> GetMunicipalities;
        List<Barangay> GetBarangays;
        List<Respondent> GetRespondents;
        List<Survey> GetSurveys;

        int check_BreadsAndCereals = 0, cbBreadsAndCereals = 0;
        int check_Meat = 0, cbMeat = 0;
        int check_FishAndSeafood = 0, cbFishAndSeafood = 0;
        int check_MilkCheeseEggs = 0, cbMilkCheeseEggs = 0;
        int check_OilsAndFats = 0, cbOilsAndFats = 0;
        int check_Fruits = 0, cbFruits = 0;
        int check_Vegetables = 0, cbVegetables = 0;
        int check_SugarJamHoney = 0, cbSugarJamHoney = 0;
        int check_FoodProducts = 0, cbFoodProducts = 0;
        int check_NonAlcoholic = 0, cbNonAlcoholic = 0;
        int check_MineralWater = 0, cbMineralWater = 0;
        int check_Alcoholic = 0, cbAlcoholic = 0;
        int check_Tobacco = 0, cbTobacco = 0;
        int check_Clothing = 0, cbClothing = 0;
        int check_Footwear = 0, cbFootwear = 0;
        int check_Housing = 0, cbHousing = 0;
        int check_Watersupply = 0, cbWatersupply = 0;
        int check_ElectricityGas = 0, cbElectricityGas = 0;
        int check_MedicalProducts = 0, cbMedicalProducts = 0;
        int check_Outpatient = 0, cbOutpatient = 0;
        int check_Inpatient = 0, cbInpatient = 0;
        int check_PersonalTransport = 0, cbPersonalTransport = 0;
        int check_TransportServices = 0, cbTransportServices = 0;
        int check_PostalService = 0, cbPostalService = 0;
        int check_TelephoneTelefax = 0, cbTelephoneTelefax = 0;
        int check_RecreationalItems = 0, cbRecreationalItems = 0;
        int check_RecreationCulture = 0, cbRecreationCulture = 0;
        int check_NewspaperBooks = 0, cbNewspaperBooks = 0;
        int check_Tuition = 0, cbTuition = 0;
        int check_Education = 0, cbEducation = 0;
        int check_Allowance = 0, cbAllowance = 0;
        int check_EducationalExpense = 0, cbEducationalExpense = 0;
        int check_PersonalCare = 0, cbPersonalCare = 0;
        int check_PersonalEffects = 0, cbPersonalEffects = 0;
        int check_Insurance = 0, cbInsurance = 0;



        int countHealthCrisis = 0, countHealthRecommendation = 0;
        int countEconomicCrisis = 0, countEconomicRecommendation = 0;

        int count_txtDate = 0;

        public frmSurveyQuestionnaire()
        {
            InitializeComponent();
        }
        private async void frmSurveyQuestionnaire_Load(object sender, EventArgs e)
        {
            await CallLoad();

            if (GetSalariesWagesLists.Count() > 0)
                await LoadSalariesWages();

            if (GetEntrepreneurialActivitiesLists.Count() > 0)
                await LoadEntreprenuerial();

            if (GetOtherSourcesLists.Count() > 0)
                await LoadOtherSources();
        }

        async Task CallLoad()
        {
            GetEconomicCrisisLists = await economicCrisisList.GetAll();
            GetEconomicRecommendationLists = await economicRecommendationList.GetAll();
            GetEntrepreneurialActivitiesLists = await entrepreneurialActivitiesList.GetAll();
            GetGoodsLists = await goodsList.GetAll();
            GetHealtCrisisLists = await healthCrisisList.GetAll();
            GetHealthRecommendationLists = await healthRecommendationList.GetAll();
            GetOtherSourcesLists = await otherSourcesList.GetAll();
            GetReasonLists = await reasonList.GetAll();
            GetSalariesWagesLists = await salariesWagesList.GetAll();
            GetServicesLists = await servicesList.GetAll();
            GetMunicipalities = await dataMunicipality.GetAll();
            GetBarangays = await dataBarangay.GetAll();
            GetRespondents = await Respondent.GetAll();
            GetSurveys = await Survey.GetAll();
            LoadHealthCrisis();
            LoadEconomicCrisis();
        }

        //Find Controls Method
        public IEnumerable<T> FindControls<T>(Control control) where T : Control
        {
            // we can't cast here because some controls in here will most likely not be <T>
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => FindControls<T>(ctrl))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == typeof(T)).Cast<T>();
        }
        private void District_CheckedChanged(object sender, EventArgs e)
        {
            cbMunicipality.Items.Clear();
            cbBarangay.Items.Clear();
            if (rb1stDistrict.Checked)
            {
                foreach (var item in GetMunicipalities.Where(x => x.District == "1st District").OrderBy(x => x.MunicipalityName))
                    cbMunicipality.Items.Add(item.MunicipalityName);
            }

            if (rb2ndDistrict.Checked)
            {
                foreach (var item in GetMunicipalities.Where(x => x.District == "2nd District").OrderBy(x => x.MunicipalityName))
                    cbMunicipality.Items.Add(item.MunicipalityName);
            }
        }
        private void textDays(object sender, EventArgs e)
        {
            count_txtDate = FindControls<TextBox>(this).Count(x => x.AccessibleName == "ControlsDays" && x.Text != string.Empty);
        }

        private void rbSalaries_CheckedChanged(object sender, EventArgs e)
        {
            rbEntrepreneural.Checked = false;
            rbOtherSources.Checked = false;
        }

        private void rbEnterpreneural_CheckedChanged(object sender, EventArgs e)
        {
            rbSalaries.Checked = false;
            rbOtherSources.Checked = false;
        }

        private void rbOtherSources_CheckedChanged(object sender, EventArgs e)
        {
            rbSalaries.Checked = false;
            rbEntrepreneural.Checked = false;
        }

        //Check boxes in Goods
        private void CheckBoxesGoods(object sender, EventArgs e)
        {
            if (chkGoods_A.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableFoodNonAlcoholic").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableFoodNonAlcoholic").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesGoods_A").ToList().ForEach(x => x.Checked = false);
                //checkBoxesGoods_A
            }

            if (chkGoods_B.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableAlcoholicBeverages").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableAlcoholicBeverages").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesGoods_B").ToList().ForEach(x => x.Checked = false);
            }

            if (chkGoods_C.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableClothing").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableClothing").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesGoods_C").ToList().ForEach(x => x.Checked = false);
            }

            if (chkGoods_D.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableHousing").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableHousing").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesGoods_D").ToList().ForEach(x => x.Checked = false);
            }
        }

        //Check boxes in Services
        private void CheckBoxesServices(object sender, EventArgs e)
        {
            if (chkServices_A.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableHealth").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableHealth").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesServices_A").ToList().ForEach(x => x.Checked = false);
            }

            if (chkServices_B.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableTransport").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableTransport").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesServices_B").ToList().ForEach(x => x.Checked = false);
            }

            if (chkServices_C.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableCommunication").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableCommunication").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesServices_C").ToList().ForEach(x => x.Checked = false);
            }

            if (chkServices_D.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableRecreation").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableRecreation").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesServices_D").ToList().ForEach(x => x.Checked = false);
            }

            if (chkServices_E.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableEducation").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableEducation").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesServices_E").ToList().ForEach(x => x.Checked = false);
            }

            if (chkServices_F.Checked)
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableMiscellaneous").ToList().ForEach(x => x.Enabled = true);
            else
            {
                FindControls<TableLayoutPanel>(this).Where(x => x.AccessibleName == "tableMiscellaneous").ToList().ForEach(x => x.Enabled = false);
                FindControls<CheckBox>(this).Where(x => x.AccessibleName == "checkBoxesServices_F").ToList().ForEach(x => x.Checked = false);
            }
        }

        private void CheckBoxesGoodsBreadAndCereals(object sender, EventArgs e)
        {
            //table Bread and Cereals ==================================================================================================== //
            if (chkKalinayan.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsKalinayan").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsKalinayan").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsKalinayan").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsKalinayan").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsKalinayan").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCommercialRice.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCommercial").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCommercial").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCommercial").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCommercial").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCommercial").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkNFA.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsNFA").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsNFA").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsNFA").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsNFA").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsNFA").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCorn.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCorn").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCorn").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCorn").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCorn").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCorn").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkFlour.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFlour").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFlour").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFlour").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFlour").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFlour").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkOtherCereals.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCereals").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCereals").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCereals").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCereals").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCereals").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkPandesal.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPandesal").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPandesal").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPandesal").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPandesal").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPandesal").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkPasta.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPasta").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPasta").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPasta").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPasta").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPasta").ToList().ForEach(x => x.Enabled = false);
            }
            //Count Checkbox Cheked from Breads and Cereals
            check_BreadsAndCereals = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "BreadsAndCereals" && x.Checked);

        }
        private void ComboBreadsAndCereals(object sender, EventArgs e)
        {
            cbBreadsAndCereals = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyBreadsAndCereals" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereBreadsAndCereals" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeBreadsAndCereals" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonBreadsAndCereals" && x.SelectedItem != null);
        }

        private void CheckBoxesMeat(object sender, EventArgs e)
        {
            //Table Meat ==================================================================================================== //
            if (chkPork.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPork").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPork").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPork").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPork").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPork").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkBeef.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBeef").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBeef").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBeef").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBeef").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBeef").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCaraBeef.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCaraBeef").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCaraBeef").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCaraBeef").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCaraBeef").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCaraBeef").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkChicken.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsChicken").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsChicken").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsChicken").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsChicken").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsChicken").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkGoat.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGoat").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsGoat").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGoat").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGoat").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsGoat").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkAtay.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAtay").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAtay").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAtay").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAtay").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAtay").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkMeatbased.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMeatbased").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMeatbased").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMeatbased").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMeatbased").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMeatbased").ToList().ForEach(x => x.Enabled = false);
            }
            //Count Checkbox Checked from Breads and Cereals
            check_Meat = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Meat" && x.Checked);
        }
        private void ComboMeat(object sender, EventArgs e)
        {
            cbMeat = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyMeat" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereMeat" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeMeat" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonMeat" && x.SelectedItem != null);
        }

        private void CheckBoxesGoodsFishAndSeafoods(object sender, EventArgs e)
        {
            //Table Fish and Seafood ==================================================================================================== //
            if (chkFrozenFish.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFrozenFish").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFrozenFish").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFrozenFish").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFrozenFish").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFrozenFish").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkDriedFish.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDriedFish").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsDriedFish").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDriedFish").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDriedFish").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsDriedFish").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkShrimp.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsShrimp").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsShrimp").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsShrimp").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsShrimp").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsShrimp").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkShells.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsShells").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsShells").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsShells").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsShells").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsShells").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkSardines.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSardines").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSardines").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSardines").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSardines").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSardines").ToList().ForEach(x => x.Enabled = false);
            }
            //Count Checkbox Checked from Fish and Seafoods
            check_FishAndSeafood = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "FishAndSeafood" && x.Checked);
        }

        private void ComboFishAndSeafood(object sender, EventArgs e)
        {
            cbFishAndSeafood = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyFishAndSeafood" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereFishAndSeafood" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeFishAndSeafood" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonFishAndSeafood" && x.SelectedItem != null);
        }

        private void CheckBoxesMilkCheeseAndEggs(object sender, EventArgs e)
        {
            //Table milk Cheese and eggs ==================================================================================================== //
            if (chkRaw.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRaw").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRaw").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRaw").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRaw").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRaw").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkYogurt.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsYogurt").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsYogurt").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsYogurt").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsYogurt").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsYogurt").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkSoyaMilk.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSoyaMilk").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSoyaMilk").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSoyaMilk").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSoyaMilk").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSoyaMilk").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCheese.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCheese").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCheese").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCheese").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCheese").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCheese").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkKisiyo.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsKisiyo").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsKisiyo").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsKisiyo").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsKisiyo").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsKisiyo").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkEggs.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsEggs").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsEggs").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsEggs").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsEggs").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsEggs").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkTaho.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTaho").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTaho").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTaho").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTaho").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTaho").ToList().ForEach(x => x.Enabled = false);
            }
            check_MilkCheeseEggs = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "MilkCheeseEggs" && x.Checked);
        }
        private void ComboMilkCheeseEggs(object sender, EventArgs e)
        {
            cbMilkCheeseEggs = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyMilkCheeseEggs" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereMilkCheeseEggs" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeMilkCheeseEggs" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonMilkCheeseEggs" && x.SelectedItem != null);
        }
        private void CheckBoxesOilsAndFats(object sender, EventArgs e)
        {
            // Table Oils and Fats ==================================================================================================== //
            if (chkButter.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsButter").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsButter").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsButter").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsButter").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsButter").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkMargarine.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMargarine").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMargarine").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMargarine").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMargarine").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMargarine").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkEdibleOil.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsEdibleOil").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsEdibleOil").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsEdibleOil").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsEdibleOil").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsEdibleOil").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkEdibleFat.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsEdibleFat").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsEdibleFat").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsEdibleFat").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsEdibleFat").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsEdibleFat").ToList().ForEach(x => x.Enabled = false);
            }

            check_OilsAndFats = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "OilsAndFats" && x.Checked);
        }

        private void ComboOilsAndFats(object sender, EventArgs e)
        {
            cbOilsAndFats = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyOilsAndFats" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereOilsAndFats" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeOilsAndFats" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonOilsAndFats" && x.SelectedItem != null);
        }

        private void CheckBoxesFruits(object sender, EventArgs e)
        {
            //Table Fruits ==================================================================================================== //
            if (chkFreshFruits.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFreshFruits").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFreshFruits").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFreshFruits").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFreshFruits").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFreshFruits").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkDriedFruits.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDriedFruits").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsDriedFruits").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDriedFruits").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDriedFruits").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsDriedFruits").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkFruitNuts.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFruitNuts").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFruitNuts").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFruitNuts").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFruitNuts").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFruitNuts").ToList().ForEach(x => x.Enabled = false);
            }
            check_Fruits = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Fruits" && x.Checked);
        }

        private void ComboFruits(object sender, EventArgs e)
        {
            cbFruits = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyFruits" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereFruits" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeFruits" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonFruits" && x.SelectedItem != null);
        }

        private void CheckBoxesVegetables(object sender, EventArgs e)
        {
            //Table Vegetables ==================================================================================================== //
            if (chkStalks.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsStalks").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsStalks").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsStalks").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsStalks").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsStalks").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkVegeFruit.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeFruit").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVegeFruit").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeFruit").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeFruit").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVegeFruit").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkVegeRoots.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeRoots").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVegeRoots").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeRoots").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeRoots").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVegeRoots").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkPotatoes.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPotatoes").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPotatoes").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPotatoes").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPotatoes").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPotatoes").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkVegeProcessed.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeProcessed").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVegeProcessed").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeProcessed").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeProcessed").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVegeProcessed").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkVegeTuber.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeTuber").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVegeTuber").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeTuber").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVegeTuber").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVegeTuber").ToList().ForEach(x => x.Enabled = false);
            }
            check_Vegetables = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Vegetables" && x.Checked);
        }

        private void ComboVegetables(object sender, EventArgs e)
        {
            cbVegetables = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyVegetables" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereVegetables" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeVegetables" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonVegetables" && x.SelectedItem != null);
        }

        private void CheckBoxesSugarJamHoney(object sender, EventArgs e)
        {
            //Tble Sugar Jam Honey ==================================================================================================== //
            if (chkSugar.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSugar").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSugar").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSugar").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSugar").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSugar").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkJam.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsJam").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsJam").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsJam").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ConControlsJamtrolsSugar").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsJam").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkHoney.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHoney").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsHoney").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHoney").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHoney").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsHoney").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkChocolates.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsChocolates").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsChocolates").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsChocolates").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsChocolates").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsChocolates").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkIceCream.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsIceCream").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsIceCream").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsIceCream").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsIceCream").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsIceCream").ToList().ForEach(x => x.Enabled = false);
            }
            check_SugarJamHoney = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "SugarJamHoney" && x.Checked);
        }

        private void ComboSugarJamHoney(object sender, EventArgs e)
        {
            cbSugarJamHoney = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencySugarJamHoney" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereSugarJamHoney" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeSugarJamHoney" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonSugarJamHoney" && x.SelectedItem != null);
        }

        private void CheckBoxesFoodProducts(object sender, EventArgs e)
        {
            //Table Food Products ==================================================================================================== //
            if (chkSalt.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSalt").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSalt").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSalt").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSalt").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSalt").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkSpices.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSpices").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSpices").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSpices").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSpices").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSpices").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkSauces.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSauces").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSauces").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSauces").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSauces").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSauces").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkVinegar.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVinegar").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVinegar").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVinegar").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsVinegar").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsVinegar").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkDessert.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDessert").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsDessert").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDessert").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDessert").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsDessert").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkBabyFood.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBabyFood").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBabyFood").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBabyFood").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBabyFood").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBabyFood").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCoffeeMate.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCoffeeMate").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCoffeeMate").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCoffeeMate").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCoffeeMate").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCoffeeMate").ToList().ForEach(x => x.Enabled = false);
            }
            check_FoodProducts = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "FoodProducts" && x.Checked);
        }

        private void ComboFoodProducts(object sender, EventArgs e)
        {
            cbFoodProducts = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyFoodProducts" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereFoodProducts" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeFoodProducts" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonFoodProducts" && x.SelectedItem != null);
        }

        private void CheckBoxesNonAlcoholicBeverages(object sender, EventArgs e)
        {
            //Table Non Alcoholic ==================================================================================================== //
            if (chkCoffee.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCoffee").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCoffee").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCoffee").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCoffee").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCoffee").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkTea.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTea").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTea").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTea").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTea").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTea").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCocoa.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCocoa").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCocoa").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCocoa").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCocoa").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCocoa").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkSoya.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSoya").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSoya").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSoya").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSoya").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSoya").ToList().ForEach(x => x.Enabled = false);
            }
            check_NonAlcoholic = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "NonAlcoholicBeverages" && x.Checked);
        }

        private void ComboNonAlcoholicBeverages(object sender, EventArgs e)
        {
            cbNonAlcoholic = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyNonAlcoholicBeverages" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereNonAlcoholicBeverages" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeNonAlcoholicBeverages" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonNonAlcoholicBeverages" && x.SelectedItem != null);
        }

        private void CheckBoxesMineralwaterSoftdrinks(object sender, EventArgs e)
        {
            //Table Mineral Water ==================================================================================================== //
            if (chkMineral.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMineral").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMineral").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMineral").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMineral").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMineral").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkSoftDrinks.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSoftDrinks").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSoftDrinks").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSoftDrinks").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSoftDrinks").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSoftDrinks").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkJuices.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsJuices").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsJuices").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsJuices").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsJuices").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsJuices").ToList().ForEach(x => x.Enabled = false);
            }
            check_MineralWater = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "MineralwaterSoftdrinks" && x.Checked);
        }

        private void ComboMineralwaterSoftdrinks(object sender, EventArgs e)
        {
            cbMineralWater = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyMineralwaterSoftdrinks" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereMineralwaterSoftdrinks" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeMineralwaterSoftdrinks" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonMineralwaterSoftdrinks" && x.SelectedItem != null);
        }

        private void CheckBoxesAlcoholicBeverages(object sender, EventArgs e)
        {
            //Table Alcoholic Beverages ==================================================================================================== //
            if (chkLiquor.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLiquor").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLiquor").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLiquor").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLiquor").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLiquor").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkWines.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsWines").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsWines").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsWines").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsWines").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsWines").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkBeer.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBeer").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBeer").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBeer").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsWines").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBeer").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkTuba.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTuba").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTuba").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTuba").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTuba").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTuba").ToList().ForEach(x => x.Enabled = false);
            }
            check_Alcoholic = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "AlcoholicBeverages" && x.Checked);
        }

        private void ComboAlcoholicBeverages(object sender, EventArgs e)
        {
            cbAlcoholic = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyAlcoholicBeverages" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereAlcoholicBeverages" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeAlcoholicBeverages" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonAlcoholicBeverages" && x.SelectedItem != null);
        }

        private void CheckBoxesTobacco(object sender, EventArgs e)
        {
            //Table Tobacco ==================================================================================================== //
            if (chkCigarettes.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCigarettes").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCigarettes").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCigarettes").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCigarettes").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCigarettes").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCigars.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCigars").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCigars").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCigars").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCigars").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCigars").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkChewingTobacco.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsChewingTobacco").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsChewingTobacco").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsChewingTobacco").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsChewingTobacco").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsChewingTobacco").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkMama.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMama").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMama").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMama").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMama").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMama").ToList().ForEach(x => x.Enabled = false);
            }
            check_Tobacco = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Tobacco" && x.Checked);
        }

        private void ComboTobacco(object sender, EventArgs e)
        {
            cbTobacco = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyTobacco" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereTobacco" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeTobacco" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonTobacco" && x.SelectedItem != null);
        }

        private void CheckBoxesClothing(object sender, EventArgs e)
        {
            //Table Clothing ==================================================================================================== //
            if (chkMaterials.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMaterials").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMaterials").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMaterials").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMaterials").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMaterials").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkGarments.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGarments").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsGarments").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGarments").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGarments").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsGarments").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkAccessories.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAccessories").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAccessories").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAccessories").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAccessories").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAccessories").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCleaning.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCleaning").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCleaning").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCleaning").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCleaning").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCleaning").ToList().ForEach(x => x.Enabled = false);
            }
            check_Clothing = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Clothing" && x.Checked);
        }

        private void ComboClothing(object sender, EventArgs e)
        {
            cbClothing = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyClothing" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereClothing" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeClothing" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonClothing" && x.SelectedItem != null);
        }

        private void CheckBoxesFootwear(object sender, EventArgs e)
        {
            //Table Footwear ==================================================================================================== //
            if (chkShoes.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsShoes").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsShoes").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsShoes").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsShoes").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsShoes").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkRepair.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRepair").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRepair").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRepair").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRepair").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRepair").ToList().ForEach(x => x.Enabled = false);
            }
            check_Footwear = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Footwear" && x.Checked);
        }

        private void ComboFootwear(object sender, EventArgs e)
        {
            cbFootwear = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyFootwear" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereFootwear" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeFootwear" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonFootwear" && x.SelectedItem != null);
        }

        private void CheckBoxesHousing(object sender, EventArgs e)
        {
            //Table Housing ==================================================================================================== //
            if (chkActual.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsActual").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsActual").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsActual").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsActual").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsActual").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkImputed.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsImputed").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsImputed").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsImputed").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsImputed").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsImputed").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkMaintenance.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMaintenance").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMaintenance").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMaintenance").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMaintenance").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMaintenance").ToList().ForEach(x => x.Enabled = false);
            }
            check_Housing = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Housing" && x.Checked);
        }

        private void ComboHousing(object sender, EventArgs e)
        {
            cbHousing = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyHousing" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereHousing" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeHousing" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonHousing" && x.SelectedItem != null);
        }

        private void CheckBoxesWatersupply(object sender, EventArgs e)
        {
            //Table Water Supply ==================================================================================================== //
            if (chkWater.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsWater").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsWater").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsWater").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsWater").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsWater").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkServices.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsServices").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsServices").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsServices").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsServices").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsServices").ToList().ForEach(x => x.Enabled = false);
            }
            check_Watersupply = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Watersupply" && x.Checked);
        }

        private void ComboWatersupply(object sender, EventArgs e)
        {
            cbWatersupply = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyWatersupply" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereWatersupply" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeWatersupply" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonWatersupply" && x.SelectedItem != null);
        }

        private void CheckBoxesElectricityGas(object sender, EventArgs e)
        {
            //Table Electricity ==================================================================================================== //
            if (chkElectricity.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsElectricity").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsElectricity").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsElectricity").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsElectricity").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsElectricity").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkLPG.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLPG").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLPG").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLPG").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLPG").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLPG").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkKerosene.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsKerosene").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsKerosene").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsKerosene").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsKerosene").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsKerosene").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkFuelwood.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFuelwood").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFuelwood").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFuelwood").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFuelwood").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFuelwood").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCharcoal.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCharcoal").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCharcoal").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCharcoal").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCharcoal").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCharcoal").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkBiomass.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBiomass").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBiomass").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBiomass").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBiomass").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBiomass").ToList().ForEach(x => x.Enabled = false);
            }
            check_ElectricityGas = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "ElectricityGas" && x.Checked);
        }

        private void ComboElectricityGas(object sender, EventArgs e)
        {
            cbElectricityGas = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyElectricityGas" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereElectricityGas" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeElectricityGas" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonElectricityGas" && x.SelectedItem != null);
        }

        private void CheckBoxesMedicalProducts(object sender, EventArgs e)
        {
            //Table Medical Products
            if (chkPharma.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPharma").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPharma").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPharma").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPharma").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPharma").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkOtherMedical.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsOtherMedical").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsOtherMedical").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsOtherMedical").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsOtherMedical").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsOtherMedical").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkTherap.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTherap").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTherap").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTherap").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTherap").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTherap").ToList().ForEach(x => x.Enabled = false);
            }
            check_MedicalProducts = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "MedicalProducts" && x.Checked);
        }

        private void ComboMedicalProductsg(object sender, EventArgs e)
        {
            cbMedicalProducts = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyMedicalProducts" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereMedicalProducts" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeMedicalProducts" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonMedicalProducts" && x.SelectedItem != null);
        }

        private void CheckBoxesOutpatient(object sender, EventArgs e)
        {
            //Table Outpatient Medical Services
            if (chkMedical.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMedical").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMedical").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMedical").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsMedical").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsMedical").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkDental.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDental").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsDental").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDental").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsDental").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsDental").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkParam.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsParam").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsParam").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsParam").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsParam").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsParam").ToList().ForEach(x => x.Enabled = false);
            }
            check_Outpatient = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Outpatient" && x.Checked);
        }

        private void ComboOutpatient(object sender, EventArgs e)
        {
            cbOutpatient = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyOutpatient" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereOutpatient" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeOutpatient" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonOutpatient" && x.SelectedItem != null);
        }

        private void CheckBoxesInpatient(object sender, EventArgs e)
        {
            //Table Hospital Services In-patient
            if (chkPublic.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPublic").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPublic").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPublic").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPublic").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPublic").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkPrivate.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPrivate").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPrivate").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPrivate").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPrivate").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPrivate").ToList().ForEach(x => x.Enabled = false);
            }
            check_Inpatient = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Inpatient" && x.Checked);
        }

        private void ComboInpatient(object sender, EventArgs e)
        {
            cbInpatient = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyInpatient" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereInpatient" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeInpatient" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonInpatient" && x.SelectedItem != null);
        }

        private void CheckBoxesPersonalTransport(object sender, EventArgs e)
        {
            //Table Operation of Personal Transport
            if (chkSpare.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSpare").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSpare").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSpare").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSpare").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSpare").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkFuel.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFuel").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFuel").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFuel").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsFuel").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsFuel").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkTransRepair.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTransRepair").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTransRepair").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTransRepair").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTransRepair").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTransRepair").ToList().ForEach(x => x.Enabled = false);
            }
            check_PersonalTransport = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "PersonalTransport" && x.Checked);
        }

        private void ComboPersonalTransport(object sender, EventArgs e)
        {
            cbPersonalTransport = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyPersonalTransport" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "wherePersonalTransport" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changePersonalTransport" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonPersonalTransport" && x.SelectedItem != null);
        }

        private void CheckBoxesTransportServices(object sender, EventArgs e)
        {
            //Table Transport Services
            if (chkRailway.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRailway").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRailway").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRailway").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRailway").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRailway").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkRoad.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRoad").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRoad").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRoad").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRoad").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRoad").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkAir.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAir").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAir").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAir").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAir").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAir").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkSea.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSea").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSea").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSea").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSea").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSea").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCombined.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCombined").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCombined").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCombined").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCombined").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCombined").ToList().ForEach(x => x.Enabled = false);
            }
            check_TransportServices = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "TransportServices" && x.Checked);
        }

        private void ComboTransportServices(object sender, EventArgs e)
        {
            cbTransportServices = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyTransportServices" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereTransportServices" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeTransportServices" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonTransportServices" && x.SelectedItem != null);
        }

        private void CheckBoxesPostalServices(object sender, EventArgs e)
        {
            //Table Postal Services
            if (chkPostal.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPostal").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPostal").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPostal").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPostal").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPostal").ToList().ForEach(x => x.Enabled = false);
            }
            check_PostalService = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "PostalService" && x.Checked);
        }

        private void ComboPostalService(object sender, EventArgs e)
        {
            cbPostalService = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyPostalService" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "wherePostalService" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changePostalService" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonPostalService" && x.SelectedItem != null);
        }

        private void CheckBoxesTelephoneAndTelefax(object sender, EventArgs e)
        {
            //Table Telephone and Telefax Services
            if (chkLandline.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLandline").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLandline").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLandline").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLandline").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLandline").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkInternet.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsInternet").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsInternet").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsInternet").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsInternet").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsInternet").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkPostpaid.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPostpaid").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPostpaid").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPostpaid").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPostpaid").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPostpaid").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkPrepaid.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPrepaid").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPrepaid").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPrepaid").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPrepaid").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPrepaid").ToList().ForEach(x => x.Enabled = false);
            }
            check_TelephoneTelefax = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "TelephoneTelefax" && x.Checked);
        }

        private void ComboTelephoneTelefax(object sender, EventArgs e)
        {
            cbTelephoneTelefax = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyTelephoneTelefax" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereTelephoneTelefax" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeTelephoneTelefax" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonTelephoneTelefax" && x.SelectedItem != null);
        }

        private void CheckBoxesRecreactionalItemsEquipment(object sender, EventArgs e)
        {
            //Table Recreational Items and Equipment
            if (chkGames.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGames").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsGames").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGames").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGames").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsGames").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkGarden.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGarden").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsGarden").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGarden").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsGarden").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsGarden").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkPet.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPet").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPet").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPet").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPet").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPet").ToList().ForEach(x => x.Enabled = false);
            }
            check_RecreationalItems = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "RecreationalItemsEquipment" && x.Checked);
        }

        private void ComboRecreationalItemsEquipment(object sender, EventArgs e)
        {
            cbRecreationalItems = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyRecreationalItemsEquipment" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereRecreationalItemsEquipment" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeRecreationalItemsEquipment" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonRecreationalItemsEquipment" && x.SelectedItem != null);
        }

        private void CheckBoxesRecreationAndCulture(object sender, EventArgs e)
        {
            //Table Recreation and Culture
            if (chkSports.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSports").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSports").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSports").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSports").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSports").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkCable.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCable").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCable").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCable").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsCable").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsCable").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkLotto.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLotto").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLotto").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLotto").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLotto").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLotto").ToList().ForEach(x => x.Enabled = false);
            }
            check_RecreationCulture = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "RecreationAndCulture" && x.Checked);
        }

        private void ComboRecreationAndCulture(object sender, EventArgs e)
        {
            cbRecreationCulture = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyRecreationAndCulture" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereRecreationAndCulture" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeRecreationAndCulture" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonRecreationAndCulture" && x.SelectedItem != null);
        }

        private void CheckBoxesNewspaperBooks(object sender, EventArgs e)
        {
            //Table Newspaper, Books and Stationary
            if (chkBooks.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBooks").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBooks").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBooks").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBooks").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBooks").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkNewspaper.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsNewspaper").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsNewspaper").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsNewspaper").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsNewspaper").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsNewspaper").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkStationary.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsStationary").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsStationary").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsStationary").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsStationary").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsStationary").ToList().ForEach(x => x.Enabled = false);
            }
            check_NewspaperBooks = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "NewspaperBooks" && x.Checked);
        }

        private void ComboNewspaperBooks(object sender, EventArgs e)
        {
            cbNewspaperBooks = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyNewspaperBooks" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereNewspaperBooks" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeNewspaperBooks" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonNewspaperBooks" && x.SelectedItem != null);
        }

        private void CheckBoxesTuitionFees(object sender, EventArgs e)
        {
            //Table Tuition Fees
            if (chkPre.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPre").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPre").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPre").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPre").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPre").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkPrimary.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPrimary").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPrimary").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPrimary").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPrimary").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPrimary").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkSecondary.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSecondary").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSecondary").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSecondary").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSecondary").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSecondary").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkPost.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPost").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPost").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPost").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsPost").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsPost").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkTertiary.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTertiary").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTertiary").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTertiary").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTertiary").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTertiary").ToList().ForEach(x => x.Enabled = false);
            }
            check_Tuition = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "TuitionFees" && x.Checked);
        }

        private void ComboTuitionFees(object sender, EventArgs e)
        {
            cbTuition = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyTuitionFees" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereTuitionFees" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeTuitionFees" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonTuitionFees" && x.SelectedItem != null);
        }

        private void CheckBoxesEducation(object sender, EventArgs e)
        {
            //Table Education Non Definable by Level

            if (chkReview.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsReview").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsReview").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsReview").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsReview").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsReview").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkTraining.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTraining").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTraining").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTraining").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsTraining").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsTraining").ToList().ForEach(x => x.Enabled = false);
            }
            check_Education = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Education" && x.Checked);
        }

        private void ComboEducation(object sender, EventArgs e)
        {
            cbEducation = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyEducation" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereEducation" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeEducation" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonEducation" && x.SelectedItem != null);
        }

        private void CheckBoxesAllowanceOfStudent(object sender, EventArgs e)
        {
            //Table Allowance of Students
            if (chkAllowance.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAllowance").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAllowance").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAllowance").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAllowance").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAllowance").ToList().ForEach(x => x.Enabled = false);
            }
            check_Allowance = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Allowance" && x.Checked);
        }

        private void ComboAllowance(object sender, EventArgs e)
        {
            cbAllowance = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyAllowance" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereAllowance" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeAllowance" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonAllowance" && x.SelectedItem != null);
        }

        private void CheckBoxesEducationalExpense(object sender, EventArgs e)
        {
            //Table Other Educational Expense
            if (chkUniform.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsUniform").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsUniform").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsUniform").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsUniform").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsUniform").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkRental.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRental").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRental").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRental").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsRental").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsRental").ToList().ForEach(x => x.Enabled = false);
            }
            check_EducationalExpense = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "EducationalExpense" && x.Checked);
        }

        private void ComboEducationalExpense(object sender, EventArgs e)
        {
            cbEducationalExpense = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyEducationalExpense" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereEducationalExpense" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeEducationalExpense" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonEducationalExpense" && x.SelectedItem != null);
        }

        private void CheckBoxesPersonalCare(object sender, EventArgs e)
        {
            //Table Personal Care
            if (chkSalon.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSalon").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSalon").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSalon").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsSalon").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsSalon").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkAppliances.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAppliances").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAppliances").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAppliances").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsAppliances").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsAppliances").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkBeauty.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBeauty").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBeauty").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBeauty").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsBeauty").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsBeauty").ToList().ForEach(x => x.Enabled = false);
            }
            check_PersonalCare = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "PersonalCare" && x.Checked);
        }

        private void ComboPersonalCare(object sender, EventArgs e)
        {
            cbPersonalCare = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyPersonalCare" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "wherePersonalCare" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changePersonalCare" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonPersonalCare" && x.SelectedItem != null);
        }

        private void CheckBoxesPersonalEffects(object sender, EventArgs e)
        {
            //Table Personal Effects
            if (chkJewelry.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsJewelry").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsJewelry").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsJewelry").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsJewelry").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsJewelry").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkHandbags.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHandbags").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsHandbags").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHandbags").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHandbags").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsHandbags").ToList().ForEach(x => x.Enabled = false);
            }
            check_PersonalEffects = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "PersonalEffects" && x.Checked);
        }

        private void ComboPersonalEffects(object sender, EventArgs e)
        {
            cbPersonalEffects = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyPersonalEffects" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "wherePersonalEffects" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changePersonalEffects" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonPersonalEffects" && x.SelectedItem != null);
        }

        private void CheckBoxesInsurance(object sender, EventArgs e)
        {
            //Table Insurance (Life and Non-Life)
            if (chkLife.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLife").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLife").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLife").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsLife").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsLife").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkHousing.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHousing").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsHousing").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHousing").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHousing").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsHousing").ToList().ForEach(x => x.Enabled = false);
            }

            if (chkHealth.Checked)
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHealth").ToList().ForEach(x => x.Enabled = true);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsHealth").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHealth").ToList().ForEach(x => x.Enabled = false);
                FindControls<ComboBox>(this).Where(x => x.AccessibleName == "ControlsHealth").ToList().ForEach(x => x.SelectedItem = null);
                FindControls<Button>(this).Where(x => x.AccessibleName == "ControlsHealth").ToList().ForEach(x => x.Enabled = false);
            }
            check_Insurance = FindControls<CheckBox>(this).Count(x => x.AccessibleDescription == "Insurance" && x.Checked);
        }

        private void ComboInsurance(object sender, EventArgs e)
        {
            cbInsurance = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "frequencyInsurance" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "whereInsurance" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "changeInsurance" && x.SelectedItem != null)
                + FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "reasonInsurance" && x.SelectedItem != null);
        }


        private void cbMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBarangay.Items.Clear();
            foreach (var item in GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text).OrderBy(x => x.BarangayName))
                cbBarangay.Items.Add(item.BarangayName);
        }

        private async void CheckBoxesIncome(object sender, EventArgs e)
        {
            if (chkSalaries.Checked)
            {
                rbSalaries.Enabled = true;
                lvSalariesWages.Enabled = true;
                btnAddSalariesWages.Enabled = true;
                btnReloadSalariesWages.Enabled = true;
            }

            else
            {
                rbSalaries.Enabled = false;
                rbSalaries.Checked = false;
                lvSalariesWages.Enabled = false;
                btnAddSalariesWages.Enabled = false;
                btnReloadSalariesWages.Enabled = false;
                await LoadSalariesWages();
            }

            if (chkEntrepreneurial.Checked)
            {
                rbEntrepreneural.Enabled = true;
                lvEntrepreneurial.Enabled = true;
                btnAddEnrpreneurial.Enabled = true;
                btnReloadEntrepreneurial.Enabled = true;
            }

            else
            {
                rbEntrepreneural.Enabled = false;
                rbEntrepreneural.Checked = false;
                lvEntrepreneurial.Enabled = false;
                btnAddEnrpreneurial.Enabled = false;
                btnReloadEntrepreneurial.Enabled = false;
                await LoadEntreprenuerial();
            }

            if (chkOtherSources.Checked)
            {
                rbOtherSources.Enabled = true;
                lvOtherSources.Enabled = true;
                btnAddOtherSources.Enabled = true;
                btnReloadOtherSources.Enabled = true;
            }

            else
            {
                rbOtherSources.Enabled = false;
                rbOtherSources.Checked = false;
                lvOtherSources.Enabled = false;
                btnAddOtherSources.Enabled = false;
                btnReloadOtherSources.Enabled = false;
                await LoadOtherSources();
            }
        }

        private void chkL_Yes_CheckedChanged(object sender, EventArgs e)
        {
            tblQuestionnaire_L_1.Enabled = chkL_Yes.Checked;
            if (!chkL_Yes.Checked)
                FindControls<TextBox>(this).Where(x => x.AccessibleName == "ControlsDays").ToList().ForEach(x => x.Clear());
        }

        private void HealthCrisis(object sender, EventArgs e)
        {
            if (cbConcerns_HealthOne.SelectedItem != null)
            {
                cbRecommendation_HealthOne.Enabled = true;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_HealthOne").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                cbRecommendation_HealthOne.Enabled = false;
                cbRecommendation_HealthOne.SelectedItem = null;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_HealthOne").ToList().ForEach(x => x.Enabled = false);

            }

            if (cbConcerns_HealthTwo.SelectedItem != null)
            {
                cbRecommendation_HealthTwo.Enabled = true;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_HealthTwo").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                cbRecommendation_HealthTwo.Enabled = false;
                cbRecommendation_HealthTwo.SelectedItem = null;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_HealthTwo").ToList().ForEach(x => x.Enabled = false);

            }

            if (cbConcerns_HealthThree.SelectedItem != null)
            {
                cbRecommendation_HealthThree.Enabled = true;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_HealthThree").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                cbRecommendation_HealthThree.Enabled = false;
                cbRecommendation_HealthThree.SelectedItem = null;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_HealthThree").ToList().ForEach(x => x.Enabled = false);

            }
            countHealthCrisis = FindControls<ComboBox>(this).Count(x => x.AccessibleName == "HealthCrisis" && x.SelectedItem != null);
        }

        private void btnAddEnrpreneurial_Click(object sender, EventArgs e)
        {
            frmAddEntrepreneurialActivities obj = new frmAddEntrepreneurialActivities();
            obj.ShowDialog();
        }

        private async void btnReloadEntrepreneurial_Click(object sender, EventArgs e)
        {
            await LoadEntreprenuerial();
        }

        private void btnAddOtherSources_Click(object sender, EventArgs e)
        {
            frmAddOtherSources obj = new frmAddOtherSources();
            obj.ShowDialog();
        }

        private async void btnReloadOtherSources_Click(object sender, EventArgs e)
        {
            await LoadOtherSources();
        }
        private void btnAddSalariesWages_Click(object sender, EventArgs e)
        {
            frmAddSalariesWages obj = new frmAddSalariesWages();
            obj.ShowDialog();
        }

        private async void btnReloadSalariesWages_Click(object sender, EventArgs e)
        {
            await LoadSalariesWages();
        }

        private void RecommendationHealthCrisis(object sender, EventArgs e)
        {
            countHealthRecommendation = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "HealthRecommendation" && x.SelectedItem != null);
        }

        private void EconomicCrisis(object sender, EventArgs e)
        {
            if (cbConcerns_EconomicOne.SelectedItem != null)
            {
                cbRecommendation_EconomicOne.Enabled = true;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_EconomicOne").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                cbRecommendation_EconomicOne.Enabled = false;
                cbRecommendation_EconomicOne.SelectedItem = null;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_EconomicOne").ToList().ForEach(x => x.Enabled = false);

            }

            if (cbConcerns_EconomicTwo.SelectedItem != null)
            {
                cbRecommendation_EconomicTwo.Enabled = true;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_EconomicTwo").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                cbRecommendation_EconomicTwo.Enabled = false;
                cbRecommendation_EconomicTwo.SelectedItem = null;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_EconomicTwo").ToList().ForEach(x => x.Enabled = false);

            }

            if (cbConcerns_EconomicThree.SelectedItem != null)
            {
                cbRecommendation_EconomicThree.Enabled = true;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_EconomicThree").ToList().ForEach(x => x.Enabled = true);
            }
            else
            {
                cbRecommendation_EconomicThree.Enabled = false;
                cbRecommendation_EconomicThree.SelectedItem = null;
                FindControls<Button>(this).Where(x => x.AccessibleName == "cbConcerns_EconomicThree").ToList().ForEach(x => x.Enabled = false);
            }
            countEconomicCrisis = FindControls<ComboBox>(this).Count(x => x.AccessibleName == "EconomicCrisis" && x.SelectedItem != null);
        }

        private void RecommendationEconomicCrisis(object sender, EventArgs e)
        {
            countEconomicRecommendation = FindControls<ComboBox>(this).Count(x => x.AccessibleDescription == "EconomicRecommendation" && x.SelectedItem != null);
        }

        private void btnAdd_HealthCrisis_Click(object sender, EventArgs e)
        {
            frmAddHealthCrisis obj = new frmAddHealthCrisis();
            obj.ShowDialog();
        }

        private void btnReload_HealthCrisis_Click(object sender, EventArgs e)
        {
            LoadHealthCrisis();
        }

        private void btnAdd_EconomicCrisis_Click(object sender, EventArgs e)
        {
            frmAddEconomicCrisis obj = new frmAddEconomicCrisis();
            obj.ShowDialog();
        }

        private void btnReload_EconomicCrisis_Click(object sender, EventArgs e)
        {
            LoadEconomicCrisis();
        }

        public bool IsValidEntry()
        {
            if (FindControls<ComboBox>(this).Count(x => x.AccessibleName == "ControlsRespondent" && x.SelectedItem == null) > 0)
            {
                MessageBox.Show("Action failed! Complete respondent information...", "Error");
                return false;
            }

            else if (FindControls<TextBox>(this).Count(x => x.AccessibleName == "ControlsRespondent" && x.Text == string.Empty) > 0)
            {
                MessageBox.Show("Action failed! Complete respondent information...", "Error");
                return false;
            }

            else if (FindControls<CheckBox>(this).Count(x => x.AccessibleName == "ControlsIncome" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Select type of income...", "Error");
                tblSalariesWages.Focus();
                return false;
            }

            else if (FindControls<RadioButton>(this).Count(x => x.AccessibleName == "ControlsMainSource" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Select main source of income...", "Error");
                tblSalariesWages.Focus();
                return false;
            }

            else if(chkSalaries.Checked && lvSalariesWages.CheckedItems.Count == 0)
            {
                MessageBox.Show("Action failed! Select type of income in Salaries/Wages...", "Error");
                tblSalariesWages.Focus();
                return false;
            }

            else if (chkEntrepreneurial.Checked && lvEntrepreneurial.CheckedItems.Count == 0)
            {
                MessageBox.Show("Action failed! Select type of income in Entrepreneurial Activities...", "Error");
                tblEntrepreneurial.Focus();
                return false;
            }

            else if (chkOtherSources.Checked && lvOtherSources.CheckedItems.Count == 0)
            {
                MessageBox.Show("Action failed! Select type of income in Other Sources if Income...", "Error");
                tblOtherSources.Focus();
                return false;
            }

            else if (FindControls<RadioButton>(this).Count(x => x.AccessibleName == "rbQuestionaireG" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Question letter G has no answer...", "Error");
                tblQuestionnaire_G.Focus();
                return false;
            }

            else if (FindControls<RadioButton>(this).Count(x => x.AccessibleName == "rbQuestionaireH" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Question letter H has no answer...", "Error");
                tblQuestionnaire_H.Focus();
                return false;
            }

            else if (FindControls<RadioButton>(this).Count(x => x.AccessibleName == "rbQuestionaireI" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Question letter I has no answer...", "Error");
                tblQuestionnaire_I.Focus();
                return false;
            }

            else if (FindControls<CheckBox>(this).Count(x => x.AccessibleName == "CheckBoxesGoods" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Question from Goods has no answer...", "Error");
                tblQuestionnaire_Goods.Focus();
                return false;
            }

            else if (FindControls<CheckBox>(this).Count(x => x.AccessibleName == "CheckBoxesServices" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Question from Services has no answer...", "Error");
                tblQuestionnaire_Services.Focus();
                return false;
            }

            else if (chkGoods_A.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesGoods_A" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Food and Non-Alcoholic Beverages is null...", "Error");
                pnlFoodNonAlcoholic.Focus();
                return false;
            }

            else if (chkGoods_B.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesGoods_B" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Alcoholic Beverages and Tobacco is null...", "Error");
                pnlAlcoholic.Focus();
                return false;
            }

            else if (chkGoods_C.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesGoods_C" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Clothing and Footwear is null...", "Error");
                pnlClothing.Focus();
                return false;
            }

            else if (chkGoods_D.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesGoods_D" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Housing, Water, Electricity, Gas and Other Fuels is null...", "Error");
                pnlHousing.Focus();
                return false;
            }

            else if (chkServices_A.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesServices_A" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Health is null...", "Error");
                pnlHealth.Focus();
                return false;
            }

            else if (chkServices_B.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesServices_B" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Transport is null...", "Error");
                pnlTransport.Focus();
                return false;
            }

            else if (chkServices_C.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesServices_C" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Communication is null...", "Error");
                pnlCommunication.Focus();
                return false;
            }

            else if (chkServices_D.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesServices_D" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Recreation and Culture is null...", "Error");
                pnlRecreation.Focus();
                return false;
            }

            else if (chkServices_E.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesServices_E" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Education is null...", "Error");
                pnlEducation.Focus();
                return false;
            }

            else if (chkServices_F.Checked && FindControls<CheckBox>(this).Count(x => x.AccessibleName == "checkBoxesServices_F" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Entry from Miscellaneous Goods and Services is null...", "Error");
                pnlMiscellaneous.Focus();
                return false;
            }

            else if (check_BreadsAndCereals > 0 && cbBreadsAndCereals == 0)
            {
                MessageBox.Show("Action failed! No entry from Breads and Cereals ...", "Error");
                tblBreadCereals.Focus();
                return false;
            }

            else if (check_Meat > 0 && cbMeat == 0)
            {
                MessageBox.Show("Action failed! No entry from Meat...", "Error");
                tblMeat.Focus();
                return false;
            }

            else if (check_FishAndSeafood > 0 && cbFishAndSeafood == 0)
            {
                MessageBox.Show("Action failed! No entry from Fish and Seafoods...", "Error");
                tblFishSeafood.Focus();
                return false;
            }

            else if (check_MilkCheeseEggs > 0 && cbMilkCheeseEggs == 0)
            {
                MessageBox.Show("Action failed! No entry from Milk, Cheese and Eggs...", "Error");
                tblMilkCheese.Focus();
                return false;
            }

            else if (check_OilsAndFats > 0 && cbOilsAndFats == 0)
            {
                MessageBox.Show("Action failed! No entry from Oils and Fats...", "Error");
                tblOilsFats.Focus();
                return false;
            }

            else if (check_Fruits > 0 && cbFruits == 0)
            {
                MessageBox.Show("Action failed! No entry from Fruit...", "Error");
                tblFruits.Focus();
                return false;
            }

            else if (check_Vegetables > 0 && cbVegetables == 0)
            {
                MessageBox.Show("Action failed! No entry from Vegetables...", "Error");
                tblVegetables.Focus();
                return false;
            }

            else if (check_SugarJamHoney > 0 && cbSugarJamHoney == 0)
            {
                MessageBox.Show("Action failed! No entry from Sugar, Jam, Honey, Chocolate and Confectionary...", "Error");
                tblSugarJam.Focus();
                return false;
            }

            else if (check_FoodProducts > 0 && cbFoodProducts == 0)
            {
                MessageBox.Show("Action failed! No entry from Food Products...", "Error");
                tblFoodProducts.Focus();
                return false;
            }

            else if (check_NonAlcoholic > 0 && cbNonAlcoholic == 0)
            {
                MessageBox.Show("Action failed! No entry from Non-Alcoholic Beverages...", "Error");
                tblNonAlcoholic.Focus();
                return false;
            }

            else if (check_MineralWater > 0 && cbMineralWater == 0)
            {
                MessageBox.Show("Action failed! No entry from Mineral water, Softdrinks, Fruit and Vegetable Juice...", "Error");
                tblMineral.Focus();
                return false;
            }

            else if (check_Alcoholic > 0 && cbAlcoholic == 0)
            {
                MessageBox.Show("Action failed! No entry from Alcoholic Beverages...", "Error");
                tblAlcoholicBeverages.Focus();
                return false;
            }

            else if (check_Tobacco > 0 && cbTobacco == 0)
            {
                MessageBox.Show("Action failed! No entry from Tobacco...", "Error");
                tblTobacco.Focus();
                return false;
            }

            else if (check_Clothing > 0 && cbClothing == 0)
            {
                MessageBox.Show("Action failed! No entry from Clothing...", "Error");
                tblClothing.Focus();
                return false;
            }

            else if (check_Footwear > 0 && cbFootwear == 0)
            {
                MessageBox.Show("Action failed! No entry from Footwear...", "Error");
                tblFootwear.Focus();
                return false;
            }

            else if (check_Housing > 0 && cbHousing == 0)
            {
                MessageBox.Show("Action failed! No entry from Housing...", "Error");
                tblHousing.Focus();
                return false;
            }

            else if (check_Watersupply > 0 && cbWatersupply == 0)
            {
                MessageBox.Show("Action failed! No entry from Water Supply and Miscellaneous Services...", "Error");
                tblWaterSupply.Focus();
                return false;
            }

            else if (check_ElectricityGas > 0 && cbElectricityGas == 0)
            {
                MessageBox.Show("Action failed! No entry from Electricity, Gas and Other Fuels...", "Error");
                tblElectricity.Focus();
                return false;
            }

            else if (check_MedicalProducts > 0 && cbMedicalProducts == 0)
            {
                MessageBox.Show("Action failed! No entry from Medical Products...", "Error");
                tblMedicalProducts.Focus();
                return false;
            }

            else if (check_Outpatient > 0 && cbOutpatient == 0)
            {
                MessageBox.Show("Action failed! No entry from Outpatient Medical Services...", "Error");
                tblOutpatient.Focus();
                return false;
            }

            else if (check_Inpatient > 0 && cbInpatient == 0)
            {
                MessageBox.Show("Action failed! No entry from Hospital Serives (In-Patient)...", "Error");
                tblInpatient.Focus();
                return false;
            }

            else if (check_PersonalTransport > 0 && cbPersonalTransport == 0)
            {
                MessageBox.Show("Action failed! No entry from Operation of Personal Transport...", "Error");
                tblPersonalTransport.Focus();
                return false;
            }

            else if (check_TransportServices > 0 && cbTransportServices == 0)
            {
                MessageBox.Show("Action failed! No entry from Transport Services...", "Error");
                tblTransportServices.Focus();
                return false;
            }

            else if (check_PostalService > 0 && cbPostalService == 0)
            {
                MessageBox.Show("Action failed! No entry from Postal Services...", "Error");
                tblPostalServices.Focus();
                return false;
            }

            else if (check_TelephoneTelefax > 0 && cbTelephoneTelefax == 0)
            {
                MessageBox.Show("Action failed! No entry from Telephone and Telefax Services...", "Error");
                tblTelephone.Focus();
                return false;
            }

            else if (check_RecreationalItems > 0 && cbRecreationalItems == 0)
            {
                MessageBox.Show("Action failed! No entry from Recreational Items and Equipment...", "Error");
                tblRecreationalItems.Focus();
                return false;
            }

            else if (check_RecreationCulture > 0 && cbRecreationCulture == 0)
            {
                MessageBox.Show("Action failed! No entry from Recreation and Culture...", "Error");
                tblRecreationCulture.Focus();
                return false;
            }

            else if (check_NewspaperBooks > 0 && cbNewspaperBooks == 0)
            {
                MessageBox.Show("Action failed! No entry from Newspaper, Books and Stationary...", "Error");
                tblNewspaper.Focus();
                return false;
            }

            else if (check_Tuition > 0 && cbTuition == 0)
            {
                MessageBox.Show("Action failed! No entry from Tuition Fees...", "Error");
                tblTuition.Focus();
                return false;
            }

            else if (check_Education > 0 && cbEducation == 0)
            {
                MessageBox.Show("Action failed! No entry from Education Non Definable by Level...", "Error");
                tblEducation.Focus();
                return false;
            }

            else if (check_Allowance > 0 && cbAllowance == 0)
            {
                MessageBox.Show("Action failed! No entry from Allowance of Student...", "Error");
                tblAllowance.Focus();
                return false;
            }

            else if (check_EducationalExpense > 0 && cbEducationalExpense == 0)
            {
                MessageBox.Show("Action failed! No entry from Other Educational Expense...", "Error");
                tblOtherEducational.Focus();
                return false;
            }

            else if (check_PersonalCare > 0 && cbPersonalCare == 0)
            {
                MessageBox.Show("Action failed! No entry from Personal Care...", "Error");
                tblPersonalCare.Focus();
                return false;
            }

            else if (check_PersonalEffects > 0 && cbPersonalEffects == 0)
            {
                MessageBox.Show("Action failed! No entry from Personal Effects...", "Error");
                tblPersonalEffects.Focus();
                return false;
            }

            else if (check_Insurance > 0 && cbInsurance == 0)
            {
                MessageBox.Show("Action failed! No entry from Insurance (Life and Non-Life)...", "Error");
                tblInsurance.Focus();
                return false;
            }

            else if (check_BreadsAndCereals > 0 && cbBreadsAndCereals / check_BreadsAndCereals != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Breads and Cereals...", "Error");
                tblBreadCereals.Focus();
                return false;
            }


            else if (check_Meat > 0 && cbMeat / check_Meat != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Meat...", "Error");
                tblMeat.Focus();
                return false;
            }

            else if (check_FishAndSeafood > 0 && cbFishAndSeafood / check_FishAndSeafood != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Fish and Seafoods...", "Error");
                tblFishSeafood.Focus();
                return false;
            }

            else if (check_MilkCheeseEggs > 0 && cbMilkCheeseEggs / check_MilkCheeseEggs != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Milk, Cheese and Eggs...", "Error");
                tblMilkCheese.Focus();
                return false;
            }

            else if (check_OilsAndFats > 0 && cbOilsAndFats / check_OilsAndFats != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Oils and Fats...", "Error");
                tblOilsFats.Focus();
                return false;
            }

            else if (check_Fruits > 0 && cbFruits / check_Fruits != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Fruits...", "Error");
                tblFruits.Focus();
                return false;
            }

            else if (check_Vegetables > 0 && cbVegetables / check_Vegetables != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Vegetables...", "Error");
                tblVegetables.Focus();
                return false;
            }

            else if (check_SugarJamHoney > 0 && cbSugarJamHoney / check_SugarJamHoney != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Sugar, Jam, Honey, Chocolate and Confectionary...", "Error");
                tblSugarJam.Focus();
                return false;
            }

            else if (check_FoodProducts > 0 && cbFoodProducts / check_FoodProducts != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Food Products...", "Error");
                tblFoodProducts.Focus();
                return false;
            }

            else if (check_NonAlcoholic > 0 && cbNonAlcoholic / check_NonAlcoholic != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Non-Alcoholic Beverages...", "Error");
                tblNonAlcoholic.Focus();
                return false;
            }

            else if (check_MineralWater > 0 && cbMineralWater / check_MineralWater != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Mineral water, Softdrinks, Fruit and Vegetable Juice...", "Error");
                tblMineral.Focus();
                return false;
            }

            else if (check_Alcoholic > 0 && cbAlcoholic / check_Alcoholic != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Alcoholic Beverages...", "Error");
                tblAlcoholicBeverages.Focus();
                return false;
            }

            else if (check_Tobacco > 0 && cbTobacco / check_Tobacco != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Tobacco...", "Error");
                tblTobacco.Focus();
                return false;
            }

            else if (check_Clothing > 0 && cbClothing / check_Clothing != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Clothing...", "Error");
                tblClothing.Focus();
                return false;
            }

            else if (check_Footwear > 0 && cbFootwear / check_Footwear != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Footwear...", "Error");
                tblFootwear.Focus();
                return false;
            }

            else if (check_Housing > 0 && cbHousing / check_Housing != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Housing...", "Error");
                tblHousing.Focus();
                return false;
            }

            else if (check_Watersupply > 0 && cbWatersupply / check_Watersupply != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Water Supply and Miscellaneous Services...", "Error");
                tblWaterSupply.Focus();
                return false;
            }

            else if (check_ElectricityGas > 0 && cbElectricityGas / check_ElectricityGas != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Electricity, Gas and Other Fuels...", "Error");
                tblElectricity.Focus();
                return false;
            }

            else if (check_MedicalProducts > 0 && cbMedicalProducts / check_MedicalProducts != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Medical Products...", "Error");
                tblMedicalProducts.Focus();
                return false;
            }

            else if (check_Outpatient > 0 && cbOutpatient / check_Outpatient != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Outpatient Medical Services...", "Error");
                tblOutpatient.Focus();
                return false;
            }

            else if (check_Inpatient > 0 && cbInpatient / check_Inpatient != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Outpatient Hospital Serives (In-Patient)...", "Error");
                tblInpatient.Focus();
                return false;
            }

            else if (check_PersonalTransport > 0 && cbPersonalTransport / check_PersonalTransport != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Personal Transport...", "Error");
                tblPersonalTransport.Focus();
                return false;
            }

            else if (check_TransportServices > 0 && cbTransportServices / check_TransportServices != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Transport Services...", "Error");
                tblTransportServices.Focus();
                return false;
            }

            else if (check_PostalService > 0 && cbPostalService / check_PostalService != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Postal Services...", "Error");
                tblPostalServices.Focus();
                return false;
            }

            else if (check_TelephoneTelefax > 0 && cbTelephoneTelefax / check_TelephoneTelefax != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Telephone and Telefax Services...", "Error");
                tblTelephone.Focus();
                return false;
            }

            else if (check_RecreationalItems > 0 && cbRecreationalItems / check_RecreationalItems != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Recreational Items and Equipment...", "Error");
                tblRecreationalItems.Focus();
                return false;
            }

            else if (check_RecreationCulture > 0 && cbRecreationCulture / check_RecreationCulture != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Recreation and Culturet...", "Error");
                tblRecreationCulture.Focus();
                return false;
            }

            else if (check_NewspaperBooks > 0 && cbNewspaperBooks / check_NewspaperBooks != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Newspaper, Books and Stationary...", "Error");
                tblNewspaper.Focus();
                return false;
            }

            else if (check_Tuition > 0 && cbTuition / check_Tuition != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Tuition Fees...", "Error");
                tblTuition.Focus();
                return false;
            }

            else if (check_Education > 0 && cbEducation / check_Education != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Education Non Definable by Level...", "Error");
                tblEducation.Focus();
                return false;
            }

            else if (check_Allowance > 0 && cbAllowance / check_Allowance != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Allowance of Student...", "Error");
                tblAllowance.Focus();
                return false;
            }

            else if (check_EducationalExpense > 0 && cbEducationalExpense / check_EducationalExpense != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Other Educational Expense...", "Error");
                tblOtherEducational.Focus();
                return false;
            }

            else if (check_PersonalCare > 0 && cbPersonalCare / check_PersonalCare != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Other Personal Care...", "Error");
                tblPersonalCare.Focus();
                return false;
            }

            else if (check_PersonalEffects > 0 && cbPersonalEffects / check_PersonalEffects != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Personal Effects...", "Error");
                tblPersonalEffects.Focus();
                return false;
            }

            else if (check_Insurance > 0 && cbInsurance / check_Insurance != 4)
            {
                MessageBox.Show("Action failed! Incomplete entry for Insurance (Life and Non-Life)...", "Error");
                tblInsurance.Focus();
                return false;
            }      

            else if (chkL_Yes.Checked && count_txtDate == 0)
            {
                MessageBox.Show("Action failed! Number of days has no entry...", "Error");
                tblQuestionnaire_L_1.Focus();
                return false;
            }

            else if (countHealthCrisis != 3)
            {
                MessageBox.Show("Action failed! Health crisis concerns and recommendation has not been completely filled up...", "Error");
                tblHealthCrisis.Focus();
                return false;
            }

            else if (countHealthRecommendation != 3)
            {
                MessageBox.Show("Action failed! Health crisis concerns and recommendation has not been completely filled up...", "Error");
                tblHealthCrisis.Focus();
                return false;
            }

            else if (countEconomicCrisis != 3)
            {
                MessageBox.Show("Action failed! Economic crisis concerns and recommendation has not been completely filled up...", "Error");
                tblEconomicCrisis.Focus();
                return false;
            }

            else if (countEconomicRecommendation != 3)
            {
                MessageBox.Show("Action failed! Economic crisis concerns and recommendation has not been completely filled up...", "Error");
                tblEconomicCrisis.Focus();
                return false;
            }

            else if(GetSurveys.Count(x => x.RespondentCode == txtRespCode.Text) > 0)
            {
                MessageBox.Show("Action failed! Respondet Code No. already exist...", "Error");
                return false;
            }

            else if (FindControls<RadioButton>(this).Count(x => x.AccessibleName == "rbQuestionaireN" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Question letter N has no answer...", "Error");
                tblQuestionnaire_N.Focus();
                return false;
            }

            else if (FindControls<RadioButton>(this).Count(x => x.AccessibleName == "rbQuestionaireO" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Question letter O has no answer...", "Error");
                tblQuestionnaire_O.Focus();
                return false;
            }

            else if (FindControls<RadioButton>(this).Count(x => x.AccessibleName == "rbQuestionaireP" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Question letter P has no answer...", "Error");
                tblQuestionnaire_P.Focus();
                return false;
            }

            else if (FindControls<RadioButton>(this).Count(x => x.AccessibleName == "rbQuestionaireQ" && x.Checked) == 0)
            {
                MessageBox.Show("Action failed! Question letter Q has no answer...", "Error");
                tblQuestionnaire_Q.Focus();
                return false;
            }

            else return true;
        }

        public async Task LoadSalariesWages()
        {
            lvSalariesWages.Items.Clear();
            int num = 1;

            foreach (var item in await salariesWagesList.GetAll())
            {
                ListViewItem lvi = new ListViewItem(num.ToString() + ")");
                lvi.SubItems.Add(item.ListSalariesWages);
                lvSalariesWages.Items.Add(lvi);
                num++;
            }
        }

        public async Task LoadEntreprenuerial()
        {
            lvEntrepreneurial.Items.Clear();
            int num = 1;

            foreach (var item in await entrepreneurialActivitiesList.GetAll())
            {
                ListViewItem lvi = new ListViewItem(num.ToString() + ")");
                lvi.SubItems.Add(item.ListEntrepreneurialActivities);
                lvEntrepreneurial.Items.Add(lvi);
                num++;
            }
        }
        public async Task LoadOtherSources()
        {
            lvOtherSources.Items.Clear();
            int num = 1;

            foreach (var item in await otherSourcesList.GetAll())
            {
                ListViewItem lvi = new ListViewItem(num.ToString() + ")");
                lvi.SubItems.Add(item.ListOtherSources);
                lvOtherSources.Items.Add(lvi);
                num++;
            }
        }

        private async void Button_ReloadReason(object sender, EventArgs e)
        {
            if (sender == btnReload_Kalinayan)
            {
                cbReason_Kalinayan.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Kalinayan.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Commercial)
            {
                cbReason_Commercial.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Commercial.Items.Add(item.ListReason);
            }

            if (sender == btnReload_NFA)
            {
                cbReason_NFA.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_NFA.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Corn)
            {
                cbReason_Corn.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Corn.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Flour)
            {
                cbReason_Flour.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Flour.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Cereals)
            {
                cbReason_Cereals.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Cereals.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Pandesal)
            {
                cbReason_Pandesal.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Pandesal.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Pasta)
            {
                cbReason_Pasta.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Pasta.Items.Add(item.ListReason);
            }

            if (sender == btnReload__Pork)
            {
                cbReason_Pork.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Pork.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Beef)
            {
                cbReason_Beef.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Beef.Items.Add(item.ListReason);
            }

            if (sender == btnReload_CaraBeef)
            {
                cbReason_CaraBeef.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_CaraBeef.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Chicken)
            {
                cbReason_Chicken.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Chicken.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Goat)
            {
                cbReason_Goat.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Goat.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Atay)
            {
                cbReason_Atay.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Atay.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Meatbased)
            {
                cbReason_Meatbased.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Meatbased.Items.Add(item.ListReason);
            }

            if (sender == btnReload_FrozenFish)
            {
                cbReason_FrozenFish.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_FrozenFish.Items.Add(item.ListReason);
            }

            if (sender == btnReload_DriedFish)
            {
                cbReason_DriedFish.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_DriedFish.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Shrimp)
            {
                cbReason_Shrimp.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Shrimp.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Shells)
            {
                cbReason_Shells.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Shells.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Sardines)
            {
                cbReason_Sardines.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Sardines.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Raw)
            {
                cbReason_Raw.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Raw.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Yogurt)
            {
                cbReason_Yogurt.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Yogurt.Items.Add(item.ListReason);
            }

            if (sender == btnReload_SoyaMilk)
            {
                cbReason_SoyaMilk.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_SoyaMilk.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Cheese)
            {
                cbReason_Cheese.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Cheese.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Kisiyo)
            {
                cbReason_Kisiyo.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Kisiyo.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Eggs)
            {
                cbReason_Eggs.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Eggs.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Taho)
            {
                cbReason_Taho.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Taho.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Butter)
            {
                cbReason_Butter.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Butter.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Margarine)
            {
                cbReason_Margarine.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Margarine.Items.Add(item.ListReason);
            }

            if (sender == btnReload_EdibleOil)
            {
                cbReason_EdibleOil.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_EdibleOil.Items.Add(item.ListReason);
            }

            if (sender == btnReload_EdibleFat)
            {
                cbReason_EdibleFat.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_EdibleFat.Items.Add(item.ListReason);
            }

            if (sender == btnReload_FreshFruits)
            {
                cbReason_FreshFruits.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_FreshFruits.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Stalks)
            {
                cbReason_Stalks.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Stalks.Items.Add(item.ListReason);
            }

            if (sender == btnReload_VegeFruits)
            {
                cbReason_VegeFruits.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_VegeFruits.Items.Add(item.ListReason);
            }

            if (sender == btnReload_VegeRoots)
            {
                cbReason_VegeRoots.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_VegeRoots.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Potatoes)
            {
                cbReason_Potatoes.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Potatoes.Items.Add(item.ListReason);
            }

            if (sender == btnReload_VegeProcessed)
            {
                cbReason_VegeProcessed.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_VegeProcessed.Items.Add(item.ListReason);
            }

            if (sender == btnReload_VegeTuber)
            {
                cbReason_VegeTuber.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_VegeTuber.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Sugar)
            {
                cbReason_Sugar.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Sugar.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Jam)
            {
                cbReason_Jam.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Jam.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Honey)
            {
                cbReason_Honey.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Honey.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Chocolates)
            {
                cbReason_Chocolates.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Chocolates.Items.Add(item.ListReason);
            }

            if (sender == btnReload_IceCream)
            {
                cbReason_IceCream.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_IceCream.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Salt)
            {
                cbReason_Salt.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Salt.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Spices)
            {
                cbReason_Spices.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Spices.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Sauces)
            {
                cbReason_Sauces.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Sauces.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Vinegar)
            {
                cbReason_Vinegar.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Vinegar.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Dessert)
            {
                cbReason_Dessert.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Dessert.Items.Add(item.ListReason);
            }

            if (sender == btnReload_BabyFood)
            {
                cbReason_BabyFood.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_BabyFood.Items.Add(item.ListReason);
            }

            if (sender == btnReload_CoffeeMate)
            {
                cbReason_CoffeeMate.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_CoffeeMate.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Coffee)
            {
                cbReason_Coffee.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Coffee.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Tea)
            {
                cbReason_Tea.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Tea.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Cocoa)
            {
                cbReason_Cocoa.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Cocoa.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Soya)
            {
                cbReason_Soya.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Soya.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Mineral)
            {
                cbReason_Mineral.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Mineral.Items.Add(item.ListReason);
            }

            if (sender == btnReload_SoftDrinks)
            {
                cbReason_SoftDrinks.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_SoftDrinks.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Juices)
            {
                cbReason_Juices.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Juices.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Liqour)
            {
                cbReason_Liqour.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Liqour.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Wines)
            {
                cbReason_Wines.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Wines.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Beer)
            {
                cbReason_Beer.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Beer.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Tuba)
            {
                cbReason_Tuba.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Tuba.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Cigarettes)
            {
                cbReason_Cigarettes.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Cigarettes.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Cigars)
            {
                cbReason_Cigars.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Cigars.Items.Add(item.ListReason);
            }

            if (sender == btnReload_ChewingTobacco)
            {
                cbReason_ChewingTobacco.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_ChewingTobacco.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Mama)
            {
                cbReason_Mama.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Mama.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Materials)
            {
                cbReason_Materials.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Materials.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Garments)
            {
                cbReason_Garments.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Garments.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Accessories)
            {
                cbReason_Accessories.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Accessories.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Repair)
            {
                cbReason_Repair.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Repair.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Shoes)
            {
                cbReason_Shoes.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Shoes.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Cleaning)
            {
                cbReason_Cleaning.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Cleaning.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Actual)
            {
                cbReason_Actual.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Actual.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Imputed)
            {
                cbReason_Imputed.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Imputed.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Maintenance)
            {
                cbReason_Maintenance.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Maintenance.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Water)
            {
                cbReason_Water.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Water.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Services)
            {
                cbReason_Services.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Services.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Electricity)
            {
                cbReason_Electricity.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Electricity.Items.Add(item.ListReason);
            }

            if (sender == btnReload_LPG)
            {
                cbReason_LPG.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_LPG.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Kerosene)
            {
                cbReason_Kerosene.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Kerosene.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Fuelwood)
            {
                cbReason_Fuelwood.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Fuelwood.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Charcoal)
            {
                cbReason_Charcoal.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Charcoal.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Biomass)
            {
                cbReason_Biomass.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Biomass.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Pharma)
            {
                cbReason_Pharma.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Pharma.Items.Add(item.ListReason);
            }

            if (sender == btnReload_OtherMedical)
            {
                cbReason_OtherMedical.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_OtherMedical.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Therap)
            {
                cbReason_Therap.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Therap.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Medical)
            {
                cbReason_Medical.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Medical.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Dental)
            {
                cbReason_Dental.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Dental.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Param)
            {
                cbReason_Param.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Param.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Public)
            {
                cbReason_Public.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Public.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Private)
            {
                cbReason_Private.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Private.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Spare)
            {
                cbReason_Spare.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Spare.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Fuel)
            {
                cbReason_Fuel.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Fuel.Items.Add(item.ListReason);
            }

            if (sender == btnReload_TransRepair)
            {
                cbReason_TransRepair.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_TransRepair.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Railway)
            {
                cbReason_Railway.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Railway.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Road)
            {
                cbReason_Road.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Road.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Air)
            {
                cbReason_Air.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Air.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Sea)
            {
                cbReason_Sea.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Sea.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Combined)
            {
                cbReason_Combined.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Combined.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Postal)
            {
                cbReason_Postal.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Postal.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Landline)
            {
                cbReason_Landline.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Landline.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Internet)
            {
                cbReason_Internet.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Internet.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Postpaid)
            {
                cbReason_Postpaid.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Postpaid.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Prepaid)
            {
                cbReason_Prepaid.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Prepaid.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Games)
            {
                cbReason_Games.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Games.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Garden)
            {
                cbReason_Garden.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Garden.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Pet)
            {
                cbReason_Pet.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Pet.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Sports)
            {
                cbReason_Sports.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Sports.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Cable)
            {
                cbReason_Cable.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Cable.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Lotto)
            {
                cbReason_Lotto.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Lotto.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Books)
            {
                cbReason_Books.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Books.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Newspaper)
            {
                cbReason_Newspaper.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Newspaper.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Stationary)
            {
                cbReason_Stationary.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Stationary.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Pre)
            {
                cbReason_Pre.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Pre.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Primary)
            {
                cbReason_Primary.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Primary.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Secondary)
            {
                cbReason_Secondary.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Secondary.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Post)
            {
                cbReason_Post.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Post.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Tertiary)
            {
                cbReason_Tertiary.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Tertiary.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Review)
            {
                cbReason_Review.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Review.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Training)
            {
                cbReason_Training.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Training.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Uniform)
            {
                cbReason_Uniform.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Uniform.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Rental)
            {
                cbReason_Rental.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Rental.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Salon)
            {
                cbReason_Salon.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Salon.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Appliances)
            {
                cbReason_Appliances.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Appliances.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Beauty)
            {
                cbReason_Beauty.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Beauty.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Jewelry)
            {
                cbReason_Jewelry.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Jewelry.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Handbags)
            {
                cbReason_Handbags.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Handbags.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Life)
            {
                cbReason_Life.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Life.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Housing)
            {
                cbReason_Housing.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Housing.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Health)
            {
                cbReason_Health.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Health.Items.Add(item.ListReason);
            }

            if (sender == btnReload_Allowance)
            {
                cbReason_Allowance.Items.Clear();
                foreach (var item in await reasonList.GetAll())
                    cbReason_Allowance.Items.Add(item.ListReason);
            }
        }

        private void Button_AddReason(object sender, EventArgs e)
        {
            frmAddReason obj = new frmAddReason();
            obj.ShowDialog();
        }
        private void Button_AddHealthRecommendation(object sender, EventArgs e)
        {
            frmAddHealthRecommendation obj = new frmAddHealthRecommendation();
            obj.ShowDialog();
        }
        private void Button_AddEconomicRecommendation(object sender, EventArgs e)
        {
            frmAddEconomicRecommendation obj = new frmAddEconomicRecommendation();
            obj.ShowDialog();
        }
        private async void Button_ReloadRecommendation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string x = b.Name;
            //if (sender == btnReload_HealthRecommendationOne)
            //{
            //    cbRecommendation_HealthOne.Items.Clear();
            //    foreach (var item in await healthRecommendationList.GetAll())
            //        cbRecommendation_HealthOne.Items.Add(item.ListHealthRecommendation);
            //}

            //if (sender == btnReload_HealthRecommendationTwo)
            //{
            //    cbRecommendation_HealthTwo.Items.Clear();
            //    foreach (var item in await healthRecommendationList.GetAll())
            //        cbRecommendation_HealthTwo.Items.Add(item.ListHealthRecommendation);
            //}

            //if (sender == btnReload_HealthRecommendationThree)
            //{
            //    cbRecommendation_HealthThree.Items.Clear();
            //    foreach (var item in await healthRecommendationList.GetAll())
            //        cbRecommendation_HealthThree.Items.Add(item.ListHealthRecommendation);
            //}

            //if (sender == btnReload_EconomicRecommendationOne)
            //{
            //    cbRecommendation_EconomicOne.Items.Clear();
            //    foreach (var item in await economicRecommendationList.GetAll())
            //        cbRecommendation_EconomicOne.Items.Add(item.ListEconomicRecommendation);
            //}

            //if (sender == btnReload_EconomicRecommendationTwo)
            //{
            //    cbRecommendation_EconomicTwo.Items.Clear();
            //    foreach (var item in GetEconomicRecommendationLists)
            //        cbRecommendation_EconomicTwo.Items.Add(item.ListEconomicRecommendation);
            //}

            //if (sender == btnReload_EconomicRecommendationThree)
            //{
            //    cbRecommendation_EconomicThree.Items.Clear();
            //    foreach (var item in await economicRecommendationList.GetAll())
            //        cbRecommendation_EconomicThree.Items.Add(item.ListEconomicRecommendation);
            //}
            switch (x)
            {
                case "btnReload_HealthRecommendationOne":
                    cbRecommendation_HealthOne.Items.Clear();
                    foreach (var item in await healthRecommendationList.GetAll())
                        cbRecommendation_HealthOne.Items.Add(item.ListHealthRecommendation);
                    break;

                case "btnReload_HealthRecommendationTwo":
                    cbRecommendation_HealthTwo.Items.Clear();
                    foreach (var item in await healthRecommendationList.GetAll())
                        cbRecommendation_HealthTwo.Items.Add(item.ListHealthRecommendation);
                    break;

                case "btnReload_HealthRecommendationThree":
                    cbRecommendation_HealthThree.Items.Clear();
                    foreach (var item in await healthRecommendationList.GetAll())
                        cbRecommendation_HealthThree.Items.Add(item.ListHealthRecommendation);
                    break;

                case "btnReload_EconomicRecommendationOne":
                    cbRecommendation_EconomicOne.Items.Clear();
                    foreach (var item in await economicRecommendationList.GetAll())
                        cbRecommendation_EconomicOne.Items.Add(item.ListEconomicRecommendation);
                    break;

                case "btnReload_EconomicRecommendationTwo":
                    cbRecommendation_EconomicTwo.Items.Clear();
                    foreach (var item in GetEconomicRecommendationLists)
                        cbRecommendation_EconomicTwo.Items.Add(item.ListEconomicRecommendation);
                    break;

                case "btnReload_EconomicRecommendationThree":
                    cbRecommendation_EconomicThree.Items.Clear();
                    foreach (var item in await economicRecommendationList.GetAll())
                        cbRecommendation_EconomicThree.Items.Add(item.ListEconomicRecommendation);
                    break;

                default:
                    break;

            }
        }
        public async void LoadHealthCrisis()
        {
            cbConcerns_HealthOne.SelectedItem = null;
            cbConcerns_HealthTwo.SelectedItem = null;
            cbConcerns_HealthThree.SelectedItem = null;
            cbConcerns_HealthOne.Items.Clear();
            cbConcerns_HealthTwo.Items.Clear();
            cbConcerns_HealthThree.Items.Clear();
            foreach (var item in await healthCrisisList.GetAll())
            {
                cbConcerns_HealthOne.Items.Add(item.ListHealthCrisis);
                cbConcerns_HealthTwo.Items.Add(item.ListHealthCrisis);
                cbConcerns_HealthThree.Items.Add(item.ListHealthCrisis);
            }
        }
        public async void LoadEconomicCrisis()
        {
            cbConcerns_EconomicOne.SelectedItem = null;
            cbConcerns_EconomicTwo.SelectedItem = null;
            cbConcerns_EconomicThree.SelectedItem = null;
            cbConcerns_EconomicOne.Items.Clear();
            cbConcerns_EconomicTwo.Items.Clear();
            cbConcerns_EconomicThree.Items.Clear();
            foreach (var item in await economicCrisisList.GetAll())
            {
                cbConcerns_EconomicOne.Items.Add(item.ListEconomicCrisis);
                cbConcerns_EconomicTwo.Items.Add(item.ListEconomicCrisis);
                cbConcerns_EconomicThree.Items.Add(item.ListEconomicCrisis);
            }
        }
        private void TextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private async void btnSubmitSurvey_Click(object sender, EventArgs e)
        {

            if (IsValidEntry())
            {
                btnSubmitSurvey.Enabled = false;
                Respondent respondent = new Respondent();
                respondent.Fullname = txtName.Text.Trim();
                respondent.Gender = cbSex.Text;
                respondent.CivilStatus = cbCivilStatus.Text;
                respondent.AgeBracket = cbAgeBracket.Text;
                respondent.Education = cbEducationalAttainment.Text;
                respondent.NumberHouseholdMembers = int.Parse(txtNumHouseholdmem.Text);
                respondent.brgyID = GetBarangays.Where(x => x.Municipality.MunicipalityName == cbMunicipality.Text && x.BarangayName == cbBarangay.Text).Select(x => x.ID).SingleOrDefault();

                if (chkSalaries.Checked)
                    respondent.SalariesWages = true;
                if (chkEntrepreneurial.Checked)
                    respondent.EntrepreneurialActivities = true;
                if (chkOtherSources.Checked)
                    respondent.Otherources = true;

                respondent.MainSource = FindControls<RadioButton>(this).Where(x => x.AccessibleName == "ControlsMainSource" && x.Checked).Select(x => x.AccessibleDescription).SingleOrDefault();
                respondent.IncomeBefore = FindControls<RadioButton>(this).Where(x => x.AccessibleName == "rbQuestionaireG" && x.Checked).Select(x => x.Text).SingleOrDefault();
                respondent.IncomeChanges = FindControls<RadioButton>(this).Where(x => x.AccessibleName == "rbQuestionaireH" && x.Checked).Select(x => x.Text).SingleOrDefault();
                respondent.IncomeNow = FindControls<RadioButton>(this).Where(x => x.AccessibleName == "rbQuestionaireI" && x.Checked).Select(x => x.Text).SingleOrDefault();

                if (chkL_Yes.Checked)
                    respondent.HungerExperience = "Yes";

                if (txtJanuary.Text != string.Empty)
                    respondent.January = int.Parse(txtJanuary.Text);

                if (txtFebruary.Text != string.Empty)
                    respondent.February = int.Parse(txtFebruary.Text);

                if (txtMarch.Text != string.Empty)
                    respondent.March = int.Parse(txtMarch.Text);

                if (txtApril.Text != string.Empty)
                    respondent.April = int.Parse(txtApril.Text);

                if (txtMay.Text != string.Empty)
                    respondent.May = int.Parse(txtMay.Text);

                if (txtJune.Text != string.Empty)
                    respondent.June = int.Parse(txtJune.Text);

                if (txtJuly.Text != string.Empty)
                    respondent.July = int.Parse(txtJuly.Text);

                if (txtAugust.Text != string.Empty)
                    respondent.August = int.Parse(txtAugust.Text);

                respondent.RegularMonthlySavings = FindControls<RadioButton>(this).Where(x => x.AccessibleName == "rbQuestionaireN" && x.Checked).Select(x => x.Text).SingleOrDefault();
                respondent.RealizeMonthlySavings = FindControls<RadioButton>(this).Where(x => x.AccessibleName == "rbQuestionaireO" && x.Checked).Select(x => x.Text).SingleOrDefault();
                respondent.AffectedSavings = FindControls<RadioButton>(this).Where(x => x.AccessibleName == "rbQuestionaireP" && x.Checked).Select(x => x.Text).SingleOrDefault();
                respondent.EconomicSituation = FindControls<RadioButton>(this).Where(x => x.AccessibleName == "rbQuestionaireQ" && x.Checked).Select(x => x.Text).SingleOrDefault();

                await Respondent.Create(respondent);

                // ================================================================= Salaries Wages ===================================================================

                RespondentSalariesWages salariesWages = new RespondentSalariesWages();
                for (int i = 0; i < lvSalariesWages.CheckedItems.Count; i++)
                {
                    salariesWages.RespSalaryWage = lvSalariesWages.CheckedItems[i].SubItems[1].Text;
                    salariesWages.RespondentID = respondent.ID;

                    await respondentSalariesWages.Create(salariesWages);
                }

                // ================================================================= Entrepreneurial Activities ===================================================================

                RespondentEntrepreneurialActivities entrepreneurialActivities = new RespondentEntrepreneurialActivities();
                for (int i = 0; i < lvEntrepreneurial.CheckedItems.Count; i++)
                {
                    entrepreneurialActivities.RespEntrepreneurialActivity = lvEntrepreneurial.CheckedItems[i].SubItems[1].Text;
                    entrepreneurialActivities.RespondentID = respondent.ID;

                    await respondentEntrepreneurialActivities.Create(entrepreneurialActivities);
                }

                // ================================================================= Other Sources ===================================================================

                RespondentOtherSources otherSources = new RespondentOtherSources();
                for (int i = 0; i < lvOtherSources.CheckedItems.Count; i++)
                {
                    otherSources.RespOtherSources = lvOtherSources.CheckedItems[i].SubItems[1].Text;
                    otherSources.RespondentID = respondent.ID;

                    await respondentOtherSources.Create(otherSources);
                }

                // ================================================================= Respondent Goods ===================================================================

                RespondentGoods goods = new RespondentGoods();
                foreach (var item in FindControls<CheckBox>(this).Where(x => x.AccessibleName == "CheckBoxesGoods" && x.Checked).ToList())
                {
                    goods.RespGoods = item.Text;
                    goods.RespondentID = respondent.ID;

                    await respondentGoods.Create(goods);
                }

                // ================================================================= Respondent Services ===================================================================

                RespondentServices services = new RespondentServices();
                foreach (var item in FindControls<CheckBox>(this).Where(x => x.AccessibleName == "CheckBoxesServices" && x.Checked).ToList())
                {
                    services.RespServices = item.Text;
                    services.RespondentID = respondent.ID;

                    await respondentServices.Create(services);
                }

                // ================================================================= Breads And Cereals ===================================================================

                var BreadsAndCereals = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "BreadsAndCereals" && x.Checked).ToList();
                var frequencyBreadsAndCereals = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyBreadsAndCereals" && x.SelectedItem != null).ToList();
                var whereBreadsAndCereals = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereBreadsAndCereals" && x.SelectedItem != null).ToList();
                var changeBreadsAndCereals = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeBreadsAndCereals" && x.SelectedItem != null).ToList();
                var reasonBreadsAndCereals = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonBreadsAndCereals" && x.SelectedItem != null).ToList();

                BreadsAndCereals breads = new BreadsAndCereals();
                for (int i = 0; i < BreadsAndCereals.Count(); i++)
                {
                    breads.Item = BreadsAndCereals[i].Text;
                    breads.Frequency = frequencyBreadsAndCereals[i].Text;
                    breads.Where = whereBreadsAndCereals[i].Text;
                    breads.Change = changeBreadsAndCereals[i].Text;
                    breads.Reason = reasonBreadsAndCereals[i].Text;
                    breads.RespondentID = respondent.ID;

                    await breadsAndCereals.Create(breads);
                }

                // ================================================================= Meat ===================================================================
                Meat meat = new Meat();
                var Meat = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Meat" && x.Checked).ToList();
                var frequencyMeat = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyMeat" && x.SelectedItem != null).ToList();
                var whereMeat = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereMeat" && x.SelectedItem != null).ToList();
                var changeMeat = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeMeat" && x.SelectedItem != null).ToList();
                var reasonMeat = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonMeat" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Meat.Count(); i++)
                {
                    meat.Item = Meat[i].Text;
                    meat.Frequency = frequencyMeat[i].Text;
                    meat.Where = whereMeat[i].Text;
                    meat.Change = changeMeat[i].Text;
                    meat.Reason = reasonMeat[i].Text;
                    meat.RespondentID = respondent.ID;

                    await Meats.Create(meat);
                }

                // ================================================================= Fish And Seafood ===================================================================

                FishAndSeafood fish = new FishAndSeafood();
                var FishAndSeafood = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "FishAndSeafood" && x.Checked).ToList();
                var frequencyFishAndSeafood = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyFishAndSeafood" && x.SelectedItem != null).ToList();
                var whereFishAndSeafood = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereFishAndSeafood" && x.SelectedItem != null).ToList();
                var changeFishAndSeafood = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeFishAndSeafood" && x.SelectedItem != null).ToList();
                var reasonFishAndSeafood = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonFishAndSeafood" && x.SelectedItem != null).ToList();

                for (int i = 0; i < FishAndSeafood.Count(); i++)
                {
                    fish.Item = FishAndSeafood[i].Text;
                    fish.Frequency = frequencyFishAndSeafood[i].Text;
                    fish.Where = whereFishAndSeafood[i].Text;
                    fish.Change = changeFishAndSeafood[i].Text;
                    fish.Reason = reasonFishAndSeafood[i].Text;
                    fish.RespondentID = respondent.ID;

                    await fishAndSeafood.Create(fish);
                }

                // ================================================================= Milk Cheese Eggs ===================================================================

                MilkCheeseEggs milk = new MilkCheeseEggs();
                var MilkCheeseEggs = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "MilkCheeseEggs" && x.Checked).ToList();
                var frequencyMilkCheeseEggs = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyMilkCheeseEggs" && x.SelectedItem != null).ToList();
                var whereMilkCheeseEggs = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereMilkCheeseEggs" && x.SelectedItem != null).ToList();
                var changeMilkCheeseEggs = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeMilkCheeseEggs" && x.SelectedItem != null).ToList();
                var reasonMilkCheeseEggs = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonMilkCheeseEggs" && x.SelectedItem != null).ToList();

                for (int i = 0; i < MilkCheeseEggs.Count(); i++)
                {
                    milk.Item = MilkCheeseEggs[i].Text;
                    milk.Frequency = frequencyMilkCheeseEggs[i].Text;
                    milk.Where = whereMilkCheeseEggs[i].Text;
                    milk.Change = changeMilkCheeseEggs[i].Text;
                    milk.Reason = reasonMilkCheeseEggs[i].Text;
                    milk.RespondentID = respondent.ID;

                    await milkCheeseEggs.Create(milk);
                }

                // ================================================================= Oils And Fats ===================================================================

                OilsAndFats oils = new OilsAndFats();
                var OilsAndFats = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "OilsAndFats" && x.Checked).ToList();
                var frequencyOilsAndFats = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyOilsAndFats" && x.SelectedItem != null).ToList();
                var whereOilsAndFats = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereOilsAndFats" && x.SelectedItem != null).ToList();
                var changeOilsAndFats = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeOilsAndFats" && x.SelectedItem != null).ToList();
                var reasonOilsAndFats = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonOilsAndFats" && x.SelectedItem != null).ToList();

                for (int i = 0; i < OilsAndFats.Count(); i++)
                {
                    oils.Item = OilsAndFats[i].Text;
                    oils.Frequency = frequencyOilsAndFats[i].Text;
                    oils.Where = whereOilsAndFats[i].Text;
                    oils.Change = changeOilsAndFats[i].Text;
                    oils.Reason = reasonOilsAndFats[i].Text;
                    oils.RespondentID = respondent.ID;

                    await oilsAndFats.Create(oils);
                }

                // ================================================================= Fruits ===================================================================

                Fruit fruit = new Fruit();
                var Fruits = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Fruits" && x.Checked).ToList();
                var frequencyFruits = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyFruits" && x.SelectedItem != null).ToList();
                var whereFruits = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereFruits" && x.SelectedItem != null).ToList();
                var changeFruits = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeFruits" && x.SelectedItem != null).ToList();
                var reasonFruits = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonFruits" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Fruits.Count(); i++)
                {
                    fruit.Item = Fruits[i].Text;
                    fruit.Frequency = frequencyFruits[i].Text;
                    fruit.Where = whereFruits[i].Text;
                    fruit.Change = changeFruits[i].Text;
                    fruit.Reason = reasonFruits[i].Text;
                    fruit.RespondentID = respondent.ID;

                    await Fruit.Create(fruit);
                }

                // ================================================================= Vegetable ===================================================================

                Vegetable vegetable = new Vegetable();
                var Vegetables = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Vegetables" && x.Checked).ToList();
                var frequencyVegetables = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyVegetables" && x.SelectedItem != null).ToList();
                var whereVegetables = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereVegetables" && x.SelectedItem != null).ToList();
                var changeVegetables = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeVegetables" && x.SelectedItem != null).ToList();
                var reasonVegetables = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonVegetables" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Vegetables.Count(); i++)
                {
                    vegetable.Item = Vegetables[i].Text;
                    vegetable.Frequency = frequencyVegetables[i].Text;
                    vegetable.Where = whereVegetables[i].Text;
                    vegetable.Change = changeVegetables[i].Text;
                    vegetable.Reason = reasonVegetables[i].Text;
                    vegetable.RespondentID = respondent.ID;

                    await Vegetable.Create(vegetable);
                }

                // ================================================================= Sugar JamHoney Chocolate Confectionary ===================================================================

                SugarJamHoneyChocolateConfectionary sugar = new SugarJamHoneyChocolateConfectionary();
                var SugarJamHoney = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "SugarJamHoney" && x.Checked).ToList();
                var frequencySugarJamHoney = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencySugarJamHoney" && x.SelectedItem != null).ToList();
                var whereSugarJamHoney = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereSugarJamHoney" && x.SelectedItem != null).ToList();
                var changeSugarJamHoney = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeSugarJamHoney" && x.SelectedItem != null).ToList();
                var reasonSugarJamHoney = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonSugarJamHoney" && x.SelectedItem != null).ToList();

                for (int i = 0; i < SugarJamHoney.Count(); i++)
                {
                    sugar.Item = SugarJamHoney[i].Text;
                    sugar.Frequency = frequencySugarJamHoney[i].Text;
                    sugar.Where = whereSugarJamHoney[i].Text;
                    sugar.Change = changeSugarJamHoney[i].Text;
                    sugar.Reason = reasonSugarJamHoney[i].Text;
                    sugar.RespondentID = respondent.ID;

                    await sugarJamHoney.Create(sugar);
                }

                // ================================================================= Food Product ===================================================================

                FoodProduct food = new FoodProduct();
                var FoodProducts = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "FoodProducts" && x.Checked).ToList();
                var frequencyFoodProducts = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyFoodProducts" && x.SelectedItem != null).ToList();
                var whereFoodProducts = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereFoodProducts" && x.SelectedItem != null).ToList();
                var changeFoodProducts = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeFoodProducts" && x.SelectedItem != null).ToList();
                var reasonFoodProducts = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonFoodProducts" && x.SelectedItem != null).ToList();

                for (int i = 0; i < FoodProducts.Count(); i++)
                {
                    food.Item = FoodProducts[i].Text;
                    food.Frequency = frequencyFoodProducts[i].Text;
                    food.Where = whereFoodProducts[i].Text;
                    food.Change = changeFoodProducts[i].Text;
                    food.Reason = reasonFoodProducts[i].Text;
                    food.RespondentID = respondent.ID;

                    await foodProduct.Create(food);
                }

                // ================================================================= Non Alcoholic Beverages ===================================================================

                NonAlcoholicBeverages beverages = new NonAlcoholicBeverages();
                var NonAlcoholicBeverages = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "NonAlcoholicBeverages" && x.Checked).ToList();
                var frequencyNonAlcoholicBeverages = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyNonAlcoholicBeverages" && x.SelectedItem != null).ToList();
                var whereNonAlcoholicBeverages = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereNonAlcoholicBeverages" && x.SelectedItem != null).ToList();
                var changeNonAlcoholicBeverages = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeNonAlcoholicBeverages" && x.SelectedItem != null).ToList();
                var reasonNonAlcoholicBeverages = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonNonAlcoholicBeverages" && x.SelectedItem != null).ToList();

                for (int i = 0; i < NonAlcoholicBeverages.Count(); i++)
                {
                    beverages.Item = NonAlcoholicBeverages[i].Text;
                    beverages.Frequency = frequencyNonAlcoholicBeverages[i].Text;
                    beverages.Where = whereNonAlcoholicBeverages[i].Text;
                    beverages.Change = changeNonAlcoholicBeverages[i].Text;
                    beverages.Reason = reasonNonAlcoholicBeverages[i].Text;
                    beverages.RespondentID = respondent.ID;

                    await nonAlcoholicBeverages.Create(beverages);
                }

                // ================================================================= Non Alcoholic Beverages ===================================================================

                MineralwaterSoftdrinkJuice mineralwater = new MineralwaterSoftdrinkJuice();
                var MineralwaterSoftdrinks = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "MineralwaterSoftdrinks" && x.Checked).ToList();
                var frequencyMineralwaterSoftdrinks = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyMineralwaterSoftdrinks" && x.SelectedItem != null).ToList();
                var whereMineralwaterSoftdrinks = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereMineralwaterSoftdrinks" && x.SelectedItem != null).ToList();
                var changeMineralwaterSoftdrinks = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeMineralwaterSoftdrinks" && x.SelectedItem != null).ToList();
                var reasonMineralwaterSoftdrinks = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonMineralwaterSoftdrinks" && x.SelectedItem != null).ToList();

                for (int i = 0; i < MineralwaterSoftdrinks.Count(); i++)
                {
                    mineralwater.Item = MineralwaterSoftdrinks[i].Text;
                    mineralwater.Frequency = frequencyMineralwaterSoftdrinks[i].Text;
                    mineralwater.Where = whereMineralwaterSoftdrinks[i].Text;
                    mineralwater.Change = changeMineralwaterSoftdrinks[i].Text;
                    mineralwater.Reason = reasonMineralwaterSoftdrinks[i].Text;
                    mineralwater.RespondentID = respondent.ID;

                    await mineralWaterSoftdrinks.Create(mineralwater);
                }

                // ================================================================= Alcoholic Beverages ===================================================================

                AlcoholicBeverages alcoholic = new AlcoholicBeverages();
                var AlcoholicBeverages = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "AlcoholicBeverages" && x.Checked).ToList();
                var frequencyAlcoholicBeverages = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyAlcoholicBeverages" && x.SelectedItem != null).ToList();
                var whereAlcoholicBeverages = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereAlcoholicBeverages" && x.SelectedItem != null).ToList();
                var changeAlcoholicBeverages = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeAlcoholicBeverages" && x.SelectedItem != null).ToList();
                var reasonAlcoholicBeverages = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonAlcoholicBeverages" && x.SelectedItem != null).ToList();

                for (int i = 0; i < AlcoholicBeverages.Count(); i++)
                {
                    alcoholic.Item = AlcoholicBeverages[i].Text;
                    alcoholic.Frequency = frequencyAlcoholicBeverages[i].Text;
                    alcoholic.Where = whereAlcoholicBeverages[i].Text;
                    alcoholic.Change = changeAlcoholicBeverages[i].Text;
                    alcoholic.Reason = reasonAlcoholicBeverages[i].Text;
                    alcoholic.RespondentID = respondent.ID;

                    await alcoholicBeverages.Create(alcoholic);
                }

                // ================================================================= Tobacco ===================================================================

                Tobacco tobacco = new Tobacco();
                var Tobacco = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Tobacco" && x.Checked).ToList();
                var frequencyTobacco = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyTobacco" && x.SelectedItem != null).ToList();
                var whereTobacco = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereTobacco" && x.SelectedItem != null).ToList();
                var changeTobacco = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeTobacco" && x.SelectedItem != null).ToList();
                var reasonTobacco = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonTobacco" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Tobacco.Count(); i++)
                {
                    tobacco.Item = Tobacco[i].Text;
                    tobacco.Frequency = frequencyTobacco[i].Text;
                    tobacco.Where = whereTobacco[i].Text;
                    tobacco.Change = changeTobacco[i].Text;
                    tobacco.Reason = reasonTobacco[i].Text;
                    tobacco.RespondentID = respondent.ID;

                    await Tobaccos.Create(tobacco);
                }

                // ================================================================= Clothing ===================================================================

                Clothing clothing = new Clothing();
                var Clothing = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Clothing" && x.Checked).ToList();
                var frequencyClothing = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyClothing" && x.SelectedItem != null).ToList();
                var whereClothing = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereClothing" && x.SelectedItem != null).ToList();
                var changeClothing = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeClothing" && x.SelectedItem != null).ToList();
                var reasonClothing = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonClothing" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Clothing.Count(); i++)
                {
                    clothing.Item = Clothing[i].Text;
                    clothing.Frequency = frequencyClothing[i].Text;
                    clothing.Where = whereClothing[i].Text;
                    clothing.Change = changeClothing[i].Text;
                    clothing.Reason = reasonClothing[i].Text;
                    clothing.RespondentID = respondent.ID;

                    await Clothings.Create(clothing);
                }

                // ================================================================= Footwear ===================================================================

                Footwear footwear = new Footwear();
                var Footwear = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Footwear" && x.Checked).ToList();
                var frequencyFootwear = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyFootwear" && x.SelectedItem != null).ToList();
                var whereFootwear = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereFootwear" && x.SelectedItem != null).ToList();
                var changeFootwear = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeFootwear" && x.SelectedItem != null).ToList();
                var reasonFootwear = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonFootwear" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Footwear.Count(); i++)
                {
                    footwear.Item = Footwear[i].Text;
                    footwear.Frequency = frequencyFootwear[i].Text;
                    footwear.Where = whereFootwear[i].Text;
                    footwear.Change = changeFootwear[i].Text;
                    footwear.Reason = reasonFootwear[i].Text;
                    footwear.RespondentID = respondent.ID;

                    await Footwears.Create(footwear);
                }

                // ================================================================= Housing ===================================================================

                Housing housing = new Housing();
                var Housing = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Housing" && x.Checked).ToList();
                var frequencyHousing = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyHousing" && x.SelectedItem != null).ToList();
                var whereHousing = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereHousing" && x.SelectedItem != null).ToList();
                var changeHousing = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeHousing" && x.SelectedItem != null).ToList();
                var reasonHousing = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonHousing" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Housing.Count(); i++)
                {
                    housing.Item = Housing[i].Text;
                    housing.Frequency = frequencyHousing[i].Text;
                    housing.Where = whereHousing[i].Text;
                    housing.Change = changeHousing[i].Text;
                    housing.Reason = reasonHousing[i].Text;
                    housing.RespondentID = respondent.ID;

                    await Housings.Create(housing);
                }

                // ================================================================= Watersupply Miscellaneous ===================================================================

                WatersupplyMiscellaneous watersupply = new WatersupplyMiscellaneous();
                var Watersupply = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Watersupply" && x.Checked).ToList();
                var frequencyWatersupply = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyWatersupply" && x.SelectedItem != null).ToList();
                var whereWatersupply = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereWatersupply" && x.SelectedItem != null).ToList();
                var changeWatersupply = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeWatersupply" && x.SelectedItem != null).ToList();
                var reasonWatersupply = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonWatersupply" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Watersupply.Count(); i++)
                {
                    watersupply.Item = Watersupply[i].Text;
                    watersupply.Frequency = frequencyWatersupply[i].Text;
                    watersupply.Where = whereWatersupply[i].Text;
                    watersupply.Change = changeWatersupply[i].Text;
                    watersupply.Reason = reasonWatersupply[i].Text;
                    watersupply.RespondentID = respondent.ID;

                    await waterSupplyMisc.Create(watersupply);
                }

                // ================================================================= Electricity Gas Fuels ===================================================================

                ElectricityGasFuels gasFuels = new ElectricityGasFuels();
                var ElectricityGas = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "ElectricityGas" && x.Checked).ToList();
                var frequencyElectricityGas = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyElectricityGas" && x.SelectedItem != null).ToList();
                var whereElectricityGas = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereElectricityGas" && x.SelectedItem != null).ToList();
                var changeElectricityGas = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeElectricityGas" && x.SelectedItem != null).ToList();
                var reasonElectricityGas = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonElectricityGas" && x.SelectedItem != null).ToList();

                for (int i = 0; i < ElectricityGas.Count(); i++)
                {
                    gasFuels.Item = ElectricityGas[i].Text;
                    gasFuels.Frequency = frequencyElectricityGas[i].Text;
                    gasFuels.Where = whereElectricityGas[i].Text;
                    gasFuels.Change = changeElectricityGas[i].Text;
                    gasFuels.Reason = reasonElectricityGas[i].Text;
                    gasFuels.RespondentID = respondent.ID;

                    await electricityGasFuel.Create(gasFuels);
                }

                // ================================================================= Medical Products ===================================================================

                MedicalProducts medical = new MedicalProducts();
                var MedicalProducts = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "MedicalProducts" && x.Checked).ToList();
                var frequencyMedicalProducts = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyMedicalProducts" && x.SelectedItem != null).ToList();
                var whereMedicalProducts = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereMedicalProducts" && x.SelectedItem != null).ToList();
                var changeMedicalProducts = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeMedicalProducts" && x.SelectedItem != null).ToList();
                var reasonMedicalProducts = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonMedicalProducts" && x.SelectedItem != null).ToList();

                for (int i = 0; i < MedicalProducts.Count(); i++)
                {
                    medical.Item = MedicalProducts[i].Text;
                    medical.Frequency = frequencyMedicalProducts[i].Text;
                    medical.Where = whereMedicalProducts[i].Text;
                    medical.Change = changeMedicalProducts[i].Text;
                    medical.Reason = reasonMedicalProducts[i].Text;
                    medical.RespondentID = respondent.ID;

                    await medicalProducts.Create(medical);
                }

                // ================================================================= Outpatient Medical Services ===================================================================

                OutpatientMedicalServices outpatient = new OutpatientMedicalServices();
                var Outpatient = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Outpatient" && x.Checked).ToList();
                var frequencyOutpatient = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyOutpatient" && x.SelectedItem != null).ToList();
                var whereOutpatient = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereOutpatient" && x.SelectedItem != null).ToList();
                var changeOutpatient = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeOutpatient" && x.SelectedItem != null).ToList();
                var reasonOutpatient = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonOutpatient" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Outpatient.Count(); i++)
                {
                    outpatient.Item = Outpatient[i].Text;
                    outpatient.Frequency = frequencyOutpatient[i].Text;
                    outpatient.Where = whereOutpatient[i].Text;
                    outpatient.Change = changeOutpatient[i].Text;
                    outpatient.Reason = reasonOutpatient[i].Text;
                    outpatient.RespondentID = respondent.ID;

                    await outpatientMedicalServices.Create(outpatient);
                }

                // ================================================================= Inpatient Medical Services ===================================================================

                InpatientMedicalServices inpatient = new InpatientMedicalServices();
                var Inpatient = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Inpatient" && x.Checked).ToList();
                var frequencyInpatient = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyInpatient" && x.SelectedItem != null).ToList();
                var whereInpatient = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereInpatient" && x.SelectedItem != null).ToList();
                var changeInpatient = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeInpatient" && x.SelectedItem != null).ToList();
                var reasonInpatient = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonInpatient" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Inpatient.Count(); i++)
                {
                    inpatient.Item = Inpatient[i].Text;
                    inpatient.Frequency = frequencyInpatient[i].Text;
                    inpatient.Where = whereInpatient[i].Text;
                    inpatient.Change = changeInpatient[i].Text;
                    inpatient.Reason = reasonInpatient[i].Text;
                    inpatient.RespondentID = respondent.ID;

                    await inpatientMedicalServices.Create(inpatient);
                }

                // ================================================================= Personal Transport ===================================================================

                PersonalTransport personal = new PersonalTransport();
                var PersonalTransport = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "PersonalTransport" && x.Checked).ToList();
                var frequencyPersonalTransport = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyPersonalTransport" && x.SelectedItem != null).ToList();
                var wherePersonalTransport = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "wherePersonalTransport" && x.SelectedItem != null).ToList();
                var changePersonalTransport = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changePersonalTransport" && x.SelectedItem != null).ToList();
                var reasonPersonalTransport = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonPersonalTransport" && x.SelectedItem != null).ToList();

                for (int i = 0; i < PersonalTransport.Count(); i++)
                {
                    personal.Item = PersonalTransport[i].Text;
                    personal.Frequency = frequencyPersonalTransport[i].Text;
                    personal.Where = wherePersonalTransport[i].Text;
                    personal.Change = changePersonalTransport[i].Text;
                    personal.Reason = reasonPersonalTransport[i].Text;
                    personal.RespondentID = respondent.ID;

                   await personalTransport.Create(personal);
                }

                // ================================================================= Transport Services ===================================================================

                TransportServices transport = new TransportServices();
                var TransportServices = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "TransportServices" && x.Checked).ToList();
                var frequencyTransportServices = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyTransportServices" && x.SelectedItem != null).ToList();
                var whereTransportServices = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereTransportServices" && x.SelectedItem != null).ToList();
                var changeTransportServices = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeTransportServices" && x.SelectedItem != null).ToList();
                var reasonTransportServices = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonTransportServices" && x.SelectedItem != null).ToList();

                for (int i = 0; i < TransportServices.Count(); i++)
                {
                    transport.Item = TransportServices[i].Text;
                    transport.Frequency = frequencyTransportServices[i].Text;
                    transport.Where = whereTransportServices[i].Text;
                    transport.Change = changeTransportServices[i].Text;
                    transport.Reason = reasonTransportServices[i].Text;
                    transport.RespondentID = respondent.ID;

                    await transportServices.Create(transport);
                }

                // ================================================================= Postal Services ===================================================================

                PostalServices postal = new PostalServices();
                var PostalService = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "PostalService" && x.Checked).ToList();
                var frequencyPostalService = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyPostalService" && x.SelectedItem != null).ToList();
                var wherePostalService = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "wherePostalService" && x.SelectedItem != null).ToList();
                var changePostalService = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changePostalService" && x.SelectedItem != null).ToList();
                var reasonPostalService = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonPostalService" && x.SelectedItem != null).ToList();

                for (int i = 0; i < PostalService.Count(); i++)
                {
                    postal.Item = PostalService[i].Text;
                    postal.Frequency = frequencyPostalService[i].Text;
                    postal.Where = wherePostalService[i].Text;
                    postal.Change = changePostalService[i].Text;
                    postal.Reason = reasonPostalService[i].Text;
                    postal.RespondentID = respondent.ID;

                    await postalServices.Create(postal);
                }

                // ================================================================= Telephone Telefax Services ===================================================================

                TelephoneTelefaxServices telephone = new TelephoneTelefaxServices();
                var TelephoneTelefax = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "TelephoneTelefax" && x.Checked).ToList();
                var frequencyTelephoneTelefax = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyTelephoneTelefax" && x.SelectedItem != null).ToList();
                var whereTelephoneTelefax = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereTelephoneTelefax" && x.SelectedItem != null).ToList();
                var changeTelephoneTelefax = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeTelephoneTelefax" && x.SelectedItem != null).ToList();
                var reasonTelephoneTelefax = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonTelephoneTelefax" && x.SelectedItem != null).ToList();

                for (int i = 0; i < TelephoneTelefax.Count(); i++)
                {
                    telephone.Item = TelephoneTelefax[i].Text;
                    telephone.Frequency = frequencyTelephoneTelefax[i].Text;
                    telephone.Where = whereTelephoneTelefax[i].Text;
                    telephone.Change = changeTelephoneTelefax[i].Text;
                    telephone.Reason = reasonTelephoneTelefax[i].Text;
                    telephone.RespondentID = respondent.ID;

                    await telephoneTelefaxes.Create(telephone);
                }

                // ================================================================= Recreational Items Equipment ===================================================================

                RecreationalItemsEquipment recreationalItems = new RecreationalItemsEquipment();
                var RecreationalItemsEquipment = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "RecreationalItemsEquipment" && x.Checked).ToList();
                var frequencyRecreationalItemsEquipment = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyRecreationalItemsEquipment" && x.SelectedItem != null).ToList();
                var whereRecreationalItemsEquipment = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereRecreationalItemsEquipment" && x.SelectedItem != null).ToList();
                var changeRecreationalItemsEquipment = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeRecreationalItemsEquipment" && x.SelectedItem != null).ToList();
                var reasonRecreationalItemsEquipment = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonRecreationalItemsEquipment" && x.SelectedItem != null).ToList();

                for (int i = 0; i < RecreationalItemsEquipment.Count(); i++)
                {
                    recreationalItems.Item = RecreationalItemsEquipment[i].Text;
                    recreationalItems.Frequency = frequencyRecreationalItemsEquipment[i].Text;
                    recreationalItems.Where = whereRecreationalItemsEquipment[i].Text;
                    recreationalItems.Change = changeRecreationalItemsEquipment[i].Text;
                    recreationalItems.Reason = reasonRecreationalItemsEquipment[i].Text;
                    recreationalItems.RespondentID = respondent.ID;

                    await recreationalItemsEquipment.Create(recreationalItems);
                }

                // ================================================================= Recreation And Culture ===================================================================

                RecreationAndCulture recreation = new RecreationAndCulture();
                var RecreationAndCulture = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "RecreationAndCulture" && x.Checked).ToList();
                var frequencyRecreationAndCulture = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyRecreationAndCulture" && x.SelectedItem != null).ToList();
                var whereRecreationAndCulture = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereRecreationAndCulture" && x.SelectedItem != null).ToList();
                var changeRecreationAndCulture = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeRecreationAndCulture" && x.SelectedItem != null).ToList();
                var reasonRecreationAndCulture = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonRecreationAndCulture" && x.SelectedItem != null).ToList();

                for (int i = 0; i < RecreationAndCulture.Count(); i++)
                {
                    recreation.Item = RecreationAndCulture[i].Text;
                    recreation.Frequency = frequencyRecreationAndCulture[i].Text;
                    recreation.Where = whereRecreationAndCulture[i].Text;
                    recreation.Change = changeRecreationAndCulture[i].Text;
                    recreation.Reason = reasonRecreationAndCulture[i].Text;
                    recreation.RespondentID = respondent.ID;

                    await recreationAndculture.Create(recreation);
                }

                // ================================================================= Newspaper Book Stationary ===================================================================

                NewspaperBookStationary newspaper = new NewspaperBookStationary();
                var NewspaperBooks = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "NewspaperBooks" && x.Checked).ToList();
                var frequencyNewspaperBooks = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyNewspaperBooks" && x.SelectedItem != null).ToList();
                var whereNewspaperBooks = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereNewspaperBooks" && x.SelectedItem != null).ToList();
                var changeNewspaperBooks = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeNewspaperBooks" && x.SelectedItem != null).ToList();
                var reasonNewspaperBooks = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonNewspaperBooks" && x.SelectedItem != null).ToList();

                for (int i = 0; i < NewspaperBooks.Count(); i++)
                {
                    newspaper.Item = NewspaperBooks[i].Text;
                    newspaper.Frequency = frequencyNewspaperBooks[i].Text;
                    newspaper.Where = whereNewspaperBooks[i].Text;
                    newspaper.Change = changeNewspaperBooks[i].Text;
                    newspaper.Reason = reasonNewspaperBooks[i].Text;
                    newspaper.RespondentID = respondent.ID;

                    await newspaperBookStationary.Create(newspaper);
                }

                // ================================================================= Tuition Fee ===================================================================

                TuitionFee tuition = new TuitionFee();
                var TuitionFees = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "TuitionFees" && x.Checked).ToList();
                var frequencyTuitionFees = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyTuitionFees" && x.SelectedItem != null).ToList();
                var whereTuitionFees = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereTuitionFees" && x.SelectedItem != null).ToList();
                var changeTuitionFees = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeTuitionFees" && x.SelectedItem != null).ToList();
                var reasonTuitionFees = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonTuitionFees" && x.SelectedItem != null).ToList();

                for (int i = 0; i < TuitionFees.Count(); i++)
                {
                    tuition.Item = TuitionFees[i].Text;
                    tuition.Frequency = frequencyTuitionFees[i].Text;
                    tuition.Where = whereTuitionFees[i].Text;
                    tuition.Change = changeTuitionFees[i].Text;
                    tuition.Reason = reasonTuitionFees[i].Text;
                    tuition.RespondentID = respondent.ID;

                    await tuitionFee.Create(tuition);
                }

                // ================================================================= Education ===================================================================

                Education education = new Education();
                var Education = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Education" && x.Checked).ToList();
                var frequencyEducation = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyEducation" && x.SelectedItem != null).ToList();
                var whereEducation = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereEducation" && x.SelectedItem != null).ToList();
                var changeEducation = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeEducation" && x.SelectedItem != null).ToList();
                var reasonEducation = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonEducation" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Education.Count(); i++)
                {
                    education.Item = Education[i].Text;
                    education.Frequency = frequencyEducation[i].Text;
                    education.Where = whereEducation[i].Text;
                    education.Change = changeEducation[i].Text;
                    education.Reason = reasonEducation[i].Text;
                    education.RespondentID = respondent.ID;

                    await Educations.Create(education);
                }

                // ================================================================= Allowance Of Student ===================================================================

                AllowanceOfStudent allowance = new AllowanceOfStudent();
                var Allowance = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Allowance" && x.Checked).ToList();
                var frequencyAllowance = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyAllowance" && x.SelectedItem != null).ToList();
                var whereAllowance = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereAllowance" && x.SelectedItem != null).ToList();
                var changeAllowance = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeAllowance" && x.SelectedItem != null).ToList();
                var reasonAllowance = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonAllowance" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Allowance.Count(); i++)
                {
                    allowance.Item = Allowance[i].Text;
                    allowance.Frequency = frequencyAllowance[i].Text;
                    allowance.Where = whereAllowance[i].Text;
                    allowance.Change = changeAllowance[i].Text;
                    allowance.Reason = reasonAllowance[i].Text;
                    allowance.RespondentID = respondent.ID;

                    await allowanceOfStudent.Create(allowance);
                }

                // ================================================================= Other Educational Expense ===================================================================

                OtherEducationalExpense other = new OtherEducationalExpense();
                var EducationalExpense = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "EducationalExpense" && x.Checked).ToList();
                var frequencyEducationalExpense = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyEducationalExpense" && x.SelectedItem != null).ToList();
                var whereEducationalExpense = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereEducationalExpense" && x.SelectedItem != null).ToList();
                var changeEducationalExpense = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeEducationalExpense" && x.SelectedItem != null).ToList();
                var reasonEducationalExpense = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonEducationalExpense" && x.SelectedItem != null).ToList();

                for (int i = 0; i < EducationalExpense.Count(); i++)
                {
                    other.Item = EducationalExpense[i].Text;
                    other.Frequency = frequencyEducationalExpense[i].Text;
                    other.Where = whereEducationalExpense[i].Text;
                    other.Change = changeEducationalExpense[i].Text;
                    other.Reason = reasonEducationalExpense[i].Text;
                    other.RespondentID = respondent.ID;

                    await otherEducationalExpense.Create(other);
                }

                // ================================================================= Personal Care ===================================================================

                PersonalCare care = new PersonalCare();
                var PersonalCare = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "PersonalCare" && x.Checked).ToList();
                var frequencyPersonalCare = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyPersonalCare" && x.SelectedItem != null).ToList();
                var wherePersonalCare = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "wherePersonalCare" && x.SelectedItem != null).ToList();
                var changePersonalCare = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changePersonalCare" && x.SelectedItem != null).ToList();
                var reasonPersonalCare = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonPersonalCare" && x.SelectedItem != null).ToList();

                for (int i = 0; i < PersonalCare.Count(); i++)
                {
                    care.Item = PersonalCare[i].Text;
                    care.Frequency = frequencyPersonalCare[i].Text;
                    care.Where = wherePersonalCare[i].Text;
                    care.Change = changePersonalCare[i].Text;
                    care.Reason = reasonPersonalCare[i].Text;
                    care.RespondentID = respondent.ID;

                    await personalCare.Create(care);
                }

                // ================================================================= Personal Effect ===================================================================

                PersonalEffect effect = new PersonalEffect();
                var PersonalEffects = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "PersonalEffects" && x.Checked).ToList();
                var frequencyPersonalEffects = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyPersonalEffects" && x.SelectedItem != null).ToList();
                var wherePersonalEffects = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "wherePersonalEffects" && x.SelectedItem != null).ToList();
                var changePersonalEffects = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changePersonalEffects" && x.SelectedItem != null).ToList();
                var reasonPersonalEffects = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonPersonalEffects" && x.SelectedItem != null).ToList();

                for (int i = 0; i < PersonalEffects.Count(); i++)
                {
                    effect.Item = PersonalEffects[i].Text;
                    effect.Frequency = frequencyPersonalEffects[i].Text;
                    effect.Where = wherePersonalEffects[i].Text;
                    effect.Change = changePersonalEffects[i].Text;
                    effect.Reason = reasonPersonalEffects[i].Text;
                    effect.RespondentID = respondent.ID;

                    await personalEffect.Create(effect);
                }

                // ================================================================= Insurance ===================================================================

                Insurance insurance = new Insurance();
                var Insurance = FindControls<CheckBox>(this).Where(x => x.AccessibleDescription == "Insurance" && x.Checked).ToList();
                var frequencyInsurance = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "frequencyInsurance" && x.SelectedItem != null).ToList();
                var whereInsurance = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "whereInsurance" && x.SelectedItem != null).ToList();
                var changeInsurance = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "changeInsurance" && x.SelectedItem != null).ToList();
                var reasonInsurance = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "reasonInsurance" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Insurance.Count(); i++)
                {
                    insurance.Item = Insurance[i].Text;
                    insurance.Frequency = frequencyInsurance[i].Text;
                    insurance.Where = whereInsurance[i].Text;
                    insurance.Change = changeInsurance[i].Text;
                    insurance.Reason = reasonInsurance[i].Text;
                    insurance.RespondentID = respondent.ID;

                    await Insurances.Create(insurance);
                }

                // ================================================================= Health Crisis ===================================================================

                RespondentHealthCrisis healthCrisis = new RespondentHealthCrisis();
                var Health_Crisis = FindControls<ComboBox>(this).Where(x => x.AccessibleName == "HealthCrisis" && x.SelectedItem != null).ToList();
                var Health_Recommendation = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "HealthRecommendation" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Health_Crisis.Count(); i++)
                {
                    healthCrisis.HealthCrisis = Health_Crisis[i].Text;
                    healthCrisis.Recommendation = Health_Recommendation[i].Text;
                    healthCrisis.RespondentID = respondent.ID;

                    await respondentHealthCrisis.Create(healthCrisis);
                }

                // ================================================================= Respondent Health Crisis ===================================================================

                RespondentEconomicCrisis economicCrisis = new RespondentEconomicCrisis();
                var Economic_Crisis = FindControls<ComboBox>(this).Where(x => x.AccessibleName == "EconomicCrisis" && x.SelectedItem != null).ToList();
                var Economic_Recommendation = FindControls<ComboBox>(this).Where(x => x.AccessibleDescription == "EconomicRecommendation" && x.SelectedItem != null).ToList();

                for (int i = 0; i < Economic_Crisis.Count(); i++)
                {
                    economicCrisis.EconomicCrisis = Economic_Crisis[i].Text;
                    economicCrisis.Recommendation = Economic_Recommendation[i].Text;
                    economicCrisis.RespondentID = respondent.ID;

                    await respondentEconomicCrisis.Create(economicCrisis);
                }

                // ================================================================= Survey ===================================================================

                Survey survey = new Survey();
                survey.DateSurveyed = dtpSurveyed.Value.Date;
                survey.EnumeratorsCode = txtEnumCode.Text.Trim();
                survey.RespondentCode = txtRespCode.Text.Trim();
                survey.RespondentID = respondent.ID;

                await Survey.Create(survey);

                MessageBox.Show("New entry has been submitted...", "Success!");
                FindControls<CheckBox>(this).Where(x => x.Checked).ToList().ForEach(x => x.Checked = false);
                FindControls<ComboBox>(this).Where(x => x.SelectedItem != null).ToList().ForEach(x => x.SelectedItem = null);
                FindControls<RadioButton>(this).Where(x => x.Checked).ToList().ForEach(x => x.Checked = false);
                FindControls<TextBox>(this).Where(x => x.Text != string.Empty).ToList().ForEach(x => x.Clear());
                btnSubmitSurvey.Enabled = true;
                tblSalariesWages.Focus();
            }
        }
    }
}
