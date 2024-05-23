namespace REIA.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlcoholicBeverages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Respondents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fullname = c.String(),
                        Gender = c.String(nullable: false),
                        CivilStatus = c.String(nullable: false),
                        AgeBracket = c.String(nullable: false),
                        Education = c.String(nullable: false),
                        SalariesWages = c.Boolean(nullable: false),
                        EntrepreneurialActivities = c.Boolean(nullable: false),
                        Otherources = c.Boolean(nullable: false),
                        MainSource = c.String(),
                        IncomeBefore = c.String(),
                        IncomeNow = c.String(),
                        IncomeChanges = c.String(),
                        HungerExperience = c.String(),
                        January = c.Int(nullable: false),
                        February = c.Int(nullable: false),
                        April = c.Int(nullable: false),
                        May = c.Int(nullable: false),
                        June = c.Int(nullable: false),
                        July = c.Int(nullable: false),
                        August = c.Int(nullable: false),
                        NumberHouseholdMembers = c.Int(nullable: false),
                        brgyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Barangays", t => t.brgyID, cascadeDelete: true)
                .Index(t => t.brgyID);
            
            CreateTable(
                "dbo.AllowanceOfStudents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Barangays",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BarangayName = c.String(nullable: false),
                        BarangayCluster = c.String(),
                        MunID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Municipalities", t => t.MunID, cascadeDelete: true)
                .Index(t => t.MunID);
            
            CreateTable(
                "dbo.Municipalities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MunicipalityName = c.String(nullable: false),
                        District = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BreadsAndCereals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Clothings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.ElectricityGasFuels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.FishAndSeafoods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.FoodProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Footwears",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Fruits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.RespondentEconomicCrisis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EconomicCrisis = c.String(nullable: false),
                        Recommendation = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Housings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.InpatientMedicalServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Meats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.MedicalProducts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.MilkCheeseEggs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.MineralwaterSoftdrinkJuices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.NewspaperBookStationaries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.NonAlcoholicBeverages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.OilsAndFats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.OtherEducationalExpenses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.OutpatientMedicalServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.PersonalCares",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.PersonalEffects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.PersonalTransports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.PostalServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.RecreationalItemsEquipments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.RecreationAndCultures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.RespondentEntrepreneurialActivities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RespEntrepreneurialActivity = c.String(),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.RespondentGoods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RespGoods = c.String(),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.RespondentHealthCrisis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HealthCrisis = c.String(nullable: false),
                        Recommendation = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.RespondentOtherSources",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RespOtherSources = c.String(),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.RespondentSalariesWages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RespSalaryWage = c.String(),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.RespondentServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RespServices = c.String(),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.SugarJamHoneyChocolateConfectionaries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateSurveyed = c.DateTime(nullable: false),
                        EnumeratorsCode = c.String(),
                        RespondentCode = c.String(),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.TelephoneTelefaxServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Tobacco",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.TransportServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.TuitionFees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Vegetables",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.WatersupplyMiscellaneous",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Item = c.String(nullable: false),
                        Frequency = c.String(nullable: false),
                        Where = c.String(nullable: false),
                        Change = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        RespondentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Respondents", t => t.RespondentID, cascadeDelete: true)
                .Index(t => t.RespondentID);
            
            CreateTable(
                "dbo.Clusters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClusterName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EconomicCrisisLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListEconomicCrisis = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EconomicRecommendationLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListEconomicRecommendation = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EntrepreneurialActivitiesLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListEntrepreneurialActivities = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GoodsLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListGoods = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HealtCrisisLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListHealthCrisis = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HealthRecommendationLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListHealthRecommendation = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OtherSourcesLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListOtherSources = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ReasonLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListReason = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SalariesWagesLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListSalariesWages = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ServicesLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ListServices = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AlcoholicBeverages", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.WatersupplyMiscellaneous", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Vegetables", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.TuitionFees", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.TransportServices", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Tobacco", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.TelephoneTelefaxServices", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Surveys", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.SugarJamHoneyChocolateConfectionaries", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.RespondentServices", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.RespondentSalariesWages", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.RespondentOtherSources", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.RespondentHealthCrisis", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.RespondentGoods", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.RespondentEntrepreneurialActivities", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.RecreationAndCultures", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.RecreationalItemsEquipments", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.PostalServices", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.PersonalTransports", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.PersonalEffects", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.PersonalCares", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.OutpatientMedicalServices", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.OtherEducationalExpenses", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.OilsAndFats", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.NonAlcoholicBeverages", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.NewspaperBookStationaries", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.MineralwaterSoftdrinkJuices", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.MilkCheeseEggs", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.MedicalProducts", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Meats", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Insurances", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.InpatientMedicalServices", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Housings", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.RespondentEconomicCrisis", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Fruits", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Footwears", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.FoodProducts", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.FishAndSeafoods", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.ElectricityGasFuels", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Educations", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Clothings", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.BreadsAndCereals", "RespondentID", "dbo.Respondents");
            DropForeignKey("dbo.Respondents", "brgyID", "dbo.Barangays");
            DropForeignKey("dbo.Barangays", "MunID", "dbo.Municipalities");
            DropForeignKey("dbo.AllowanceOfStudents", "RespondentID", "dbo.Respondents");
            DropIndex("dbo.WatersupplyMiscellaneous", new[] { "RespondentID" });
            DropIndex("dbo.Vegetables", new[] { "RespondentID" });
            DropIndex("dbo.TuitionFees", new[] { "RespondentID" });
            DropIndex("dbo.TransportServices", new[] { "RespondentID" });
            DropIndex("dbo.Tobacco", new[] { "RespondentID" });
            DropIndex("dbo.TelephoneTelefaxServices", new[] { "RespondentID" });
            DropIndex("dbo.Surveys", new[] { "RespondentID" });
            DropIndex("dbo.SugarJamHoneyChocolateConfectionaries", new[] { "RespondentID" });
            DropIndex("dbo.RespondentServices", new[] { "RespondentID" });
            DropIndex("dbo.RespondentSalariesWages", new[] { "RespondentID" });
            DropIndex("dbo.RespondentOtherSources", new[] { "RespondentID" });
            DropIndex("dbo.RespondentHealthCrisis", new[] { "RespondentID" });
            DropIndex("dbo.RespondentGoods", new[] { "RespondentID" });
            DropIndex("dbo.RespondentEntrepreneurialActivities", new[] { "RespondentID" });
            DropIndex("dbo.RecreationAndCultures", new[] { "RespondentID" });
            DropIndex("dbo.RecreationalItemsEquipments", new[] { "RespondentID" });
            DropIndex("dbo.PostalServices", new[] { "RespondentID" });
            DropIndex("dbo.PersonalTransports", new[] { "RespondentID" });
            DropIndex("dbo.PersonalEffects", new[] { "RespondentID" });
            DropIndex("dbo.PersonalCares", new[] { "RespondentID" });
            DropIndex("dbo.OutpatientMedicalServices", new[] { "RespondentID" });
            DropIndex("dbo.OtherEducationalExpenses", new[] { "RespondentID" });
            DropIndex("dbo.OilsAndFats", new[] { "RespondentID" });
            DropIndex("dbo.NonAlcoholicBeverages", new[] { "RespondentID" });
            DropIndex("dbo.NewspaperBookStationaries", new[] { "RespondentID" });
            DropIndex("dbo.MineralwaterSoftdrinkJuices", new[] { "RespondentID" });
            DropIndex("dbo.MilkCheeseEggs", new[] { "RespondentID" });
            DropIndex("dbo.MedicalProducts", new[] { "RespondentID" });
            DropIndex("dbo.Meats", new[] { "RespondentID" });
            DropIndex("dbo.Insurances", new[] { "RespondentID" });
            DropIndex("dbo.InpatientMedicalServices", new[] { "RespondentID" });
            DropIndex("dbo.Housings", new[] { "RespondentID" });
            DropIndex("dbo.RespondentEconomicCrisis", new[] { "RespondentID" });
            DropIndex("dbo.Fruits", new[] { "RespondentID" });
            DropIndex("dbo.Footwears", new[] { "RespondentID" });
            DropIndex("dbo.FoodProducts", new[] { "RespondentID" });
            DropIndex("dbo.FishAndSeafoods", new[] { "RespondentID" });
            DropIndex("dbo.ElectricityGasFuels", new[] { "RespondentID" });
            DropIndex("dbo.Educations", new[] { "RespondentID" });
            DropIndex("dbo.Clothings", new[] { "RespondentID" });
            DropIndex("dbo.BreadsAndCereals", new[] { "RespondentID" });
            DropIndex("dbo.Barangays", new[] { "MunID" });
            DropIndex("dbo.AllowanceOfStudents", new[] { "RespondentID" });
            DropIndex("dbo.Respondents", new[] { "brgyID" });
            DropIndex("dbo.AlcoholicBeverages", new[] { "RespondentID" });
            DropTable("dbo.ServicesLists");
            DropTable("dbo.SalariesWagesLists");
            DropTable("dbo.ReasonLists");
            DropTable("dbo.OtherSourcesLists");
            DropTable("dbo.HealthRecommendationLists");
            DropTable("dbo.HealtCrisisLists");
            DropTable("dbo.GoodsLists");
            DropTable("dbo.EntrepreneurialActivitiesLists");
            DropTable("dbo.EconomicRecommendationLists");
            DropTable("dbo.EconomicCrisisLists");
            DropTable("dbo.Clusters");
            DropTable("dbo.WatersupplyMiscellaneous");
            DropTable("dbo.Vegetables");
            DropTable("dbo.TuitionFees");
            DropTable("dbo.TransportServices");
            DropTable("dbo.Tobacco");
            DropTable("dbo.TelephoneTelefaxServices");
            DropTable("dbo.Surveys");
            DropTable("dbo.SugarJamHoneyChocolateConfectionaries");
            DropTable("dbo.RespondentServices");
            DropTable("dbo.RespondentSalariesWages");
            DropTable("dbo.RespondentOtherSources");
            DropTable("dbo.RespondentHealthCrisis");
            DropTable("dbo.RespondentGoods");
            DropTable("dbo.RespondentEntrepreneurialActivities");
            DropTable("dbo.RecreationAndCultures");
            DropTable("dbo.RecreationalItemsEquipments");
            DropTable("dbo.PostalServices");
            DropTable("dbo.PersonalTransports");
            DropTable("dbo.PersonalEffects");
            DropTable("dbo.PersonalCares");
            DropTable("dbo.OutpatientMedicalServices");
            DropTable("dbo.OtherEducationalExpenses");
            DropTable("dbo.OilsAndFats");
            DropTable("dbo.NonAlcoholicBeverages");
            DropTable("dbo.NewspaperBookStationaries");
            DropTable("dbo.MineralwaterSoftdrinkJuices");
            DropTable("dbo.MilkCheeseEggs");
            DropTable("dbo.MedicalProducts");
            DropTable("dbo.Meats");
            DropTable("dbo.Insurances");
            DropTable("dbo.InpatientMedicalServices");
            DropTable("dbo.Housings");
            DropTable("dbo.RespondentEconomicCrisis");
            DropTable("dbo.Fruits");
            DropTable("dbo.Footwears");
            DropTable("dbo.FoodProducts");
            DropTable("dbo.FishAndSeafoods");
            DropTable("dbo.ElectricityGasFuels");
            DropTable("dbo.Educations");
            DropTable("dbo.Clothings");
            DropTable("dbo.BreadsAndCereals");
            DropTable("dbo.Municipalities");
            DropTable("dbo.Barangays");
            DropTable("dbo.AllowanceOfStudents");
            DropTable("dbo.Respondents");
            DropTable("dbo.AlcoholicBeverages");
        }
    }
}
