namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '01-01-1992' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = '07-09-1982' WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
