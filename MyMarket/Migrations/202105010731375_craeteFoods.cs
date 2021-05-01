namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class craeteFoods : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.foods");
            AlterColumn("dbo.foods", "Barcode", c => c.String(nullable: false, maxLength: 15));
            AddPrimaryKey("dbo.foods", "Barcode");
            DropTable("dbo.Markets");
            DropTable("dbo.Stocks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Barcod = c.String(maxLength: 10),
                        Quantity = c.Int(nullable: false),
                        PricePerUnit = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        Barcode = c.String(maxLength: 10),
                        QuantitySold = c.Int(nullable: false),
                        DateTimeSold = c.DateTime(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionID);
            
            DropPrimaryKey("dbo.foods");
            AlterColumn("dbo.foods", "Barcode", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.foods", "Barcode");
        }
    }
}
