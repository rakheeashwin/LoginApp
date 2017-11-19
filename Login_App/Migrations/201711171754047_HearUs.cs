namespace Login_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HearUs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "HearUs", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "ReasonToSignUp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ReasonToSignUp");
            DropColumn("dbo.AspNetUsers", "HearUs");
        }
    }
}
