namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedFoods : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Foods(Barcode,BrandName,FoodTypeID,ProductionDate,ExpiryDate)" +
    "values ('422606074872911','Candia',1,'1/1/2021','1/5/2021')");
            Sql("insert into Foods(Barcode,BrandName,FoodTypeID,ProductionDate,ExpiryDate)" +
                "values ('422606074872912','Nido',2,'1/4/2021','1/5/2022')");
            Sql("insert into Foods(Barcode,BrandName,FoodTypeID,ProductionDate,ExpiryDate)" +
                "values ('422606074802911','White Bell,',3,'1/2/2021','1/7/2021')");
            Sql("insert into Foods(Barcode,BrandName,FoodTypeID,ProductionDate,ExpiryDate)" +
                "values ('422226074872911','Najjar',4,'1/1/2021','1/5/2021')");
        }
        
        public override void Down()
        {
        }
    }
}
