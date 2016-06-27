namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerBirthdateNull : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Customers ALTER COLUMN Birthdate datetime null");
        }
        
        public override void Down()
        {
        }
    }
}
