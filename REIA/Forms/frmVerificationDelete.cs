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
using System.Xml;

namespace REIA.Forms
{
    public partial class frmVerificationDelete : Form
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



        //List<EconomicCrisisList> GetEconomicCrisisLists;
        //List<EconomicRecommendationList> GetEconomicRecommendationLists;
        //List<EntrepreneurialActivitiesList> GetEntrepreneurialActivitiesLists;
        //List<GoodsList> GetGoodsLists;
        //List<HealtCrisisList> GetHealtCrisisLists;
        //List<HealthRecommendationList> GetHealthRecommendationLists;
        //List<OtherSourcesList> GetOtherSourcesLists;
        //List<ReasonList> GetReasonLists;
        //List<SalariesWagesList> GetSalariesWagesLists;
        //List<ServicesList> GetServicesLists;
        //List<Municipality> GetMunicipalities;
        //List<Barangay> GetBarangays;
        List<Respondent> GetRespondents;
        List<Survey> GetSurveys;

        List<RespondentSalariesWages> GetRespondentSalariesWages;
        List<RespondentEntrepreneurialActivities> GetRespondentEntrepreneurialActivities;
        List<RespondentOtherSources> GetRespondentOtherSources;
        List<BreadsAndCereals> GetBreads;
        List<Meat> GetMeats;
        List<FishAndSeafood> GetSeafoods;
        List<MilkCheeseEggs> GetMilkCheese;
        List<OilsAndFats> GetOilsAndFats;
        List<Fruit> GetFruits;
        List<Vegetable> GetVegetables;
        List<SugarJamHoneyChocolateConfectionary> GetSugarJamHoneyChocolates;
        List<FoodProduct> GetFoodProducts;
        List<NonAlcoholicBeverages> GetNonAlcoholicBeverages;
        List<MineralwaterSoftdrinkJuice> GetMineralwaterSoftdrinkJuices;
        List<AlcoholicBeverages> GetAlcoholicBeverages;
        List<Tobacco> GetTobaccos;
        List<Clothing> GetClothings;
        List<Footwear> GetFootwears;
        List<Housing> GetHousings;
        List<WatersupplyMiscellaneous> GetWatersupplyMiscellaneous;
        List<ElectricityGasFuels> GetElectricityGas;
        List<MedicalProducts> GetMedicalProducts;
        List<OutpatientMedicalServices> GetOutpatientMedicalServices;
        List<InpatientMedicalServices> GetInpatientMedicalServices;
        List<PersonalTransport> GetPersonalTransports;
        List<TransportServices> GetTransportServices;
        List<PostalServices> GetPostalServices;
        List<TelephoneTelefaxServices> GetTelephoneTelefaxServices;
        List<RecreationalItemsEquipment> GetRecreationalItemsEquipment;
        List<RecreationAndCulture> GetRecreationAndCultures;
        List<NewspaperBookStationary> GetNewspaperBookStationaries;
        List<TuitionFee> GetTuitionFees;
        List<Education> GetEducations;
        List<AllowanceOfStudent> GetAllowanceOfStudents;
        List<OtherEducationalExpense> GetOtherEducationalExpenses;
        List<PersonalCare> GetPersonalCares;
        List<PersonalEffect> GetPersonalEffects;
        List<Insurance> GetInsurances;
        List<RespondentHealthCrisis> GetRespondentHealthCrises;
        List<RespondentEconomicCrisis> GetRespondentEconomicCrises;
        List<RespondentGoods> GetRespondentGoods;
        List<RespondentServices> GetRespondentServices;



        public frmVerificationDelete()
        {
            InitializeComponent();
            txtCode.PasswordChar = '\u25CF';
        }

