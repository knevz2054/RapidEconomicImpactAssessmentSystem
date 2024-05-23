namespace REIA.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRespondentNewColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Respondents", "EconomicSituation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Respondents", "EconomicSituation");
        }
    }
}
