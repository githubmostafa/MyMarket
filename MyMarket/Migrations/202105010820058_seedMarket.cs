namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedMarket : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Markets ON");
            Sql("SELECT PricePerUnit AS prp FROM Stocks; ");
            Sql("Select Quantity AS qt FROM Stocks ;");

            Sql("insert into Markets(TransactionID,Barcode,QuantitySold,DateTimeSold,TotalPrice)" +
                "VALUES(1,'122546372466511',10,'4/4/2021',prp*qt)");
            Sql("insert into Markets(TransactionID,Barcode,QuantitySold,DateTimeSold,TotalPrice)" +
                "VALUES(2,'112546372466511',20,'4/4/2021',prp*qt)");
            Sql("insert into Markets(TransactionID,Barcode,QuantitySold,DateTimeSold,TotalPrice)" +
                "VALUES(3,'022546372466511',15,'4/4/2021',prp*qt)");

        }
        
        public override void Down()
        {
        }
    }
}
