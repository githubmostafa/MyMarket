namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createOthers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        Barcode = c.String(maxLength: 15),
                        QuantitySold = c.Int(nullable: false),
                        DateTimeSold = c.DateTime(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Barcod = c.String(maxLength: 15),
                        Quantity = c.Int(nullable: false),
                        PricePerUnit = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stocks");
            DropTable("dbo.Markets");
        }
    }
}
