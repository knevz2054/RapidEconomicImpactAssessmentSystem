using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIA.Models.Entities
{
    public class Respondent : DomainObject
    {
        public string Fullname { get; set; } = "Not Specified";
        [Required]
        public string Gender { get; set; }
        [Required]
        public string CivilStatus { get; set; }
        [Required]
        public string AgeBracket { get; set; }
        [Required]
        public string Education { get; set; }
        public bool SalariesWages { get; set; } = false;
        public bool EntrepreneurialActivities { get; set; } = false;
        public bool Otherources { get; set; } = false;
        public string MainSource { get; set; }
        public string IncomeBefore { get; set; }
        public string IncomeNow { get; set; }
        public string IncomeChanges { get; set; }        
        public string HungerExperience { get; set; } = "No";
        public int January { get; set; } = 0;
        public int February { get; set; } = 0;
        public int March { get; set; } = 0;
        public int April { get; set; } = 0;
        public int May { get; set; } = 0;
        public int June { get; set; } = 0;
        public int July { get; set; } = 0;
        public int August { get; set; } = 0;
        public string RegularMonthlySavings { get; set; }
        public string RealizeMonthlySavings { get; set; }
        public string AffectedSavings { get; set; }
        public string EconomicSituation { get; set; }
        [Required]
        public int NumberHouseholdMembers { get; set; }
        [ForeignKey("Barangay")]
        public int brgyID { get; set; }
        public virtual Barangay Barangay { get; set; }
        public virtual ICollection<RespondentSalariesWages>  RespondentSalariesWages { get; set; }
        public virtual ICollection<RespondentEntrepreneurialActivities> RespondentEntrepreneurialActivities { get; set; }
        public virtual ICollection<RespondentOtherSources> RespondentOtherSources { get; set; }
        public virtual ICollection<BreadsAndCereals> BreadsAndCereals { get; set; }
        public virtual ICollection<Meat> Meats { get; set; }
        public virtual ICollection<FishAndSeafood> FishAndSeafoods { get; set; }
        public virtual ICollection<MilkCheeseEggs> MilkCheeseEggs { get; set; }
        public virtual ICollection<OilsAndFats> OilsAndFats { get; set; }
        public virtual ICollection<Fruit> Fruits { get; set; }
        public virtual ICollection<Vegetable> Vegetables { get; set; }
        public virtual ICollection<SugarJamHoneyChocolateConfectionary> SugarJamHoneyChocolateConfectionaries { get; set; }
        public virtual ICollection<FoodProduct> FoodProducts { get; set; }
        public virtual ICollection<NonAlcoholicBeverages> NonAlcoholicBeverages { get; set; }
        public virtual ICollection<MineralwaterSoftdrinkJuice> MineralwaterSoftdrinkJuices { get; set; }
        public virtual ICollection<AlcoholicBeverages> AlcoholicBeverages { get; set; }
        public virtual ICollection<Tobacco> Tobaccos { get; set; }
        public virtual ICollection<Clothing> Clothings { get; set; }
        public virtual ICollection<Footwear> Footwears { get; set; }
        public virtual ICollection<Housing> Housings { get; set; }
        public virtual ICollection<WatersupplyMiscellaneous> WatersupplyMiscellaneous { get; set; }
        public virtual ICollection<ElectricityGasFuels> ElectricityGasFuels { get; set; }
        public virtual ICollection<MedicalProducts> MedicalProducts { get; set; }
        public virtual ICollection<OutpatientMedicalServices> OutpatientMedicalServices { get; set; }
        public virtual ICollection<InpatientMedicalServices> InpatientMedicalServices { get; set; }
        public virtual ICollection<PersonalTransport> PersonalTransports { get; set; }
        public virtual ICollection<TransportServices> TransportServices { get; set; }
        public virtual ICollection<PostalServices> PostalServices { get; set; }
        public virtual ICollection<TelephoneTelefaxServices> TelephoneTelefaxServices { get; set; }
        public virtual ICollection<RecreationalItemsEquipment> RecreationalItemsEquipment { get; set; }
        public virtual ICollection<RecreationAndCulture> RecreationAndCultures { get; set; }
        public virtual ICollection<NewspaperBookStationary> NewspaperBookStationaries { get; set; }
        public virtual ICollection<TuitionFee> TuitionFees { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<AllowanceOfStudent> AllowanceOfStudents { get; set; }
        public virtual ICollection<OtherEducationalExpense> OtherEducationalExpenses { get; set; }
        public virtual ICollection<PersonalCare> PersonalCares { get; set; }
        public virtual ICollection<PersonalEffect> PersonalEffects { get; set; }
        public virtual ICollection<Insurance> Insurances { get; set; }
        public virtual ICollection<RespondentHealthCrisis> RespondentHealthCrises { get; set; }
        public virtual ICollection<RespondentEconomicCrisis> GetRespondentEconomicCrises { get; set; }
        public virtual ICollection<RespondentGoods> RespondentGoods { get; set; }
        public virtual ICollection<RespondentServices> RespondentServices { get; set; }
        public virtual ICollection<Survey> Surveys { get; set; }

    }
}