        private async void frmVerificationDelete_Load(object sender, EventArgs e)
        {
            await CallLoad();
        }
        async Task CallLoad()
        {            
            GetRespondents = await Respondent.GetAll();
            GetSurveys = await Survey.GetAll();
            GetRespondentSalariesWages = await respondentSalariesWages.GetAll();
            GetRespondentEntrepreneurialActivities = await respondentEntrepreneurialActivities.GetAll();
            GetRespondentOtherSources = await respondentOtherSources.GetAll();
            GetBreads = await breadsAndCereals.GetAll();
            GetMeats = await Meats.GetAll();
            GetSeafoods = await fishAndSeafood.GetAll();
            GetMilkCheese = await milkCheeseEggs.GetAll();
            GetOilsAndFats = await oilsAndFats.GetAll();
            GetFruits = await Fruit.GetAll();
            GetVegetables = await Vegetable.GetAll();
            GetSugarJamHoneyChocolates = await sugarJamHoney.GetAll();
            GetFoodProducts = await foodProduct.GetAll();
            GetNonAlcoholicBeverages = await nonAlcoholicBeverages.GetAll();
            GetMineralwaterSoftdrinkJuices = await mineralWaterSoftdrinks.GetAll();
            GetAlcoholicBeverages = await alcoholicBeverages.GetAll();
            GetTobaccos = await Tobaccos.GetAll();
            GetClothings = await Clothings.GetAll();
            GetFootwears = await Footwears.GetAll();
            GetHousings = await Housings.GetAll();
            GetWatersupplyMiscellaneous = await waterSupplyMisc.GetAll();
            GetElectricityGas = await electricityGasFuel.GetAll();
            GetMedicalProducts = await medicalProducts.GetAll();
            GetOutpatientMedicalServices = await outpatientMedicalServices.GetAll();
            GetInpatientMedicalServices = await inpatientMedicalServices.GetAll();
            GetPersonalTransports = await personalTransport.GetAll();
            GetTransportServices = await transportServices.GetAll();
            GetPostalServices = await postalServices.GetAll();
            GetTelephoneTelefaxServices = await telephoneTelefaxes.GetAll();
            GetRecreationalItemsEquipment = await recreationalItemsEquipment.GetAll();
            GetRecreationAndCultures = await recreationAndculture.GetAll();
            GetNewspaperBookStationaries = await newspaperBookStationary.GetAll();
            GetTuitionFees = await tuitionFee.GetAll();
            GetEducations = await Educations.GetAll();
            GetAllowanceOfStudents = await allowanceOfStudent.GetAll();
            GetOtherEducationalExpenses = await otherEducationalExpense.GetAll();
            GetPersonalCares = await personalCare.GetAll();
            GetPersonalEffects = await personalEffect.GetAll();
            GetInsurances = await Insurances.GetAll();
            GetRespondentHealthCrises = await respondentHealthCrisis.GetAll();
            GetRespondentEconomicCrises = await respondentEconomicCrisis.GetAll();
            GetRespondentGoods = await respondentGoods.GetAll();
            GetRespondentServices = await respondentServices.GetAll();
        }

