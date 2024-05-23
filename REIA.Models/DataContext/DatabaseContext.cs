using REIA.Models.Entities;
using REIA.Models.Entities.Lists;
using REIA.Models.Entities.Other;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.DataContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Data Source=.\\sqlexpress;Initial Catalog=RapidEconomicImpactAssessment;Integrated Security=True")
        {

        }
        public virtual DbSet<Municipality> Municipalities { get; set; }
        public virtual DbSet<Barangay> Barangays { get; set; }
        public virtual DbSet<Respondent> Respondents { get; set; }
        public virtual DbSet<Cluster> Clusters { get; set; }
        public virtual DbSet<EconomicCrisisList> EconomicCrisisLists { get; set; }
        public virtual DbSet<EconomicRecommendationList> EconomicRecommendationLists { get; set; }
        public virtual DbSet<EntrepreneurialActivitiesList> EntrepreneurialActivitiesLists { get; set; }
        public virtual DbSet<GoodsList> GoodsLists { get; set; }
        public virtual DbSet<HealtCrisisList> HealtCrisisLists { get; set; }
        public virtual DbSet<OtherSourcesList> OtherSourcesLists { get; set; }
        public virtual DbSet<HealthRecommendationList> HealthRecommendationLists { get; set; }
        public virtual DbSet<ReasonList> ReasonLists { get; set; }
        public virtual DbSet<SalariesWagesList> SalariesWagesLists { get; set; }
        public virtual DbSet<ServicesList> ServicesLists { get; set; }
        public virtual DbSet<RespondentSalariesWages> RespondentSalariesWages { get; set; }
        public virtual DbSet<RespondentEntrepreneurialActivities> RespondentEntrepreneurialActivities { get; set; }
        public virtual DbSet<RespondentOtherSources> RespondentOtherSources { get; set; }
        public virtual DbSet<BreadsAndCereals> BreadsAndCereals { get; set; }
        public virtual DbSet<Meat> Meats { get; set; }
        public virtual DbSet<FishAndSeafood> FishAndSeafoods { get; set; }
        public virtual DbSet<MilkCheeseEggs> MilkCheeseEggs { get; set; }
        public virtual DbSet<OilsAndFats> OilsAndFats { get; set; }
        public virtual DbSet<Fruit> Fruits { get; set; }
        public virtual DbSet<Vegetable> Vegetables { get; set; }
        public virtual DbSet<SugarJamHoneyChocolateConfectionary> SugarJamHoneyChocolateConfectionaries { get; set; }
        public virtual DbSet<FoodProduct> FoodProducts { get; set; }
        public virtual DbSet<NonAlcoholicBeverages> NonAlcoholicBeverages { get; set; }
        public virtual DbSet<MineralwaterSoftdrinkJuice> MineralwaterSoftdrinkJuices { get; set; }
        public virtual DbSet<AlcoholicBeverages> AlcoholicBeverages { get; set; }
        public virtual DbSet<Tobacco> Tobaccos { get; set; }
        public virtual DbSet<Clothing> Clothings { get; set; }
        public virtual DbSet<Footwear> Footwears { get; set; }
        public virtual DbSet<Housing> Housings { get; set; }
        public virtual DbSet<WatersupplyMiscellaneous> WatersupplyMiscellaneous { get; set; }
        public virtual DbSet<ElectricityGasFuels> ElectricityGasFuels { get; set; }
        public virtual DbSet<MedicalProducts> MedicalProducts { get; set; }
        public virtual DbSet<OutpatientMedicalServices> OutpatientMedicalServices { get; set; }
        public virtual DbSet<InpatientMedicalServices> InpatientMedicalServices { get; set; }
        public virtual DbSet<PersonalTransport> PersonalTransports { get; set; }
        public virtual DbSet<TransportServices> TransportServices { get; set; }
        public virtual DbSet<PostalServices> PostalServices { get; set; }
        public virtual DbSet<TelephoneTelefaxServices> TelephoneTelefaxServices { get; set; }
        public virtual DbSet<RecreationalItemsEquipment> RecreationalItemsEquipment { get; set; }
        public virtual DbSet<RecreationAndCulture> RecreationAndCultures { get; set; }
        public virtual DbSet<NewspaperBookStationary> NewspaperBookStationaries { get; set; }
        public virtual DbSet<TuitionFee> TuitionFees { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<AllowanceOfStudent> AllowanceOfStudents { get; set; }
        public virtual DbSet<OtherEducationalExpense> OtherEducationalExpenses { get; set; }
        public virtual DbSet<PersonalCare> PersonalCares { get; set; }
        public virtual DbSet<PersonalEffect> PersonalEffects { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<RespondentHealthCrisis> RespondentHealthCrises { get; set; }
        public virtual DbSet<RespondentEconomicCrisis> GetRespondentEconomicCrises { get; set; }
        public virtual DbSet<RespondentGoods> RespondentGoods { get; set; }
        public virtual DbSet<RespondentServices> RespondentServices { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }

    }
}
