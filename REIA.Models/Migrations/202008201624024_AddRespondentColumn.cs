namespace REIA.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRespondentColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Respondents", "RegularMonthlySavings", c => c.String());
            AddColumn("dbo.Respondents", "RealizeMonthlySavings", c => c.String());
            AddColumn("dbo.Respondents", "AffectedSavings", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Respondents", "AffectedSavings");
            DropColumn("dbo.Respondents", "RealizeMonthlySavings");
            DropColumn("dbo.Respondents", "RegularMonthlySavings");
        }
    }
}