        private async void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != "00000000")
            {
                MessageBox.Show("Action failed! Invalid Verification Code!", "Error!");
                return;
            }
            else
            {
                //var SalariesWagesID = GetRespondentSalariesWages.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < SalariesWagesID.Count; i++)
                //    await respondentSalariesWages.Delete(SalariesWagesID[i].ID);

                //var EntrepreneurialID = GetRespondentEntrepreneurialActivities.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < EntrepreneurialID.Count; i++)
                //    await respondentEntrepreneurialActivities.Delete(EntrepreneurialID[i].ID);

                //var OtherSourcesID = GetRespondentOtherSources.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < OtherSourcesID.Count; i++)
                //    await respondentOtherSources.Delete(OtherSourcesID[i].ID);

                //var GoodsID = GetRespondentGoods.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < GoodsID.Count; i++)
                //    await respondentGoods.Delete(GoodsID[i].ID);

                //var ServicesID = GetRespondentServices.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < ServicesID.Count; i++)
                //    await respondentServices.Delete(ServicesID[i].ID);

                //var BreadID = GetBreads.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < BreadID.Count; i++)
                //    await breadsAndCereals.Delete(BreadID[i].ID);

                //var MeatID = GetMeats.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < MeatID.Count; i++)
                //    await Meats.Delete(MeatID[i].ID);

                //var SeafoodID = GetSeafoods.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < SeafoodID.Count; i++)
                //    await fishAndSeafood.Delete(SeafoodID[i].ID);

                //var MilkCheeseID = GetMilkCheese.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < MilkCheeseID.Count; i++)
                //    await milkCheeseEggs.Delete(MilkCheeseID[i].ID);

                //var OilFatID = GetOilsAndFats.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < OilFatID.Count; i++)
                //    await oilsAndFats.Delete(OilFatID[i].ID);

                //var FruitID = GetFruits.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < FruitID.Count; i++)
                //    await Fruit.Delete(FruitID[i].ID);

                //var VegetableID = GetVegetables.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < VegetableID.Count; i++)
                //    await Vegetable.Delete(VegetableID[i].ID);

                //var SugarJamID = GetSugarJamHoneyChocolates.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < SugarJamID.Count; i++)
                //    await sugarJamHoney.Delete(SugarJamID[i].ID);

                //var FoodProductID = GetFoodProducts.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < FoodProductID.Count; i++)
                //    await foodProduct.Delete(FoodProductID[i].ID);

                //var NonAlcoholicID = GetNonAlcoholicBeverages.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < NonAlcoholicID.Count; i++)
                //    await nonAlcoholicBeverages.Delete(NonAlcoholicID[i].ID);

                //var MineralID = GetMineralwaterSoftdrinkJuices.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < MineralID.Count; i++)
                //    await mineralWaterSoftdrinks.Delete(MineralID[i].ID);

                //var AlcoholicID = GetAlcoholicBeverages.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < AlcoholicID.Count; i++)
                //    await alcoholicBeverages.Delete(AlcoholicID[i].ID);

                //var TobaccoID = GetTobaccos.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < TobaccoID.Count; i++)
                //    await Tobaccos.Delete(TobaccoID[i].ID);

                //var ClothingID = GetClothings.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < ClothingID.Count; i++)
                //    await Clothings.Delete(ClothingID[i].ID);

                //var FootwearID = GetFootwears.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < FootwearID.Count; i++)
                //    await Footwears.Delete(FootwearID[i].ID);

                //var HousingID = GetHousings.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < HousingID.Count; i++)
                //    await Housings.Delete(HousingID[i].ID);

                //var WatersupplyID = GetWatersupplyMiscellaneous.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < WatersupplyID.Count; i++)
                //    await waterSupplyMisc.Delete(WatersupplyID[i].ID);

                //var ElectricityID = GetElectricityGas.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < ElectricityID.Count; i++)
                //    await electricityGasFuel.Delete(ElectricityID[i].ID);

                //var MedicalProductID = GetMedicalProducts.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < MedicalProductID.Count; i++)
                //    await medicalProducts.Delete(MedicalProductID[i].ID);

                //var OutpatientID = GetOutpatientMedicalServices.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < OutpatientID.Count; i++)
                //    await outpatientMedicalServices.Delete(OutpatientID[i].ID);

                //var InpatientID = GetInpatientMedicalServices.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < InpatientID.Count; i++)
                //    await inpatientMedicalServices.Delete(InpatientID[i].ID);

                //var PersonalTransportID = GetPersonalTransports.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < PersonalTransportID.Count; i++)
                //    await personalTransport.Delete(PersonalTransportID[i].ID);

                //var TransportServicesID = GetTransportServices.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < TransportServicesID.Count; i++)
                //    await transportServices.Delete(TransportServicesID[i].ID);

                //var PostalID = GetPostalServices.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < PostalID.Count; i++)
                //    await postalServices.Delete(PostalID[i].ID);

                //var TelephoneID = GetTelephoneTelefaxServices.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < TelephoneID.Count; i++)
                //    await telephoneTelefaxes.Delete(TelephoneID[i].ID);

                //var RecreationalItemsID = GetRecreationalItemsEquipment.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < RecreationalItemsID.Count; i++)
                //    await recreationalItemsEquipment.Delete(RecreationalItemsID[i].ID);

                //var RecreactionCultureID = GetRecreationAndCultures.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < RecreactionCultureID.Count; i++)
                //    await recreationAndculture.Delete(RecreactionCultureID[i].ID);

                //var NewspaperID = GetNewspaperBookStationaries.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < NewspaperID.Count; i++)
                //    await newspaperBookStationary.Delete(NewspaperID[i].ID);

                //var TuitionID = GetTuitionFees.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < TuitionID.Count; i++)
                //    await tuitionFee.Delete(TuitionID[i].ID);

                //var EducationID = GetEducations.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < EducationID.Count; i++)
                //    await Educations.Delete(EducationID[i].ID);

                //var AllowanceID = GetAllowanceOfStudents.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < AllowanceID.Count; i++)
                //    await allowanceOfStudent.Delete(AllowanceID[i].ID);

                //var EducExpensesID = GetOtherEducationalExpenses.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < EducExpensesID.Count; i++)
                //    await otherEducationalExpense.Delete(EducExpensesID[i].ID);

                //var PersonalCareID = GetPersonalCares.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < PersonalCareID.Count; i++)
                //    await personalCare.Delete(PersonalCareID[i].ID);

                //var PersonalEffectID = GetPersonalEffects.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < PersonalEffectID.Count; i++)
                //    await personalEffect.Delete(PersonalEffectID[i].ID);

                //var InsuranceID = GetInsurances.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < InsuranceID.Count; i++)
                //    await Insurances.Delete(InsuranceID[i].ID);

                //var HealthCrisisID = GetRespondentHealthCrises.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < HealthCrisisID.Count; i++)
                //    await respondentHealthCrisis.Delete(HealthCrisisID[i].ID);

                //var EconomicCrisisID = GetRespondentEconomicCrises.Where(x => x.RespondentID == frmSettings.RespondentID).ToList();
                //for (int i = 0; i < EconomicCrisisID.Count; i++)
                //    await respondentEconomicCrisis.Delete(EconomicCrisisID[i].ID);

                //await Survey.Delete(frmSettings.SurveyID);

                await Respondent.Delete(frmSettings.RespondentID);

                MessageBox.Show("Selected Survey Has been deleted", "Deleted!");
                frmSettings obj = (frmSettings)Application.OpenForms["frmSettings"];
                await obj.LoadSurveys();
                this.Close();
            }
        }
    }
}
