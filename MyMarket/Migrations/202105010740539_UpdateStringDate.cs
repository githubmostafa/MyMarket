namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStringDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.foods", "ExpiryDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.foods", "ExpiryDate", c => c.Int(nullable: false));
        }
    }
}
