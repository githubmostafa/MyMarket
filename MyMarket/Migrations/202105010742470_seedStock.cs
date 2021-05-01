namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedStock : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Stocks ON");

            Sql("insert into Stocks(ItemId,Barcod,Quantity,PricePerUnit) values" +
                " (1,'122546372466523',20,3000)");
            Sql("insert into Stocks(ItemId,Barcod,Quantity,PricePerUnit) values" +
                " (2,'122546372466123',10,3500)");
            Sql("insert into Stocks(ItemId,Barcod,Quantity,PricePerUnit) values" +
                " (3,'122146372466123',10,4000)");
            Sql("insert into Stocks(ItemId,Barcod,Quantity,PricePerUnit) values" +
                " (4,'122544372466123',10,2000)");
        }
        
        public override void Down()
        {
        }
    }
}
