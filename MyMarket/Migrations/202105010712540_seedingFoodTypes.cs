namespace MyMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingFoodTypes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT FoodTypes ON");
            Sql("insert into FoodTypes (Id,FoodType) values (1,'Spaghetti')");
            Sql("insert into FoodTypes (Id,FoodType) values (2,'Milk')");
            Sql("insert into FoodTypes (Id,FoodType) values (3,'Fish')");
            Sql("insert into FoodTypes (Id,FoodType) values (4,'Coffee')");


        }

        public override void Down()
        {
        }
    }
}
